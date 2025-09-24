using Mtd.Core.Entities;
using System.Diagnostics.CodeAnalysis;

namespace Mtd.Stopwatch.Core.Entities.Transit;

public class FleetVehicle : Entity, IIdentity<string>, IImportable
{
	public required string Id { get; set; }
	public required string FleetId { get; set; }
	public required bool IsActive { get; set; }

	public virtual Fleet Fleet { get; set; } = default!;
	public virtual ICollection<FleetVehicleAttribute> Attributes { get; set; }

	public DateTime ImportTime { get; set; }

	protected FleetVehicle()
	{
		Attributes = [];
	}

	[SetsRequiredMembers]
	public FleetVehicle(string id, string fleetId, bool isActive, ICollection<FleetVehicleAttribute> attributes, DateTime importTime)
	{
		Id = id;
		IsActive = isActive;
		FleetId = fleetId;
		Attributes = attributes;
		ImportTime = importTime;
	}
}
