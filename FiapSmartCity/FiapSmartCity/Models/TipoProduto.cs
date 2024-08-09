using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FiapSmartCity.Models
{
    [Table("TIPOPRODUTO")]
    public class TipoProduto
    {
        [Key]
        [Column("IDTIPO")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTipo { get; set; }

        [Required(ErrorMessage = "Descrição obrigatória!")]
        [StringLength(50, ErrorMessage = "A descrição deve ter no máximo 50 caracteres")]
        [Display(Name = "Descrição:")]
        [Column("DESCRICAOTIPO")]
        public String DescricaoTipo { get; set; }

        [Column("COMERCIALIZADO")]
        public bool Comercializado { get; set; }

    }
}