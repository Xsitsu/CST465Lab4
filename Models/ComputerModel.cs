using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class ComputerModel
    {
        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        [DisplayName("Password")]
        public string AdminPassword { get; set; }

        [DisplayName("IP Address")]
        [RegularExpression(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}", ErrorMessage = "You must enter a valid IP Address!")]
        public string IpAddress { get; set; }

        public string Location { get; set; }

        [Required]
        [UIHint("OSDropdown")]
        public string OS { get; set; }

        [DisplayName("Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required]
        [DisplayName("Supported Monitors")]
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
