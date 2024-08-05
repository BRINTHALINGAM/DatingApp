using API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController(DataContext context):ControllerBase
{
   
    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
        var users = await context.MyProperty.ToListAsync();
        return users;

    }

     [HttpGet("{id:int}")]
    public async Task<ActionResult<AppUser>> GetUser(int id)
    {
        var user = await context.MyProperty.FindAsync(id);
        if (User == null) return NotFound();
#pragma warning disable CS8604 // Possible null reference argument.
        return user;
#pragma warning restore CS8604 // Possible null reference argument.

    }
}