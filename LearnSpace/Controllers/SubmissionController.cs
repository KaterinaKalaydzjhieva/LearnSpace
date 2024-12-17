using LearnSpace.Core.Interfaces.Student;
using LearnSpace.Core.Models.Assignment;
using LearnSpace.Web.Extensions;
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
                return RedirectToAction(nameof(AllSubmissionsForAssignment), new { assignmentId = assignmentId});
            }
            else if(User.IsTeacher()) 
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
