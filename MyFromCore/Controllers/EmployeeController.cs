using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyFromCore.Models;

namespace MyFromCore.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            EmployeeViewModel employeeViewModel = new();

            employeeViewModel.Data = new List<SelectListItem>();

            employeeViewModel.Data.Add(new SelectListItem { Text = "Mr", Value = "Mr" });
            employeeViewModel.Data.Add(new SelectListItem { Text="Mrs", Value="Mrs"});

            return View(employeeViewModel);
        }

        [HttpPost]
        public IActionResult Index(EmployeeViewModel d)
        {
            

            d.Data = new List<SelectListItem>();

            d.Data.Add(new SelectListItem { Text = "Mr", Value = "Mr" });
            d.Data.Add(new SelectListItem { Text = "Mrs", Value = "Mrs" });

            if(!ModelState.IsValid)
            {
                return View(d);
            }

            return View(d);
        }
    }
}
