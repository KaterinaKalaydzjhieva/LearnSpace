using LearnSpace.Core.Interfaces;
using LearnSpace.Core.Models.Class;
using LearnSpace.Infrastructure.Database.Repository;

namespace LearnSpace.Core.Services
{
    public class ClassService : IClassService
	{
		private readonly IRepository repository;
		public ClassService(IRepository _repository)
		{
			repository = _repository;
		}
		public async Task<AllClassesViewModel> GetAllClassesAsync(string id)
		{
			var student = await repository.GetStudentAsync(id);
			var classes = new AllClassesViewModel();
			var courses = student.StudentCourses.Select(sc => sc.Course);

			foreach (var c in courses) 
			{
				var classInfo = new ClassInfoModel()
				{
					Id = c.Id,
					TeacherName = c.Teacher.ApplicationUser.FirstName + " " + c.Teacher.ApplicationUser.LastName,
					Name = c.Name,
					AssignmentCount = c.Assignments.Count,
				};
				classes.Classes.Add(classInfo);
			}

			return classes;
		}
	}
}
