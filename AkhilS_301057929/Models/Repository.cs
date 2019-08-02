using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AkhilS_301057929.Models
{
    public static class Repository
    {
        private static List<Courses> courses = new List<Courses>();
        private static List<Faculty> faculties = new List<Faculty>();
        private static List<AssignFaculty> assigned = new List<AssignFaculty>();
        public static IEnumerable<Courses> Courses
        {
            get
            {
                return courses;
            }
        }
        public static IEnumerable<Faculty> Faculty
        {
            get
            {
                return faculties;
            }
        }
        public static IEnumerable<AssignFaculty> AssignFaculty
        {
            get
            {
                return assigned;
            }
        }
        public static void AddCourse(Courses course)
        {
            courses.Add(course);
        }
        public static void AddFaculty(Faculty faculty)
        {
            faculties.Add(faculty);
        }
        public static void AddAssigned(AssignFaculty assignFaculty)
        {
            assigned.Add(assignFaculty);
        }
    }
}
