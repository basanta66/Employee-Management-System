using Microsoft.AspNetCore.Mvc;


public class ContactController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(ContactModel model)
    {

        // Handle the POST request
        if (ModelState.IsValid)
        {
            // Process the submitted data, e.g., save it to a database
            // Redirect to a success page or return a view
            return RedirectToAction("Success");
        }

        // If the model is not valid, return to the same view with validation errors
        return View(model);
    }

    public IActionResult Success()
    {

        List<ContactModel> contact = new List<ContactModel>();
        return View(contact);
        // This action will be called after a successful POST request
        //
    }
}
