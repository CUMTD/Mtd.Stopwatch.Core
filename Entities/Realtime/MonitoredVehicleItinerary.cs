namespace Mtd.Stopwatch.Core.Entities.Realtime
{
	public class MonitoredVehicleItinerary
	{
		public required string StopId { get; set; }
		public required string StopName { get; set; }

		public MonitoredVehicleItinerary()
		{
		}

		public MonitoredVehicleItinerary(string stopId, string stopName)
		{
			StopId = stopId;
			StopName = stopName;
		}
	}
}
