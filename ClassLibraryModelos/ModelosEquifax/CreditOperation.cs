using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClassLibraryModelos.ModelosEquifax
{
    public class CreditOperation
    {
        [JsonPropertyName("identificationNumber")]
        public string IdentificationNumber { get; set; }

        [JsonPropertyName("operationCode")]
        public string OperationCode { get; set; }

        [JsonPropertyName("originalCreatedDate")]
        public string OriginalCreatedDate { get; set; }

        [JsonPropertyName("product")]
        public Product Product { get; set; }

        [JsonPropertyName("nature")]
        public Nature Nature { get; set; }

        [JsonPropertyName("totalAmount")]
        public double TotalAmount { get; set; }

        [JsonPropertyName("totalUnpaidPaymentAmount")]
        public double TotalUnpaidPaymentAmount { get; set; }

        [JsonPropertyName("entity")]
        public string Entity { get; set; }
    }

}
