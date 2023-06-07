int num1 = 0;
int num2 = 0;

Console.WriteLine("Console Calculator in C#\r");
Console.WriteLine("------------------------\n");

Console.WriteLine("Escribe un numero, luego presiona Enter");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Esrcribe otro numero, luego presiona Enter: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Escoje una opcion de las siguientes: ");
Console.WriteLine("\ta - Suma");
Console.WriteLine("\ts - Resta");
Console.WriteLine("\tm - Multiplicacion");
Console.WriteLine("\td - Division");
Console.WriteLine("Tu opcion? ");

switch(Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Tu resultado: {num1} + {num2} = " + (num1 + num2));
        break;
    case "b":
        Console.WriteLine($"Tu resultado: {num1} - {num2} = " + (num1 - num2));
        break;
    case "c":
        Console.WriteLine($"Tu resultado: {num1} * {num2} = " + (num1 * num2));
        break;
    case "d":
        Console.WriteLine($"Tu resultado: {num1}  /  {num2} = " + (num1 / num2));
    break;
}
Console.WriteLine("Presiona cualquier letra para salir de la Calculadora");
Console.ReadKey();