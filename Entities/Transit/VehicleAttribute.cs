using Mtd.Core.Entities;
using System.Diagnostics.CodeAnalysis;

namespace Mtd.Stopwatch.Core.Entities.Transit;

public class VehicleAttribute : Entity, IIdentity<string>, IImportable
{
	public required string VehicleId { get; set; }
	public required string Id { get; set; }
	public required string Value { get; set; }

	public virtual Vehicle Vehicle { get; set; } = default!;
	public DateTime ImportTime { get; set; }

	[SetsRequiredMembers]
	public VehicleAttribute(string vehicleId, string id, string value, DateTime importTime)
	{
		VehicleId = vehicleId;
		Id = id;
		Value = value;
		ImportTime = importTime;
	}
}
