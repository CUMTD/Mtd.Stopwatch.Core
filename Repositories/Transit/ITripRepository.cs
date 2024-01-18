using Mtd.Core.Repositories;
using Mtd.Stopwatch.Core.Entities.Transit;

namespace Mtd.Stopwatch.Core.Repositories.Transit
{
	public interface ITripRepository : IReadable<Trip>, IWriteable<Trip>, IIdentifiable<string, Trip>, IDisposable
	{
		Task<List<Trip>> GetAllWithRoutesAsync();
	}
}