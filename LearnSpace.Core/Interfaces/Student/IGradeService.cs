using LearnSpace.Core.Models.Grade;

namespace LearnSpace.Core.Interfaces.Student
{
    public interface IGradeService
    {
        Task<List<GradeCourseViewModel>> GetAllGradesAsync(string userId);

        Task<GradeInfoViewModel> GetGradeInfoAsync(int id);
    }
}
