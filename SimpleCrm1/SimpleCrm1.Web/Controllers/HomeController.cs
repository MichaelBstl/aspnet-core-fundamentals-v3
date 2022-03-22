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
        private ICustomerData _customerData;
        private readonly IGreeter _greeter;
        public HomeController(ICustomerData customerData,
            IGreeter greeter)
        {
            _customerData = customerData;
            _greeter = greeter;
        }
        public IActionResult Index(string id)
        {
            var model = new HomePageViewModel()
            {
                Customers = _customerData.GetAll(),
                CurrentMessage = _greeter.GetGreeting()
            };
            return View(model);
        }
        public IActionResult Details(int id)
        {
            Customer customer = _customerData.Get(id);
            if (customer == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }
    }
}
