using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace DAL1StSharp.Modelos
{
    [Table("___ClienteCuenta")]
    public class ClienteCuenta : DbContext
    {
        protected ClienteCuenta() : base("SchoolDb-DataAnnotations")
        {
        }

        public int IdClienteTitular { get; set; } //PK y FK Cliente
        public int IdCuenta { get; set; } //PK y FK Cuenta
        public int IdClienteAutorizado { get; set; } //FK Cliente
        [Column("FechaAlta", TypeName = "Date")]
        [MaxLength(15)]
        public DateTime FechaAlta { get; set; }
        [Column("FechaBaja", TypeName = "Date")]
        [MaxLength(15)]
        public DateTime FechaBaja { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Cuenta> Cuenta { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
