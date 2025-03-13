using System;

namespace calculatingNumbers // Define o namespace para organizar a classe Calculadora.
{
    internal class Calculadora // Declara a classe Calculadora, que contém métodos para operações matemáticas.
    {
        // Método principal para executar uma operação com base em um operador fornecido.
        public static double ExecutarOperacao(double valor1, double valor2, string operacao)
        {
            // Usa uma expressão switch para escolher qual operação executar.
            return operacao switch
            {
                "+" => Somar(valor1, valor2), // Chama o método Somar.
                "-" => Subtrair(valor1, valor2), // Chama o método Subtrair.
                "*" => Multiplicar(valor1, valor2), // Chama o método Multiplicar.
                "/" => Dividir(valor1, valor2), // Chama o método Dividir.
                _ => throw new InvalidOperationException("Operação inválida."), // Lança exceção se o operador for inválido.
            };
        }

        // Método para somar dois números.
        private static double Somar(double valor1, double valor2) => valor1 + valor2;

        // Método para subtrair o segundo número do primeiro.
        private static double Subtrair(double valor1, double valor2) => valor1 - valor2;

        // Método para multiplicar dois números.
        private static double Multiplicar(double valor1, double valor2) => valor1 * valor2;

        // Método para dividir o primeiro número pelo segundo, com verificação de erro.
        private static double Dividir(double valor1, double valor2)
        {
            if (valor2 == 0) // Verifica se o divisor é zero para evitar erro de divisão por zero.
                throw new DivideByZeroException("Erro: Divisão por zero não é permitida."); // Lança exceção.
            return valor1 / valor2; // Retorna o resultado da divisão