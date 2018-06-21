using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Financeiro.Controllers;
using Financeiro.Models;

namespace UnitTest
{
    [TestClass]
    public class MensalidadeTest
    {
        [TestMethod]
        public void CalculaValor_DepoisDtVenc_Retorna1040()
        {
            //Arrange
            Mensalidade mensalidade = new Mensalidade();
            mensalidade.ValorMensalidade = 1000;
            mensalidade.DataVencimento = new DateTime(2018, 06, 17);
            mensalidade.JurosAoDia = 1;
            mensalidade.PercentualBolsa = 10;

            int resultado = 1040;

            //Act
            var atual = mensalidade.calculaValor(mensalidade.ValorMensalidade, mensalidade.DataVencimento, mensalidade.PercentualBolsa, mensalidade.JurosAoDia);

            //Assert
            Assert.AreEqual(resultado, atual);
        }

        [TestMethod]
        public void CalculaValor_AntesDtVenc_Retorna900()
        {
            //Arrange
            Mensalidade mensalidade = new Mensalidade();
            mensalidade.ValorMensalidade = 1000;
            mensalidade.DataVencimento = new DateTime(2018, 06, 23);
            mensalidade.JurosAoDia = 1;
            mensalidade.PercentualBolsa = 10;

            int resultado = 900;

            //Act
            var atual = mensalidade.calculaValor(mensalidade.ValorMensalidade, mensalidade.DataVencimento, mensalidade.PercentualBolsa, mensalidade.JurosAoDia);

            //Assert
            Assert.AreEqual(resultado, atual);
        }

        [TestMethod]
        public void CalculaValor_DtVenc_Retorna1000()
        {
            //Arrange
            Mensalidade mensalidade = new Mensalidade();
            mensalidade.ValorMensalidade = 1000;
            mensalidade.DataVencimento = new DateTime(2018, 06, 20);
            mensalidade.JurosAoDia = 1;
            mensalidade.PercentualBolsa = 0;

            int resultado = 1000;

            //Act
            var atual = mensalidade.calculaValor(mensalidade.ValorMensalidade, mensalidade.DataVencimento, mensalidade.PercentualBolsa, mensalidade.JurosAoDia);

            //Assert
            Assert.AreEqual(resultado, atual);
        }
    }
}
