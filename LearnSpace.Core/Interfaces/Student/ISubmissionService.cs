using LearnSpace.Core.Models.Submission;
using Microsoft.AspNetCore.Http;

namespace LearnSpace.Core.Interfaces.Student
{
    public interface ISubmissionService
    {
        Task CreateSubmissionAsync(string userId, int assignmentId, IFormFile file);
        Task<SubmissionsViewModel> GetAllSubmissionsForAssignmentAsync(int assignmentId);
        Task<SubmissionFileModel> GetFileBySubmissionIdAsync(int submissionId);
        Task DeleteSubmissionIdAsync(int submissionId);
        Task<SubmissionsViewModel> GetAllSubmissionsForTeacherAsync(string userId);
    }
}
