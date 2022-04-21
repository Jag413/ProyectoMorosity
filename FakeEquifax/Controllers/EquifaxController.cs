using FakeEquifax.Modelos;
using Microsoft.AspNetCore.Mvc;
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
        public ScoringPersona GetStatusPersona(Persona personaParaHacerScoring)
        {
            var resultado = new ScoringPersona();

            resultado.Persona = personaParaHacerScoring;
            resultado.IsOk = true;
            resultado.ConErrores = true;

            /*
             * Tabla : ScoringPersonas
             * id int autonumerico clave pk
             * documentoID nvarchar()
             * nombre nvarchar
             * apellido nvarchar
             * valoracion (isok) bool
             * valoraciondescripcion
            */
            //ver si existe en db <- obtengo la persona o null
           
            //recuperar sus datos de escorring

            //valoracion de la persona

            //retornar el scoring de dicha persona o si no existe
            return resultado;
        }

        private Persona ExistePersona(Persona persona)
        {
            //consulto con db
            //si existe persona retorno persona
            //sino existe retorno null
            return null;
        }

    }
}
