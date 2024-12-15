namespace LearnSpace.Core.Models.Assignment
{
    public class CreateAssignmentFormModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
        public int ClassId { get; set; }

    }
}
