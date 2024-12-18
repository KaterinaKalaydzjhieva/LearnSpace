using LearnSpace.Core.Interfaces;
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
            if (!(await submissionService.ExistsByIdAsync(assignmentId)))
            {
                return RedirectToAction("Error404", "Error");
            }
            if (filePath == null || filePath.Length == 0)
            {
                ModelState.AddModelError("File", "Please upload a file.");
            }
            if (!submissionService.ContainsOnlyAllowedFileTypeAsync(filePath))
            {
                ModelState.AddModelError("File", "Invalid file type. Allowed types are .pdf, .docx, .xlsx., .txt");
                return RedirectToAction("AssignmentInfo", "Assignment",new {area="Student", id = assignmentId });
            }
            if (!submissionService.SizeIsNotTooBig(filePath)) 
            {
                ModelState.AddModelError("File", "File size exceeds the maximum allowed limit of 5 MB.");
                return RedirectToAction("Error400", "Error");
            }
            await submissionService.CreateSubmissionAsync(GetUserId(), assignmentId, filePath);

            return RedirectToAction("AssignmentInfo", "Assignment", new { id = assignmentId });
        }

    }
}
