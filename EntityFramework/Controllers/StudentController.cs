using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult AddSession()
        {
            HttpContext.Session.SetString("Username", "Bmc");
            Response.Cookies.Append("course", "netCentric");
            return View();
        }
        public IActionResult ReadSession()
        {
            string username = HttpContext.Session.GetString("Username");
            ViewBag.Username = username;
            ViewData["college"] = "bmc";
            TempData["address"] = "bkt";
            string course = HttpContext.Request.Cookies["course"];
            ViewBag.Course = course;
            return View();
        }
        public IActionResult Jquery()
        {

            return View();
        }
        public IActionResult EditStudentId(int studentId)
        { //url?studentId=100;
            ViewBag.studentId = studentId; return View();
        }
    }
}



