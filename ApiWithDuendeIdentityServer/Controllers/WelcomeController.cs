using Microsoft.AspNetCore.Mvc;
using ApiWithDuendeIdentityServer.Models;
using Microsoft.AspNetCore.Authorization;

namespace ApiWithDuendeIdentityServer.Controllers;

public class WelcomeController : ControllerBase
{
    [Authorize]
    [HttpGet("/api/welcome")]
    public string Greet()
    {
        var greeting = new Greeting()
        {
            Message = "Hello World!"
        };
            
        return greeting.Message;
    }
}