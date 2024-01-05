using System.ComponentModel.DataAnnotations;
using StudentsRepository.Client.Attributes;

namespace StudentsRepository.Client.Models.Students;

[ClientGenesis(HttpClientName = "HostApi")]
public class Student
{
    [Key]
    public int Id { get; set; }

    [MaxLength(length: 450), Required]
    public string FamilyName { get; set; } = default!;

    [MaxLength(length: 450), Required]
    public string GivenName { get; set; } = default!;
}
