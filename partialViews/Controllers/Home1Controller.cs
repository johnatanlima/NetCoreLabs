using Microsoft.AspNetCore.Mvc;

namespace partialViews.Controllers {
    public class Home1Controller : Controller {
        public IActionResult Home() => View();
        public IActionResult Page1() => View();
        public IActionResult Page2() => View();
    }
}

