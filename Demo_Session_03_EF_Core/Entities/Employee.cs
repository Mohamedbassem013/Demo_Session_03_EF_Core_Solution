using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Session_03_EF_Core.Entities
{
    public abstract class Employee
    {
        public int Id { get; set; } 
        public string Name { get; set; } 
        public double Salary { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int DeptId { get; set; }
        public string Email { get; set; }
        public virtual Department WorkFor { get; set; }
    }
}
