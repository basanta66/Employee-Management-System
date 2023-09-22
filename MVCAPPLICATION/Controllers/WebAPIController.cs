using Microsoft.AspNetCore.Mvc;

namespace webMVC.Controllers
{
 [Route("api/[controller]/[action]")] //to call specific action, placing action in route
 [ApiController]
 public class WebAPIController : ControllerBase
    {
        // GET: api/<WebAPIController>
        [HttpGet]
        public object Getdata()
        {
            //return new string[] { "value1", "value2" };
            return new { Name = "Basanta", Address = "Kathmandu" }; //displays in json format
        }
        public List<object> GetUsers()
        {
            List<object> list = new List<object>(); //creating new list
            list.Add(new { name = "Rio", Series     = "Heist" });
            list.Add(new { name = "Ted", Series = "Lasso" });
            list.Add(new { name = "Beard", Series = "Lasso" });
            return list; // displays json data in a list 
        }
    }
}
