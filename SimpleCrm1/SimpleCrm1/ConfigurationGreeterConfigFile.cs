using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCrm1
{
    public class ConfigurationGreeterConfigFile : IGreeter
    {
        public IConfiguration configuration;
        public ConfigurationGreeterConfigFile(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public string GetGreeting()
        {
            var message = configuration["Greeting"];
            return (message);
        }
    }
}
