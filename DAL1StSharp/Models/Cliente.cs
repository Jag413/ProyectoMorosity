using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL1StSharp.Modelos
{
    [Table("___Cliente")]
    public class Cliente : Base
    {
        [Key]
        public int IdCliente { get; set; }
        [Column("DocumentoId", TypeName = "nvarchar")]
        [MaxLength(10)]
        public string DocumentoId { get; set; }
        [Column("RazonSocial", TypeName = "nvarchar")]
        [MaxLength(50)]
        public string RazonSocial { get; set; }
        [Column("Nombre", TypeName = "nvarchar")]
        [MaxLength(20)]
        public string Nombre { get; set; }
        [Column("Apellidos", TypeName = "nvarchar")]
        [MaxLength(25)]       
        public string Apellidos { get; set; }
        [Column("FechaNacimiento", TypeName = "Date")]
        public DateTime? FechaNacimiento { get; set; } 
        [Column("Nacionalidad", TypeName = "nvarchar")]
        [MaxLength(20)]
        public string Nacionalidad { get; set; }
        [Column("Telefono", TypeName = "nvarchar")]
        [MaxLength(15)]
        public string Telefono { get; set; }
        [Column("Movil", TypeName = "nvarchar")]
        [MaxLength(15)]
        public string Movil { get; set; }
        [Column("Email", TypeName = "nvarchar")]
        [MaxLength(50)]
        public string Email { get; set; }
        [Column("Direccion", TypeName = "nvarchar")]
        [MaxLength(250)]
        public string Direccion { get; set; }
        [Column("CP", TypeName = "nvarchar")]
        [MaxLength(5)]
        public string CodPostal { get; set; }
        [Column("Ciudad", TypeName = "nvarchar")]
        [MaxLength(25)]
        public string Ciudad { get; set; }
        [Column("Provincia", TypeName = "nvarchar")]
        [MaxLength(35)]
        public string Provincia { get; set; }
        //public int dSucursal { get; set; } //FK Sucursal
        public Sucursal Sucursal { get; set; } //FK Sucursal
        public ICollection<Peticion> Peticion { get; set; }
        //FK N:M ClienteCuenta
        public virtual ICollection<ClienteCuenta> ClienteCuenta { get; set; }

        
    }
}
