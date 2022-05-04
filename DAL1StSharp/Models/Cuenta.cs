using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL1StSharp.Modelos
{
    [Table("___Cuenta")]
    public class Cuenta : Base
    {
        [Key]
        public int IdCuenta { get; set; }
        [Column("NumCuenta", TypeName = "nvarchar")]
        [MaxLength(24)]
        public string NumCuenta { get; set; }
        [Column("Saldo", TypeName = "decimal")]
        public decimal Saldo { get; set; }
        public virtual ICollection<Cliente> Cliente { get; set; }
       public ICollection<Movimiento> Movimiento { get; set; }  



    }
}
