using Microsoft.AspNetCore.Mvc;
using MVCuppgift.Models;

namespace MVCuppgift.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Fevercheck()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Fevercheck(string temperature)
        {
            string feverStatus = FeverModel.CheckFever(temperature);
            ViewBag.Msg = feverStatus;
            return View();
        }


    }
}
