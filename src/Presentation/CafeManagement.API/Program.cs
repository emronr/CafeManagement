using CafeManagement.API.Extensions;
using CafeManagement.Business.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApiRegistration();;

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
}

app.UseRequestLogAndExceptionHandle();
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();