using System.Collections.Generic;
using System.Threading.Tasks;
using Examination.Domain.AggregateModels.ExamAggregate;
using Examination.Domain.AggregateModels.ExamResultAggregate;
using Examination.Infrastructure.SeedWork;
using MediatR;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Examination.Infrastructure.Repositories
{
    public class ExamResultRepository : BaseRepository<ExamResult>, IExamResultRepository
    {
        public ExamResultRepository(IMongoClient mongoClient,
        IClientSessionHandle clientSessionHandle,
        IOptions<ExamSettings> settings,
        IMediator mediator, string collection)
        : base(mongoClient, clientSessionHandle, settings, mediator, collection)
        {
        }

        public async Task<ExamResult> GetDetails(string userId, string examId)
        {
            var filter = Builders<ExamResult>.Filter.Where( s => s.UserId == userId && s.Id == examId );
            return await Collection.Find(filter).FirstOrDefaultAsync();
        }
    }
}