using Mtd.Core.Entities;
using System.Diagnostics.CodeAnalysis;

namespace Mtd.Stopwatch.Core.Entities.Transit;

public class Vehicle : Entity, IIdentity<string>, IImportable
{
	public required string Id { get; set; }
	public required string VehicleConfigurationId { get; set; }
	public required bool IsActive { get; set; }
	public required string VIN { get; set; }
	public required string LicensePlateNumber { get; set; }
	public required DateOnly DateInService { get; set; }
	public virtual VehicleConfiguration VehicleConfiguration { get; set; } = default!;
	public virtual ICollection<VehicleAttribute> Attributes { get; set; }

	public DateTime ImportTime { get; set; }

	protected Vehicle()
	{
		Attributes = [];
	}

	[SetsRequiredMembers]
	public Vehicle(string id, string vehicleConfigurationId, bool isActive, string vin, string licensePlateNumber, DateOnly dateInService, DateTime importTime) : this()
	{
		Id = id;
		VehicleConfigurationId = vehicleConfigurationId;
		IsActive = isActive;
		VIN = vin;
		LicensePlateNumber = licensePlateNumber;
		DateInService = dateInService;
		ImportTime = importTime;
	}
}
