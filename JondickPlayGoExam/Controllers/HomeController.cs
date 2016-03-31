using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JondickPlayGoExam.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Reed()
        {
            ViewBag.ReedClass = new List<string>()
            {
               "Jocelyn Concha",
               "Jando Molina",
               "Joseph Cajida",
               "Available Slot: 22"
            };

            return View();
        }

        public ActionResult Comtech()
        {
            ViewBag.ComtechClass = new List<string>()
            {
               "JJ Uriza",
               "Junel Cabornay",
               "Sez Balagtas",
               "Jiro Lim",
               "Aaron Cajes",
               "Toff Marquez",
               "Patrick Santos",
               "Available Slot: 12"
            };
                     

           return View();
        }

        public ActionResult GameDev()
        {

            ViewBag.GameDevClass = new List<string>()
            {
               "JJ Uriza",
               "Junel Cabornay",
               "Sez Balagtas",
               "Jiro Lim",
               "Aaron Cajes",
               "Toff Marquez",
               "Patrick Santos",
               "Available Slot: 4"
            };

            return View();
        }

        public ActionResult Rizal()
        {

            ViewBag.RizalClass = new List<string>()
            {
               "Randy Cosmic",
               "Luisa Jane",
               "Marco Cosmic Jr.",
               "Jorel Baquial",
               "Emil Bella",
               "Available Slot: 21"
            };

            return View();
        } 

        public ActionResult Intro()
        {
            ViewBag.SubList = new List<string>()
            {
               "REED101 Available : 22",
               "COMTECH101 Available : 12",
               "RIZAL101 Available : 21",
               "GAMEDEV101 Available : 4"
            };

            return View();
        }
    }
}