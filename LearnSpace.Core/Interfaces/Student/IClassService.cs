using LearnSpace.Core.Models.Class;

namespace LearnSpace.Core.Interfaces.Student
{
    public interface IClassService
    {
        Task<AllClassesViewModel> GetAllClassesForStudentAsync(string userId);
        Task LeaveClassAsync(string userId, int classId);
        AllClassesViewModel GetAllClasses(string userId);
        Task JoinClassAsync(string userId, int id);
    }
}
