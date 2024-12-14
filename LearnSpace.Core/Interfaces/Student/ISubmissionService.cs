using Microsoft.AspNetCore.Http;

namespace LearnSpace.Core.Interfaces.Student
{
    public interface ISubmissionService
    {
        Task CreateSubmissionAsync(string userId, int assignmentId, IFormFile file); 
    }
}
