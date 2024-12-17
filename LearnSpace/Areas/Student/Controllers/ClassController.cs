using LearnSpace.Core.Interfaces;
using LearnSpace.Core.Models.Class;
using Microsoft.AspNetCore.Mvc;

namespace LearnSpace.Web.Areas.Student.Controllers
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
        public async Task<IActionResult> AllClasses([FromQuery] AllClassesQueryModel query)
        {
            var model = await classService.GetAllClassesAsync(
                     GetUserId(),
                     query.SearchTerm,
                     query.Sorting,
                     query.CurrentPage,
                     query.ClassesPerPage
            );
            query.TotalClassesCount = model.TotalClassesCount;
            query.Classes = model.Classes;

            return View(query);
        }

        [HttpPost]
        public async Task<IActionResult> LeaveClass(int classId)
        {
            await classService.LeaveClassAsync(GetUserId(), classId);

            return RedirectToAction(nameof(AllClassesForStudent));
        }

        [HttpPost]
        public async Task<IActionResult> JoinClass(int classId)
        {
            var userId = GetUserId();

            await classService.JoinClassAsync(userId, classId);

            return RedirectToAction(nameof(AllClassesForStudent));
        }
    }
}
