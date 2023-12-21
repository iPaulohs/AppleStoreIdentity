using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppleStoreIdentity.Models;

public class Device
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required (AllowEmptyStrings = false, ErrorMessage = "Campo Nome do device obrigatório")]
    [Display(Name = "Device")]
    [Column(TypeName = "NVARCHAR")]
    [MaxLength(40)]
    public string? Name { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Campo Descrição do device obrigatório")]
    [Display(Name = "Descrição")]
    [Column(TypeName = "NVARCHAR")]
    [MaxLength(144)]
    public string? Description { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Campo Url da Imagem do device obrigatório")]
    [Display(Name = "Imagem")]
    [Column(TypeName = "NVARCHAR")]
    [MaxLength(80)]
    public string? UrlImg { get; set; }

    [Required]
    [Display(Name = "Categoria")]
    [Column(TypeName = "INT")]
    public int CategoryId { get; set; }

    [Required]
    [Column(TypeName = "DECIMAL")]
    public decimal Price { get; set; }
}
