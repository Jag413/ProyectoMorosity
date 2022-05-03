using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL1StSharp.Modelos
{
    public class Sucursal
    {
        [Key]
        public int IdSucursal { get; set; }
        [Column("Telefono", TypeName = "nvarchar")]
        [MaxLength(25)]
        public string Telefono { get; set; }
        [Column("Direccion", TypeName = "nvarchar")]
        [MaxLength(25)]
        public string Direccion { get; set; }
        [Column("CP", TypeName = "int")]
        public int CodPostal { get; set; }
        [Column("Ciudad", TypeName = "nvarchar")]
        [MaxLength(25)]
        public string Ciudad { get; set; }
    }
}
