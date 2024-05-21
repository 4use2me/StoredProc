using Microsoft.AspNetCore.Mvc;

namespace StoredProc.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
