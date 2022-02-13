using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace Madlibs.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/postcard")]
public ActionResult Postcard(string adjective,string foods,string verb,string saying,string noun,string color,string ride,string animal, string person)
{
  LetterVariable myLetterVariable = new LetterVariable();
  myLetterVariable.Adjective = adjective;
  myLetterVariable.Foods = foods;
  myLetterVariable.Verb = verb;
  myLetterVariable.Saying = saying;
  myLetterVariable.Noun = noun;
  myLetterVariable.Color = color;
  myLetterVariable.Ride = ride;
  myLetterVariable.Animal = animal;
  myLetterVariable.Person = person;
  return View(myLetterVariable);
}

  }
}