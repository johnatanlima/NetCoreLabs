using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoConclusao.Models;

namespace ProjetoConclusao.Controllers
{
    public class CityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(City city)
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            return View();
        }

        public IActionResult Update(City city)
        {
            return View();
        }

        public IActionResult Remove(int id)
        {
            return View();
        }
/* 
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        } */
    }
}
