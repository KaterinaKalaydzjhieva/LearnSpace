using LearnSpace.Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LearnSpace.Web.Controllers
{
    [Authorize(Roles = "Student")]
    public class StudentController : BaseController
    {
        private readonly IStudentService studentService;

        public StudentController(IStudentService _studentService)
        {
                studentService = _studentService;
        }

        [HttpGet]
        public async Task<IActionResult> Dashboard(int id)
        {
            if (!User.Identity!.IsAuthenticated)
            {
                return Redirect("/User/Register");
            }
            if (!(await studentService.ExistsByIdAsync(id)))
            {
                return RedirectToAction("Error404", "Home", new { area = "" });
            }

            var student = await studentService.GetStudentDashboardInformationAsync(id);

            return View(student);
        }

    }
}
