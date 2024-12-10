using LearnSpace.Core.Interfaces;
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
        public async Task<IActionResult> AllClassesForStudent(string id) 
        {
            var list = await classService.GetAllClassesForStudentAsync(id);

            return View(list);
        }

        [HttpGet]
        public IActionResult AllClasses(string id)
        {
            var list = classService.GetAllClasses(id);

            return View(list);
        }

        [HttpPost]
        public async Task<IActionResult> LeaveClass(string userId, int classId) 
        {
            await classService.LeaveClassAsync(userId, classId);

            return RedirectToAction(nameof(AllClassesForStudent), new { userId = userId });
        }

        [HttpPost]
        public async Task<IActionResult> JoinClass(string userId, int classId) 
        {
            await classService.JoinClassAsync(userId, classId);

            return RedirectToAction(nameof(AllClassesForStudent), userId);
        }
    }
}
