using Xunit;
using TesteUnitario;

namespace Teste;

public class UnitTest1
{
    [Theory]
    [InlineData(1, 1, 2)]
    public void Test1(int valor1, int valor2, int resultado)
    {
        Calculadora calc = new Calculadora();

        int result = calc.somar(valor1, valor2);

        Assert.Equal(resultado, result);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(2, 2, 4)]
    public void Test2(int valor1, int valor2, int resultado)
    {
        Calculadora calc = new Calculadora();

        int result = calc.multiplicar(valor1, valor2);

        Assert.Equal(resultado, result);
    }

    [Theory]
    [InlineData(1, 1, 0)]
    [InlineData(3, 2, 1)]
    public void Test3(int valor1, int valor2, int resultado)
    {
        Calculadora calc = new Calculadora();

        int result = calc.subtrair(valor1, valor2);

        Assert.Equal(resultado, result);
    }

    [Theory]
    [InlineData(1, 1, 1)]
    [InlineData(4, 2, 2)]
    public void Test4(int valor1, int valor2, int resultado)
    {
        Calculadora calc = new Calculadora();

        int result = calc.dividir(valor1, valor2);

        Assert.Equal(resultado, result);
    }

    [Fact]
    public void TestHistorico()
    {
        Calculadora calc = new Calculadora();

        calc.somar(1, 1);
        calc.somar(2, 2);
        calc.somar(3, 3);
        calc.somar(4, 4);
        calc.somar(5, 5);

        Assert.Empty(historico);
        Assert.Equal(5, historico.Count);
    }
}