using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ELOSHOP.Models;

[Table("Avaliacao")]
public class Avaliacao
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o Nome")]
    [StringLength(60, ErrorMessage = "O NOme deve possuir até 60 caracteres")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O Título deve possuir até 60 caracteres")]
    [StringLength(300, ErrorMessage = "O Titulo deve possuir no máximo 60 caracteres")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "Escreva sua Avaliação")]
    [StringLength(300, ErrorMessage = "A Avaliação deve possuir no máximo 300 caracteres")]
    public string Texto { get; set; }

    [Display(Name = "Data da Avaliação")]
    public DateTime DataAvaliacao { get; set; } = DateTime.Now;

    [Display(Name = "Produto")]
    [Required(ErrorMessage = "Informe o Produto")]
    public int ProdutoId { get; set; }
    [ForeignKey("ProdutoID")]
    public Produto Produto { get; set; }

}   