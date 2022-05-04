using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL1StSharp
{
    public class DAL1stContext : DbContext
    {
        public DAL1stContext() : base("DalDB")
        {
            Database.SetInitializer<DAL1stContext>(new CreateDatabaseIfNotExists<DAL1stContext>());

            // Database.SetInitializer(new MigrateDatabaseToLatestVersion<DAL1stContext, DAL1stContext.Migrations.Configuration>());
        }

        //public DbSet<Student> Students { get; set; }
        public DbSet<DAL1StSharp.Modelos.Sucursal> Sucursales { get; set; }
        public DbSet<DAL1StSharp.Modelos.Peticion> Peticiones { get; set; }
        public DbSet<DAL1StSharp.Modelos.Cliente> Clientes { get; set; }
        public DbSet<DAL1StSharp.Modelos.Cuenta> Cuentas { get; set; }
        public DbSet<DAL1StSharp.Modelos.Movimiento> Movimientos { get; set; }
        public DbSet<DAL1StSharp.Modelos.ClienteCuenta> ClienteCuentas { get; set; }
        public DbSet<DAL1StSharp.Modelos.Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
