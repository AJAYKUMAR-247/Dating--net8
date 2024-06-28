using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API;
[ApiController]
[Route("api/[Controller]")]
public class UserController(DataContext context) : ControllerBase
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
        var user =await context.MyProperty.FindAsync(id);

        if(user == null) return NotFound();

        return user;
    }





}
