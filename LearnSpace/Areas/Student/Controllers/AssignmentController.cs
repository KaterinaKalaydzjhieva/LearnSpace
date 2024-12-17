using LearnSpace.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LearnSpace.Web.Areas.Student.Controllers
{
    public class AssignmentController : BaseController
    {
        private readonly IAssignmentService assignmentService;

        public AssignmentController(IAssignmentService _assignmentService)
        {
            assignmentService = _assignmentService;
        }

        [HttpGet]
        public async Task<IActionResult> AllAssignments() 
        {
            var assignments = await assignmentService.GetAllAssignmentsAsync(GetUserId());

            return View(assignments);
        }

        [HttpGet]
        public async Task<IActionResult> AllAssignmentsClassStudent(int classId)
        {
            if (!(await assignmentService.ExistsByIdAsync(classId))) 
            {
                return RedirectToAction("Error404", "Error"); 
            }
            var assignments = await assignmentService.GetAllAssignmentsByClassForStudentAsync(GetUserId(), classId);

            return View(assignments);
        }
        [HttpGet]
        public async Task<IActionResult> AssignmentInfo(int id) 
        {
            var assignment = await assignmentService.GetAssignmentInfoAsync(GetUserId(),id);

            return View(assignment);
        }
    }
}
