using FakeEquifax.Modelos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeEquifax.Controllers
{
    [ApiController]
    [Route("[controller]/GetDatta")]
    public class EquifaxController : Controller
    {
        [HttpPost]
        public ScoringPersona GetStatusPersona (Persona PersonaParaHacerScoring)
        {
            var resultado = new ScoringPersona();
            resultado.Persona = PersonaParaHacerScoring;
            resultado.IsOk = true;
            resultado.Errores = false;
            //Ver si existe en la bd --> obtengo la persona o null 
            if(ExistePersona(PersonaParaHacerScoring) != null)
            {

            }
            //Recuperar sus datos de scoring
            //Valoración de la persona 
            //retornar el scoring de dicha persona o si no existe
            return resultado;
        }
    }

    private Persona ExistePersona(Persona persona)
    {
        //consulta db
        // si existe persona retorna persona
        // si no retorna null
        
        return;
    }
}
