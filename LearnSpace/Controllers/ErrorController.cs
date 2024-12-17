using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LearnSpace.Web.Controllers
{
    [AllowAnonymous]
    public class ErrorController : Controller
    {
        public IActionResult Error404()
        {
            return View();
        }
    }
}
