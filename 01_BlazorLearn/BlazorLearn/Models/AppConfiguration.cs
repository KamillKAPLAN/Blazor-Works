using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorLearn.Models
{
    public class AppConfiguration
    {
        string Ip;
        string Port;
        public AppConfiguration(string Ip, string Port)
        {
            this.Ip = Ip;
            this.Port = Port;
        }
    }
}
