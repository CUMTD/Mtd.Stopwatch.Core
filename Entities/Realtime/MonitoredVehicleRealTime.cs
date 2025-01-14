namespace Mtd.Stopwatch.Core.Entities.Realtime;

public class MonitoredVehicleRealTime
{
	public DateTime ScheduledArrival { get; set; }
	public DateTime ExpectedArrival { get; set; }
	public DateTime ScheduledDeparture { get; set; }
	public DateTime ExpectedDeparture { get; set; }
	public long OnTimePerformance => (long)Math.Round((ExpectedDeparture - ScheduledDeparture).TotalSeconds);
}
