using Mtd.Core.Entities;
using System.Diagnostics.CodeAnalysis;

namespace Mtd.Stopwatch.Core.Entities.Transit;

public class FleetVehicle : Entity, IIdentity<string>, IImportable
{
	public required string Id { get; set; }
	public required string FleetId { get; set; }
	public required bool IsActive { get; set; }

	public virtual ICollection<FleetVehicleAttribute> Attributes { get; set; }

	public DateTime ImportTime { get; set; }

	[SetsRequiredMembers]
	public FleetVehicle(string id, string fleetId, ICollection<FleetVehicleAttribute> attributes, DateTime importTime)
	{
		Id = id;
		FleetId = fleetId;
		Attributes = attributes;
		ImportTime = importTime;
	}
}
