using Mtd.Core.Repositories;
using Mtd.Stopwatch.Core.Entities.Schedule;

namespace Mtd.Stopwatch.Core.Repositories.Schedule
{
	public interface IRerouteRepository : IReadable<Reroute>, IWriteable<Reroute>, IIdentifiable<string, Reroute>, IDisposable
	{
		Task<IEnumerable<Reroute>> GetAllActiveAsync();
		Task<Reroute[]> GetAllActiveWithRoutesAsync(CancellationToken cancellationToken);
	}
}
