using LearnSpace.Core.Interfaces;
using LearnSpace.Core.Models.Grade;
using LearnSpace.Infrastructure.Database.Repository;

namespace LearnSpace.Core.Services
{
    public class GradeService : IGradeService
    {
        private readonly IRepository repository;
        public GradeService(IRepository _repository)
        {
            repository = _repository;
        }
        public async Task<List<GradeCourse>> GetAllGradesAsync(string id)
        {
            var student = await repository.GetStudentAsync(id);
            var list = new List<GradeCourse>();
            var gradeCourse = new GradeCourse();
            var courses = student.StudentCourses.Select(sc => sc.Course).ToList();

            foreach (var course in courses) 
            {
                if (course.Assignments.Any(a => a.Grades.Any())) 
                {
                    gradeCourse.Grades = course.Assignments.SelectMany(a => a.Grades).Select(g=>g.Score).ToList();
                }
                gradeCourse.Name = course.Name;
                list.Add(gradeCourse);
                gradeCourse = new GradeCourse();
            }

            return list;
        }
    }
}
