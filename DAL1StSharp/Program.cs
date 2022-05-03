using DAL1StSharp.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL1StSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var sucursal = new Sucursal() { Ciudad = "Zaragoza2", CodPostal = "50009", Direccion = "Plaza Roma2", Telefono = "+34600000002", FechaInsercion = DateTime.Now, FechaUltimaActualizacion = DateTime.Now };
            var contexto = new DAL1stContext();

            contexto.Sucursales.Add(sucursal);

            contexto.SaveChanges();
        }
    }
}
