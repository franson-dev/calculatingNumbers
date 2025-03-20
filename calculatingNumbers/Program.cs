using System; // Importa a biblioteca padrão para recursos de entrada e saída, como Console.
using Etec.Negocios; // Importa o namespace onde a classe Calculadora está definida.

public class Program // Define a classe principal do programa.
{
    public static void Main(string[] args) // Método principal, ponto de entrada do programa.
    {
        bool continuar = true; // Variável de controle para repetição do programa.

        // Loop principal do programa que continua enquanto o usuário desejar.
        while (continuar)
        {
            Console.WriteLine("=== Calculadora ==="); // Exibe o título da aplicação.

            // Solicita o primeiro número ao usuário.
            double valor1 = ObterValor("\nDigite o primeiro valor: ");

            // Solicita o tipo de operação matemática.
            string operacao = ObterOperacao();

            // Solicita o segundo número ao usuário.
            double valor2 = ObterValor("\nDigite o segundo valor: ");

            // Calcula o resultado utilizando a classe Calculadora.
            double resultado = Calculadora.ExecutarOperacao(valor1, valor2, operacao);

            // Exibe o resultado final ao usuário.
            Console.WriteLine($"\nResultado: {valor1} {operacao} {valor2} = {resultado}");

            // Verifica se o usuário deseja realizar outro cálculo.
            continuar = DesejaContinuar();

            // Limpa a tela do console antes de reiniciar o loop.
            Console.Clear();
        }

        Console.WriteLine("Obrigado por usar a calculadora!"); // Mensagem final ao encerrar o programa.
    }

    // Método para solicitar e validar um número fornecido pelo usuário.
    public static double ObterValor(string mensagem)
    {
        double valor; // Variável para armazenar o número inserido.
        Console.Write(mensagem); // Exibe a mensagem ao usuário.

        // Valida a entrada até que seja fornecido um número válido.
        while (!double.TryParse(Console.ReadLine(), out valor))
        {
            Console.WriteLine("Valor inválido. Tente novamente."); // Informa erro na entrada.
            Console.Write(mensagem); // Repete a solicitação do valor.
        }
        return valor; // Retorna o número válido.
    }

    // Método para obter e validar a operação matemática escolhida.
    public static string ObterOperacao()
    {
        // Exibe as operações disponíveis ao usuário.
        Console.WriteLine("\nEscolha a operação:");
        Console.WriteLine("+ Somar");
        Console.WriteLine("- Subtrair");
        Console.WriteLine("* Multiplicar");
        Console.WriteLine("/ Dividir\n");

        string operacao; // Variável para armazenar a operação escolhida.

        // Loop para garantir que o usuário escolha uma operação válida.
        while (true)
        {
            operacao = Console.ReadLine().Trim(); // Lê e remove espaços extras da entrada.

            // Valida se a operação é uma das permitidas.
            if (operacao == "+" || operacao == "-" || operacao == "*" || operacao == "/")
                break; // Sai do loop em caso de operação válida.

            Console.WriteLine("Operação inválida. Tente novamente."); // Mensagem de erro.
        }
        return operacao; // Retorna a operação escolhida.
    }

    // Método para perguntar ao usuário se deseja realizar mais cálculos.
    public static bool DesejaContinuar()
    {
        Console.WriteLine("\nDeseja realizar outro cálculo? (s/n): "); // Solicita uma resposta ao usuário.
        string resposta = Console.ReadLine().Trim().ToLower(); // Lê e normaliza a resposta para minúsculas.
        return resposta == "s"; // Retorna true para "s" e false para qualquer outra entrada.
    }
}
