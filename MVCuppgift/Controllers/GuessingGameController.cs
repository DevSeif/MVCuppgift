using Microsoft.AspNetCore.Mvc;
using MVCuppgift.Models;

namespace MVCuppgift.Controllers
{
    public class GuessingGameController : Controller
    {
        Random random = new Random();
        GuessingGameModel guessModel = new GuessingGameModel();

        public IActionResult GuessingGame()
        {
            if (HttpContext.Session.GetInt32("number") == null)
            {
                HttpContext.Session.SetInt32("number", random.Next(1, 100));
            }
            return View();
        }

        [HttpPost]
        public IActionResult GuessingGame(int guessNumber)
        {
            ViewBag.Msg = guessModel.IsItCorrect(guessNumber, HttpContext.Session.GetInt32("number"));
            if (guessModel.IsCorrect)
            {
                HttpContext.Session.SetInt32("number", random.Next(1, 100));
            }

            return View();
        }

    }
}
