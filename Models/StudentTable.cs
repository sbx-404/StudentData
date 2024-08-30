using System.ComponentModel.DataAnnotations;

namespace StudentTodo.Models;

public class StudentTable
{
    [Key]
    public int Id { get; set; }
    [Required]
    public required string Name { get; set; }
    public required string City { get; set; }
    public int Age { get; set; }
    public DateTime CreatedDateTime { get; set; } = DateTime.Now;
}
