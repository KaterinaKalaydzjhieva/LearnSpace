using LearnSpace.Core.Models.Student;
using Microsoft.AspNetCore.Mvc;

namespace LearnSpace.Core.Interfaces
{
    public interface IStudentService
    {
        Task<bool> ExistsByIdAsync(string id);

        Task<StudentDashboardModel> GetStudentDashboardInformationAsync(string id);
    }
}
