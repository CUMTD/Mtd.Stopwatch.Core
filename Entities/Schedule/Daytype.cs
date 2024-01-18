using Mtd.Core.Entities;

namespace Mtd.Stopwatch.Core.Entities.Schedule
{
	public class Daytype : GuidEntity, IComparable<Daytype>
	{
		public required string Daypart { get; set; }
		public required string Timepart { get; set; }
		public required int SortOrder { get; set; }

		public required string DaysOfWeekString { get; set; }

		public IEnumerable<DayOfWeek> DaysOfWeek => (DaysOfWeekString ?? string.Empty)
			.Split(',')
			.Select(dow => (DayOfWeek)int.Parse(dow));

		public string FriendlyName => $"{Daypart} - {Timepart}";
		public virtual ICollection<PublicRoute> Routes { get; set; }

		protected Daytype()
		{
			Routes = new List<PublicRoute>();
		}

		public Daytype(string daypart, string timepart, int sortOrder) : this()
		{
			Daypart = daypart;
			Timepart = timepart;
			SortOrder = sortOrder;
		}

		public int CompareTo(Daytype? other) => SortOrder.CompareTo(other?.SortOrder);
	}
}
