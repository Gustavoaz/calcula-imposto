using CalculaJuros.Domain.Contract.Dto;
using CalculaJuros.Domain.Contract.Interface;
using CalculaJuros.Domain.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CalculaJuros.Domain.Test
{
    [TestClass]
    public class JurosCompostoServiceTest
    {
        private readonly IJurosCompostoService service;

        public JurosCompostoServiceTest()
        {
            service = new JurosCompostoService();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "ValorInicial")]
        public async Task CalculaJuros_ValorInicial_Zerado()
        {
            var request = new DtoJurosCompostoCalculaJurosRequest() { Meses = 1 };

            await service.CalculaJuros(request);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Meses")]
        public async Task CalculaJuros_Meses_Zerado()
        {
            var request = new DtoJurosCompostoCalculaJurosRequest() { ValorInicial = 100 };

            await service.CalculaJuros(request);
        }

        [TestMethod]
        public async Task CalculaJuros_Sucesso()
        {
            var request = new DtoJurosCompostoCalculaJurosRequest() { ValorInicial = 100, Meses = 5 };

            var result = await service.CalculaJuros(request);

            Assert.IsTrue(result == 105.10M);
        }
    }
}
