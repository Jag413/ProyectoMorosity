using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ClassLibraryModelos.ModelosEquifax
{
    public class EquifaxResponse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EquifaxResponseId { get; set; }
        
        [JsonPropertyName("applicants")]
        public Applicants Applicants { get; set; }

        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }

        [JsonPropertyName("errors")]
        public List<Error> Errors { get; set; }
        //TODO Si el estado es COMPLETED y sino es ERROR, se hace algo más o se deja en inglés
        [JsonPropertyName("transactionState")]
        public string TransactionState { get; set; }

        [JsonPropertyName("interactionId")]
        public string InteractionId { get; set; }

        [JsonPropertyName("transactionId")]
        public int TransactionId { get; set; }
    }
    
    
}