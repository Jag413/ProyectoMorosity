using FakeEquifax.Modelos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.Json;


namespace TestEquifax
{
    [TestClass]
    public class UnitTest1
    {
        string InfoMin = @"{
    ""applicants"": {
        ""primaryConsumer"": {
            ""personalInformation"": {
                ""idType"": ""SUSTITUIR POR TIPO DE IDENTIFICACIÓN: ID / PASS"",
                ""idCode"": ""SUSTITUIR POR IDENTIFICACIÓN"",
                ""addresses"": [
                    {
                    ""postalCode"": ""SUSTITUIR POR CÓDIGO POSTAL""
                    }
                ]
            }
        }
    }
}";
        string InfoExtra = @"{
  ""applicants"": {
    ""primaryConsumer"": {
      ""personalInformation"": {
        ""idType"": ""SUSTITUIR POR TIPO DE IDENTIFICACIÓN: ID / PASS"",
        ""idCode"": ""SUSTITUIR POR IDENTIFICACIÓN"",
        ""dateOfBirth"": ""SUSTITUIR POR FECHA DE NACIMIENTO"",
        ""addresses"": [
          {
            ""postalCode"": ""SUSTITUIR POR CÓDIGO POSTAL""
          }
        ]
      }
    }
  }
}";
        string InfoRespuesta = @"{
  ""interactionId"": ""ID-uicu1lc9a040-37773-1508329048373-1-149"",
  ""applicants"": {
    ""primaryConsumer"": {
      ""personalInformation"": {
        ""idType"": ""ID / PASS informado en la petición"",
        ""idCode"": ""Identificación informada en la petición"",
        ""dateOfBirth"": ""Fecha de nacimiento informada en la petición"",
        ""addresses"": [
          {
            ""postalCode"": ""Código postal informado en la petición""
          }
        ]
      },
      ""dataSourceResponses"": {
    ""EIPG"": {
        ""RISK"": {
            ""identifier"": ""primary"",
            ""idCode"": ""Identificación informada en la petición"",
            ""returnCode"": ""000"",
            ""present"": ""00"",
            ""rating"": ""1"",
            ""score"": ""7"",
            ""araAttributes"": {
                ""totalNumberOfOperations"": 5,
              ""numberOfConsumerCreditOperations"": 0,
              ""numberOfMortgageOperations"": 0,
              ""numberOfPersonalLoanOperations"": 5,
              ""numberOfCreditCardOperations"": 0,
              ""numberOfTelcoOperations"": 0,
              ""totalNumberOfOtherUnpaid"": 0,
              ""totalUnpaidBalance"": 3513.4,
              ""unpaidBalanceOwnEntity"": 0,
              ""unpaidBalanceOfOtherEntities"": 3513.4,
              ""unpaidBalanceOfConsumerCredit"": 0,
              ""unpaidBalanceOfMortgage"": 0,
              ""unpaidBalanceOfPersonalLoan"": 3513.4,
              ""unpaidBalanceOfCreditCard"": 0,
              ""unpaidBalanceOfTelco"": 0,
              ""unpaidBalanceOfOtherProducts"": 0,
              ""worstUnpaidBalance"": 865.88,
              ""worstSituationCode"": ""04"",
              ""numberOfDaysOfWorstSituation"": 44,
              ""numberOfCreditors"": 3,
              ""delincuencyDays"": 1536
            }
        }
    }
}
    }
  },
  ""transactionState"": ""COMPLETED"",
  ""transactionId"": 525,
  ""timestamp"": ""2017-11-14 15:42:40:645""
}";
        string ErrorTexto = @"{
  ""applicants"": {
    ""primaryConsumer"": {
      ""personalInformation"": {
        ""idCountryCode"": ""724"",
        ""idType"": ""ID/PASS informado en la petición"",
        ""idCode"": ""Identificación informada en la petición"",
        ""addresses"": [
          {
            ""postalCode"": ""99999""
          }
        ]
      },
      ""dataSourceResponses"": {
    ""EIPG"": {
        ""RISK"": {
            ""identifier"": ""primary"",
            ""idCode"": ""Identificación informada en la petición"",
            ""returnCode"": ""173"",
            ""errors"": [
              {
                ""code"": ""HOSTVALIDATION"",
                ""description"": ""RISK returnCode: 173""
              }
            ]
          }
    }
}
    }
  },
  ""timestamp"": ""2018-10-02 13:11:54:659"",
  ""errors"": [
    {
      ""code"": ""ICDAS004"",
      ""message"": ""Errors present in [EIPG] response"",
      ""category"": ""C""
    }
  ],
  ""transactionState"": ""ERROR"",
  ""interactionId"": ""ID-01722210217-45691-1536166074269-0-2804"",
  ""transactionId"": 41169
}";
        string PeticionJSon = @"{
