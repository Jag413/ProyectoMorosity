using System.Collections.Generic;

namespace ClassLibraryModelos.ModelosEquifax
{
    public class EquifaxClases
    {

    }
    //TODO En cuanto definamos clases, separarlas en fichero - clase
    //TODO Comprobar los Id porque el get por si hay que formatear algún get para returnear como haya que hacerlo

    // TipoClase miClaseDeserializada = JsonSerializer.Deserialize<TipoClase>(miRespuestaJson);

    /* public class Address
 {
     [JsonPropertyName("postalCode")]
     public string PostalCode { get; set; }
 }*/


    /*public class Error
    {

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }
    }*/

    /*public class RISK
    {
        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }

        [JsonPropertyName("idCode")]
        public string IdCode { get; set; }

        [JsonPropertyName("returnCode")]
        public string ReturnCode { get; set; }
        [JsonPropertyName("present")]
        public string Present { get; set; }
        [JsonPropertyName("rating")]
        public string Rating { get; set; }
        [JsonPropertyName("score")]
        public string Score { get; set; }
        [JsonPropertyName("araAttributes")]
        public AraAttributes AraAttributes { get; set; }    
        [JsonPropertyName("errors")]
        public List<Error> Errors { get; set; }
    }*/


    /*public class DataSourceResponses
     {
         [JsonPropertyName("EIPG")]
         public EIPG EIPG { get; set; }

         [JsonPropertyName("errors")]
         public List<Error> Errors { get; set; }
     }*/


    /*public class WorstSituation
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }*/


    /*public class SummaryInformation
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
    }*/

    /*public class MonthlyCreditInformation
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
    }*/

    /*public class Product
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }*/

    /*public class Nature
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }*/

    /*public class CreditOperation
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
    }*/

    /*public class OperationProduct
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }*/

    /*public class Situation
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }*/

    /*public class SpecificCreditOperationsDetail
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
    }*/

    /*public class ASNEFDETAIL
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
    }*/

    /*public class EIPG
    {
        [JsonPropertyName("ASNEFDETAIL")]
        public ASNEFDETAIL ASNEFDETAIL { get; set; }
        [JsonPropertyName("RISK")]
        public RISK RISK { get; set; }
    }
    */
    /*public class PersonalInformation
    {

        private string _idType;
        private string _idCode;


        [JsonPropertyName("idCountryCode")]
        public string IdCountryCode { get; set; }

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
        public string IdAuxiliar { get; set; }
        [JsonPropertyName("correlationId")]
        public string CorrelationId { get; set; }
        [JsonPropertyName("dateOfBirth")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string DateOfBirth { get; set; }

        [JsonPropertyName("addresses")]
        public List<Address> Addresses { get; set; }
        [JsonPropertyName("idAuxiliar")]
    }*/

    /*public class PrimaryConsumer
    {
        
        [JsonPropertyName("personalInformation")]
        public PersonalInformation PersonalInformation { get; set; }

        [JsonPropertyName("dataSourceResponses")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DataSourceResponses DataSourceResponses { get; set; }
    }*/

    /*public class Applicants
    {
        [JsonPropertyName("primaryConsumer")]
        public PrimaryConsumer PrimaryConsumer { get; set; }
    }*/

    /*public class Root
    {
        [JsonPropertyName("interactionId")]
        public string InteractionId { get; set; }
        [JsonPropertyName("applicants")]
        public Applicants Applicants { get; set; }
        [JsonPropertyName("transactionState")]
        public string TransactionState { get; set; }
        [JsonPropertyName("transactionId")]
        public int TransactionId { get; set; }
        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }
        [JsonPropertyName("errors")]
        public List<Error> errors { get; set; }
    }*/

    /*public class AraAttributes
    {
        [JsonPropertyName("totalNumberOfOperations")]
        public int TotalNumberOfOperations { get; set; }
        [JsonPropertyName("numberOfConsumerCreditOperations")]
        public int NumberOfConsumerCreditOperations { get; set; }
        [JsonPropertyName("numberOfMortgageOperations")]
        public int NumberOfMortgageOperations { get; set; }
        [JsonPropertyName("numberOfPersonalLoanOperations")]
        public int NumberOfPersonalLoanOperations { get; set; }
        [JsonPropertyName("numberOfCreditCardOperations")]
        public int NumberOfCreditCardOperations { get; set; }
        [JsonPropertyName("numberOfTelcoOperations")]
        public int NumberOfTelcoOperations { get; set; }
        [JsonPropertyName("totalNumberOfOtherUnpaid")]
        public int TotalNumberOfOtherUnpaid { get; set; }
        [JsonPropertyName("totalUnpaidBalance")]
        public double TotalUnpaidBalance { get; set; }
        [JsonPropertyName("unpaidBalanceOwnEntity")]
        public int UnpaidBalanceOwnEntity { get; set; }
        [JsonPropertyName("unpaidBalanceOfOtherEntities")]
        public double UnpaidBalanceOfOtherEntities { get; set; }
        [JsonPropertyName("unpaidBalanceOfConsumerCredit")]
        public int UnpaidBalanceOfConsumerCredit { get; set; }
        [JsonPropertyName("unpaidBalanceOfMortgage")]
        public int UnpaidBalanceOfMortgage { get; set; }
        [JsonPropertyName("unpaidBalanceOfPersonalLoan")]
        public double UnpaidBalanceOfPersonalLoan { get; set; }
        [JsonPropertyName("unpaidBalanceOfCreditCard")]
        public int UnpaidBalanceOfCreditCard { get; set; }
        [JsonPropertyName("unpaidBalanceOfTelco")]
        public int UnpaidBalanceOfTelco { get; set; }
        [JsonPropertyName("unpaidBalanceOfOtherProducts")]
        public int UnpaidBalanceOfOtherProducts { get; set; }
        [JsonPropertyName("worstUnpaidBalance")]
        public double WorstUnpaidBalance { get; set; }
        [JsonPropertyName("worstSituationCode")]
        public string WorstSituationCode { get; set; }
        [JsonPropertyName("numberOfDaysOfWorstSituation")]
        public int NumberOfDaysOfWorstSituation { get; set; }
        [JsonPropertyName("numberOfCreditors")]
        public int NumberOfCreditors { get; set; }
        [JsonPropertyName("delincuencyDays")]
        public int DelincuencyDays { get; set; }
    }*/

}