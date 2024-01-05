using System.ComponentModel.DataAnnotations;
using StudentsRepository.Attributes;

namespace StudentsRepository.Models.Students;

[ServerGenesis(UseAuthorization = true, UseOData = true)]
public class Student
{
    [Key]
    public int Id { get; set; }

    [Required, MaxLength(450)]
    public string GivenName { get; set; } = null!;

    [Required, MaxLength(450)]
    public string FamilyName { get; set; } = null!;
}
