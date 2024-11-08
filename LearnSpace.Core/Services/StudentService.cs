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

        public async Task<bool> ExistsByIdAsync(int id)
        {
            var student = await repository.GetByIdAsync<Student>(id);

            return student != null;
        }

        public async Task<StudentDashboardModel> GetStudentDashboardInformationAsync(int id)
        {
            var student = repository.GetByIdAsync<Student>(id);

            var model = new StudentDashboardModel() 
            { 
                Success = student.Result.Grades.ToList().Average(g=>g.Score),
                GradeCount = student.Result.Grades.Count(),
                ClassCount = student.Result.StudentCourses.Count(),
                AssignmentCount = student.Result.StudentCourses.Sum(c=>c.Course.Assignments.Count)
            };

            return model;
        }


    }
}
