using LearnSpace.Core.Interfaces;
using LearnSpace.Core.Models.Class;
using LearnSpace.Infrastructure.Database.Entities;
using LearnSpace.Infrastructure.Database.Repository;
using Microsoft.EntityFrameworkCore;

namespace LearnSpace.Core.Services
{
    public class ClassService : IClassService
	{
		private readonly IRepository repository;
		public ClassService(IRepository _repository)
		{
			repository = _repository;
		}

        public AllClassesViewModel GetAllClasses(string id)
        {
			var list = repository.All<Course>()
                                .Where(course => !course.CourseStudents.Any(cs => cs.StudentId.ToString().ToLower() == id))
								.ToList();


            var allClasses = list.Select(c=> new ClassInfoModel 
			{
                Id = c.Id,
                TeacherName = c.Teacher.ApplicationUser.FirstName + " " + c.Teacher.ApplicationUser.LastName,
                Name = c.Name,
                AssignmentCount = c.Assignments.Count

            }).ToList();

			var result = new AllClassesViewModel
			{
				Classes = allClasses
			};

			return result;
        }

        public async Task<AllClassesViewModel> GetAllClassesForStudentAsync(string id)
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

        public async Task JoinClassAsync(string userId, int id)
        {
			var student = await repository.GetStudentAsync(userId);
			var studentCourse = new StudentCourse
			{
				StudentId = student.Id,
				CourseId = id
			};

			await repository.AddAsync(studentCourse);
			await repository.SaveChangesAsync();
        }

        public async Task LeaveClassAsync(string userId, int classId)
        {
			var student = await repository.GetStudentAsync(userId);
			var studentCourse = student.StudentCourses.First(sc => sc.CourseId == classId);

			repository.Delete(studentCourse);
			await repository.SaveChangesAsync();
        }
    }
}
