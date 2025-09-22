using Mtd.Core.Repositories;
using Mtd.Stopwatch.Core.Entities.Transit;

namespace Mtd.Stopwatch.Core.Repositories.Transit;

public interface IFleetRepository<T_Collection> : IAsyncReadable<Fleet, T_Collection>, IAsyncWriteable<Fleet, T_Collection>, IAsyncIdentifiable<string, Fleet>, IDisposable
	where T_Collection : IEnumerable<Fleet>
{
	Task<T_Collection> GetAllActiveAsync(CancellationToken cancellationToken);
}
