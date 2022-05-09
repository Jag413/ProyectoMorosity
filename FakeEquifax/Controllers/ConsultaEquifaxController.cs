using FakeEquifax.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FakeEquifax.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConsultaEquifaxController : Controller
    {
        
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
