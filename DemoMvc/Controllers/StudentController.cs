using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace DemoMvc.Controllers{
    public class StudentldController : Controller{
        public IActionResult Index(){
            return View();
        }
    }
}
