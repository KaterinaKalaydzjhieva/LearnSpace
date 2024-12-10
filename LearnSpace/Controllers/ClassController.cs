using LearnSpace.Core.Interfaces;
using LearnSpace.Core.Services;
using LearnSpace.Web.Extensions;
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
        public async Task<IActionResult> AllClasses(string id) 
        {
            var list = await classService.GetAllClassesAsync(id);

            return View("AllClasses", list);
        }

        [HttpPost]
        public async Task<IActionResult> LeaveClass(string userId, int classId) 
        {
            await classService.LeaveClassAsync(userId, classId);

            return RedirectToAction(nameof(AllClasses), User.Id());
        }
    }
}
