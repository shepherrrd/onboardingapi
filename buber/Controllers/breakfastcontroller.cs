using buber.contracts.Breakfast;
using buber.Model;
using buber.Services.Breakfasts;
using Microsoft.AspNetCore.Mvc;

namespace buber.Controllers;
[ApiController]

[Route("[controller]")]

public class Breakfastcontroller : ControllerBase

{
    private readonly Ibreakfast _breakfastservice;

    public Breakfastcontroller(Ibreakfast ibreakfast)
    {
        _breakfastservice = ibreakfast;
    }

    [HttpPost]
    public IActionResult CreateBreakfast(CreateBreakfast request){
        var breakfast = new Breakfast(
            Guid.NewGuid(),
            request.name,
            request.Description,
            request.StartDate,
            request.EndDate,
            DateTime.UtcNow,
            request.savory,
            request.sweet

        );
        _breakfastservice.CreateBreakfast(breakfast);

        var response = new Breakfast(
            breakfast.Id,
            breakfast.Description,
            breakfast.name,
            breakfast.StartDate,breakfast.EndDate,
            breakfast.LastModified,
            breakfast.savory,
            breakfast.sweet
        );
        return CreatedAtAction(
            nameof(GetBreakfast),
            new {id = breakfast.Id},
            response);
    }

[HttpGet("{id:guid}")]
 public IActionResult GetBreakfast(Guid id){
    Breakfast breakfast = _breakfastservice.GetBreakfast(id);
    var response = new Breakfast(
            breakfast.Id,
            breakfast.Description,
            breakfast.name,
            breakfast.StartDate,breakfast.EndDate,
            breakfast.LastModified,
            breakfast.savory,
            breakfast.sweet
        );
        return Ok(response);
    }
[HttpPut("{id:guid}")]
    public IActionResult UpsertBreakfast(Guid id,UpsertBreakfastRequest request){
       var breakfast = new Breakfast(
            id,
            request.name,
            request.Description,
            request.StartDate,
            request.EndDate,
            DateTime.UtcNow,
            request.savory,
            request.sweet

        );
        _breakfastservice.UpsertBreakfast(breakfast);
        return NoContent();
    }

[HttpDelete("{id:guid}")]
 public IActionResult DeletetBreakfast(Guid id){
    _breakfastservice.DeleteBreakfast(id);
        return NoContent();
    }


}