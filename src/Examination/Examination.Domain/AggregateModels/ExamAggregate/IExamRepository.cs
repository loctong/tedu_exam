using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Examination.Domain.SeedWork;

namespace Examination.Domain.AggregateModels.ExamAggregate
{
    public interface IExamRepository : IRepositoryBase<Exam>
    {
        Task<IEnumerable<Exam>> GetExamListAsync(); // TODO: y nghia la Toi can cai nay (implement duoi infrastructure)
        Task<Exam> GetExamByIdAsync(string id);
    }
}