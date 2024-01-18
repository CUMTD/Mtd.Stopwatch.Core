using Mtd.Core.Repositories;
using Mtd.Stopwatch.Core.Entities.Transit;

namespace Mtd.Stopwatch.Core.Repositories.Transit
{
	public interface ICalendarDateRepository : IReadable<CalendarDate>, IWriteable<CalendarDate>, IDisposable
	{
		CalendarDate GetByIdentity(string serviceId, DateTime date);

		CalendarDate GetByIdentityOrDefault(string serviceId, DateTime date);
	}
}