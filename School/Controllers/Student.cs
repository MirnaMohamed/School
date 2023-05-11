using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.IO;
namespace School.Controllers
{
    public class Student : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
