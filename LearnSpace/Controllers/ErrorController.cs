using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LearnSpace.Web.Controllers
{
    [AllowAnonymous]
    public class ErrorController : Controller
    {
        
        public IActionResult NotFound()
        {
            return View();
        }
    }
}
