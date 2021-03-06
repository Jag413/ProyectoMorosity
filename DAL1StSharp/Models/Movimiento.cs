using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL1StSharp.Modelos
{
    [Table("___Movimiento")]
    public class Movimiento : Base
    {
        [Key]
        public int IdMovimiento { get; set; }
        [Column("FechaValor", TypeName = "Date")]
        
        public DateTime FechaValor { get; set; }
        [Column("FechaOperacion", TypeName = "Date")]
        
        public DateTime FechaOperacion { get; set; }
        [Column("Importe", TypeName = "Decimal")]
        
        public decimal Importe { get; set; }
        
        [Column("Titulo", TypeName = "nvarchar")]
        [MaxLength(30)]
        public string Titulo { get; set; }
        [Column("Descripcion", TypeName = "nvarchar")]
        [MaxLength(3000)]
        public string Descripcion { get; set; }
        [Column("CuentaOrigen")]
       public Cuenta Cuenta { get; set; } //FK Cuenta
    }
}
