using System;
using calculatingNumbers;

public class Program
{
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("=== Calculadora ===");

            double valor1 = ObterValor("\nDigite o primeiro valor: ");
            string operacao = ObterOperacao();
            double valor2 = ObterValor("\nDigite o segundo valor: ");

            double resultado = Calculadora.ExecutarOperacao(valor1, valor2, operacao);

            Console.WriteLine($"\nResultado: {valor1} {operacao} {valor2} = {resultado}");

            continuar = DesejaContinuar();
            Console.Clear();
        }

        Console.WriteLine("Obrigado por usar a calculadora!");
    }

    private static double ObterValor(string mensagem)
    {
        double valor;
        Console.Write(mensagem);
        while (!double.TryParse(Console.ReadLine(), out valor))
        {
            Console.WriteLine("Valor inválido. Tente novamente.");
            Console.Write(mensagem);
        }
        return valor;
    }

    private static string ObterOperacao()
    {
        Console.WriteLine("\nEscolha a operação:");
        Console.WriteLine("+ Somar");
        Console.WriteLine("- Subtrair");
        Console.WriteLine("* Multiplicar");
        Console.WriteLine("/ Dividir\n");

        string operacao;
        while (true)
        {
            operacao = Console.ReadLine().Trim();
            if (operacao == "+" || operacao == "-" || operacao == "*" || operacao == "/")
                break;

            Console.WriteLine("Operação inválida. Tente novamente.");
        }
        return operacao;
    }

    private static bool DesejaContinuar()
    {
        Console.WriteLine("\nDeseja realizar outro cálculo? (s/n): ");
        string resposta = Console.ReadLine().Trim().ToLower();
        return resposta == "s";
    }
}
