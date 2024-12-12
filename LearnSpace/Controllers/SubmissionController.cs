using LearnSpace.Core.Interfaces.Student;
using Microsoft.AspNetCore.Mvc;

namespace LearnSpace.Web.Controllers
{
    public class SubmissionController : Controller
    {
        private readonly ISubmissionService submissionService;

        public SubmissionController(ISubmissionService _submissionService)
        {
            submissionService = _submissionService;
        }
        public async Task<IActionResult> SubmitAssignment(string userId, int assignmentId, string filePath) 
        {
            await submissionService.CreateSubmissionAsync(userId, assignmentId, filePath);

            return
        }
    }
}
