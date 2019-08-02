using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AkhilS_301057929.Models;

namespace AkhilS_301057929.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("Home");
        }
        public ViewResult Home()
        {
            return View("Home");
        }

        public ViewResult Courses()
        {
            return View(Repository.Courses);
        }
        [HttpGet]
        public ViewResult AddCourse()
        {
            return View("AddCourse");
        }
        [HttpPost]
        public ViewResult AddCourse(Courses courses)
        {
            if (ModelState.IsValid)
            {
                Repository.AddCourse(courses);
                return View(courses);
            }
            else
            {
                return View();
            }

        }

        public ViewResult Faculty()
        {
            return View(Repository.Faculty);
        }
        [HttpGet]
        public ViewResult AddFaculty()
        {
            return View("AddFaculty");
        }
        [HttpPost]
        public ViewResult AddFaculty(Faculty faculty)
        {
            if (ModelState.IsValid)
            {
                Repository.AddFaculty(faculty);
                return View(faculty);
            }
            else
            {
                return View();
            }
        }
        public ViewResult AssignedFaculty()
        {
            return View(Repository.AssignFaculty);
        }

        [HttpGet]
        public ViewResult AssignFaculty()
        {
            return View("AssignFaculty");
        }
        [HttpPost]
        public ViewResult AssignFaculty(AssignFaculty assignFaculty)
        {
            if (ModelState.IsValid)
            {
                Repository.AddAssigned(assignFaculty);
                return View(assignFaculty);

            }
            else
            {
                return View();
            }

        }

    }
}