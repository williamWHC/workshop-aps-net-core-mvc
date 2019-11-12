using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoSalesWebMvc.Models;

namespace ProjetoSalesWebMvc.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            List<Department> List = new List<Department>();
            List.Add(new Department { id = 1, name = "Eletronics" });
            List.Add(new Department { id = 2, name = "Fashion" });

            return View(List);
        }
    }
}