using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL1StSharp.Modelos
{
    public class Cuenta : Base
    {
        [Key]
        public int IdCuenta { get; set; }
        [Column("NumCuenta", TypeName = "nvarchar")]
        [MaxLength(24)]
        public string NumCuenta { get; set; }
        [Column("Saldo", TypeName = "decimal")]
        [MaxLength(30)]
        public double Saldo { get; set; }
       
    }
}
