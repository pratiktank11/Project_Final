using System.ComponentModel.DataAnnotations;

public class FeaturedCarsFormsModel
{
	public int? CarID {  get; set; }
	[Required]
	[StringLength(50)]
	public string? CarName { get; set; }

	[Required]
	[Url]
	public string? ImgURL { get; set; }

	// BrandID and BrandName validation can be conditional
	// based on your data setup:
	public int? BrandID { get; set; }

	public string? BrandName { get; set; }

	// Similar checks for other IDs and corresponding names

	[Range(1, int.MaxValue)]
	public int? TransmissionID { get; set; }

	[Required]
	public string? TransmissionType { get; set; }

	[Range(1, int.MaxValue)]
	public int? FuelTypeID { get; set; }

	[Required]
	public string? FuelType { get; set; }

	[Range(2000, int.MaxValue)]
	public int? ModelYearID { get; set; }

	public int? ModelYear { get; set; } // Already nullable

	[Range(1, int.MaxValue)]
	public int? EngineTypeID { get; set; }

	[Required]
	public string? EngineType { get; set; }

	[Range(1, int.MaxValue)]
	public int? SeatingCapacity { get; set; }

	[Range(0, int.MaxValue)]
	public int? Mileage { get; set; }

	[Range(0, double.MaxValue)]
	public double? Price { get; set; }

	[StringLength(500)]
	public string? Description { get; set; }
}
