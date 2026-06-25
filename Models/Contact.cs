using System.ComponentModel.DataAnnotations;

namespace ContactBook.Models;

public class Contact
{
    public int Id { get; set; }
    [Required]
    [StringLength(50)]
    public string FirstName { get; set; } = string.Empty;
    [Required]
    [StringLength(50)]
    public string LastName { get; set; } = string.Empty;
    [Required]
    [StringLength(50)]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;
    [StringLength(20)]
    [Phone]
    public string PhoneNumber { get; set; } = string.Empty;
    [StringLength(75)]
    public string Company { get; set; }= string.Empty;
}