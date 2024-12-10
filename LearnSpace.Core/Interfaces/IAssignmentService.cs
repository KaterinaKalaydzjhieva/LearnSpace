using LearnSpace.Core.Models.Assignment;

namespace LearnSpace.Core.Interfaces
{
    public interface IAssignmentService
    {
        Task<AllAssignmentsViewModel> GetAllAssignmentsByClassAsync(string userId, int classId);
        Task<AllAssignmentsViewModel> GetAllAssignmentsAsync(string userId);
        Task<AssignmentInfoViewModel> GetAssignmentInfoAsync(int id);
    }
}
