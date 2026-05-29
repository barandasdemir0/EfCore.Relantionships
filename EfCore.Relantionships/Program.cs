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

app.MapGet("/userGetAll", (ApplicationDbContext context) =>
{
    #region yöntem 1 include
    //var usersInclude = context.Users.Include(x=>x.UserInformation).ToList();
    //navigation property verdik ve lazy loading yaptık
    #endregion

    #region yöntem 2 join
    //var usersJoin = context.Users.Join
    //(
    //    context.UserInformations, //ilişki kurmak istediğin tablo
    //    user => user!.UserInformation!.Id,//ilişki kullandığım alan
    //    userInformation => userInformation.Id,
    //    (user, userInformation) => new
    //    {
    //        user,
    //        userInformation
    //    }).Select(p => new
    //    {
    //        Id = p.user.Id,
    //        FullName = p.user.FullName,
    //        IdentityNumber = p.userInformation.IdentityNumber,
    //        FullAddress  = p.userInformation.FullAddress,
    //    }).ToList();
    #endregion

    #region from kullanımı


    #endregion


    //return usersInclude;
    //return usersJoin;
});

app.Run();
