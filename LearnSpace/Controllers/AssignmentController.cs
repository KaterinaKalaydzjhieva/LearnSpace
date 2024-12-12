using LearnSpace.Core.Interfaces.Student;
using Microsoft.AspNetCore.Mvc;

namespace LearnSpace.Web.Controllers
{
    public class AssignmentController : BaseController
    {
        private readonly IAssignmentService assignmentService;

        public AssignmentController(IAssignmentService _assignmentService)
        {
            assignmentService = _assignmentService;
        }

        [HttpGet]
        public async Task<IActionResult> AllAssignments(string id) 
        {
            var assignments = await assignmentService.GetAllAssignmentsAsync(id);

            return View(assignments);
        }

        [HttpGet]
        public async Task<IActionResult> AllAssignmentsForClass(string userId, int classId)
        {
            var assignments = await assignmentService.GetAllAssignmentsByClassAsync(userId, classId);

            return View(assignments);
        }

        public async Task<IActionResult> AssignmentInfo(int id) 
        {
            var assignment = await assignmentService.GetAssignmentInfoAsync(id);

            return View(assignment);
        }
    }
}
