using Mtd.Core.Repositories;
using Mtd.Stopwatch.Core.Entities.Transit;

namespace Mtd.Stopwatch.Core.Repositories.Transit
{
	public interface IAgencyRepository : IReadable<Agency>, IWriteable<Agency>, IIdentifiable<string, Agency>, IDisposable { }
}