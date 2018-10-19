using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;
//Add
using System;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace MyWebApp.Controllers {
 
    public class HomeController : Controller {
 
        public IActionResult Index() {
 
            return View(DataSource.Countries);
        }

        //ADD
        private IHostingEnvironment _environment;

        public HomeController(IHostingEnvironment env) {
            _environment = env;
        }

        [HttpGet]
        public IActionResult UpdateNationalFlag(string code) {
        var country = DataSource.Countries.SingleOrDefault(c => c.Code.Equals
        (code, StringComparison.CurrentCultureIgnoreCase));
       
            return View(country);
        }

        [HttpPost]
        public IActionResult UpdateNationalFlag(string code, IFormFile nationalFlagFile) {
            
            if (nationalFlagFile == null || nationalFlagFile.Length == 0)
              return RedirectToAction(nameof(Index));
            
            var targetFileName = $"{code}{Path.GetExtension(nationalFlagFile.FileName)}";
            
            var relativeFilePath = Path.Combine("images", targetFileName);
            
            var absolutFilePath = Path.Combine(_environment.WebRootPath, relativeFilePath);
            
            var country = DataSource.Countries
            .SingleOrDefault(c => c.Code.Equals(code, StringComparison.CurrentCultureIgnoreCase));
            
            country.NationalFlagPath = relativeFilePath;
            
            using (var stream = new FileStream(absolutFilePath, FileMode.Create)) {
                nationalFlagFile.CopyTo(stream);
            }
        
         return RedirectToAction(nameof(Index));
    }

    }//controller
}

