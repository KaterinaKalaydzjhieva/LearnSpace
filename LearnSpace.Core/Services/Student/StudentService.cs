using LearnSpace.Core.Models.Student;
using LearnSpace.Infrastructure.Database.Repository;
using LearnSpace.Infrastructure.Database.Entities.Account;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using Microsoft.IdentityModel.Tokens;
using LearnSpace.Core.Interfaces.Student;

namespace LearnSpace.Core.Services.Student
{
    public class StudentService : IStudentService
    {
        private readonly IRepository repository;
        public StudentService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<bool> ExistsByIdAsync(string id)
        {
            var result = await repository.GetByIdAsync<ApplicationUser>(Guid.Parse(id));

            return result.Student != null;
        }

        public async Task<StudentDashboardModel> GetStudentDashboardInformationAsync(string id)
        {
            var student = await repository.GetStudentAsync(id);

            var model = new StudentDashboardModel();

            model.FullName = student.ApplicationUser.FirstName + " " + student.ApplicationUser.LastName;
            if (student.Grades.Any())
            {
                model.Success = student.Grades.ToList().Average(g => g.Score);
            }
            model.GradeCount = student.Grades.Count();
            model.ClassCount = student.StudentCourses.Count();
            model.AssignmentCount = student.StudentCourses.Sum(c => c.Course.Assignments.Count);

            return model;
        }
    }
}
