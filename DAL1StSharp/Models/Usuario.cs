using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL1StSharp.Modelos
{
    [Table("___Usuario")]
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        [Column("NumUsuario", TypeName = "bigint")]
        
        public int NumUsuario { get; set; }
        [Column("Password", TypeName = "nvarchar")]
        public string Password { get; set; }
        public Sucursal Sucursal { get; set; } //FK Sucursal
    }
}
