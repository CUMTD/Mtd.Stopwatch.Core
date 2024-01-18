using Mtd.Core.Repositories;
using Mtd.Stopwatch.Core.Entities.Schedule;

namespace Mtd.Stopwatch.Core.Repositories.Schedule
{
	public interface IDaytypeRepository : IReadable<Daytype>, IWriteable<Daytype>, IIdentifiable<string, Daytype>, IDisposable
	{
		Task<List<Daytype>> GetAllWithRoutesAsync();
	}
}
