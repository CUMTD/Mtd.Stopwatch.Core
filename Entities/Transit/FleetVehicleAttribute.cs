using Mtd.Core.Entities;
using System.Diagnostics.CodeAnalysis;

namespace Mtd.Stopwatch.Core.Entities.Transit;

public class FleetVehicleAttribute : Entity, IIdentity<string>, IImportable
{
	public required string FleetVehicleId { get; set; }
	public required string Id { get; set; }
	public required string Value { get; set; }

	public DateTime ImportTime { get; set; }

	[SetsRequiredMembers]
	public FleetVehicleAttribute(string fleetVehicleId, string id, string value, DateTime importTime)
	{
		FleetVehicleId = fleetVehicleId;
		Id = id;
		Value = value;
		ImportTime = importTime;
	}
}