""applicants"": {
    ""primaryConsumer"": {
        ""personalInformation"": {
            ""idType"": ""REPLACE WITH IDENTIFICATION TYPE: ID / PASS"",
            ""idCode"": ""REPLACE WITH IDENTIFICATION NUMBER""
            }
        }
    }
}";
        string Respuesta = @"{
    ""interactionId"": ""ID-uict2lc9a008-33137-1503398018475-1-765"",
    ""applicants"": {
        ""primaryConsumer"": {
            ""personalInformation"": {
                ""idType"": ""ID / PASS"",
                ""idCode"": ""ID NUMBER SENT IN THE REQUEST""
            },
            ""dataSourceResponses"": { }
        }
    },
    ""transactionState"": ""COMPLETED"",
    ""transactionId"": 17146,
    ""timestamp"": ""2017-08-29 21:22:04:629""
}";
        string RespuestaError = @"{
    ""interactionId"": ""ID - uicu1lc9a040 - 37773 - 1508329048373 - 1 - 69"",
    ""applicants"": {
        ""primaryConsumer"": {
            ""personalInformation"": {
                ""idType"": ""ID / PASS"",
                ""dCode"": ""THE ID SENT IN THE REQUEST""
            },
            ""dataSourceResponses"": {
                ""errors"": [{
                    ""code"": ""ERROR CODE"",
                    ""description"": ""ERROR DESCRIPTION""
                    }
                ]
            }
        }
    },
    ""transactionState"": ""ERROR"",
    ""errors"": [{
        ""code"": ""ERROR CODE"",
        ""message"": ""ERROR MESSAGE""
        }
    ],
    ""transactionId"": 483,
    ""timestamp"": ""2017-11-08 11:50:24:338""
}";
        string RespuestaAsnef = @"{
    ""applicants"": {
        ""primaryConsumer"": {
            ""personalInformation"": {
                ""idType"": ""TIPO DE IDENTIFICADOR: ID / PASS"",
                ""idCode"": ""NÚMERO DE IDENTIFICADOR""
            },
            ""dataSourceResponses"": {
                ""EIPG"": {
                    ""ASNEFDETAIL"": {
                        ""identifier"": ""primary"",
                        ""idCode"": ""????????Z"",
                        ""returnCode"": ""000"",
                        ""summaryInformation"": {
                            ""personName"": ""XXXXX XXXXXXX CESAR"",
                            ""identificationNumber"": ""????????Z"",
                            ""originalCreatedDate"": ""2013-08-19 00:00:00 +0000"",
                            ""mostRecentUpdateDate"": ""2014-02-23 00:00:00 +0000"",
                            ""recentInquiryEntity"": ""ACCESO DENEGADO"",
                            ""numberOfOperations"": 1,
                            ""totalAmountOfOperations"": 21287.42,
                            ""numberOfUnpaidOperations"": 1,
                            ""numberOfUnpaidPayments"": 7,
                            ""totalUnpaidPaymentAmount"": 4069.56,
                            ""maximumUnpaidPaymentAmount"": 4069.56,
                            ""maximumUnpaidPaymentDate"": ""2018-11-01 00:00:00 +0000"",
                            ""worstSituation"": {
                            ""code"": ""02"",
                            ""description"": ""Pre-judicial""
                            },
                            ""worstSituationDate"": ""2018-11-01 00:00:00 +0000""
                        },
                        ""MonthlyCreditInformation"": [
                            {
                                ""identificationNumber"": ""????????Z"",
                                ""date"": ""2018-12-01 00:00:00 +0000"",
                                ""numberOfOperations"": 1,
                                ""totalAmountOfOperations"": 21287.42,
                                ""numberOfUnpaidOperations"": 1,
                                ""numberOfUnpaidPayments"": 7,
                                ""totalUnpaidPaymentAmount"": 4069.56,
                                ""worstSituation"": {
                                    ""code"": ""02"",
                                    ""description"": ""Pre-judicial""
                                }
                            },
                            {
                                ""identificationNumber"": ""????????Z"",
                                ""date"": ""2018-11-01 00:00:00 +0000"",
                                ""numberOfOperations"": 1,
                                ""totalAmountOfOperations"": 21287.42,
                                ""numberOfUnpaidOperations"": 1,
                                ""numberOfUnpaidPayments"": 7,
                                ""totalUnpaidPaymentAmount"": 4069.56,
                                ""worstSituation"": {
                                    ""code"": ""02"",
                                    ""description"": ""Pre-judicial""
                                }
                            },
                            {
                                ""identificationNumber"": ""????????Z"",
                                ""date"": ""2018-10-01 00:00:00 +0000"",
                                ""numberOfOperations"": 1,
                                ""totalAmountOfOperations"": 21287.42,
                                ""numberOfUnpaidOperations"": 1,
                                ""numberOfUnpaidPayments"": 7,
                                ""totalUnpaidPaymentAmount"": 4069.56,
                                ""worstSituation"": {
                                    ""code"": ""02"",
                                    ""description"": ""Pre-judicial""
                                }
                            },
                            {
                                ""identificationNumber"": ""????????Z"",
                                ""date"": ""2018-09-01 00:00:00 +0000"",
                                ""numberOfOperations"": 1,
                                ""totalAmountOfOperations"": 21287.42,
                                ""numberOfUnpaidOperations"": 1,
                                ""numberOfUnpaidPayments"": 7,
                                ""totalUnpaidPaymentAmount"": 4069.56,
                                ""worstSituation"": {
                                    ""code"": ""02"",
                                    ""description"": ""Pre-judicial""
                                }
                            },
                            {
                                ""identificationNumber"": ""????????Z"",
                                ""date"": ""2018-08-01 00:00:00 +0000"",
                                ""numberOfOperations"": 1,
                                ""totalAmountOfOperations"": 21287.42,
                                ""numberOfUnpaidOperations"": 1,
                                ""numberOfUnpaidPayments"": 7,
                                ""totalUnpaidPaymentAmount"": 4069.56,
                                ""worstSituation"": {
                                    ""code"": ""02"",
                                    ""description"": ""Pre-judicial""
                                }
                            },
                            {
                                ""identificationNumber"": ""????????Z"",
                                ""date"": ""2018-07-01 00:00:00 +0000"",
                                ""numberOfOperations"": 1,
                                ""totalAmountOfOperations"": 21287.42,
                                ""numberOfUnpaidOperations"": 1,
                                ""numberOfUnpaidPayments"": 7,
                                ""totalUnpaidPaymentAmount"": 4069.56,
                                ""worstSituation"": {
                                    ""code"": ""02"",
                                    ""description"": ""Pre-judicial""
                                }
                            },
                            {
                                ""identificationNumber"": ""????????Z"",
                                ""date"": ""2018-06-01 00:00:00 +0000"",
                                ""numberOfOperations"": 1,
                                ""totalAmountOfOperations"": 21287.42,
                                ""numberOfUnpaidOperations"": 1,
                                ""numberOfUnpaidPayments"": 7,
                                ""totalUnpaidPaymentAmount"": 4069.56,
                                ""worstSituation"": {
                                    ""code"": ""02"",
                                    ""description"": ""Pre-judicial""
                                }
                            },
                            {
                                ""identificationNumber"": ""????????Z"",
                                ""date"": ""2018-05-01 00:00:00 +0000"",
                                ""numberOfOperations"": 1,
                                ""totalAmountOfOperations"": 21287.42,
                                ""numberOfUnpaidOperations"": 1,
                                ""numberOfUnpaidPayments"": 7,
                                ""totalUnpaidPaymentAmount"": 4069.56,
                                ""worstSituation"": {
                                    ""code"": ""02"",
                                    ""description"": ""Pre-judicial""
                                }
                            },
                            {
                                ""identificationNumber"": ""????????Z"",
                                ""date"": ""2018-04-01 00:00:00 +0000"",
                                ""numberOfOperations"": 1,
                                ""totalAmountOfOperations"": 21287.42,
                                ""numberOfUnpaidOperations"": 1,
                                ""numberOfUnpaidPayments"": 7,
                                ""totalUnpaidPaymentAmount"": 4069.56,
                                ""worstSituation"": {
                                    ""code"": ""02"",
                                    ""description"": ""Pre-judicial""
                                }
                            },
                            {
                                ""identificationNumber"": ""????????Z"",
                                ""date"": ""2018-03-01 00:00:00 +0000"",
                                ""numberOfOperations"": 1,
                                ""totalAmountOfOperations"": 21287.42,
                                ""numberOfUnpaidOperations"": 1,
                                ""numberOfUnpaidPayments"": 7,
                                ""totalUnpaidPaymentAmount"": 4069.56,
                                ""worstSituation"": {
                                    ""code"": ""02"",
                                    ""description"": ""Pre-judicial""
                                }
                            },
                            {
                                ""identificationNumber"": ""????????Z"",
                                ""date"": ""2018-02-01 00:00:00 +0000"",
                                ""numberOfOperations"": 1,
                                ""totalAmountOfOperations"": 21287.42,
                                ""numberOfUnpaidOperations"": 1,
                                ""numberOfUnpaidPayments"": 7,
                                ""totalUnpaidPaymentAmount"": 4069.56,
                                ""worstSituation"": {
                                    ""code"": ""02"",
                                    ""description"": ""Pre-judicial""
                                }
                            },
                            {
                                ""identificationNumber"": ""????????Z"",
                                ""date"": ""2018-01-01 00:00:00 +0000"",
                                ""numberOfOperations"": 1,
                                ""totalAmountOfOperations"": 21287.42,
                                ""numberOfUnpaidOperations"": 1,
                                ""numberOfUnpaidPayments"": 7,
                                ""totalUnpaidPaymentAmount"": 4069.56,
                                ""worstSituation"": {
                                    ""code"": ""02"",
                                    ""description"": ""Pre-judicial""
                                }
                            },
                            {
                                ""identificationNumber"": ""????????Z"",
                                ""date"": ""2017-12-01 00:00:00 +0000"",
                                ""numberOfOperations"": 1,
                                ""totalAmountOfOperations"": 21287.42,
                                ""numberOfUnpaidOperations"": 1,
                                ""numberOfUnpaidPayments"": 7,
                                ""totalUnpaidPaymentAmount"": 4069.56,
                                ""worstSituation"": {
                                    ""code"": ""02"",
                                    ""description"": ""Pre-judicial""
                                }
                            },
                            {
                                ""identificationNumber"": ""????????Z"",
                                ""date"": ""2017-11-01 00:00:00 +0000"",
                                ""numberOfOperations"": 1,
                                ""totalAmountOfOperations"": 21287.42,
                                ""numberOfUnpaidOperations"": 1,
                                ""numberOfUnpaidPayments"": 7,
                                ""totalUnpaidPaymentAmount"": 4069.56,
                                ""worstSituation"": {
                                    ""code"": ""02"",
                                    ""description"": ""Pre-judicial""
                                }
                            },
                            {
                                ""identificationNumber"": ""????????Z"",
                                ""date"": ""2017-10-01 00:00:00 +0000"",
                                ""numberOfOperations"": 1,
                                ""totalAmountOfOperations"": 21287.42,
                                ""numberOfUnpaidOperations"": 1,
                                ""numberOfUnpaidPayments"": 7,
                                ""totalUnpaidPaymentAmount"": 4069.56,
                                ""worstSituation"": {
                                    ""code"": ""02"",
                                    ""description"": ""Pre-judicial""
                                }
                            },
                            {
                                ""identificationNumber"": ""????????Z"",
                                ""date"": ""2017-09-01 00:00:00 +0000"",
                                ""numberOfOperations"": 1,
                                ""totalAmountOfOperations"": 21287.42,
                                ""numberOfUnpaidOperations"": 1,
                                ""numberOfUnpaidPayments"": 7,
                                ""totalUnpaidPaymentAmount"": 4069.56,
                                ""worstSituation"": {
                                    ""code"": ""02"",
                                    ""description"": ""Pre-judicial""
                                }
                            },
                            {
                                ""identificationNumber"": ""????????Z"",
                                ""date"": ""2017-08-01 00:00:00 +0000"",
                                ""numberOfOperations"": 1,
                                ""totalAmountOfOperations"": 21287.42,
                                ""numberOfUnpaidOperations"": 1,
                                ""numberOfUnpaidPayments"": 7,
                                ""totalUnpaidPaymentAmount"": 4069.56,
                                ""worstSituation"": {
                                    ""code"": ""02"",
                                    ""description"": ""Pre-judicial""
                                }
                            },
                            {
                                ""identificationNumber"": ""????????Z"",
                                ""date"": ""2017-07-01 00:00:00 +0000"",
                                ""numberOfOperations"": 1,
                                ""totalAmountOfOperations"": 21287.42,
                                ""numberOfUnpaidOperations"": 1,
                                ""numberOfUnpaidPayments"": 7,
                                ""totalUnpaidPaymentAmount"": 4069.56,
                                ""worstSituation"": {
                                    ""code"": ""02"",
                                    ""description"": ""Pre-judicial""
                                }
                            },
                            {
                                ""identificationNumber"": ""????????Z"",
                                ""date"": ""2017-06-01 00:00:00 +0000"",
                                ""numberOfOperations"": 1,
                                ""totalAmountOfOperations"": 21287.42,
                                ""numberOfUnpaidOperations"": 1,
                                ""numberOfUnpaidPayments"": 7,
                                ""totalUnpaidPaymentAmount"": 4069.56,
                                ""worstSituation"": {
                                    ""code"": ""02"",
                                    ""description"": ""Pre-judicial""
                                }
                            },
                            {
                                ""identificationNumber"": ""????????Z"",
                                ""date"": ""2017-05-01 00:00:00 +0000"",
                                ""numberOfOperations"": 1,
                                ""totalAmountOfOperations"": 21287.42,
                                ""numberOfUnpaidOperations"": 1,
                                ""numberOfUnpaidPayments"": 7,
                                ""totalUnpaidPaymentAmount"": 4069.56,
                                ""worstSituation"": {
                                    ""code"": ""02"",
                                    ""description"": ""Pre-judicial""
                                }
                            },
                            {
                                ""identificationNumber"": ""????????Z"",
                                ""date"": ""2017-04-01 00:00:00 +0000"",
                                ""numberOfOperations"": 1,
                                ""totalAmountOfOperations"": 21287.42,
                                ""numberOfUnpaidOperations"": 1,
                                ""numberOfUnpaidPayments"": 7,
                                ""totalUnpaidPaymentAmount"": 4069.56,
                                ""worstSituation"": {
                                    ""code"": ""02"",
                                    ""description"": ""Pre-judicial""
                                }
                            },
                            {
                                ""identificationNumber"": ""????????Z"",
                                ""date"": ""2017-03-01 00:00:00 +0000"",
                                ""numberOfOperations"": 1,
                                ""totalAmountOfOperations"": 21287.42,
                                ""numberOfUnpaidOperations"": 1,
                                ""numberOfUnpaidPayments"": 7,
                                ""totalUnpaidPaymentAmount"": 4069.56,
                                ""worstSituation"": {
                                    ""code"": ""02"",
                                    ""description"": ""Pre-judicial""
                                }
                            },
                            {
                                ""identificationNumber"": ""????????Z"",
                                ""date"": ""2017-02-01 00:00:00 +0000"",
                                ""numberOfOperations"": 1,
                                ""totalAmountOfOperations"": 21287.42,
                                ""numberOfUnpaidOperations"": 1,
                                ""numberOfUnpaidPayments"": 7,
                                ""totalUnpaidPaymentAmount"": 4069.56,
                                ""worstSituation"": {
                                    ""code"": ""02"",
                                    ""description"": ""Pre-judicial""
                                }
                            },
                            {
                                ""identificationNumber"": ""????????Z"",
                                ""date"": ""2017-01-01 00:00:00 +0000"",
                                ""numberOfOperations"": 1,
                                ""totalAmountOfOperations"": 21287.42,
                                ""numberOfUnpaidOperations"": 1,
                                ""numberOfUnpaidPayments"": 7,
                                ""totalUnpaidPaymentAmount"": 4069.56,
                                ""worstSituation"": {
                                    ""code"": ""02"",
                                    ""description"": ""Pre-judicial""
                                }
                            }
                        ],
                        ""creditOperations"": [
                            {
                                ""identificationNumber"": ""????????Z"",
                                ""operationCode"": ""41IJ1TV11G"",
                                ""originalCreatedDate"": ""2013-08-19 00:00:00 +0000"",
                                ""product"": {
                                    ""code"": ""07"",
                                    ""description"": ""Personal Loan""
                                },
                                ""nature"": {
                                    ""code"": ""01"",
                                    ""description"": ""Holder""
                                },
                                ""totalAmount"": 21287.42,
                                ""totalUnpaidPaymentAmount"": 4069.56,
                                ""entity"": ""E.F. DE MARCA""
                            }
                        ],
                        ""specificCreditOperationsDetails"": [
                            {
                                ""identificationNumber"": ""????????Z"",
                                ""operationCode"": ""41IJ1TV11G"",
                                ""originalCreatedDate"": ""2013-08-19 00:00:00 +0000"",
                                ""entityCode"": ""17"",
                                ""entityName"": ""E.F. DE MARCA"",
                                ""operationProduct"": {
                                    ""code"": ""07"",
                                    ""description"": ""Personal Loan""
                                },
                                ""nature"": {
                                    ""code"": ""01"",
                                    ""description"": ""Holder""
                                },
                                ""situation"": {
                                    ""code"": ""02"",
                                    ""description"": ""Pre-judicial""
                                },
                                ""totalAmountOfOperation"": 21287.42,
                                ""operationEndDate"": ""2015-05-11 00:00:00 +0000"",
                                ""numberOfPayments"": 0,
                                ""totalAmountOfAllPayments"": 0,
                                ""numberOfUnpaidPayments"": 7,
                                ""totalUnpaidPaymentAmount"": 4069.56,
                                ""totalOutstandingBalance"": 0,
                                ""firstUnpaidPaymentDueDate"": ""2013-08-12 00:00:00 +0000"",
                                ""lastUnpaidPaymentDueDate"": ""2014-02-11 00:00:00 +0000""
                            }
                        ]
                    }
                }
            }
        }
    },
    ""timestamp"": ""2018-12-04 09:52:31:822"",
    ""transactionState"": ""COMPLETED"",
    ""interactionId"": ""ID-01722210249-44509-1542220295976-0-3997"",
    ""transactionId"": 71796
}";
        string RespuestaAsnef2 = @"{
    ""applicants"": {
        ""primaryConsumer"": {
            ""personalInformation"": {
                ""idType"": ""TIPO DE IDENTIFICADOR: ID / PASS"",
                ""idCode"": ""NÚMERO DE IDENTIFICADOR""
            },
            ""dataSourceResponses"": {
                ""EIPG"": {
                    ""ASNEFDETAIL"": {
                        ""identifier"": ""primary"",
                        ""idCode"": ""1R"",
                        ""returnCode"": ""001"",
                        ""summaryInformation"": {
                            ""numberOfOperations"": 0,
                            ""totalAmountOfOperations"": 0,
                            ""numberOfUnpaidOperations"": 0,
                            ""numberOfUnpaidPayments"": 0,
                            ""totalUnpaidPaymentAmount"": 0,
                            ""maximumUnpaidPaymentAmount"": 0,
                            ""worstSituation"": { }
                        }
                    }
                }
            }
        }
    },
    ""timestamp"": ""2018-12-04 09:50:09:585"",
    ""transactionState"": ""COMPLETED"",
    ""interactionId"": ""ID-01722210249-44509-1542220295976-0-3996"",
    ""transactionId"": 71795
}";
        



        [TestMethod]
        public void TestMethod1()
        {
            //Console.WriteLine(InfoMin);

            var pic = new Persona()
            {
                //DocumentoID = "00000000T",
                Nombre = "Pedro",
                Apellido = "PicaPiedra"
            };
            string a = @"{
""nombre"": ""Pedro"",
""apellido"": ""PicaPiedra"",
""documento"": ""00000000T""
}";

            var options = new JsonSerializerOptions { WriteIndented = true };
            string picap = JsonSerializer.Serialize<Persona>(pic, options);
            Persona p = JsonSerializer.Deserialize<Persona>(a);
            
            Console.WriteLine(p);
    }
    }
}
