using System;
using System.ComponentModel.DataAnnotations;

public class BloodStorage
{
    public int BloodID { get; set; }

    [Required]
    public int UserId { get; set; }

    [Required]
    [MaxLength(5)]
    public string BloodType { get; set; }

    [Required]
    [MaxLength(1)]
    public string RhFactor { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime CollectionDate { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime ExpirationDate { get; set; }

    [Required]
    [MaxLength(20)]
    public string StorageLocation { get; set; }

    [Required]
    public int QuantityInMl { get; set; }

    [Required]
    [MaxLength(15)]
    public string StorageStatus { get; set; }
}
