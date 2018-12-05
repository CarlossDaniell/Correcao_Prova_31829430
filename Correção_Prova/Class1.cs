using System;
{
namespace Correcao




    private double altura;

    public IMC()
    {
    this.peso = 0.0;
    this.altura = 0.0;
    }

    public IMC(double peso, double altura)
    {
    this.peso = peso;
    this.altura = altura;
    }

    public double Calcular(double peso, double altura)
    {
    return peso / (altura * altura);

    }
}
