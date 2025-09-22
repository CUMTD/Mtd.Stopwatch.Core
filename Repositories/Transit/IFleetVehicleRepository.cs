using Mtd.Core.Repositories;
using Mtd.Stopwatch.Core.Entities.Transit;

namespace Mtd.Stopwatch.Core.Repositories.Transit;

public interface IFleetVehicleRepository<T_Collection> : IAsyncReadable<FleetVehicle, T_Collection>, IAsyncWriteable<FleetVehicle, T_Collection>, IAsyncIdentifiable<string, FleetVehicle>, IDisposable
	where T_Collection : IEnumerable<FleetVehicle>
{
	Task<T_Collection> GetAllActiveAsync(CancellationToken cancellationToken);
}
