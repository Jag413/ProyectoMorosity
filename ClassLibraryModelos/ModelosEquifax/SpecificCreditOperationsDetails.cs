using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClassLibraryModelos.ModelosEquifax
{
    public class SpecificCreditOperationsDetails
    {
        [JsonPropertyName("identificationNumber")]
        public string IdentificationNumber { get; set; }

        [JsonPropertyName("operationCode")]
        public string OperationCode { get; set; }

        [JsonPropertyName("originalCreatedDate")]
        public string OriginalCreatedDate { get; set; }

        [JsonPropertyName("entityCode")]
        public string EntityCode { get; set; }

        [JsonPropertyName("entityName")]
        public string EntityName { get; set; }

        [JsonPropertyName("operationProduct")]
        public OperationProduct OperationProduct { get; set; }

        [JsonPropertyName("nature")]
        public Nature Nature { get; set; }

        [JsonPropertyName("situation")]
        public Situation Situation { get; set; }

        [JsonPropertyName("totalAmountOfOperation")]
        public double TotalAmountOfOperation { get; set; }

        [JsonPropertyName("operationStartDate")]
        public string OperationStartDate { get; set; }

        [JsonPropertyName("operationEndDate")]
        public string OperationEndDate { get; set; }

        [JsonPropertyName("numberOfPayments")]
        public int NumberOfPayments { get; set; }

        [JsonPropertyName("totalAmountOfAllPayments")]
        public int TotalAmountOfAllPayments { get; set; }

        [JsonPropertyName("numberOfUnpaidPayments")]
        public int NumberOfUnpaidPayments { get; set; }

        [JsonPropertyName("totalUnpaidPaymentAmount")]
        public double TotalUnpaidPaymentAmount { get; set; }

        [JsonPropertyName("totalOutstandingBalance")]
        public int TotalOutstandingBalance { get; set; }

        [JsonPropertyName("firstUnpaidPaymentDueDate")]
        public string FirstUnpaidPaymentDueDate { get; set; }

        [JsonPropertyName("lastUnpaidPaymentDueDate")]
        public string LastUnpaidPaymentDueDate { get; set; }
    }
}
