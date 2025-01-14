using Mtd.Core.Entities;

namespace Mtd.Stopwatch.Core.Entities.Transit;

public class ShapePoint : Entity, IEquatable<ShapePoint>
{
	public required string ShapeId { get; set; }
	public required double Latitude { get; set; }
	public required double Longitude { get; set; }
	public required short Sequence { get; set; }
	public required decimal DistanceTraveled { get; set; }
	public string? StopId { get; set; }
	public required virtual Shape Shape { get; set; }

	protected ShapePoint()
	{
	}

	public ShapePoint(string shapeId, double latitude, double longitude, short sequence, decimal distanceTraveled)
	{
		ShapeId = shapeId;
		Sequence = sequence;
		DistanceTraveled = distanceTraveled;
		Latitude = latitude;
		Longitude = longitude;
	}

	public override bool Equals(object? obj)
	{
		if (obj is ShapePoint sp)
		{
			return Equals(sp);
		}

		return false;
	}

	public bool Equals(ShapePoint? other)
	{
		if (other is null)
		{
			return false;
		}

		return ShapeId == other.ShapeId && Sequence == other.Sequence;
	}

	public override int GetHashCode() => ShapeId.GetHashCode() ^ Sequence.GetHashCode();
}
