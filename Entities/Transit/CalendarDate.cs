﻿using Mtd.Core.Entities;

namespace Mtd.Stopwatch.Core.Entities.Transit
{
	public class CalendarDate : Entity, IImportable
	{
		public required string ServiceId { get; set; }
		public required DateTime Date { get; set; }
		public required bool HasService { get; set; }
		public required DateTime ImportTime { get; set; }

		public virtual ICollection<Trip> Trips { get; set; }

		protected CalendarDate()
		{
			Trips = new List<Trip>();
		}

		public CalendarDate(string serviceId, DateTime date, bool hasService, DateTime importTime) : this()
		{
			ServiceId = serviceId;
			Date = date;
			HasService = hasService;
			ImportTime = importTime;
		}
	}
}
