using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCrm1.Web.Controllers
{
    public class HomeController
    {
        public string Index(string id)
        {
            return "hello from Home controller index " + id;
        }
        public string Notindex(string id)
        {
            return "hello from Home controller/Notindex" + id;
        }
    }
}
