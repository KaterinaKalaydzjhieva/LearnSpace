using LearnSpace.Infrastructure.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnSpace.Infrastructure.Database.Configuration
{
    public class SubmissionConfiguration : IEntityTypeConfiguration<Submission>
    {
        public void Configure(EntityTypeBuilder<Submission> builder)
        {
            builder.HasData(SeedSubmissions());
        }
        private static List<Submission> SeedSubmissions() 
        {
            var submissions = new List<Submission>();
            
            //1
            var submission = new Submission()
            {
                Id = 1,
                AssignmentId = 2,
                StudentId = Guid.Parse("5c07f155-602e-403b-bb86-5a786814f575"),
                FilePath = "D:\\Programing Files\\C#\\LearnSpace\\LearnSpace\\wwwroot\\uploads\\submissions\\task1.txt",
                SubmittedOn = DateTime.UtcNow,
                GradeId = 1
            };

            submissions.Add(submission);

            //2
            submission = new Submission()
            {
                Id = 2,
                AssignmentId = 4,
                StudentId = Guid.Parse("18e76084-b8a6-4e78-bd26-143f33a05eb8"),
                FilePath = "D:\\Programing Files\\C#\\LearnSpace\\LearnSpace\\wwwroot\\uploads\\submissions\\task2.txt",
                SubmittedOn = DateTime.UtcNow,
                GradeId = 2
            };

            submissions.Add(submission);

            //3
            submission = new Submission()
            {
                Id = 3,
                AssignmentId = 6,
                StudentId = Guid.Parse("c6903087-71e5-41ba-80be-ed119b7902fc"),
                FilePath = "D:\\Programing Files\\C#\\LearnSpace\\LearnSpace\\wwwroot\\uploads\\submissions\\task3.txt",
                SubmittedOn = DateTime.UtcNow,
                GradeId = 3
            };

            submissions.Add(submission);

            //4
            submission = new Submission()
            {
                Id = 4,
                AssignmentId = 8,
                StudentId = Guid.Parse("f4aa693d-305e-426b-950c-d02a8ca8b56f"),
                FilePath = "D:\\Programing Files\\C#\\LearnSpace\\LearnSpace\\wwwroot\\uploads\\submissions\\task4.txt",
                SubmittedOn = DateTime.UtcNow,
                GradeId = 4
            };

            submissions.Add(submission);

            //5
            submission = new Submission()
            {
                Id = 5,
                AssignmentId = 10,
                StudentId = Guid.Parse("bb5432a1-ea56-450b-9db6-f7349faf28a6"),
                FilePath = "D:\\Programing Files\\C#\\LearnSpace\\LearnSpace\\wwwroot\\uploads\\submissions\\task5.txt",
                SubmittedOn = DateTime.UtcNow,
                GradeId = 5
            };

            submissions.Add(submission);


            return submissions;
        }
    }
}
