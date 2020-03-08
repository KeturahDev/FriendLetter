// This line imports the Microsoft.AspNetCore.Mvc namespace into our controller, so we have access to ASP.NET Core's built in Controller class
using Microsoft.AspNetCore.Mvc;
// make our model available to our controller:
using FriendLetter.Models;


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
    public ActionResult Letter() {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = "Lina";
      myLetterVariable.Sender = "Jasmine";
      return View(myLetterVariable);
    }

    // HOW ITS WORKING>>>

    // Because views should always reside in a Views directory, View() first locates the Views directory in the production project.

    // Then the method looks for a subdirectory with a name that matches the controller name. Our Letter() route is in a HomeController so it looks for the subdirectory Home.

    // Once in the Home directory, the method looks for a file that corresponds with the route itself. In this case, it's looking for Letter(). Our Letter.cshtml file name matches the name of this route so the View() method returns the HTML in this file.
  }
}