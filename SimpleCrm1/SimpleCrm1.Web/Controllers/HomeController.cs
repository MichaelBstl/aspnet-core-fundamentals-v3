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
        public HomeController(ICustomerData customerData)
        {
            _customerData = customerData;
        }
        public IActionResult Index(string id)
        {
            var customerModel = _customerData.GetAll();
            return View(customerModel);
        }
    }
}
