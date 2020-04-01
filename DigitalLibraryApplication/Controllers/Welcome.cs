using Microsoft.AspNetCore.Mvc;

namespace DigitalLibraryApplication.Controllers
{
    public class Welcome : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public string Index()
        {
            return "Welcome to Digital Library!";
        }
        public string Description()
        {
            return "This is the application for managing digital books!";
        }
    }
}
