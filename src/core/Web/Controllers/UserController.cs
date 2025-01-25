using CleanArchitecture.Application.User.Commands.Add;
using CleanArchitecture.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Web.Controllers;

[ApiController]
[Route("/users")]
public class UserController(IMediator mediator) : BaseController
{


    [HttpPost]
    public async Task<IActionResult> AddUser(AddUserCommand command) =>
        MapResult( await mediator.Send(command));

    [HttpGet]
    public  IActionResult GetUser() =>
        Ok(new User { Name = "123", Age = 123 });
}
