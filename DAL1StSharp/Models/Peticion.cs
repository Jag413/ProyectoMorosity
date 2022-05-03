using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL1StSharp.Modelos
{
    [Table("___Peticion")]
    public class Peticion : Base
    {
        [Key]
        public int IdPeticion { get; set; }
       
        [Column("Estado", TypeName = "nvarchar")]
        [MaxLength(20)]
        public string Estado { get; set; }

        public virtual Cliente Cliente { get; set; } //FK Cliente
    }
}
