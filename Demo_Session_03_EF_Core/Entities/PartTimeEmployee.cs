using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Session_03_EF_Core.Entities
{
    public class PartTimeEmployee : Employee
    {
        public int NumberOfHours { get; set; }
        public double HourRate { get; set; }
    }
}
