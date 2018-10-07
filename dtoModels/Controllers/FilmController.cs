using dtoModels.Models;
using Microsoft.AspNetCore.Mvc;

namespace MyWebApp.Controllers {
    public class FilmController : Controller {
      
       /*  
            DESTA FORMA, ACOES CREATE E UPDATE ESTÃO MUITO DEPENDENTES,
            ENTÃO É RECOMENDADO SEPARAR ISSO EM AÇÕES SEPARADAS. COMO
            FOI FEITO LOGO ABAIXO DAS SEGUINTES AÇÕES.

       [HttpGet]
        public IActionResult CreateOrUpdate() {
            return View();
        }

        [HttpPost]
        public IActionResult CreateOrUpdate(CreateOrUpdateDTO dto) {
            var film = new Film()
            {
                ID = dto.ID,
                Name = dto.Name,
                Year = dto.Year,
                Genres = dto.Genres,
                IsInStore = dto.IsInStore
            };

            if (dto.Operation == Operation.Create) {
                // create a new film ... Note: the ID from the dto will be ignored
                return View("Created");
            } else if (dto.Operation == Operation.Update) {
                // update the existing film by ID
                return View("Updated");
            } else {
                return View("Error"); // we don't implement the Error view now
            }
        } */

        [HttpGet]
        public IActionResult Create(){
            return View();
        }

        [HttpPost]
        public IActionResult Create(Film film){//Aqui, o objeto film irá vir populado com os 
            if (this.ModelState.IsValid){       //valores que estão sendo passados em sua 
                //create a new film               view correspondente
              
                return Content(" Dados do filme corretos.");
            } else {
                return View("Error");
            }
        }

        [HttpGet]
        public IActionResult Update() {
            return View();
        }

        [HttpPost]
        public IActionResult Update(Film film) { //Aqui, o objeto film irá vir populado com os
            if (this.ModelState.IsValid) {       //valores que estão sendo passados em sua 
            // update the existing film by ID      correspondente.
                return Content(" Dados do filme corretos.");
            } else {
                return View("Error");
            }
        }
    }
}

