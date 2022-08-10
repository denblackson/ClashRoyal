using ClashRoyal.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace ClashRoyal.Controllers
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
            if (Request.Cookies["PLAYER_NAME"] != null)
            {
        
                AllPlayData initPlayData = new AllPlayData();
                initPlayData.PlayerName = Request.Cookies["PLAYER_NAME"];
                if (Request.Cookies["PLAYER_LANGUAGE"] == null)
                {
                    initPlayData.LanguagePlayer = new Language("EN");
                }
                else
                {
                    initPlayData.LanguagePlayer = new Language(Request.Cookies["PLAYER_LANGUAGE"]);
                }


                if (Request.Cookies["PLAYER_MAP"] == null)
                {
                    initPlayData.PlayerMap = "0";
                }
                else
                {
                    initPlayData.PlayerMap = Request.Cookies["PLAYER_MAP"];
                }
                initPlayData.AllEntity = new AllEntity("CommonField").AllCreatures;




                return View("Index", initPlayData);
            }
            else
            {
                return View("Register");  
            }
        } 


        public IActionResult Settings()
        {
            AllPlayData initPlayData = new AllPlayData();
            if (Request.Cookies["PLAYER_LANGUAGE"] == null)
            {
                initPlayData.LanguagePlayer = new Language("EN");
            }
            else
            {
                initPlayData.LanguagePlayer = new Language(Request.Cookies["PLAYER_LANGUAGE"]);
            }
            return View(initPlayData);
        }

        public IActionResult Play()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(IFormCollection fromRegistration)
        {
            if (fromRegistration["nickname"] != "")
            {
                Response.Cookies.Append("PLAYER_NAME", fromRegistration["nickname"]);  // записати даны в кукі
            }
            return RedirectToAction("Index", "Home");
        }


        [HttpPost]
        public IActionResult Settings(IFormCollection formSettings)
        {
            if (formSettings["language"].Count>0)
            {
                Response.Cookies.Append("PLAYER_LANGUAGE", formSettings["language"]);  // записати даны в кукі
            }
            if (formSettings["map"].Count > 0)
            {
                Response.Cookies.Append("PLAYER_MAP", formSettings["map"]);  // записати даны в кукі
            }
            return RedirectToAction("Settings", "Home");
        }










        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}