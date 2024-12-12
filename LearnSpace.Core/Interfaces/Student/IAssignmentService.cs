using LearnSpace.Core.Models.Assignment;

namespace LearnSpace.Core.Interfaces.Student
{
    public interface IAssignmentService
    {
        Task<AssignmentsClassViewModel> GetAllAssignmentsByClassAsync(string userId, int classId);
        Task<AllAssignmentsViewModel> GetAllAssignmentsAsync(string userId);
        Task<AssignmentInfoViewModel> GetAssignmentInfoAsync(int id);
    }
}
