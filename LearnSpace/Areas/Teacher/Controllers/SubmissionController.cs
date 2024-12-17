using LearnSpace.Core.Interfaces;
using LearnSpace.Core.Models.Assignment;
using LearnSpace.Web.Controllers;
using LearnSpace.Web.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace LearnSpace.Web.Areas.Teacher.Controllers
{
    public class SubmissionController : BaseController
    {
        private readonly ISubmissionService submissionService;

        public SubmissionController(ISubmissionService _submissionService)
        {
            submissionService = _submissionService;
        }
        [HttpGet]
        public async Task<IActionResult> AllSubmissionsForAssignment(int assignmentId)
        {
            var model = await submissionService.GetAllSubmissionsForAssignmentAsync(assignmentId);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> DownloadFile(int submissionId)
        {
            var model = await submissionService.GetFileBySubmissionIdAsync(submissionId);

            if (model == null)
            {
                return NotFound("File not found.");
            }

            return File(model.FileContent, model.FileType, model.FileName);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteSubmission(int submissionId, string assignmentId)
        {
            await submissionService.DeleteSubmissionIdAsync(submissionId);
            if (User.IsStudent())
            {
                return RedirectToAction(nameof(AllSubmissionsForAssignment), new { assignmentId });
            }
            else if (User.IsTeacher())
            {
                return RedirectToAction(nameof(AllSubmissionsForTeacher));
            }

            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> AllSubmissionsForTeacher()
        {
            var model = await submissionService.GetAllSubmissionsForTeacherAsync(GetUserId());

            return View(model);
        }
    }
}
