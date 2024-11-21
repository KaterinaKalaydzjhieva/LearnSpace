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
		public async Task<IActionResult> Dairy(string id)
		{
			var list = await gradeService.GetAllGradesAsync(id);

			return View("AllGrades",list);
		}



	}
}
