using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Projeto.Testes
{
    [TestClass]
    public class CoordenadaTeste
    {
        //[metodo]_[condicao]_[resultadoEsperado]

        [TestMethod]
        public void PosicaoCartesiana_QuandoObterOsComandosNormais_DeveRetornarCoordenada3X3Y()
        {

            //arrange
            Coordenada comandos = new Coordenada();
            comandos.Comandos = "NNNLLL";
            string resultadoEsperado = "(3, 3)";

            //Act
            string resultadoAtual = Coordenada.PosicaoCartesiana(comandos.Comandos);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }
        [TestMethod]
        public void PosicaoCartesiana_QuandoObterOsComandosNormais_DeveRetornarCoordenada3X3YPermutados()
        {

            //arrange
            Coordenada comandos = new Coordenada();
            comandos.Comandos = "NLNLNL";
            string resultadoEsperado = "(3, 3)";

            //Act
            string resultadoAtual = Coordenada.PosicaoCartesiana(comandos.Comandos);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }
        [TestMethod]
        public void PosicaoCartesiana_QuandoObterOsComandosComX_DeveRetornarCoordenada_1X_2Y()
        {

            //arrange
            Coordenada comandos = new Coordenada();
            comandos.Comandos = "NNNXLLLXX";
            string resultadoEsperado = "(1, 2)";

            //Act
            string resultadoAtual = Coordenada.PosicaoCartesiana(comandos.Comandos);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }
        [TestMethod]
        public void PosicaoCartesiana_QuandoObterOsComandosComXPasso_DeveRetornarCoordenadaInvalida()
        {

            //arrange
            Coordenada comandos = new Coordenada();
            comandos.Comandos = "NNX2";
            string resultadoEsperado = "(999, 999)";

            //Act
            string resultadoAtual = Coordenada.PosicaoCartesiana(comandos.Comandos);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }
        [TestMethod]
        public void PosicaoCartesiana_QuandoObterOsComandosComXCancelaCoordenada_DeveRetornarCoordenada_1X_123Y()
        {

            //arrange
            Coordenada comandos = new Coordenada();
            comandos.Comandos = "N123LSX";
            string resultadoEsperado = "(1, 123)";

            //Act
            string resultadoAtual = Coordenada.PosicaoCartesiana(comandos.Comandos);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }
        [TestMethod]
        public void PosicaoCartesiana_QuandoObterOsComandosComXCancelaPasso_DeveRetornarCoordenada_1X_1Y()
        {

            //arrange
            Coordenada comandos = new Coordenada();
            comandos.Comandos = "NLS3X";
            string resultadoEsperado = "(1, 1)";

            //Act
            string resultadoAtual = Coordenada.PosicaoCartesiana(comandos.Comandos);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }
        [TestMethod]
        public void PosicaoCartesiana_QuandoObterOsComandosDiferentesDeCoordenadasOuNumeros_DeveRetornarCoordenadaInvalida()
        {

            //arrange
            Coordenada comandos = new Coordenada();
            comandos.Comandos = "NLS3XA";
            string resultadoEsperado = "(999, 999)";

            //Act
            string resultadoAtual = Coordenada.PosicaoCartesiana(comandos.Comandos);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }



    }
}
