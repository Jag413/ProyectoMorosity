using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FakeEquifax.Modelos
{
    //TODO En cuanto definamos clases, separarlas en fichero - clase
    
    // TipoClase miClaseDeserializada = JsonSerializer.Deserialize<TipoClase>(miRespuestaJson);
    public class Address
    {
        [JsonPropertyName("postalCode")]
        public string PostalCode { get; set; }
    }

    
    
    public class Error
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }
    }

    public class RISK
    {
        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }

        [JsonPropertyName("idCode")]
        public string IdCode { get; set; }

        [JsonPropertyName("returnCode")]
        public string ReturnCode { get; set; }

        [JsonPropertyName("errors")]
        public List<Error> Errors { get; set; }
    }

    
    public class DataSourceResponses
    {
        [JsonPropertyName("EIPG")]
        public EIPG EIPG { get; set; }
        
        [JsonPropertyName("errors")]
        public List<Error> Errors { get; set; }
    }


    public class WorstSituation
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }

    public class SummaryInformation
    {
        [JsonPropertyName("personName")]
        public string PersonName { get; set; }

        [JsonPropertyName("identificationNumber")]
        public string IdentificationNumber { get; set; }

        [JsonPropertyName("originalCreatedDate")]
        public string OriginalCreatedDate { get; set; }

        [JsonPropertyName("mostRecentUpdateDate")]
        public string MostRecentUpdateDate { get; set; }

        [JsonPropertyName("recentInquiryEntity")]
        public string RecentInquiryEntity { get; set; }

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

        [JsonPropertyName("maximumUnpaidPaymentAmount")]
        public double MaximumUnpaidPaymentAmount { get; set; }

        [JsonPropertyName("maximumUnpaidPaymentDate")]
        public string MaximumUnpaidPaymentDate { get; set; }

        [JsonPropertyName("worstSituation")]
        public WorstSituation WorstSituation { get; set; }

        [JsonPropertyName("worstSituationDate")]
        public string WorstSituationDate { get; set; }
    }

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

    public class Product
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }

    public class Nature
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }

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

    public class OperationProduct
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }

    public class Situation
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }

    public class SpecificCreditOperationsDetail
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

    public class ASNEFDETAIL
    {
        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }

        [JsonPropertyName("idCode")]
        public string IdCode { get; set; }

        [JsonPropertyName("returnCode")]
        public string ReturnCode { get; set; }

        [JsonPropertyName("summaryInformation")]
        public SummaryInformation SummaryInformation { get; set; }

        [JsonPropertyName("MonthlyCreditInformation")]
        public List<MonthlyCreditInformation> MonthlyCreditInformation { get; set; }

        [JsonPropertyName("creditOperations")]
        public List<CreditOperation> CreditOperations { get; set; }

        [JsonPropertyName("specificCreditOperationsDetails")]
        public List<SpecificCreditOperationsDetail> SpecificCreditOperationsDetails { get; set; }
    }

    public class EIPG
    {
        [JsonPropertyName("ASNEFDETAIL")] 
        public ASNEFDETAIL ASNEFDETAIL { get; set; }
        [JsonPropertyName("RISK")] 
        public RISK RISK { get; set; }
    }

    public class PersonalInformation
    {
        private string _idType;
        private string _idCode;

        [JsonPropertyName("idType")]
        public string IdType
        {
            get => _idType.ToUpper();
            set => _idType = value;
        }

        [JsonPropertyName("idCode")]
        public string IdCode
        {
            get => _idCode.ToUpper();
            set => _idCode = value;
        }

        [JsonPropertyName("dateOfBirth")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string DateOfBirth { get; set; }

        [JsonPropertyName("addresses")]
        public List<Address> Addresses { get; set; }
    }

    public class PrimaryConsumer
    {
        [JsonPropertyName("personalInformation")]
        public PersonalInformation PersonalInformation { get; set; }

        [JsonPropertyName("dataSourceResponses")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DataSourceResponses DataSourceResponses { get; set; }
    }

    public class Applicants
    {
        [JsonPropertyName("primaryConsumer")]
        public PrimaryConsumer PrimaryConsumer { get; set; }
    }
}