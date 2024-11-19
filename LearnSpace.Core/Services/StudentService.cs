using LearnSpace.Core.Interfaces;
using LearnSpace.Core.Models.Student;
using LearnSpace.Infrastructure.Database.Repository;
using LearnSpace.Infrastructure.Database.Entities.Account;
using Microsoft.EntityFrameworkCore;

namespace LearnSpace.Core.Services
{
    public class StudentService : IStudentService
    {
        private readonly IRepository<Student, Guid> repository;
        public StudentService(IRepository<Student, Guid> _repository)
        {
            repository = _repository;
        }

        public async Task<bool> ExistsByIdAsync(string id)
        {
            bool result = await repository.GetAllAttached().AnyAsync(s=>s.ApplicationUserId.ToString().ToLower() == id);

            return result;
        }

        public async Task<StudentDashboardModel> GetStudentDashboardInformationAsync(string id)
        {
            var b = Guid.Parse(id);
            var user = await repository.GetByIdAsync<ApplicationUser, Guid>(b);
            var model = new StudentDashboardModel() 
            {
                Success = user.Student.Grades.ToList().Average(g => g.Score),
                GradeCount = user.Student.Grades.Count(),
                ClassCount = user.Student.StudentCourses.Count(),
                AssignmentCount = user.Student.StudentCourses.Sum(c => c.Course.Assignments.Count)
            };

            return model;
        }
    }
}
