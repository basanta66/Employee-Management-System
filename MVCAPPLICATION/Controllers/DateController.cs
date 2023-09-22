using Microsoft.AspNetCore.Mvc;

namespace MVCAPPLICATION.Controllers
{
    public class DateController : Controller
    {
        
 IDateService _service;
        public DateController(IDateService dateService)
        {
            _service = dateService;
        }
        public IActionResult GetDate()
        {
            
                //DateService dateService = new DateService();
                return Content(_service.GetDate().ToString());
            }
        }
    }


