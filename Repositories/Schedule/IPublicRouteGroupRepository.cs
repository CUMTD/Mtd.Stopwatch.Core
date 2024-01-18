using Mtd.Core.Repositories;
using Mtd.Stopwatch.Core.Entities.Schedule;

namespace Mtd.Stopwatch.Core.Repositories.Schedule
{
	public interface IPublicRouteGroupRepository : IReadable<PublicRouteGroup>, IWriteable<PublicRouteGroup>, IIdentifiable<string, PublicRouteGroup>, IDisposable
	{
		Task<IEnumerable<PublicRouteGroup>> GetAllWithPublicRoutesAsync();

		Task<PublicRouteGroup> GetByIdentityWithPublicRoutes(string identity);
	}
}
