using Mtd.Core.Repositories;
using Mtd.Stopwatch.Core.Entities.Transit;

namespace Mtd.Stopwatch.Core.Repositories.Transit
{
	public interface IShapeRepository<T_Collection> : IAsyncReadable<Shape, T_Collection>, IAsyncWriteable<Shape, T_Collection>, IAsyncIdentifiable<string, Shape>, IDisposable
		where T_Collection : IEnumerable<Shape>
	{

	}
}
