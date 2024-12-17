using LearnSpace.Core.Interfaces;
using LearnSpace.Core.Models.Assignment;
using LearnSpace.Web.Controllers;
using LearnSpace.Web.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace LearnSpace.Web.Areas.Student.Controllers
{
    public class SubmissionController : BaseController
    {
        private readonly ISubmissionService submissionService;

        public SubmissionController(ISubmissionService _submissionService)
        {
            submissionService = _submissionService;
        }
        [HttpPost]
        public async Task<IActionResult> SubmitAssignment(int assignmentId, IFormFile filePath)
        {
            await submissionService.CreateSubmissionAsync(GetUserId(), assignmentId, filePath);

            return RedirectToAction("AssignmentInfo", "Assignment", new { id = assignmentId });
        }

    }
}
