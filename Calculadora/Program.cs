double num1 = 0, num2 = 0;
int option = 0;

void Menu()
{
    Console.Clear();
    Console.WriteLine("===== Menu =====");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Sair\n================");
    option = int.Parse(Console.ReadLine());
    switchResult();
}

double Sum()
{
    double soma = num1 + num2;
    return(soma);
}

double Subtraction()
{
    double diff = num1 - num2;
    return (diff);
}

double Multiplication()
{
    double product = num1 * num2;
    return (product);
}

double Division()
{
    if (num2 != 0)
    {
        double quotient = num1 / num2;
        return (quotient);
    }
    else
        return (0);
}

void switchResult()
{
    switch (option)
    {
        default:
            Console.WriteLine("Opção inválida");
            Console.ReadKey();
            break;

        case 1:
            Console.WriteLine(num1 + " + " + num2 + " = " + Sum());
            Console.ReadKey();
            break;
        case 2:
            Console.WriteLine(num1 + " - " + num2 + " = " + Subtraction());
            Console.ReadKey();
            break;

        case 3:
            Console.WriteLine(num1 + " x " + num2 + " = " + Multiplication());
            Console.ReadKey();
            break;
        case 4:
            if (Division() == 0)
                Console.WriteLine("Impossível dividir por 0");
            else
                Console.WriteLine(num1 + " + " + num2 + " = " + Division());
            Console.ReadKey();
            break;
        case 5:
            Console.WriteLine("Programa encerrando\nAté logo!");
            Console.ReadKey();
            break;
    }
}

Console.WriteLine("Informe o primeiro número: ");
num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo número: ");
num2 = double.Parse(Console.ReadLine());

while (option != 5)
{
    Menu();
}