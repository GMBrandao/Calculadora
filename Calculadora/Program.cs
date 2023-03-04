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
    switchResult(option);
}

double Sum(double op1, double op2)
{
    double soma = op1 + op2;
    return(soma);
}

double Subtraction(double op1, double op2)
{
    double diff = op1 - op2;
    return (diff);
}

double Multiplication(double op1, double op2)
{
    double product = op1 * op2;
    return (product);
}

double Division(double op1, double op2)
{
    if (op2 != 0)
    {
        double quotient = op1 / op2;
        return (quotient);
    }
    else
        return (0);
}

void switchResult(int option)
{
    switch (option)
    {
        default:
            Console.WriteLine("Opção inválida");
            Console.ReadKey();
            break;

        case 1:
            Console.WriteLine("A soma dos números é: " + Sum(num1, num2));
            Console.ReadKey();
            break;
        case 2:
            Console.WriteLine("A diferença dos números é: " + Subtraction(num1, num2));
            Console.ReadKey();
            break;

        case 3:
            Console.WriteLine("A diferença dos números é: " + Multiplication(num1, num2));
            Console.ReadKey();
            break;
        case 4:
            if (Division(num1, num2) == 0)
                Console.WriteLine("Impossível dividir por 0");
            else
                Console.WriteLine("O quociente dos números é: " + Division(num1, num2));
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