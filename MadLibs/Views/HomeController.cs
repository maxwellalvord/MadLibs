using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello friend! Welcome to our MADLIBS!"; }

    [Route("/")]
    public ActionResult Letter()
    {
      MadLib myMadLib = new MadLib();
      myMadLib.Adjective1 = "_____";
      myMadLib.Noun1 = "_____";
      myMadLib.Verb = "_____";
      myMadLib.Adjective2 = "_____";
      myMadLib.Noun2 = "_____";
      return View(myMadLib);
    }

    [Route("/postcard")]
    public ActionResult Postcard(string adjective1, string noun1, string verb, string adjective2, string noun2)
    {
      MadLib myMadLib = new MadLib();
      myMadLib.Adjective1 = adjective1;
      myMadLib.Noun1 = noun1;
      myMadLib.Verb = verb;
      myMadLib.Adjective2 = adjective2;
      myMadLib.Noun2 = noun2;
      return View(myMadLib);
    }

    [Route("/ML2")]
    public ActionResult ML2(string adjective1_2, string noun1_2, string verb_2, string adjective2_2, string noun2_2)
    {
      MadLib myMadLib = new MadLib();
      myMadLib.Adjective1 = adjective1_2;
      myMadLib.Noun1 = noun1_2;
      myMadLib.Verb = verb_2;
      myMadLib.Adjective2 = adjective2_2;
      myMadLib.Noun2 = noun2_2;
      return View(myMadLib);
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/form2")]
    public ActionResult Form2() { return View(); }
  }
}