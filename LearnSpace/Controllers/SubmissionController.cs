using LearnSpace.Core.Interfaces.Student;
using LearnSpace.Core.Models.Assignment;
using Microsoft.AspNetCore.Mvc;

namespace LearnSpace.Web.Controllers
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
