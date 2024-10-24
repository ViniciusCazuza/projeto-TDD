using Xunit;
using Servicos.Calculadora;
using System.Reflection;
using System;

namespace ProjetoTDDTeste
{
    public class Testes
    {
        public Calculadora InstanciaCalculadora()
        {
            var data = "21/07/2018";

            Calculadora calc = new Calculadora(data);

            return calc;
        }

        [Theory]
        [InlineData (1, 2, 3)]
        [InlineData (5, 4, 9)]
        public void DeveMandarDoisNumerosERetornarASomaEmInteiro(int x, int y, int esperado)
        {
            // Arrange
            Calculadora calc = InstanciaCalculadora();

            //Act
            int resultadoOperacao = calc.Somar(x, y);

            //Assert
            Assert.Equal(esperado, resultadoOperacao);
        }
        
        [Theory]
        [InlineData (2, 1, 1)]
        [InlineData (4, 2, 2)]
        public void DeveMandarDoisNumerosERetornarASubtracaoEmInteiro(int x, int y, int esperado)
        {
            // Arrange
            Calculadora calc = InstanciaCalculadora();

            //Act
            int resultadoOperacao = calc.Subtrair(x, y);

            //Assert
            Assert.Equal(esperado, resultadoOperacao);
        }
        
        [Theory]
        [InlineData (2, 5, 10)]
        [InlineData (3, 2, 6)]
        public void DeveMandarDoisNumerosERetornarAMultiplicacaoEmInteiro(int x, int y, int esperado)
        {
            // Arrange
            Calculadora calc = InstanciaCalculadora();

            //Act
            int resultadoOperacao = calc.Multiplicar(x, y);

            //Assert
            Assert.Equal(esperado, resultadoOperacao);
        }
        
        [Theory]
        [InlineData (4, 2, 2)]
        [InlineData (20, 4, 5)]
        public void DeveMandarDoisNumerosERetornarADivisaoEmInteiro(int x, int y, int esperado)
        {
            // Arrange
            Calculadora calc = InstanciaCalculadora();

            //Act
            int resultadoOperacao = calc.Dividir(x, y);

            //Assert
            Assert.Equal(esperado, resultadoOperacao);
        }

        [Fact]
        public void DeveDividirPorZeroERetornarUmaExeccao()
        {
            //Arranger
            Calculadora calc = InstanciaCalculadora();
            
            //Assert
            Assert.Throws<DivideByZeroException>
            (
                () => calc.Dividir(3, 0)
            );
        }

        [Fact]
        public void DeveRetornarOHistoricoDasFuncoes()
        {
            //Arrange
            Calculadora calc = InstanciaCalculadora();

            //Act
            calc.Somar(3, 2);
            calc.Somar(5, 4);
            calc.Somar(10, 5);
            calc.Somar(1, 9);

            var lista = calc.Historico();

            //Assert
            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}
