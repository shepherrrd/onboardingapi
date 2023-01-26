using buber.contracts.Breakfast;
using buber.Model;
using buber.Services.Breakfasts;
using Microsoft.AspNetCore.Mvc;

namespace BuberBreakfast.Controllers;
[ApiController]

[Route("[controller]")]
public class UserController : ControllerBase
{private readonly Ibreakfast _breakfastservice;
    
    public UserController(Ibreakfast ibreakfast)
    {
        _breakfastservice = ibreakfast;
    }

    

    [HttpPost]
    public IActionResult CreateUser(Useracct request)
    {
        var user = new Useracct(
            Guid.NewGuid(),
            request.name,
            request.password,
            request.username
           

        );
        _breakfastservice.CreateUser(user);

        var response = new Useracct(
           user.id,
           user.name,
           user.password,
           user.username
        );
        return CreatedAtAction(
            nameof(Updatepassword),
            new {id = user.id},
            response

        );
    }

    [HttpPut("{id:guid}")]
    public IActionResult Updatepassword(Guid id, CreatePassword request){
       var user = new Useracct(
            id,
            request.name,
           request.username,
           request.password

        );
        _breakfastservice.CreatePassword(user);
        return NoContent();
    }

    [HttpGet("{id:guid}")]
 public IActionResult GetUser(Guid id){
    Useracct user = _breakfastservice.GetUser(id);
    var response = new Useracct(
        user.id,
        user.name,
        user.username,
        user.password

        );
        return Ok(response);
    }
}