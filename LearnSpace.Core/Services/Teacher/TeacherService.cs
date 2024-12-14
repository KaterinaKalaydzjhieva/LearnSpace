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
            var user = await repository.GetTeacherAsync(id);

            var model = new TeacherDashboardModel
            {
                FullName = user.ApplicationUser.FirstName + " " + user.ApplicationUser.LastName,
                GradeCount = user.Courses.SelectMany(c=>c.Assignments.Select(a=>a.Submissions.Select(s=>s.Grade))).Count(),
                AssignmentCount = user.Assignments.Count,
                ClassCount = user.Courses.Count
            };

            return model;
        }
    }
}
