using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoredProc.Data;
using StoredProc.Models;

namespace StoredProc.Controllers
{
    public class EmployeeController : Controller
    {
        public StoredProcDbContext_context;

        public EmployeeController
            (
                StoredProcDbContext context
            )
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IEnumerable<Employee> SearchResult()
        {
            var result = _comtext.Employees
                .FormSqlRaw<Employee>("spSearchEmployees")
                .ToList();

            return result;
        }
    }
}
