using LearnSpace.Core.Interfaces.Teacher;
using LearnSpace.Core.Models.Teacher;
using LearnSpace.Infrastructure.Database.Entities.Account;
using LearnSpace.Infrastructure.Database.Repository;

namespace LearnSpace.Core.Services.Teacher
{
    public class TeacherService : ITeacherService
    {
        private readonly IRepository repository;
        public TeacherService(IRepository _repository)
        {
            repository = _repository;
        }
        public async Task<bool> ExistsByIdAsync(string id)
        {
            var result = await repository.GetByIdAsync<ApplicationUser>(Guid.Parse(id));

            return result.Student != null;
        }

        public async Task<TeacherDashboardModel> GetTeacherDashboardInformationAsync(string id)
        {
            var teacher = await repository.GetTeacherAsync(id);

            var model = new TeacherDashboardModel
            {
                FullName = teacher.ApplicationUser.FirstName + " " + teacher.ApplicationUser.LastName,
                TotalStudentsEnrolled = teacher.Courses.Sum(c=>c.CourseStudents.Count),
                AssignmentCount = teacher.Courses.SelectMany(c=>c.Assignments).Count(),
				WaitingSubmissions = teacher.Assignments
		                                .SelectMany(a => a.Submissions)
		                                .Count(s => s.GradeId == null)
			};

            return model;
        }
    }
}
