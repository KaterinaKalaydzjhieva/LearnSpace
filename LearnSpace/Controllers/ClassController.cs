using LearnSpace.Core.Interfaces.Student;
using LearnSpace.Web.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace LearnSpace.Web.Controllers
{
    public class ClassController : BaseController
    {
        private readonly IClassService classService;

        public ClassController(IClassService _classService)
        {
            classService = _classService;
        }
        [HttpGet]
        public async Task<IActionResult> AllClassesForStudent() 
        {
            var list = await classService.GetAllClassesForStudentAsync(GetUserId());

            return View(list);
        }

        [HttpGet]
        public IActionResult AllClasses()
        {
            var list = classService.GetAllClasses(GetUserId());

            return View(list);
        }

        [HttpPost]
        public async Task<IActionResult> LeaveClass(int classId) 
        {
            var userId = GetUserId();

            await classService.LeaveClassAsync(userId, classId);

            return RedirectToAction(nameof(AllClassesForStudent), new { userId = userId });
        }

        [HttpPost]
        public async Task<IActionResult> JoinClass(int classId) 
        {
            var userId = GetUserId();

            await classService.JoinClassAsync(userId, classId);

            return RedirectToAction(nameof(AllClassesForStudent), userId);
        }
    }
}
