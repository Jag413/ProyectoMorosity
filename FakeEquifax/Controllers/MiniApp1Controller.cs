using FakeEquifax.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeEquifax.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MiniApp1Controller : Controller
    {
       [HttpGet]
        public Persona GetMiPersona(string nombre)
        {
            Persona yo = new Persona();
            yo.Nombre = nombre;
            yo.Apellido = "A";
            return yo;
        }
    }
}
