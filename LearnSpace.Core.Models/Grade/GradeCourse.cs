namespace LearnSpace.Core.Models.Grade
{
    public class GradeCourse
    {
        public string Name { get; set; } = string.Empty;
        public List<double> Grades { get; set; } = new List<double>();
    }
}
