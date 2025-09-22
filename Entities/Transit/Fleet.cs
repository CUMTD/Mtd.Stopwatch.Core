using Mtd.Core.Entities;
using System.Diagnostics.CodeAnalysis;

namespace Mtd.Stopwatch.Core.Entities.Transit;

public class Fleet : Entity, IIdentity<string>, IImportable
{
	public required string Id { get; set; }
	public required FleetVehicleType VehicleType { get; set; }
	public required int Year { get; set; }
	public required string Make { get; set; }
	public required string Model { get; set; }

	public required DateOnly DateInService { get; set; }
	public int? LengthFeet { get; set; }
	public required FleetVehiclePowertrainType Powertrain { get; set; }
	public required bool IsActive { get; set; }
	public required bool IsPublic { get; set; }

	public virtual ICollection<CalendarDate> Vehicles { get; set; }
	public DateTime ImportTime { get; set; }

	protected Fleet()
	{
		Vehicles = [];

	}

	[SetsRequiredMembers]
	public Fleet(string id, FleetVehicleType vehicleType, int year, string make, string model, DateOnly dateInService, int? lengthFeet, FleetVehiclePowertrainType powertrain, bool isActive, bool isPublic, DateTime importTime) : this()
	{
		Id = id;
		VehicleType = vehicleType;
		Year = year;
		Make = make;
		Model = model;
		DateInService = dateInService;
		LengthFeet = lengthFeet;
		Powertrain = powertrain;
		IsActive = isActive;
		IsPublic = isPublic;
		ImportTime = importTime;
	}
}
