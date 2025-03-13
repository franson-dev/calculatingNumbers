using System; // Importa o namespace System para entrada, saída e outras funcionalidades padrão.
using calculatingNumbers; // Importa o namespace que contém a classe Calculadora.

public class Program // Define a classe principal do programa.
{
    static void Main() // Método principal, ponto de entrada do programa.
    {
        bool continuar = true; // Define uma variável de controle para o loop principal.

        while (continuar) // Loop principal que repete até o usuário decidir parar.
        {
            Console.WriteLine("=== Calculadora ==="); // Exibe o título da calculadora.

            // Solicita e armazena os dois valores numéricos e a operação desejada.
            double valor1 = ObterValor("\nDigite o primeiro valor: ");
            string operacao = ObterOperacao();
            double valor2 = ObterValor("\nDigite o segundo valor: ");

            // Executa a operação escolhida utilizando a classe Calculadora.
            double resultado = Calculadora.ExecutarOperacao(valor1, valor2, operacao);

            // Exibe o resultado da operação no console.
            Console.WriteLine($"\nResultado: {valor1} {operacao} {valor2} = {resultado}");

            // Pergunta ao usuário se ele deseja continuar utilizando a calculadora.
            continuar = DesejaContinuar();
            Console.Clear(); // Limpa o console antes da próxima execução.
        }

        Console.WriteLine("Obrigado por usar a calculadora!"); // Mensagem de encerramento.
    }

    // Método para obter um valor numérico do usuário.
    private static double ObterValor(string mensagem)
    {
        double valor; // Declara uma variável para armazenar o valor numérico.
        Console.Write(mensagem); // Exibe uma mensagem solicitando o valor.

        // Valida a entrada para garantir que seja um número válido.
        while (!double.TryParse(Console.ReadLine(), out valor))
        {
            Console.WriteLine("Valor inválido. Tente novamente."); // Exibe mensagem de erro.
            Console.Write(mensagem); // Solicita novamente o valor.
        }
        return valor; // Retorna o valor numérico válido.
    }

    // Método para obter o operador da operação matemática.
    private static string ObterOperacao()
    {
        // Exibe as opções de operações disponíveis.
        Console.WriteLine("\nEscolha a operação:");
        Console.WriteLine("+ Somar");
        Console.WriteLine("- Subtrair");
        Console.WriteLine("* Multiplicar");
        Console.WriteLine("/ Dividir\n");

        string operacao; // Declara a variável para armazenar a operação.

        // Loop para validar a operação escolhida pelo usuário.
        while (true)
        {
            operacao = Console.ReadLine().Trim(); // Lê e remove espaços extras da entrada.

            // Verifica se a entrada é uma operação válida.
            if (operacao == "+" || operacao == "-" || operacao == "*" || operacao == "/")
                break; // Sai do loop se a operação