using LearnSpace.Core.Models.Teacher;

namespace LearnSpace.Core.Interfaces.Teacher
{
    public interface ITeacherService
    {
        Task<bool> ExistsByIdAsync(string id);

        Task<TeacherDashboardModel> GetTeacherDashboardInformationAsync(string id);
    }
}
