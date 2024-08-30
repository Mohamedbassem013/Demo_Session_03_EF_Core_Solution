using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Session_03_EF_Core.Entities
{
    public class StudentCourse
    {
        public Student student { get; set; }
        public Course course { get; set; }
        public int StudentId { get; set; } // FK
        public int CourseId { get; set; }  // FK
        public double Grade { get; set; }
    }
}
