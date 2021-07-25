using System;
using MediatR;

namespace Examination.Application.Commands.StartExam
{
    public class StartExamCommand : IRequest<bool>
    {
        public string UserId { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string ExamId { set; get; }
        public DateTime StartDate { set; get; }
    }
}