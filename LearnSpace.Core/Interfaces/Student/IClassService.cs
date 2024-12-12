using LearnSpace.Core.Models.Class;

namespace LearnSpace.Core.Interfaces.Student
{
    public interface IClassService
    {
        Task<AllClassesViewModel> GetAllClassesForStudentAsync(string id);
        Task LeaveClassAsync(string userId, int classId);
        AllClassesViewModel GetAllClasses(string id);
        Task JoinClassAsync(string userId, int id);
    }
}
