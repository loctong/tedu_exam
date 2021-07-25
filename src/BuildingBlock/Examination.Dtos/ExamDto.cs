using System;
using Examination.Dtos.Enums;

namespace Examination.Dtos
{
    public class ExamDto
    {
        public string Id { set; get; }
        public string Name { set; get; }
        public string ShortDesc { set; get; }
        public int NumberOfQuestion { get; set; }
        public TimeSpan? Duration { set; get; }
        public Level Level { set; get; }
        public DateTime DateCreated { set; get; }
    }
}