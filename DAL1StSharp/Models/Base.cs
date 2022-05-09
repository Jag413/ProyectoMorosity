using System;

namespace DAL1StSharp.Modelos
{
    public class Base
    {
        public int? IdUsuarioInsercion { get; set; } = null; 
        public DateTime FechaInsercion { get; set; } = DateTime.Now;
        public DateTime FechaUltimaActualizacion { get; set; } = DateTime.Now;
    }
}
