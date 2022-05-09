using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClassLibraryModelos.ModelosEquifax
{
    public class MonthlyCreditInformation
    {
        [JsonPropertyName("identificationNumber")]
        public string IdentificationNumber { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("numberOfOperations")]
        public int NumberOfOperations { get; set; }

        [JsonPropertyName("totalAmountOfOperations")]
        public double TotalAmountOfOperations { get; set; }

        [JsonPropertyName("numberOfUnpaidOperations")]
        public int NumberOfUnpaidOperations { get; set; }

        [JsonPropertyName("numberOfUnpaidPayments")]
        public int NumberOfUnpaidPayments { get; set; }

        [JsonPropertyName("totalUnpaidPaymentAmount")]
        public double TotalUnpaidPaymentAmount { get; set; }

        [JsonPropertyName("worstSituation")]
        public WorstSituation WorstSituation { get; set; }
    }
}
