using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AkhilS_301057929.Models
{
    public class Courses
    {
        [Required(ErrorMessage = "Please enter course code")]
        public int CourseCode { get; set; }

        [Required(ErrorMessage = "Please enter the course name")]
        public string CourseName { get; set; }

    }
}
