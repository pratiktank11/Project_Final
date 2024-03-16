using System.ComponentModel.DataAnnotations;

public class NewCarsFormsModel
{
	[Required]
	public int CarId { get; set; }

	[Required, StringLength(400)]
	public string ImgURL { get; set; }

	[Required, StringLength(50)]
	public string CarName { get; set; }

	[Required]
	public int BrandID { get; set; }

	public string? BrandName { get; set; }

	[StringLength(400)]
	public string? Description { get; set; }

	[Required, Range(0, int.MaxValue)]
	public int Price { get; set; }

	[Required]
	public int EngineTypeID { get; set; }

	public string? EngineType { get; set; }

	[Required]
	public int FuelTypeID { get; set; }

	public string? FuelType { get; set; }

	[Range(1, 15)] // Assuming maximum seating capacity of 15
	public int? SeatingCapacity { get; set; }

	[Required, Range(0, int.MaxValue)]
	public int Mileage { get; set; }

	[Range(1, 5)] // Assuming 5-star rating system
	public int? Rating { get; set; }

	[Required]
	public int TransmissionID { get; set; }

	public string? TransmissionType { get; set; }
}