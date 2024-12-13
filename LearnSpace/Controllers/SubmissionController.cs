using LearnSpace.Core.Interfaces.Student;

namespace LearnSpace.Web.Controllers
{
    public class SubmissionController : BaseController
    {
        private readonly ISubmissionService submissionService;

        public SubmissionController(ISubmissionService _submissionService)
        {
            submissionService = _submissionService;
        }
        //public async Task<IActionResult> SubmitAssignment(int assignmentId, string filePath) 
        //{
        //    await submissionService.CreateSubmissionAsync(GetUserId(), assignmentId, filePath);

        //    return
        //}
    }
}
