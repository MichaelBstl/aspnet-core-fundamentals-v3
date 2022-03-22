using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCrm1.Web.Controllers
{
    [Route("about")]
    public class AboutController
    {
        [Route("")]
        public string Phone(string id)
        {
            return "999-999-9999";
        }
        [Route("Address")]
        public string Address(string id)
        {
            return "USA";
        }
    }
}
