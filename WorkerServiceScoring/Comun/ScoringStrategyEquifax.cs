using DAL1StSharp;
using DAL1StSharp.Modelos;
using FakeEquifax.Modelos;
using RestSharp;
using System.Data.Entity;
using System.Linq;

namespace WorkerServiceScoring.Comun;

public class ScoringStrategyEquifax : IScoringStrategy
{
    private DAL1stContext ctx;
    public ScoringStrategyEquifax()
    {
        ctx = new DAL1StSharp.DAL1stContext();
    }
    public async Task<ResultadoEquifax?> ConsultarDatosEmpresaScoring(PersonaScoringBase data)
    {

        

        var client = new RestClient("https://localhost:44371/ConsultaEquifax");

        var request = new RestRequest().AddJsonBody(data);

        var rest = await client.PostAsync<ResultadoEquifax>(request);

        return rest;

    }

    public bool RegistrarDatosRespuesta(ResultadoEquifax data, PersonaScoringBase persona)
    {
        System.Threading.Thread.Sleep(10000);
        var peticion = ctx.Peticiones.Where(x => x.IdPeticion == persona.idpeticion).FirstOrDefault();
        
        if (data.IdResultado == 0)
        {            
            if (peticion != null)
            {
                peticion.Estado = "Aceptado";
                peticion.IsOk = true;
                peticion.FechaUltimaActualizacion = DateTime.Now;

                ctx.SaveChanges();
            }
        }
        else
        {
            if (peticion != null)
            {
                peticion.Estado = "Denegado";
                peticion.IsOk = false;
                peticion.Razones = data.Informacion;
                peticion.FechaUltimaActualizacion = DateTime.Now;
                ctx.SaveChanges();
            }
        }
        return false;

    }
}