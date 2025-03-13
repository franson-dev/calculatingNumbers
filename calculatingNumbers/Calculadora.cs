using System;

namespace calculatingNumbers
{
    internal class Calculadora
    {
        public static double ExecutarOperacao(double valor1, double valor2, string operacao)
        {
            return operacao switch
            {
                "+" => Somar(valor1, valor2),
                "-" => Subtrair(valor1, valor2),
                "*" => Multiplicar(valor1, valor2),
                "/" => Dividir(valor1, valor2),
                _ => throw new InvalidOperationException("Operação inválida."),
            };
        }

        private static double Somar(double valor1, double valor2) => valor1 + valor2;

        private static double Subtrair(double valor1, double valor2) => valor1 - valor2;

        private static double Multiplicar(double valor1, double valor2) => valor1 * valor2;

        private static double Dividir(double valor1, double valor2)
        {
            if (valor2 == 0)
                throw new DivideByZeroException("Erro: Divisão por zero não é permitida.");
            return valor1 / valor2;
        }
    }
}
