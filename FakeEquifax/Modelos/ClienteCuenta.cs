using System;

namespace FakeEquifax.Modelos
{
    public class ClienteCuenta
    {
        public int IdClienteTitular { get; set; } //PK y FK Cliente
        public int IdCuenta { get; set; } //PK y FK Cuenta
        public int IdClienteAutorizado { get; set; } //FK Cliente
        public DateTime FechaAlta { get; set; }
        public DateTime FechaBaja { get; set; }
    }
}
