using LearnSpace.Core.Interfaces;
using LearnSpace.Core.Models.Assignment;
using LearnSpace.Infrastructure.Database.Entities;
using LearnSpace.Infrastructure.Database.Repository;
using static LearnSpace.Common.Constants;
namespace LearnSpace.Core.Services
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
            var user = await repository.GetStudentAsync(userId);
            
            var allAssignments = user.StudentCourses
                                .SelectMany(sc => sc.Course.Assignments).Select(a=> new AssignmentServiceModel 
                                { 
                                    Id = a.Id,
                                    DueDate = a.DueDate.ToString(DateFormat),
                                    Title = a.Title
                                
                                }).ToList();
            
            var result = new AllAssignmentsViewModel() 
            {
                Assignments = allAssignments
            };

            return result;
        }

        public async Task<AssignmentsClassViewModel> GetAllAssignmentsByClassAsync(string userId, int classId)
        {
            var user = await repository.GetStudentAsync(userId);
            var course = await repository.GetByIdAsync<Course>(classId);

            var allAssignments = user.StudentCourses
                                        .First(sc => sc.Course.Id == classId)
                                        .Course.Assignments.Select(a => new AssignmentServiceModel
                                        {
                                            Id = a.Id,
                                            DueDate = a.DueDate.ToString(DateFormat),
                                            Title = a.Title
                                        }).ToList();

            var result = new AssignmentsClassViewModel()
            {
                ClassName = course.Name,
                Assignments = allAssignments
            };

            return result;

        }

        public async Task<AssignmentInfoViewModel> GetAssignmentInfoAsync(int id)
        {
            var assignment = await repository.GetByIdAsync<Assignment>(id);

            var model = new AssignmentInfoViewModel
            {
                Title = assignment.Title,
                Description = assignment.Description,
                DueDate = assignment.DueDate.ToString(DateFormat),
                ClassName = assignment.Course.Name,
                TeacherName = assignment.Course.Teacher.ApplicationUser.FirstName + " " + assignment.Course.Teacher.ApplicationUser.LastName
            };

            return model;
        }
    }
}
