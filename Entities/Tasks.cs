using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Tasks")]
public class Tasks
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int UserId { get; set; }

    [Required]
    public string Title { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public string Priority { get; set; }

    [Required]
    public DataType Deadline { get; set; }

    [Required]
    public bool IsCompleted { get; set; }
}