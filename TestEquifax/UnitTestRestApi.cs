using FakeEquifax.Modelos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text.Json;
using ClassLibraryModelos.ModelosEquifax;
using ClassLibraryModelos;
using RestSharp;
using System.Net;
using DAL1StSharp.Modelos;

namespace TestEquifax
{
    [TestClass]
    public class UnitTestRestApi
    {


        [TestMethod]
        public void TestCallApiHttpCllient()
        {


            Assert.IsTrue(true);

        }



        [TestMethod]
        public void TestCallApirestSharp()
        {
            var persona = new PersonaScoringBase() { documento = "73087018x", tipo ="DNI"};
            
            var client = new RestClient("https://localhost:44371/ConsultaEquifax");

            var request = new RestRequest().AddJsonBody(persona);
            
            var rest = client.PostAsync<ResultadoEquifax>(request);

            Console.WriteLine(rest.ToString());
            Assert.IsTrue(true);

        }


    }
}
