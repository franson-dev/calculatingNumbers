using System;

namespace Etec.Negocios // Define um namespace para organizar logicamente a classe Calculadora.
{
    public class Calculadora // Representa uma classe que realiza operações matemáticas básicas.
    {
        // Método que executa a operação matemática escolhida com base no operador fornecido.
        public static double ExecutarOperacao(double valor1, double valor2, string operacao)
        {
            // Seleciona e executa a operação correspondente utilizando uma expressão switch.
            return operacao switch
            {
                "+" => Somar(valor1, valor2), // Realiza a soma.
                "-" => Subtrair(valor1, valor2), // Realiza a subtração.
                "*" => Multiplicar(valor1, valor2), // Realiza a multiplicação.
                "/" => Dividir(valor1, valor2), // Realiza a divisão.
                _ => throw new InvalidOperationException("Operação inválida."), // Lança exceção para operações não suportadas.
            };
        }

        // Método para realizar a soma de dois números.
        public static double Somar(double valor1, double valor2) => valor1 + valor2;

        // Método para realizar a subtração do segundo número do primeiro.
        public static double Subtrair(double valor1, double valor2) => valor1 - valor2;

        // Método para realizar a multiplicação de dois números.
        public static double Multiplicar(double valor1, double valor2) => valor1 * valor2;

        // Método para realizar a divisão do primeiro número pelo segundo.
        public static double Dividir(double valor1, double valor2)
        {
            // Verifica se o divisor é zero e lança uma exceção caso seja.
            if (valor2 == 0)
                throw new DivideByZeroException("Erro: Divisão por zero não é permitida.");
            return valor1 / valor2; // Retorna o resultado da divisão.
        }
    }
}
