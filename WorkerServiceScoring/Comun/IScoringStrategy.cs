using DAL1StSharp.Modelos;
using FakeEquifax.Modelos;

namespace WorkerServiceScoring.Comun;

public interface IScoringStrategy
{
    public Task<ResultadoEquifax?> ConsultarDatosEmpresaScoring(PersonaScoringBase persona);
    public bool RegistrarDatosRespuesta(ResultadoEquifax resultado, PersonaScoringBase persona);
}