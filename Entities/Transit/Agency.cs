using Mtd.Core.Entities;

namespace Mtd.Stopwatch.Core.Entities.Transit
{
	public class Agency : Entity, IIdentity<string>, IImportable
	{
		public required string Id { get; set; }
		public required string Name { get; set; }
		public required string Url { get; set; }
		public required string Timezone { get; set; } = "America/Chicago";
		public required string Language { get; set; } = "en";
		public required string Phone { get; set; }
		public string? FareUrl { get; set; }
		public required string Email { get; set; }
		public required bool Active { get; set; }
		public required DateTime ImportTime { get; set; }
		public virtual ICollection<Route> Routes { get; set; }

		protected Agency()
		{
			Routes = new List<Route>();
		}

		public Agency(string id, string name, string phone, string email, string url, DateTime importTime, string? fareUrl = null, bool active = true) : this()
		{
			Id = id;
			Name = name;
			Url = url;
			Phone = phone;
			FareUrl = fareUrl;
			Email = email;
			ImportTime = importTime;
			Active = active;
		}
	}
}
