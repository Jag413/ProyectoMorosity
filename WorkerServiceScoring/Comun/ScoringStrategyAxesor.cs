using DAL1StSharp.Modelos;
using FakeEquifax.Modelos;

namespace WorkerServiceScoring.Comun;

public class ScoringStrategyAxesor : IScoringStrategy
{
    public async Task<ResultadoEquifax?> ConsultarDatosEmpresaScoring(PersonaScoringBase persona)
    {
        throw new NotImplementedException();
    }
    public bool RegistrarDatosRespuesta(ResultadoEquifax resultado, PersonaScoringBase persona)
    {
        throw new NotImplementedException();
    }
}