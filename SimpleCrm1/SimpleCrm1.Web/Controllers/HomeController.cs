using Microsoft.AspNetCore.Mvc;
using SimpleCrm1.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCrm1.Web.Controllers
{
    public class HomeController : Controller 
    {
        public IActionResult Index(string id)
        {
            var customerModel = new CustomerModel
            {
                Id = 1,
                FirstName = "Michael",
                LastName = "Bryant",
                PhoneNumber = "314-443-8763"
            };
            return View(customerModel);
        }
    }
}
