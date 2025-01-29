using Microsoft.AspNetCore.Mvc;

namespace E_Belediye.UI.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddEmployee()
        {
            return View();
        }

        public IActionResult EmployeeList()
        {
            return View();
        }
    }
}
