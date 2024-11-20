using LearnSpace.Core.Models.Grade;

namespace LearnSpace.Core.Interfaces
{
    public interface IGradeService
    {
        Task<List<GradeCourse>> GetAllGradesAsync(string id);
    }
}
