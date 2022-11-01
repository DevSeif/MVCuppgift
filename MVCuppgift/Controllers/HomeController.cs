using Microsoft.AspNetCore.Mvc;
using MVCuppgift.Models;
using System.Diagnostics;

namespace MVCuppgift.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Projects()
        {
            List<ProjectModel> projectList = new List<ProjectModel>();
            projectList.Add(new ProjectModel("Sokoban", "Move the boxes to win", "https://github.com/DevSeif/Sokoban-game"));
            projectList.Add(new ProjectModel("Vending machine", "Buy products from a vending machine", "https://github.com/DevSeif/Vending-Machine"));
            projectList.Add(new ProjectModel("Website", "Simple website with a login page", "https://github.com/DevSeif/htmluppgift2"));

            return View(projectList);
        }


    }
}