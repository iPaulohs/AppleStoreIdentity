using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppleStoreIdentity.Models;

public class Category
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    [MaxLength(10, ErrorMessage = "O campo Nome da categoria não pode ultrapassar 10 caracteres.")]
    [Column(TypeName = "NVARCHAR")]
    public string? Name { get; set; }

    [Required]
    [MaxLength(144, ErrorMessage = "O campo Descrição da categoria não pode ultrapassar 144 caracteres.")]
    [Column(TypeName = "NVARCHAR")]
    public string? Description { get; set; }

    public ICollection<Device>? Devices { get; set; }
}
