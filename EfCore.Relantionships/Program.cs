using EfCore.Relantionships;
using EfCore.Relantionships.Context;
using EfCore.Relantionships.Dtos;
using EfCore.Relantionships.Models;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddOpenApi();
builder.Services.AddDbContext<ApplicationDbContext>(cfg =>
{
    cfg.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"));
});
builder.Services.AddExceptionHandler<ExceptionHandler>().AddProblemDetails();


var app = builder.Build();




if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseExceptionHandler();

app.MapPost("/user-create", (ApplicationDbContext context,UserCreateDto request) =>
{
    User user = new()
    {
        FirstName = request.FirstName,
        Lastname = request.LastName,
        UserInformation = new()
        {
            IdentityNumber = request.IdentityNumber,
            FullAddress = request.FullAddress
        }
    };

    context.Add(user);
    context.SaveChanges();

    return Results.Ok(user);
});

app.Run();
