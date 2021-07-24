using System;
using System.Threading;
using System.Threading.Tasks;
using Examination.Domain.SeedWork;

namespace Examination.Infrastructure.SeedWork
{
    public class BaseRepository<T> : IRepositoryBase<T> where T : Entity, IAggregateRoot
    {
        public Task AbortTransactionAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task CommitTransactionAsync(T entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(T obj)
        {
            throw new NotImplementedException();
        }

        public void StartTransaction()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T obj)
        {
            throw new NotImplementedException();
        }
    }
}