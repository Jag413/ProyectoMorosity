using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL1StSharp.Modelos
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        [Column("NumUsuario", TypeName = "bigint")]
        [MaxLength(5)]
        public int NumUsuario { get; set; }
        [Column("Password", TypeName = "nvarchar")]
        public string Password { get; set; }
        public int IdSucursal { get; set; } //FK Sucursal
    }
}
