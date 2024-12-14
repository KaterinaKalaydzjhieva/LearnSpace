using LearnSpace.Core.Models.Student;
using Microsoft.AspNetCore.Mvc;

namespace LearnSpace.Core.Interfaces.Student
{
    public interface IStudentService
    {
        Task<bool> ExistsByIdAsync(string userId);

        Task<StudentDashboardModel> GetStudentDashboardInformationAsync(string userId);

	}
}
