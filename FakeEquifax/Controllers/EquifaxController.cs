using FakeEquifax.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace FakeEquifax.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EquifaxController : Controller
    {
        [HttpPost]
        public ScoringPersona GetEstatusPersona(Persona personaParaHacerScoring)
        {
            var resultado = new ScoringPersona();

            resultado.Persona = personaParaHacerScoring;
            resultado.IsOk = true;
            resultado.ConErrores = false;
            
            /*
            Tabla: ScoringPersonas

            Id int autonumerico clave PK
            DocuementoId nvarchar()
            Nombre
            Apellido
            Valoracion (IsOk) bool
            ValoracionDescripcion 


             */
            //ver si existe en db <- obteno la persona o null

            //recuperar sus datos de escorring
            
            // valoración de la persona
            
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
