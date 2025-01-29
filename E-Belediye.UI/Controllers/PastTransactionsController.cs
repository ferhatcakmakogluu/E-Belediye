using Microsoft.AspNetCore.Mvc;

namespace E_Belediye.UI.Controllers
{
    public class PastTransactionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
