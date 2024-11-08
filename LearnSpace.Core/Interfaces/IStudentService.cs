using LearnSpace.Core.Models.Student;
using Microsoft.AspNetCore.Mvc;

namespace LearnSpace.Core.Interfaces
{
    public interface IStudentService
    {
        Task<bool> ExistsByIdAsync(int id);

        Task<StudentDashboardModel> GetStudentDashboardInformationAsync(int id);
    }
}
