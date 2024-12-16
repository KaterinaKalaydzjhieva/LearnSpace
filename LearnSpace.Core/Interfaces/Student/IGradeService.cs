using LearnSpace.Core.Models.Grade;

namespace LearnSpace.Core.Interfaces.Student
{
    public interface IGradeService
    {
        Task<List<GradeCourseViewModel>> GetAllGradesAsync(string userId);
        Task<GradeInfoViewModel> GetGradeInfoAsync(int id);
        Task<CreateGradeViewModel> GetAddGradeModelAsync(int classId, string userId);
        Task CreateGradeAsync(CreateGradeViewModel model);
        Task<int> DeleteGradeAsync(int id);
    }
}
