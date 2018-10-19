using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class ComputerModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string AdminPassword { get; set; }
        [Required]
        public string IpAddress { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string OS { get; set; }
        public string Description { get; set; }
        [Required]
        [Range(1, 4)]
        public int SupportedMonitors { get; set; }

        static private List<string> _OSTypes = new List<string>() { "iOS", "Windows", "Linux" };
        static public List<string> OSTypes
        {
            get
            {
                return _OSTypes;
            }
        }
    }
}
