public class Calculos{
    static void Main()
    {
        double resultado = 0;

        Console.Write("Digite um valor: ");
        double valor1 = Convert.ToDouble(Console.ReadLine());
        Console.Clear();

        Console.Write("\nComo deseja calacular? \nSomar (+) \nSubtrair (-) \nMultiplicar (*) \nDividir (/)\n\n");
        string calculo = Console.ReadLine();
        Console.Clear();

        Console.Write($"{valor1} {calculo} ");
        double valor2 = Convert.ToDouble(Console.ReadLine());
        Console.Clear();

        switch (calculo)
        {
            case "+":
                resultado = valor1 + valor2;
                break;
            case "-":
                resultado = valor1 - valor2;
                break;
            case "*":
                resultado = valor1 * valor2;
                break;
            case "/":
                resultado = valor1 / valor2;
                break;
            default:
                break;
        }
            Console.Clear();
            Console.WriteLine("ENGRAÇADINHO!");
    }
}