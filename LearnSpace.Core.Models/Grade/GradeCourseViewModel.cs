namespace LearnSpace.Core.Models.Grade
{
    public class GradeCourseViewModel
    {
        public string Name { get; set; } = string.Empty;
        public List<double> Grades { get; set; } = new List<double>();
    }
}
