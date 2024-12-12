namespace LearnSpace.Core.Interfaces.Student
{
    public interface ISubmissionService
    {
        Task CreateSubmissionAsync(string userId, int assignmentId, string filePath); 
    }
}
