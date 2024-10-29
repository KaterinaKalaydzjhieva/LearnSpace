namespace LearnSpace.Infrastructure.Database.Entities.Account
{
    public class Student : ApplicationUser
    {
        public IEnumerable<Grade> Grades { get; set; } = new List<Grade>();
        public IEnumerable<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
    }

}
