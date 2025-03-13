using System; // Importa a biblioteca padrão para funcionalidades como manipulação de exceções.

namespace calculatingNumbers // Define um namespace para organizar e agrupar a classe Calculadora.
{
    internal class Calculadora // Declara a classe Calculadora, que contém os métodos de cálculo.
    {
        // Método público para executar uma operação matemática com base no operador fornecido.
        public static double ExecutarOperacao(double valor1, double valor2, string operacao)
        {
            // Usa uma expressão switch para decidir qual operação executar com base no operador.
            return operacao switch
            {
                "+" => Somar(valor1, valor2), // Chama o método Somar se o operador for "+".
                "-" => Subtrair(valor1, valor2), // Chama o método Subtrair se o operador for "-".
                "*" => Multiplicar(valor1, valor2), // Chama o método Multiplicar se o operador for "*".
                "/" => Dividir(valor1, valor2), // Chama o método Dividir se o operador for "/".
                _ => throw new InvalidOperationException("Operação inválida."), // Lança exceção para operadores inválidos.
            };
        }

        // Método privado para somar dois números e retornar o resultado.
        private static double Somar(double valor1, double valor2) => valor1 + valor2;

        // Método privado para subtrair o segundo número do primeiro e retornar o resultado.
        private static double Subtrair(double valor1, double valor2) => valor1 - valor2;

        // Método privado para multiplicar dois números e retornar o resultado.
        private static double Multiplicar(double valor1, double valor2) => valor1 * valor2;

        // Método privado para dividir o primeiro número pelo segundo e retornar o resultado.
        private static double Dividir(double valor1, double valor2)
        {
            // Verifica se o divisor é zero para evitar erro de divisão por zero.
            if (valor2 == 0)
                throw new DivideByZeroException("Erro: Divisão por zero não é permitida."); // Lança uma exceção.
            return valor1 / valor2; // Retorna o resultado da divisão.
        }
    }
}
