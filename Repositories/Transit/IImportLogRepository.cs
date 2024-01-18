using Mtd.Core.Repositories;
using Mtd.Stopwatch.Core.Entities.Transit;

namespace Mtd.Stopwatch.Core.Repositories.Transit
{
	public interface IImportLogRepository : IReadable<ImportLog>, IWriteable<ImportLog>,
		IIdentifiable<string, ImportLog>, IDisposable
	{
		IEnumerable<ImportLog> GetLastNLogs(int n);

		Task<ImportLog> GetMostRecentSuccessAsync();
	}
}