using LearnSpace.Core.Interfaces;
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
		public async Task<IActionResult> AllGrades(string id)
		{

			var list = await gradeService.GetAllGradesAsync(id);

			return View("AllGrades",list);
		}

		public async Task<IActionResult> GradeInfo(string userId, int id) 
		{
			var grade = await gradeService.GetGradeInfoAsync(id);

			return View(grade);
		}



	}
}
