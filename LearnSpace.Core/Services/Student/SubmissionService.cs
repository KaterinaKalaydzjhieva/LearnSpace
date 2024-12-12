using LearnSpace.Core.Interfaces.Student;
using LearnSpace.Infrastructure.Database.Entities;
using LearnSpace.Infrastructure.Database.Repository;

namespace LearnSpace.Core.Services.Student
{
    public class SubmissionService : ISubmissionService
    {
        private readonly IRepository repository;
        public SubmissionService(IRepository _repository)
        {
            repository = _repository;
        }
        public async Task CreateSubmissionAsync(string userId, int assignmentId, string filePath)
        {
            var user = await repository.GetStudentAsync(userId);

            var submission = new Submission 
            {
                AssignmentId = assignmentId,
                StudentId = user.Id,
                FilePath = filePath,
                SubmittedOn = DateTime.Now
            };

            await repository.AddAsync(submission);
            await repository.SaveChangesAsync();
        }
    }
}
