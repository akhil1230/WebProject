using System; 
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AkhilS_301057929.Models
{
    public class Faculty
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string FacultyName { set; get; }

        [Required(ErrorMessage = "Please enter your email")]
        //[RegularExpression(".+\\@.+\\..", ErrorMessage = "Please enter valid email address")]
        public string Email { set; get; }

        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { set; get; }

        [Required(ErrorMessage = "Please enter your department name")]
        public string Department { set; get; }
    }
}
