using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FakeEquifax.Controllers
{
    [ApiController]
    [Route("controller")]
    public class ConsultaEquifaxController : Controller
    {
        List<PersonaScoringBase> personas = new List<PersonaScoringBase>
        {
            new PersonaScoringBase { tipo = "DNI", documento = "83399573D" },
            new PersonaScoringBase { tipo = "NIE", documento = "Z0362389Y" },
            new PersonaScoringBase { tipo = "DNI", documento = "57389748X" },
            new PersonaScoringBase { tipo = "DNI", documento = "08986742K" },
            new PersonaScoringBase { tipo = "CIF", documento = "P9004199G" },
            new PersonaScoringBase { tipo = "DNI", documento = "53093310H" },
            new PersonaScoringBase { tipo = "CIF", documento = "N4906568C" },
        };
        // GET: ConsultaEquifaxController/Create
        [HttpGet]
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: ConsultaEquifaxController/Create
        [HttpPost]
        public ActionResult Create(PersonaScoringBase personaScoring)
        {
            try
            {
                var contexto = new DAL1StSharp.DAL1stContext();
                var resultado = contexto.ResultadoEquifaxs.Where(x => x.DocumentoId.ToUpper().Equals(personaScoring.documento.ToUpper())).FirstOrDefault();
                if (resultado == null)
                { 
                return NotFound();
                }
                else
                {
                    return Ok(resultado);
                }
            }
            catch
            {
                return View();
            }
        }
    }
}
