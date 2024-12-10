using LearnSpace.Core.Interfaces;
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
        public async Task<IActionResult> AllAssignments(string userId) 
        {
            var assignments = await assignmentService.GetAllAssignmentsAsync(userId);

            return View(assignments);
        }

        [HttpGet]
        public async Task<IActionResult> AllAssignmentsClass(string userId, int classId)
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
