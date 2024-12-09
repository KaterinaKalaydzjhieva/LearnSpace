using LearnSpace.Core.Interfaces;
using LearnSpace.Core.Models.Grade;
using LearnSpace.Infrastructure.Database.Entities;
using LearnSpace.Infrastructure.Database.Repository;
using Microsoft.AspNetCore.Identity;

namespace LearnSpace.Core.Services
{
    public class GradeService : IGradeService
    {
        private readonly IRepository repository;
        public GradeService(IRepository _repository)
        {
            repository = _repository;
        }
        public async Task<List<GradeCourseViewModel>> GetAllGradesAsync(string id)
        {
            var student = await repository.GetStudentAsync(id);
            var list = new List<GradeCourseViewModel>();
            var gradeCourse = new GradeCourseViewModel();
            var courses = student.StudentCourses.Select(sc => sc.Course).ToList();

            foreach (var course in courses) 
            {
                if (course.Assignments.Any(a => a.Grades.Any())) 
                {
                    gradeCourse.Grades = course.Assignments
                                        .SelectMany(a => a.Grades.Where(g => g.StudentId == student.Id))
                                        .Select(g => new GradeServiceModel 
                                        {
                                            Score = g.Score,  
                                            Id = g.Id
                                        } ).ToList();
				}
                gradeCourse.Name = course.Name;
                list.Add(gradeCourse);
                gradeCourse = new GradeCourseViewModel();
            }

            return list;
        }

        public async Task<GradeInfoViewModel> GetGradeInfoAsync(int id)
        {
            var grade = await repository.GetByIdAsync<Grade>(id);

            var gradeInfo = new GradeInfoViewModel();

            gradeInfo.Id = id;
            gradeInfo.CourseName = grade.Assignment.Course.Name;
            gradeInfo.AssignmentDescription = grade.Assignment.Description;
            gradeInfo.Score = grade.Score;
            gradeInfo.Teacher = grade.Assignment.Course.Teacher.ApplicationUser.FirstName + " " + grade.Assignment.Course.Teacher.ApplicationUser.LastName;

            return gradeInfo;

        }
    }
}
