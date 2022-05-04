using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeEquifax.Modelos
{
    public class ScoringPersona
    {
        public Persona Persona { get; set; }
        public bool IsOk { get; set; }

        public string Errores { get; set; }
    }
}
