using Mtd.Core.Repositories;
using Mtd.Stopwatch.Core.Entities.Schedule;

namespace Mtd.Stopwatch.Core.Repositories.Schedule
{
	public interface IPublicRouteRepository : IReadable<PublicRoute>, IWriteable<PublicRoute>, IIdentifiable<string, PublicRoute>, IDisposable
	{
		Task<IEnumerable<PublicRoute>> GetAllWithStopTimesAsync();

		IEnumerable<PublicRoute> GetAllActive();

		Task<IEnumerable<PublicRoute>> GetAllActiveAsync();

		Task<PublicRoute> GetByIdentityWithRouteGroupAsync(string identity);
	}
}
