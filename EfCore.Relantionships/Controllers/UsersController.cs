using EfCore.Relantionships.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.EntityFrameworkCore;

namespace EfCore.Relantionships.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class UsersController(ApplicationDbContext context) : ControllerBase
{

    [HttpGet]
    [EnableQuery]//o data 
    public IActionResult GetAll()
    {
        var users = context.Users.Include(p => p.UserInformation).AsQueryable();

        return Ok(users);
    }

}
