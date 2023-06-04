using System.Net.Mime;
using CafeManagement.API.Constants;
using CafeManagement.API.Decorators.ExceptionFormatter;
using Microsoft.IO;

namespace CafeManagement.API.Middlewares;

public class RequestLoggingMiddleware
{
     private readonly RequestDelegate _next;
    private readonly RecyclableMemoryStreamManager _streamManager;
    private readonly ILogger _logger;

    public RequestLoggingMiddleware(
        RequestDelegate next,
        ILoggerFactory loggerFactory)
    {
        _next = next;
        _logger = loggerFactory
            .CreateLogger<RequestLoggingMiddleware>();
        _streamManager = new RecyclableMemoryStreamManager();
    }

    public async Task Invoke(HttpContext context)
    {
        var requestMessage = await GetRequestMessage(context);
        var originalBodyStream = context.Response.Body;
        var responseStream = _streamManager.GetStream();
        context.Response.Body = responseStream;

        Exception exception = null;
        try
        {
            await _next(context);
            _logger.LogInformation(requestMessage);
        }
        catch (Exception ex)
        {
            exception = ex;
            ExceptionFormatDirector director = new();
            var responseBody = director.FormatException(ex, context);

            context.Response.ContentType = MediaTypeNames.Application.Json;
            await context.Response.WriteAsync(responseBody);
        }

        var responseMessage = await GetResponseMessage(context);
        var message =
            String.Join(
                Environment.NewLine,
                HttpRequestResponseInfo.StarLine,
                string.Format(HttpRequestResponseInfo.Tracer, context.TraceIdentifier),
                requestMessage,
                exception == null
                    ? null
                    : String.Join(Environment.NewLine, HttpRequestResponseInfo.Exception, exception.Message),
                responseMessage,
                HttpRequestResponseInfo.StarLine);


        await responseStream.CopyToAsync(originalBodyStream);

        if (!context.Request.Path.ToString().Contains("swagger") &&
            !context.Request.Path.ToString().Contains("index.html"))
        {
            if (exception == null)
            {
                _logger.LogInformation(message);
            }
            else
            {
                _logger.LogError(message);
            }
        }
    }

    private async Task<string> GetRequestMessage(HttpContext context)
    {
        context.Request.EnableBuffering();
        var requestStream = _streamManager.GetStream();
        await context.Request.Body.CopyToAsync(requestStream);

        var message = string.Join(Environment.NewLine,
            HttpRequestResponseInfo.HttpRequestInformation,
            String.Format(HttpRequestResponseInfo.Schema, context.Request.Scheme),
            String.Format(HttpRequestResponseInfo.Host, context.Request.Host),
            String.Format(HttpRequestResponseInfo.Path, context.Request.Path),
            String.Format(HttpRequestResponseInfo.QueryString, context.Request.QueryString),
            String.Format(HttpRequestResponseInfo.RequestBody, ReadStreamInChunks(requestStream)),
            String.Format(HttpRequestResponseInfo.Authorization, context.Request.Headers["Authorization"].ToString()));

        context.Request.Body.Position = 0;


        return message;
    }

    private async Task<string> GetResponseMessage(HttpContext context)
    {
        context.Response.Body.Seek(0, SeekOrigin.Begin);
        var responseText = await new StreamReader(context.Response.Body).ReadToEndAsync();
        context.Response.Body.Seek(0, SeekOrigin.Begin);

        var responseMessage = String.Join(Environment.NewLine,
            HttpRequestResponseInfo.HttpResponseInformation,
            String.Format(HttpRequestResponseInfo.Schema, context.Request.Scheme),
            String.Format(HttpRequestResponseInfo.Host, context.Request.Host),
            String.Format(HttpRequestResponseInfo.Path, context.Request.Path),
            String.Format(HttpRequestResponseInfo.QueryString, context.Request.QueryString),
            String.Format(HttpRequestResponseInfo.ResponseBody, responseText)
        );
        return responseMessage;
    }

    private static string ReadStreamInChunks(Stream stream)
    {
        const int readChunkBufferLenght = 4096;
        stream.Seek(0, SeekOrigin.Begin);
        var textWriter = new StringWriter();
        var reader = new StreamReader(stream);
        var readChunk = new char[readChunkBufferLenght];
        int readChunkLength;
        do
        {
            readChunkLength = reader.ReadBlock(readChunk,
                0,
                readChunkBufferLenght);
            textWriter.Write(readChunk, 0, readChunkLength);
        } while (readChunkLength > 0);

        return textWriter.ToString();
    }

 
}