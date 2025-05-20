using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using TechNovaSolutions.Models;

namespace TechNovaSolutions.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmployeeDbContext employee;

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public HomeController(EmployeeDbContext Employee)
        {
            employee = Employee;
        }
        public async Task<IActionResult> Index()
        {
            var stdData = await employee.Employees.ToListAsync(); 
            return View(stdData);
          
        }

        public IActionResult create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> create(DepartmentEmployee emp)
        {
            if (ModelState.IsValid)
            {
                await employee.Employees.AddAsync(emp);
                await employee.SaveChangesAsync();

                return RedirectToAction("Index", "Home");
            }
            return View(emp);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || employee.Employees == null)
            {
                return NotFound();
            }
            var stdData = await employee.Employees.FirstOrDefaultAsync(x => x.EId== id);

            if (stdData == null)
            {
                return NotFound();
            }


            return View(stdData);
        }

        [HttpGet]
        public ViewResult Edit(int id)
        {

            var fetchedDepartment = employee.Employees.FirstOrDefault(x => x.EId == id);
            return View(fetchedDepartment);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(DepartmentEmployee emp)
        {
            if (ModelState.IsValid)
            {
                employee.Employees.Update(emp);
                await employee.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(emp);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || employee.Employees == null)
            {
                return NotFound();
            }
            var stdData = await employee.Employees.FirstOrDefaultAsync(x => x.EId == id);

            if (stdData == null)
            {
                return NotFound();
            }
            return View(stdData);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var StdData = await employee.Employees.FindAsync(id);

            if (StdData != null)
            {
                employee.Employees.Remove(StdData);
            }
            await employee.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
