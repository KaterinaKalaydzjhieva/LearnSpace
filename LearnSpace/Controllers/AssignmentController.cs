using LearnSpace.Core.Interfaces.Student;
using LearnSpace.Core.Models.Assignment;
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
        public async Task<IActionResult> AllAssignments() 
        {
            var assignments = await assignmentService.GetAllAssignmentsAsync(GetUserId());

            return View(assignments);
        }

        [HttpGet]
        public async Task<IActionResult> AllAssignmentsClassStudent(int classId)
        {
            var assignments = await assignmentService.GetAllAssignmentsByClassForStudentAsync(GetUserId(), classId);

            return View(assignments);
        }

        [HttpGet]
        public async Task<IActionResult> AllAssignmentsClassTeacher(int classId)
        {
            var assignments = await assignmentService.GetAllAssignmentsByClassForTeacherAsync(GetUserId(), classId);

            return View(assignments);
        }
        [HttpGet]
        public async Task<IActionResult> AssignmentInfo(int id) 
        {
            var assignment = await assignmentService.GetAssignmentInfoAsync(GetUserId(),id);

            return View(assignment);
        }

        [HttpGet]
        public async Task<IActionResult> AssignmentInfoForTeacher(int id)
        {
            var assignment = await assignmentService.GetAssignmentInfoForTeacherAsync(id);

            return View(assignment);
        }

        [HttpGet]
        public IActionResult CreateAssignment(int classId) 
        {
            var model = new CreateAssignmentFormModel
            {
                ClassId = classId
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAssignment(CreateAssignmentFormModel model)
        {
            await assignmentService.CreateAssignment(model);

            return RedirectToAction(nameof(AllAssignmentsClassTeacher), new { classId = model.ClassId });
        }
    }
}
