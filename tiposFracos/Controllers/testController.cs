
/* 
    DESCRITION: ViewData

    ViewData é um objeto ViewDataDictionary acessado por meio de chaves string. 
    Dados de cadeias de caracteres podem ser armazenados e usados diretamente, 
    sem a necessidade de conversão, mas você precisa converter os valores de 
    outros objetos ViewData em tipos específicos quando extraí-los. Você pode 
    usar ViewData para passar dados de controladores para exibições e dentro 
    das exibições, incluindo exibições parciais e layouts.
    Font: Documentation Asp Net Core - Microsoft (https://docs.microsoft.com/pt-br/aspnet/core/mvc/views/overview?view=aspnetcore-2.1)

    DESCRITION: ViewBag

    ViewBag não está disponível nas Páginas do Razor. ViewBag é um objeto 
    DynamicViewData que fornece acesso dinâmico aos objetos armazenados em 
    ViewData. Pode ser mais conveniente trabalhar com ViewBag, pois ele não 
    requer uma conversão. O exemplo a seguir mostra como usar ViewBag com o
    mesmo resultado que o uso de ViewData também mostrado logo abaixo:
*/

using Microsoft.AspNetCore.Mvc;

namespace tiposFracos.Controllers {
    public class TestController : Controller {
        public IActionResult Foo() {
        
        ViewData["Title"] = "Foo";
        ViewData["Header"] = "Header Foo";
        ViewData["Items"] = "AAA BBB CCC".Split(' ');
        
        return View();
        }

        public IActionResult Bar() {
       
        ViewBag.Title = "Bar";
        ViewBag.Header = "Header Bar";
        ViewBag.Items = "DDD EEE FFF".Split(' ');
       
        return View();
        }
        
        //Exemplo que define valores para uma saudação.. 
        //.. e um endereço usando ViewData em uma ação:

        public IActionResult SomeAction(){

        //Open the result in Folder Views/Test/SomeAction.cshtml
        ViewData["Greeting"] = "Hello";
        
        ViewData["Address"] = new Address()
        {
            Name = "Steve",
            Street = "123 Main St",
            City = "Hudson",
            State = "OH",
            PostalCode = "44236"
        };

            return View();
        }

        public IActionResult OutraAcao(){
        
        ViewBag.Greeting = "Olá";
        ViewBag.Address  = new Address()
        {
            Name = "Johnatan",
            Street = "Rua Diácono Jair de Oliveira, 1005",
            City = "Piracicaba",
            State = "SP",
            PostalCode = "13414-155"
        };
            return View();
        }
    }
}