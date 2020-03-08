// This line imports the Microsoft.AspNetCore.Mvc namespace into our controller, so we have access to ASP.NET Core's built in Controller class
using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
  // By adding : Controller to our HomeController class, we tell .NET that HomeController should inherit or extend functionality from ASP.NET Core's built-in Controller class that we import with our using statement
  public class HomeController : Controller
  {
    //The Hello() method represents a route in our application.. apreas as a '/Hello' after home.com in url
    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }
    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }
    
    [Route("/")]
    // ActionResult .. This is a built-in MVC class that handles rendering views.
    // View() This is a built-in method from the Microsoft.AspNetCore.Mvc namespace. When our route is invoked, it will return a view.
    public ActionResult Letter() { return View(); }
  }
}