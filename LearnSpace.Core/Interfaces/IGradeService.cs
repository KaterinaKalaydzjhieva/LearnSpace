using LearnSpace.Core.Models.Grade;

namespace LearnSpace.Core.Interfaces
{
    public interface IGradeService
    {
        Task<List<GradeCourseViewModel>> GetAllGradesAsync(string id);

        Task<GradeInfoViewModel> GetGradeInfoAsync(int id);
    }
}
