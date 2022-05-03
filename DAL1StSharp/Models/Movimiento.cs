using System;

namespace DAL1StSharp.Modelos
{
    public class Movimiento
    {
        public int IdMovimiento { get; set; }
        public DateTime FechaValor { get; set; }
        public DateTime FechaOperacion { get; set; }
        public Double Importe { get; set; }
        public int IdCuentaOrigen { get; set; } //FK Cuenta
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
    }
}
