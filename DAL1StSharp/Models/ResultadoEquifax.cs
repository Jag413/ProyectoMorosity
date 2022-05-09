using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL1StSharp.Modelos
{
    [Table("___ResultadoEqifax")]
    public class ResultadoEquifax
    {
        [Key]
        public int IdResultado { get; set; }
        [Column("DocumentoId", TypeName = "nvarchar")]
        public string DocumentoId { get; set; }
        
        [Column("Informacion", TypeName = "nvarchar")]
        public string Informacion { get; set; }
    }
}
