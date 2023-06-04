# Cafe Management
> A derivative of the billing applications used in cafes has been written. It consists of 5 Projects. 

- **Services**
  - CafeManagement.Domain
  - CafeManagement.Business
  - CafeManagement.Common
- **Presentation**
  - CafeManagement.WinForm
  - CafeManagement.API

## CafeManagement.Domain
> The Domain layer is where Entity, DbContext, Repositories and Migrations are managed.
- MSSQL was used as database.

## CafeManagement.Business
> It is a layer where the presentation layer communicates directly. It wraps the domain layer and transfers the data to the Presentation layer. It secures database classes by converting entities to DTO(Data Transfer Objects). 
- AutoMapper is used during this conversion 

## CafeManagement.Common
> The Common Layer is where response, exception etc. models are. All layers can access this layer.

## CafeManagement.WinForm
> This layer is a presentation layer. Windows Form Application was used as the presentation layer.
For the management of dependencies, the program stands up like a host service

## CafeManagement.API
> This Layer is a presentation layer. ASP.NET Core WEB API was used as the presentation layer.
> Decorator pattern is used to handle errors.
