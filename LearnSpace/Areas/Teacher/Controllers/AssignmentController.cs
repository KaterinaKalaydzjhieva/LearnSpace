using LearnSpace.Core.Interfaces;
using LearnSpace.Core.Models.Assignment;
using Microsoft.AspNetCore.Mvc;

namespace LearnSpace.Web.Areas.Teacher.Controllers
{
    public class AssignmentController : BaseController
    {
        private readonly IAssignmentService assignmentService;

        public AssignmentController(IAssignmentService _assignmentService)
        {
            assignmentService = _assignmentService;
        }

        [HttpGet]
        public async Task<IActionResult> AllAssignmentsClassTeacher(int classId)
        {
            var assignments = await assignmentService.GetAllAssignmentsByClassForTeacherAsync(GetUserId(), classId);

            return View(assignments);
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
