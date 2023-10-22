using System;
using System.ComponentModel.DataAnnotations;

public class RequestCampModel
{
    public int RequestID { get; set; }

    public int UserId { get; set; }

    [Required]
    [StringLength(100)]
    public string CampName { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime CampDate { get; set; }

    [Required]
    [StringLength(200)]
    public string CampLocation { get; set; }

    [Required]
    [StringLength(255)]
    public string Purpose { get; set; }

    public string AdditionalDetails { get; set; }

    [Required]
    [StringLength(20)]
    public string Status { get; set; }
}
