using LearnSpace.Core.Interfaces.Student;
using LearnSpace.Core.Interfaces.Teacher;
using Microsoft.AspNetCore.Mvc;

namespace LearnSpace.Web.Controllers
{
    public class TeacherController : BaseController
    {
        private readonly ITeacherService teacherService;

        public TeacherController(ITeacherService _teacherService)
        {
            teacherService = _teacherService;
        }
        public async Task<IActionResult> Dashboard() 
        {
            var model = await teacherService.GetTeacherDashboardInformationAsync(GetUserId());

            return View(model);
        }
    }
}
