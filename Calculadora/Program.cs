double num1, num2;
int option = 0;

void Menu()
{
    Console.Clear();
    Console.WriteLine("===== Menu =====");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Sair\n================\n");
    option = int.Parse(Console.ReadLine());

    switch (option)
    {
        default:
            Console.WriteLine("Opção inválida");
            Console.ReadKey();
            break;

        case 1:
            Console.WriteLine("A soma dos números é: " + (num1 + num2));
            Console.ReadKey();
            break;
        case 2:
            Console.WriteLine("A diferença dos números é: " + (num1 - num2));
            Console.ReadKey();
            break;

        case 3:
            Console.WriteLine("A diferença dos números é: " + (num1 * num2));
            Console.ReadKey();
            break;
        case 4:
            Console.WriteLine("A diferença dos números é: " + num1 / num2);
            Console.ReadKey();
            break;
        case 5:
            Console.WriteLine("Programa encerrando\nAté logo!");
            Console.ReadKey();
            break;
    }
}

Console.WriteLine("Infomre o primeiro número: ");
num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Infomre o segundo número: ");
num2 = double.Parse(Console.ReadLine());

while (option != 5)
{
    Menu();
}