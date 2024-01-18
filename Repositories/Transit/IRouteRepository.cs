using Mtd.Core.Repositories;
using Mtd.Stopwatch.Core.Entities.Transit;

namespace Mtd.Stopwatch.Core.Repositories.Transit
{
	public interface IRouteRepository : IReadable<Route>, IWriteable<Route>, IIdentifiable<string, Route>, IDisposable
	{
		Task<List<Route>> GetAllWithDirectionAsync();
	}
}
