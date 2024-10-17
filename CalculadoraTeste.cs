using Calculadora;

namespace Calculadora.Teste
{
    public class CalculadoraTeste
    {
        [Fact]
        public void Somar()
        {
            Assert.Equal(20, Calculadora.Somar(10, 10));
        }

        [Fact]
        public void Subtrair()
        {
            Assert.Equal(0, Calculadora.Subtrair(10, 10));
        }

        [Fact]
        public void Multiplicar()
        {
            Assert.Equal(100, Calculadora.Multiplicar(10, 10));
        }

        [Fact]
        public void Dividir()
        {
            Assert.Equal(0, Calculadora.Dividir(0, 1));
        }

        [Fact]
        public void Porcentagem()
        {
            Assert.Equal(80, Calculadora.Porcentagem(20, 400));
        }
    }
}