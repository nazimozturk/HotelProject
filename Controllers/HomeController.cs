using HotelProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(LoginPicker model)
        {
            if (RoomList._loginPickers.Count > 0) RoomList._loginPickers.RemoveAt(0);
            RoomList._loginPickers.Add(model);
            return RedirectToAction("RoomLists");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult RoomLists()
        {
            return View(RoomList._loginPickers);
        }
        public IActionResult RoomDetails()
        {
            return View();
        }

        public IActionResult TestPage()
        {
            return View(RoomList._loginPickers);
        }
        public IActionResult TestPage2()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
