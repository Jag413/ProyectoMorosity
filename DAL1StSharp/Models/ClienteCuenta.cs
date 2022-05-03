using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL1StSharp.Modelos
{
    public class ClienteCuenta
    {
        public int IdClienteTitular { get; set; } //PK y FK Cliente
        public int IdCuenta { get; set; } //PK y FK Cuenta
        public int IdClienteAutorizado { get; set; } //FK Cliente
        [Column("FechaAlta", TypeName = "Date")]
        [MaxLength(15)]
        public DateTime FechaAlta { get; set; }
        [Column("FechaBaja", TypeName = "Date")]
        [MaxLength(15)]
        public DateTime FechaBaja { get; set; }
    }
}
