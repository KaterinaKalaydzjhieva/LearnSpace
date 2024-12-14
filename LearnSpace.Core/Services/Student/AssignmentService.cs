using LearnSpace.Core.Interfaces.Student;
using LearnSpace.Core.Models.Assignment;
using LearnSpace.Infrastructure.Database.Entities;
using LearnSpace.Infrastructure.Database.Repository;
using Microsoft.AspNetCore.Identity;
using static LearnSpace.Common.Constants;

namespace LearnSpace.Core.Services.Student
{
    public class AssignmentService : IAssignmentService
    {
        private readonly IRepository repository;
        public AssignmentService(IRepository _repository)
        {
            repository = _repository;
        }
        public async Task<AllAssignmentsViewModel> GetAllAssignmentsAsync(string userId)
        {
            var student = await repository.GetStudentAsync(userId);

            var allAssignments = student.StudentCourses
                                .SelectMany(sc => sc.Course.Assignments).Select(a => new AssignmentServiceModel
                                {
                                    Id = a.Id,
                                    DueDate = a.DueDate.ToString(DateFormat),
                                    Title = a.Title,
                                    IsSubmitted = a.Submissions.Any(s=>s.StudentId == student.Id),

                                }).ToList();

            var result = new AllAssignmentsViewModel()
            {
                Assignments = allAssignments
            };

            return result;
        }

        public async Task<AssignmentsClassViewModel> GetAllAssignmentsByClassAsync(string userId, int classId)
        {
            var student = await repository.GetStudentAsync(userId);
            var course = await repository.GetByIdAsync<Course>(classId);

            var allAssignments = student.StudentCourses
                                        .First(sc => sc.Course.Id == classId)
                                        .Course.Assignments.Select(a => new AssignmentServiceModel
                                        {
                                            Id = a.Id,
                                            DueDate = a.DueDate.ToString(DateFormat),
                                            Title = a.Title,
                                            IsSubmitted = a.Submissions.Any(s => s.StudentId == student.Id),
                                        }).ToList();

            var result = new AssignmentsClassViewModel()
            {
                ClassName = course.Name,
                Assignments = allAssignments
            };

            return result;

        }

        public async Task<AssignmentInfoViewModel> GetAssignmentInfoAsync(string userId, int assignmentId)
        {
            var assignment = await repository.GetByIdAsync<Assignment>(assignmentId);
            var student = await repository.GetStudentAsync(userId);
            var model = new AssignmentInfoViewModel
            {
                Id = assignmentId,
                Title = assignment.Title,
                Description = assignment.Description,
                DueDate = assignment.DueDate.ToString(DateFormat),
                ClassName = assignment.Course.Name,
                TeacherName = assignment.Course.Teacher.ApplicationUser.FirstName + " " + assignment.Course.Teacher.ApplicationUser.LastName,
                IsSubmitted = assignment.Submissions.Any(s=>s.StudentId ==student.Id),
                SubmissionDate = assignment.Submissions.Any(s => s.StudentId == student.Id) ? 
                                                assignment.Submissions
                                                        .First(s=>s.StudentId == student.Id)
                                                        .SubmittedOn
                                                        .ToString(DateFormat):
                                                string.Empty
            };

            return model;
        }
    }
}
