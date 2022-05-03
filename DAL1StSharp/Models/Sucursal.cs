using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL1StSharp.Modelos
{
    [Table("Sucursal")]
    public class Sucursal : Base
    {
        [Key]
        public int IdSucursal { get; set; }
        [Column("Telefono", TypeName = "nvarchar")]
        [MaxLength(15)]
        public string Telefono { get; set; }
        [Column("Direccion", TypeName = "nvarchar")]
        [MaxLength(250)]
        public string Direccion { get; set; }
        [Column("CP", TypeName = "nvarchar")]
        [MaxLength(5)]
        public string CodPostal { get; set; }
        [Column("Ciudad", TypeName = "nvarchar")]
        [MaxLength(25)]
        public string Ciudad { get; set; }
        
    }
}
