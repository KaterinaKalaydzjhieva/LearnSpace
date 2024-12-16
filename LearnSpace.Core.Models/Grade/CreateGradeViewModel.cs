namespace LearnSpace.Core.Models.Grade
{
    public class CreateGradeViewModel
    {
        public int Score { get; set; }
        public string Description { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string StudentId { get; set; }
        public string StudentName { get; set; }

    }
}
