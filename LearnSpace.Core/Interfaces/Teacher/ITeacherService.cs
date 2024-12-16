using LearnSpace.Core.Models.Teacher;

namespace LearnSpace.Core.Interfaces.Teacher
{
    public interface ITeacherService
    {
        Task<bool> ExistsByIdAsync(string userId);

        Task<TeacherDashboardModel> GetTeacherDashboardInformationAsync(string userId);
        Task<GradeBookViewModel> GetGradeBookByClassAsync(string userId, int classId);
    }
}
