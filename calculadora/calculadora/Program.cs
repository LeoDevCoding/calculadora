Console.WriteLine("Qual operação deseja fazer: ");
Console.WriteLine("1- Adição");
Console.WriteLine("2- Subtração");
Console.WriteLine("3- Multiplicação");
Console.WriteLine("4- Divisão");



int operacao = int.Parse(Console.ReadLine()!);

Console.WriteLine("Digite o primiero número: ");
int numero1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Digite o segundo número: ");
int numero2 = int.Parse(Console.ReadLine()!);

int resultado = 0;

switch (operacao)
{
    case 1:
        resultado = numero1 + numero2;
        break;
    case 2:
        resultado = numero1 - numero2;
        break;
    case 3:
        resultado = numero1 * numero2;
        break;
    case 4:
        resultado = numero1 / numero2;
        break;
}
Console.WriteLine($"O resultado da é: {resultado}");


    