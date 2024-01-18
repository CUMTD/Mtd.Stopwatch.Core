using Mtd.Core.Repositories;
using Mtd.Stopwatch.Core.Entities.Transit;

namespace Mtd.Stopwatch.Core.Repositories.Transit
{
	public interface IParentStopRepository : IStopRepository<ParentStop>, IReadable<ParentStop>, IWriteable<ParentStop>,
		IIdentifiable<string, ParentStop>, IDisposable
	{
		Task<ParentStop> GetByIdentityWithChildStopsAsync(string id);

		Task<ParentStop> GetByIdentityOrDefaultWithChildStopsAsync(string id);

		Task<List<ParentStop>> GetWithoutIStopsAsync();

		IEnumerable<ParentStop> GetAllWithChildStops();

		Task<List<ParentStop>> GetAllWithChildStopsAsync();
	}
}
