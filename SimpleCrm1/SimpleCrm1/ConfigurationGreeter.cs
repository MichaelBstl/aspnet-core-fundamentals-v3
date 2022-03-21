using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCrm1
{
    public class ConfigurationGreeter : IGreeter
    {
        public IConfiguration Configuration { get; }
        public ConfigurationGreeter(IConfiguration configuration)
        {

        }

        public string GetGreeting()
        {
            return "Greeting from ConfigurationGreeting";
        }
    }
}
