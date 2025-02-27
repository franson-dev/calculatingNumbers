using System;

public class Calculos
{
    static void Main()
    {
        double resultado = 0;  // Variável para armazenar o resultado da operação
        bool continuar = true; // Flag para controlar se o usuário deseja fazer outro cálculo

        // Loop para permitir múltiplos cálculos até o usuário decidir parar
        while (continuar)
        {
            // Solicita ao usuário o primeiro valor
            Console.Write("Digite um valor: ");
            double valor1;
            // Verifica se o valor inserido é válido (um número)
            while (!double.TryParse(Console.ReadLine(), out valor1))
            {
                Console.WriteLine("Valor inválido. Por favor, insira um número válido.");
                Console.Write("Digite um valor: ");
            }

            Console.Clear(); // Limpa a tela para um visual mais limpo

            // Exibe as opções de operações para o usuário
            Console.WriteLine($"Como deseja calcular?");
            Console.WriteLine("Somar (+)");
            Console.WriteLine("Subtrair (-)");
            Console.WriteLine("Multiplicar (*)");
            Console.WriteLine($"Dividir (/)\n");

            // Lê a operação escolhida pelo usuário
            string calculo = Console.ReadLine().Trim();
            Console.Clear(); // Limpa a tela novamente

            // Solicita ao usuário o segundo valor
            Console.Write($"{valor1} {calculo} ");
            double valor2;
            // Verifica se o valor inserido é válido (um número)
            while (!double.TryParse(Console.ReadLine(), out valor2))
            {
                Console.WriteLine("Valor inválido. Por favor, insira um número válido.");
                Console.Write($"{valor1} {calculo} ");
            }

            Console.Clear(); // Limpa a tela novamente

            // Verifica a operação escolhida e realiza o cálculo correspondente
            switch (calculo)
            {
                case "+":
                    resultado = valor1 + valor2; // Realiza a soma
                    break;
                case "-":
                    resultado = valor1 - valor2; // Realiza a subtração
                    break;
                case "*":
                    resultado = valor1 * valor2; // Realiza a multiplicação
                    break;
                case "/":
                    if (valor2 == 0) // Verifica se o divisor é zero (não é permitido dividir por zero)
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    }
                    else
                    {
                        resultado = valor1 / valor2; // Realiza a divisão
                    }
                    break;
                default:
                    Console.WriteLine("Operação inválida."); // Caso o usuário insira uma operação inválida
                    break;
            }

            // Se a operação foi válida, exibe o resultado
            if (calculo == "+" || calculo == "-" || calculo == "*" || (calculo == "/" && valor2 != 0))
            {
                Console.WriteLine($"\nResultado: {valor1} {calculo} {valor2} = {resultado}");
            }

            // Pergunta ao usuário se deseja realizar outro cálculo
            Console.WriteLine("\nDeseja realizar outro cálculo? (s/n): ");
            string resposta = Console.ReadLine().Trim().ToLower();
            if (resposta != "s") // Se o usuário não responder "s", o loop é encerrado
            {
                continuar = false;
            }

            Console.Clear(); // Limpa a tela para o próximo ciclo
        }

        // Exibe uma mensagem final quando o programa é encerrado
        Console.WriteLine("Obrigado por usar o Optimus Prime!");
    }
}
