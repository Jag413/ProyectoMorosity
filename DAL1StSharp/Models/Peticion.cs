using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL1StSharp.Modelos
{
    [Table("Peticion")]
    public class Peticion : Base
    {
        [Key]
        public int IdPeticion { get; set; }
        [Column("IdCliente", TypeName ="nvarchar")]
        public int IdCliente { get; set; } //FK Cliente
        [Column("Estado", TypeName = "nvarchar")]
        [MaxLength(20)]
        public string Estado { get; set; }
    }
}
