using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class ComputerModel
    {
        public string Name { get; set; }
        public string AdminPassword { get; set; }
        public string IpAddress { get; set; }
        public string Location { get; set; }
        public string OS { get; set; }
        public string Description { get; set; }
        public int SupportedMonitors { get; set; }

        static public List<string> OSTypes = new List<string>() { "iOS", "Windows", "Linux" };
    }
}
