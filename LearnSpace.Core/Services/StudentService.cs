using LearnSpace.Core.Interfaces;
using LearnSpace.Core.Models.Student;
using LearnSpace.Infrastructure.Database.Repository;
using LearnSpace.Infrastructure.Database.Repository.Interfaces;
using LearnSpace.Infrastructure.Database.Entities.Account;
using Microsoft.EntityFrameworkCore;

namespace LearnSpace.Core.Services
{
	public class StudentService : IStudentService
	{
		private readonly IRepository<Student, Guid> repositoryStudent;
		private readonly IRepository<ApplicationUser, Guid> repositoryUser;
		public StudentService(IRepository<Student, Guid> _repositoryStudent, IRepository<ApplicationUser, Guid> _repositoryUser)
		{
			repositoryStudent = _repositoryStudent;
			repositoryUser = _repositoryUser;
		}

		public async Task<bool> ExistsByIdAsync(string id)
		{
			bool result = await repositoryStudent.GetAllAttached().AnyAsync(s => s.ApplicationUserId.ToString().ToLower() == id);

			return result;
		}

		public async Task<StudentDashboardModel> GetStudentDashboardInformationAsync(string id)
		{
			var user = await repositoryUser.GetByIdAsync(Guid.Parse(id));
			var student = repositoryStudent.GetAllAsync().Result.First(s => s.ApplicationUserId.ToString().ToLower() == id);

			var model = new StudentDashboardModel();

			if (student.Grades.Any())
			{
				model.Success = student.Grades.ToList().Average(g=>g.Score);
			}
			model.GradeCount = student.Grades.Count();

			model.ClassCount = student.StudentCourses.Count();

			model.AssignmentCount = student.StudentCourses.Sum(c => c.Course.Assignments.Count);

			//var model = new StudentDashboardModel() 
			//{
			//    Success = student.Grades.ToList().Average(g => g.Score),
			//    GradeCount = student.Grades.Count(),
			//    ClassCount = student.StudentCourses.Count(),
			//    AssignmentCount = student.StudentCourses.Sum(c => c.Course.Assignments.Count)

			//};

			return model;
		}
	}
}
