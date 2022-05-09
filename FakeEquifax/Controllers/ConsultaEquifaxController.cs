using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FakeEquifax.Controllers
{
    [ApiController]
    [Route("controller")]
    public class ConsultaEquifaxController : Controller
    {
        
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
                
            }
            catch
            {
                return View();
            }
        }
    }
}
