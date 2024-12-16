using LearnSpace.Core.Interfaces.Student;
using LearnSpace.Core.Models.Grade;
using LearnSpace.Infrastructure.Database.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LearnSpace.Web.Controllers
{

    public class GradeController : BaseController
	{
		private readonly IGradeService gradeService;

		public GradeController(IGradeService _gradeService)
		{
			gradeService = _gradeService;
		}

		[HttpGet]
		public async Task<IActionResult> AllGrades()
		{
			var list = await gradeService.GetAllGradesAsync(GetUserId());

			return View(list);
		}
        [HttpGet]
        public async Task<IActionResult> GradeInfo(int id) 
		{
			var grade = await gradeService.GetGradeInfoAsync(id);

			return View(grade);
		}
		[HttpGet]
		public async Task<IActionResult> AddGrade(int classId, string studentId) 
		{
			var model = await gradeService.GetAddGradeModelAsync(classId, studentId);

			return View(model);
		}

        [HttpPost]
        public async Task<IActionResult> AddGrade(CreateGradeViewModel model)
        {
			await gradeService.CreateGradeAsync(model);

			return RedirectToAction("GradeBook", "Teacher", new {classId = model.CourseId });
        }

		[HttpPost]
		public async Task<IActionResult> DeleteGrade(int gradeId)
		{
			var classid = await gradeService.DeleteGradeAsync(gradeId);

			return RedirectToAction("GradeBook","Teacher",new {classId = classid } );
		}


    }
}
