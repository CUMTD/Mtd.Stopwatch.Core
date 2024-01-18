using Mtd.Stopwatch.Core.Entities.Schedule;
using Mtd.Stopwatch.Core.Entities.Transit;

namespace Mtd.Stopwatch.Core.Repositories.Transit
{
	public interface IStopRepository<T> where T : Stop
	{
		Task<ILookup<PublicRouteGroup, PublicRoute>> GetRoutesServedByStop(string stopId);

		Task<List<T>> GetAllWithStopTimesAsync();
	}
}
