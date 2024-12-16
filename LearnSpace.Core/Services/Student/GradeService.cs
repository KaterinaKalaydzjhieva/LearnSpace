﻿using LearnSpace.Core.Interfaces.Student;
using LearnSpace.Core.Models.Grade;
using LearnSpace.Infrastructure.Database.Entities;
using LearnSpace.Infrastructure.Database.Repository;

namespace LearnSpace.Core.Services.Student
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
                if (course.Grades.Any(g=>g.StudentId == student.Id))
                {
                    gradeCourse.Grades = course.Grades.Where(g=>g.StudentId == student.Id)
                                        .Select(g => new GradeServiceModel
                                        {
                                            Score = g.Score,
                                            Id = g.Id
                                        }).ToList();
                    
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
            gradeInfo.CourseName = grade.Course.Name;
            gradeInfo.AssignmentDescription = grade.Course.Description;
            gradeInfo.Score = grade.Score;
            gradeInfo.Teacher = grade.Course.Teacher.ApplicationUser.FirstName + " " + grade.Course.Teacher.ApplicationUser.LastName;

            return gradeInfo;

        }
    }
}
