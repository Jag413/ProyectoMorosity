using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace DAL1StSharp.Modelos
{
    [Table("___ClienteCuenta")]
   public class ClienteCuenta
    {
        
        public enum TipoCliente 
        { 
            Titular,
            Autorizado,
            None
        }
        [Key]
        public int IdClienteCuenta { get; set; }    
        [Column("TipoCliente", TypeName = "int")]
        public TipoCliente ClienteTipo { get; set; } //FK Cliente
        [Column("FechaAlta", TypeName = "Date")]
        
        public DateTime FechaAlta { get; set; }
        [Column("FechaBaja", TypeName = "Date")]
        
        public DateTime FechaBaja { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Cuenta> Cuenta { get; set; }

       
    }
}
