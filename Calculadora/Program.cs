using Calculadora.Services;

Calc c = new Calc();
bool stop = true;
while (stop == true)
{
    int num1 = 0, num2 = 0;
    Console.Write("Selecione a operação que deseja realizar: \n");
    Console.Write("1 - Adição\n");
    Console.Write("2 - Subtração\n");
    Console.Write("3 - Multiplicação\n");
    Console.Write("4 - Divisão\n");
    Console.Write("5 - Histórico de operações\n");
    Console.Write("6 - Encerrar programa\n");

    string indice = Console.ReadLine();

    switch (indice)
    {
        case "1": 
            Console.Write("Primeiro número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(c.Addition(num1, num2)); break;

        case "2":
            Console.Write("Primeiro número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(c.Subtraction(num1, num2)); break;

        case "3":
            Console.Write("Primeiro número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(c.Multiplication(num1, num2)); break;

        case "4":
            Console.Write("Numerador: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Denominador: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(c.Division(num1, num2)); break;
        
        case "5":
            foreach(string operacao in c.ExibirHistoricoOperacoes())
            {
                Console.WriteLine(operacao);
            }
            break;

        case "6":
            Console.WriteLine("Programa encerrado.\n");
            stop = false;
            break;
        
        default: Console.Write("Não é uma opção válida\n"); break;
    }
}



