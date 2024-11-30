namespace LearnSpace.Core.Models.Student
{
    public class StudentDashboardModel
    {
        public string FullName { get; set; }
        public double Success { get; set; } = 0;
        public int GradeCount { get; set; }
        public int AssignmentCount { get; set; }
        public int ClassCount { get; set; }

        //public List<string> GetLastSixMonths() 
        //{
        //    var dateNow = DateTime.Now;
        //    var list = new List<string>();

        //    for (int i = 0; i < GradeCount; i++) 
        //    {
            
        //    }
        //}

    }
}
