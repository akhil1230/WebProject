using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AkhilS_301057929.Models
{
    public class AssignFaculty
    {
        [Required(ErrorMessage = "Please enter Course Name")]
        public string CourseName { set; get; }

        [Required(ErrorMessage = "Please enter your Faculty name")]
        public string FacultyName { set; get; }

    }
}
