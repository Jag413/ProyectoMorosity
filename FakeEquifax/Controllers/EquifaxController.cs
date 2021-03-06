using FakeEquifax.Modelos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryRabbit;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using RabbitMQ.Client;

namespace FakeEquifax.Controllers
{
    [ApiController]
    [Route("[controller]/GetDatta")]
    public class EquifaxController : Controller
    {
        private ConnectionFactory _factoriaRabbitConexion;
        private readonly IConnection _conexionRabbit;
        private readonly IModel _channel;
        private readonly string QeueName = "exchange.scoring.dev";



        private IRabbitManager _manager;  
  
        public EquifaxController(IRabbitManager manager)
        {
            _manager = manager;
        }


       
        /*[HttpPost]
        public ScoringPersona GetStatusPersona(Persona PersonaParaHacerScoring)
        {
            var resultado = new ScoringPersona();
            resultado.Persona = PersonaParaHacerScoring;
            resultado.IsOk = true;
            resultado.Errores = false;
            //Ver si existe en la bd --> obtengo la persona o null 
            if (ExistePersona(PersonaParaHacerScoring) != null)
            {

            }
            //Recuperar sus datos de scoring
            //Valoración de la persona 
            //retornar el scoring de dicha persona o si no existe
            return resultado;
        }
        private Persona ExistePersona(Persona persona)
        {
            //consulta db
            // si existe persona retorna persona
            // si no retorna null

            return null;
        }
        */
        
        [HttpPost]
        public ActionResult EnviaClienteScoring(PersonaScoringBase cliente)
        {
            //_channel.ConfirmSelect();
            
            try
            {
                // publicar mensaje  
                _manager.Publicar(cliente, QeueName, "direct", String.Empty);
            }
            
            catch(Exception ex)
            {
                
            }

            return Ok(cliente);
        }

        /*public void RespuestaClienteScoring(PersonaScoringBase cliente)
        {
            try
            {
                _manager.Consumir(cliente, "exchange.scoring.dev");
            }     
            catch (Exception ex)
            {

            }

            return Ok();
        }*/

    }


 
}
