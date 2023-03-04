float x, y;

Console.WriteLine("Insira o primeiro número: ");
x = float.Parse(Console.ReadLine());

Console.WriteLine("Insira o segundo número: ");
y = float.Parse(Console.ReadLine());

Console.WriteLine("A soma dos números é: " + (x+y));
Console.WriteLine("A diferença dos números é: " + (x - y));
Console.WriteLine("O produto dos números é: " + x * y);
if(y == 0)
    Console.WriteLine("Impossível dividir por 0");
else
    Console.WriteLine("O quociente dos números é: " + (x / y));