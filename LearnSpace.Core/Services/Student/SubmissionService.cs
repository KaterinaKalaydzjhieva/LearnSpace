using LearnSpace.Core.Interfaces.Student;
using LearnSpace.Core.Models.Submission;
using LearnSpace.Infrastructure.Database.Entities;
using LearnSpace.Infrastructure.Database.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.FileIO;
using static LearnSpace.Common.Constants;
namespace LearnSpace.Core.Services.Student
{
    public class SubmissionService : ISubmissionService
    {
        private readonly IRepository repository;
        public SubmissionService(IRepository _repository)
        {
            repository = _repository;
        }
        public async Task CreateSubmissionAsync(string userId, int assignmentId, IFormFile file)
        {
            var student = await repository.GetStudentAsync(userId);
            var sub = student.Submissions.FirstOrDefault(s => s.AssignmentId == assignmentId);
            byte[] data;
            using (var memoryStream = new MemoryStream())
            {
                await file.CopyToAsync(memoryStream);
                data = memoryStream.ToArray();
            }

            if (sub==null) 
            {
                var submission = new Submission
                {
                    AssignmentId = assignmentId,
                    StudentId = student.Id,
                    FileName = Path.GetFileName(file.FileName),
                    FileType = file.ContentType,
                    SubmittedOn = DateTime.Now,
                    FileContent = data
                };

                await repository.AddAsync(submission);
            }
            else
            {
                sub.FileName = Path.GetFileName(file.FileName);
                sub.FileType = file.ContentType;
                sub.SubmittedOn = DateTime.Now;
                sub.FileContent = data;
            }
            await repository.SaveChangesAsync();

        }

        public async Task<SubmissionsByAssignmentViewModel> GetAllSubmissionsForAssignmentAsync(int assignmentId)
        {
            var assignment = await repository.GetByIdAsync<Assignment>(assignmentId);
            var submissions = assignment.Submissions
                                        .Select(s => new SubmissionQueryModel 
                                        {
                                            Id = s.Id,
                                            AssignmentId =assignmentId,
                                            AssignmentTitle=assignment.Title,
                                            FileName = s.FileName,
                                            SubmittedOn = s.SubmittedOn.ToString(DateFormat),
                                            StudentName = s.Student.ApplicationUser.FirstName + " "+ s.Student.ApplicationUser.LastName,
            
                                        }).ToList();
            var result = new SubmissionsByAssignmentViewModel
            {
                Submissions = submissions
            };
            return result;
        }

        public async Task<SubmissionFileModel> GetFileBySubmissionIdAsync(int submissionId)
        {
            var submission = await repository.GetByIdAsync<Submission>(submissionId);
            var model = new SubmissionFileModel
            {
                FileContent = submission.FileContent,
                FileName = submission.FileName,
                FileType = submission.FileType,
            };

            return model;
        }

        public async Task DeleteSubmissionIdAsync(int submissionId)
        {
            await repository.DeleteAsync<Submission>(submissionId);
            await repository.SaveChangesAsync();
        }

    }
}
