using LearnSpace.Core.Interfaces;
using LearnSpace.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace LearnSpace.Web.Controllers
{
    public class ClassController : Controller
    {
        private readonly IClassService classService;

        public ClassController(IClassService _classService)
        {
            classService = _classService;
        }
        [HttpGet]
        public async Task<IActionResult> Classes(string id) 
        {
            var list = await classService.GetAllClassesAsync(id);

            return View("AllClasses", list);
        }
    }
}
