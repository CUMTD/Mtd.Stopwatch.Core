namespace Mtd.Stopwatch.Core.Entities.Transit
{
	public class ChildStop : Stop
	{
		public string ParentStopId { get; set; }

		public override string? City
		{
			get => string.IsNullOrEmpty(_city) ? ParentStop?.City : _city;
			set => base.City = value;
		}

		public required virtual ParentStop ParentStop { get; set; }

		public virtual ICollection<StopTime> StopTimes { get; set; }

		protected ChildStop()
		{
			ParentStopId = string.Empty;
			StopTimes = new List<StopTime>();
		}

		public ChildStop(string id, string name, string city, double latitude, double longitude, string parentStopId, DateTime importTime, string timezone = "America/Chicago", bool accessible = true, bool active = true)
			: base(id, name, latitude, longitude, city, importTime, timezone, accessible, active)
		{
			ParentStopId = parentStopId;
			StopTimes = new List<StopTime>();
		}

		public string GetBoardingPointName() => Name.Contains('(') ? Name[Name.LastIndexOf('(')..].Trim('(', ')') : Name;
	}
}
