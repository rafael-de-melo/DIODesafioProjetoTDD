using Calculadora.Services;
using Microsoft.VisualBasic;
namespace CalculadoraTestes;

public class CalcTestes
{
    private Calc _calc;

    public CalcTestes()
    {
        _calc = new Calc();
    }


    [Fact]
    public void Add5To10Return15()
    {
        //Arrange
        int num1 = 5;
        int num2 = 10;

        //Act
        string result = _calc.Addition(num1, num2);

        //Assert
        Assert.Equal("5 + 10 = 15", result);

    }

    [Fact]
    public void Subtract10From25Return15()
    {
        //Arrange
        int num1 = 25;
        int num2 = 10;

        //Act
        string result = _calc.Subtraction(num1, num2);

        //Assert
        Assert.Equal("25 - 10 = 15", result);
    }

    [Fact]
    public void Divide5ByZeroReturnOperacaoInvalida()
    {
        //Arrange
        int num1 = 5;
        int num2 = 0;

        //Act
        string result = _calc.Division(num1, num2);

        //Assert
        Assert.Equal("Operação Inválida", result);
    }

    [Fact]
    public void Multiply10To5Return50()
    {
        //Arrange
        int num1 = 10;
        int num2 = 5;

        //Act
        string result = _calc.Multiplication(num1, num2);

        //Assert
        Assert.Equal("10 * 5 = 50", result);
    }



    
}