using Microsoft.AspNetCore.Mvc;
using MVCAPPLICATION.Models;
namespace MVCAPPLICATION.Controllers
{
    
    
public class StudentController : Controller
        {
        public IActionResult Students()
        {
            List<StudentsModel> students = new List<StudentsModel>();
            return View(students); //creates Students.cshtml
        }
        [HttpGet]
        public IActionResult AddStudent()
        {
            return View(); //creates AddStudent.cshtml
        }
    }
}
