using System; // Importa a biblioteca padrão para entrada e saída (Console, por exemplo).
using calculatingNumbers; // Importa o namespace onde a classe Calculadora está definida.

public class Program // Declara a classe principal do programa.
{
    static void Main() // Método principal, o ponto de entrada do programa.
    {
        bool continuar = true; // Variável para controlar se o programa deve continuar em loop.

        // Loop principal que executa enquanto o usuário deseja continuar.
        while (continuar)
        {
            Console.WriteLine("=== Calculadora ==="); // Exibe o título no console.

            // Solicita o primeiro número do usuário.
            double valor1 = ObterValor("\nDigite o primeiro valor: ");

            // Solicita a operação matemática que o usuário deseja realizar.
            string operacao = ObterOperacao();

            // Solicita o segundo número do usuário.
            double valor2 = ObterValor("\nDigite o segundo valor: ");

            // Realiza a operação selecionada utilizando a classe Calculadora e armazena o resultado.
            double resultado = Calculadora.ExecutarOperacao(valor1, valor2, operacao);

            // Exibe o resultado da operação no console.
            Console.WriteLine($"\nResultado: {valor1} {operacao} {valor2} = {resultado}");

            // Pergunta ao usuário se deseja realizar outro cálculo.
            continuar = DesejaContinuar();

            // Limpa o console antes de repetir o loop.
            Console.Clear();
        }

        Console.WriteLine("Obrigado por usar a calculadora!"); // Mensagem final ao encerrar o programa.
    }

    // Método para solicitar e validar um valor numérico do usuário.
    private static double ObterValor(string mensagem)
    {
        double valor; // Declara a variável para armazenar o número digitado.
        Console.Write(mensagem); // Exibe a mensagem para o usuário.

        // Valida a entrada do usuário até que ele digite um número válido.
        while (!double.TryParse(Console.ReadLine(), out valor))
        {
            Console.WriteLine("Valor inválido. Tente novamente."); // Informa que a entrada é inválida.
            Console.Write(mensagem); // Solicita novamente o número.
        }
        return valor; // Retorna o número válido.
    }

    // Método para solicitar e validar a operação matemática escolhida pelo usuário.
    private static string ObterOperacao()
    {
        // Exibe as opções de operações disponíveis.
        Console.WriteLine("\nEscolha a operação:");
        Console.WriteLine("+ Somar");
        Console.WriteLine("- Subtrair");
        Console.WriteLine("* Multiplicar");
        Console.WriteLine("/ Dividir\n");

        string operacao; // Variável para armazenar o operador escolhido.

        // Loop para garantir que a operação escolhida seja válida.
        while (true)
        {
            operacao = Console.ReadLine().Trim(); // Lê o operador e remove espaços extras.

            // Verifica se o operador é um dos valores aceitos.
            if (operacao == "+" || operacao == "-" || operacao == "*" || operacao == "/")
                break; // Sai do loop se for um operador válido.

            Console.WriteLine("Operação inválida. Tente novamente."); // Mensagem de erro.
        }
        return operacao; // Retorna a operação válida.
    }

    // Método para perguntar ao usuário se ele deseja continuar.
    private static bool DesejaContinuar()
    {
        Console.WriteLine("\nDeseja realizar outro cálculo? (s/n): "); // Solicita ao usuário uma resposta.
        string resposta = Console.ReadLine().Trim().ToLower(); // Lê a resposta e converte para minúsculas.
        return resposta == "s"; // Retorna true se o usuário digitar "s", caso contrário retorna false.
    }
}
