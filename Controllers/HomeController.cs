using Microsoft.AspNetCore.Mvc;
using PortfolioWebsite.Models;
using System.Collections.Generic;

namespace PortfolioWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            var contact = new Contact
            {
                Email = "ahmed0155085826@gmail.com",
                Phone = "01558402492",
                LinkedIn = "https://www.linkedin.com/in/ahmed-makram-0706602a3",
                Location = "Tanta, Egypt"
            };
            return View(contact);
        }

        public IActionResult Skills()
        {
            var skills = new List<Skill>
            {
                new Skill { Name = "C#", Level = "Advanced" },
                new Skill { Name = ".NET Core", Level = "Advanced" },
                new Skill { Name = "SQL", Level = "Intermediate" },
                new Skill { Name = "ASP.NET MVC", Level = "Advanced" }
            };
            return View(skills);
        }

        public IActionResult Projects()
        {
            var projects = new List<Project>
            {
                new Project { Title = "Sales and Inventory Management", Description = "System for managing sales and inventory.", Technologies = "C#, .NET Core, SQL Server" },
                new Project { Title = "Library Management System", Description = "System for managing library operations.", Technologies = "ASP.NET Core, SQL Server" }
            };
            return View(projects);
        }

        public IActionResult Contact()
        {
            var contact = new Contact
            {
                Email = "ahmed0155085826@gmail.com",
                Phone = "01558402492",
                LinkedIn = "https://www.linkedin.com/in/ahmed-makram-0706602a3",
                Location = "Tanta, Egypt"
            };
            return View(contact);
        }
        public IActionResult Resume()
        {
            return View();
        }

    }
}
