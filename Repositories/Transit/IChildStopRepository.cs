using Mtd.Core.Repositories;
using Mtd.Stopwatch.Core.Entities.Transit;

namespace Mtd.Stopwatch.Core.Repositories.Transit
{
	public interface IChildStopRepository : IStopRepository<ChildStop>, IReadable<ChildStop>, IWriteable<ChildStop>,
		IIdentifiable<string, ChildStop>, IDisposable
	{
		Task<List<ChildStop>> GetAllWithParentAsync();
	}
}