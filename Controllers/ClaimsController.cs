using Microsoft.AspNetCore.Mvc;
namespace CMCSPT.Controllers
{
    public class ClaimsController : Controller
    {
        //Action to display the image form
        public IActionResult ImageForm() {
            return View();
                }
    }
}
