using LearnSpace.Core.Models.Assignment;

namespace LearnSpace.Core.Interfaces.Student
{
    public interface IAssignmentService
    {
        Task<AssignmentsClassViewModel> GetAllAssignmentsByClassForStudentAsync(string userId,int classId);
        Task<AllAssignmentsForTeacherViewModel> GetAllAssignmentsByClassForTeacherAsync(string userId,int classId);
        Task<AllAssignmentsViewModel> GetAllAssignmentsAsync(string userId);
        Task<AssignmentInfoViewModel> GetAssignmentInfoAsync(string userId, int assignmentId);
        Task<AssignmentsInfoForTeacherViewModel> GetAssignmentInfoForTeacherAsync(int assignmentId);
        Task CreateAssignment(CreateAssignmentFormModel model);
    }
}
