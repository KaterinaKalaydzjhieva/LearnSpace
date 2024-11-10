using LearnSpace.Core.Interfaces;
using LearnSpace.Core.Models.Student;
using LearnSpace.Infrastructure.Database.Contracts;
using LearnSpace.Infrastructure.Database.Entities.Account;

namespace LearnSpace.Core.Services
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
            var user = await repository.GetByIdAsync<ApplicationUser>(Guid.Parse(id));

            return user.Student != null;
        }

        public async Task<StudentDashboardModel> GetStudentDashboardInformationAsync(string id)
        {
            var user = await repository.GetByIdAsync<ApplicationUser>(Guid.Parse(id));
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
