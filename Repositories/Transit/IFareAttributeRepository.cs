using Mtd.Core.Repositories;
using Mtd.Stopwatch.Core.Entities.Transit;

namespace Mtd.Stopwatch.Core.Repositories.Transit
{
	public interface IFareAttributeRepository : IReadable<FareAttribute>, IWriteable<FareAttribute>, IIdentifiable<string, FareAttribute>, IDisposable { }
}