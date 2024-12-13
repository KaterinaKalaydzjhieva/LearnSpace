using LearnSpace.Core.Interfaces.Student;
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

		public async Task<IActionResult> GradeInfo(int id) 
		{
			var grade = await gradeService.GetGradeInfoAsync(id);

			return View(grade);
		}



	}
}
