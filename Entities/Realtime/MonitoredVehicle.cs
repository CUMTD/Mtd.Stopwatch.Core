namespace Mtd.Stopwatch.Core.Entities.Realtime;

public class MonitoredVehicle : IRealtimeData
{
	public MonitoredVehicleRealTime? RealTime { get; set; }
	public required string BlockId { get; set; }
	public required string Direction { get; set; }
	public bool IsCanceled { get; set; }
	public bool IsInCongestion { get; set; }
	public bool IsInPanic { get; set; }
	public bool IsRealtime { get; set; }
	public bool IsInService => !string.IsNullOrEmpty(TripId);
	public decimal Latitude { get; set; }
	public decimal Longitude { get; set; }
	public string? MonitoringError { get; set; }
	public required MonitoredVehicleItinerary? DestinationStop { get; set; }
	public MonitoredVehicleItinerary? NextStop { get; set; }
	public MonitoredVehicleItinerary? OriginStop { get; set; }
	public MonitoredVehicleItinerary? PreviousStop { get; set; }
	public required string RouteId { get; set; }
	public string? PublicRouteId { get; set; }
	public required string RouteNumber { get; set; }
	public string? TripId { get; set; }
	public string? ShapeId { get; set; }
	public string? Headsign { get; set; }
	public DateTimeOffset Updated { get; set; }
	public required string VehicleNumber { get; set; }
	public string? DriverNumber { get; set; }
	public string? DriverName { get; set; }
	public required MonitoredVehicleOccupancy Occupancy { get; set; }
}
