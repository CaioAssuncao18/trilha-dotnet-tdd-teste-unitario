// Importando a biblioteca Xunit para suporte a testes unitários.
using Xunit;

// Importando a biblioteca DateTime para manipulação de datas e horas.
using System;

// Importando o namespace que contém a classe Calculadora que será testada.
using CalculadoraApp;

// Definindo a classe de testes para a classe Calculadora.
namespace CalculadoraAppTest
{
    public class CalculadoraTests
    {
        // Método auxiliar para instanciar a Calculadora antes de cada teste.
        public Calculadora InstanciarCalculadora()
        {
            return new Calculadora(DateTime.Now);
        }

        // Teste para verificar se o método Somar retorna a soma correta de dois números inteiros.
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 4, 8)]
        public void Somar_DoisNumerosInteiros_RetornarSoma(int num1, int num2, int resultadoEsperado)
        {
            // Arrange
            Calculadora calc = InstanciarCalculadora();

            // Act
            int resultado = calc.Somar(num1, num2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        // Teste para verificar se o método Subtrair retorna a subtração correta de dois números inteiros.
        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(5, 3, 2)]
        public void Subtrair_DoisNumerosInteiros_RetornarSubtracao(int num1, int num2, int resultadoEsperado)
        {
            // Arrange
            Calculadora calc = InstanciarCalculadora();

            // Act
            int resultado = calc.Subtrair(num1, num2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        // Teste para verificar se o método Multiplicar retorna a multiplicação correta de dois números inteiros.
        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 4, 16)]
        public void Multiplicar_DoisNumerosInteiros_RetornarMultiplicacao(int num1, int num2, int resultadoEsperado)
        {
            // Arrange
            Calculadora calc = InstanciarCalculadora();

            // Act
            int resultado = calc.Multiplicar(num1, num2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        // Teste para verificar se o método Dividir retorna a divisão correta de dois números inteiros.
        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(4, 4, 1)]
        public void Dividir_DoisNumerosInteiros_RetornarDivisao(int num1, int num2, int resultadoEsperado)
        {
            // Arrange
            Calculadora calc = InstanciarCalculadora();

            // Act
            int resultado = calc.Dividir(num1, num2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        // Teste para verificar se o método Dividir lança uma exceção DivideByZeroException ao dividir por zero.
        [Fact]
        public void Dividir_UmNumeroPorZero_RetornarException()
        {
            // Arrange
            Calculadora calc = InstanciarCalculadora();
            int num1 = 1;
            int num2 = 0;

            // Act e Assert
            Assert.Throws<DivideByZeroException>(() => calc.Dividir(num1, num2));
        }

        // Teste para verificar se o método RetornarHistoricoOperacoes retorna o histórico correto após realizar algumas operações.
        [Fact]
        public void Historico_RetornarHistoricoOperacoes_Retornar3Resultados()
        {
            // Arrange
            Calculadora calc = InstanciarCalculadora();
            calc.Somar(1, 2);
            calc.Subtrair(2, 1);
            calc.Multiplicar(1, 0);
            calc.Dividir(2, 1);

            // Act
            var resultado = calc.RetornarHistoricoOperacoes();

            // Assert
            Assert.NotEmpty(resultado);
            Assert.Equal(3, resultado.Count);
        }
    }
}

