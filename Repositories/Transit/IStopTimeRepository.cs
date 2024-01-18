using Mtd.Core.Repositories;
using Mtd.Stopwatch.Core.Entities.Transit;

namespace Mtd.Stopwatch.Core.Repositories.Transit
{
	public interface IStopTimeRepository : IReadable<StopTime>, IWriteable<StopTime>, IDisposable
	{
		StopTime GetByIdentity(string tripId, short stopSequence);

		StopTime GetByIdentityOrDefault(string tripId, short stopSequence);
	}
}
