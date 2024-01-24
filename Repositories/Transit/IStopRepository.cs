using Mtd.Core.Repositories;
using Mtd.Stopwatch.Core.Entities.Schedule;
using Mtd.Stopwatch.Core.Entities.Transit;

namespace Mtd.Stopwatch.Core.Repositories.Transit
{
	public interface IStopRepository<T, T_Collection> : IAsyncReadable<T, T_Collection>, IAsyncWriteable<T, T_Collection>, IAsyncIdentifiable<string, T>, IDisposable
		where T : Stop
		where T_Collection : IEnumerable<T>
	{
		Task<ILookup<PublicRouteGroup, PublicRoute>> GetRoutesServedByStopAsync(string stopId, CancellationToken cancellationToken);

		Task<T_Collection> GetAllWithStopTimesAsync(CancellationToken cancellationToken);
	}
}
