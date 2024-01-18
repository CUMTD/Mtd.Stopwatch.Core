using Mtd.Core.Repositories;
using Mtd.Stopwatch.Core.Entities.Transit;

namespace Mtd.Stopwatch.Core.Repositories.Transit
{
	public interface IShapeRepository : IReadable<Shape>, IWriteable<Shape>, IIdentifiable<string, Shape>, IDisposable { }
}