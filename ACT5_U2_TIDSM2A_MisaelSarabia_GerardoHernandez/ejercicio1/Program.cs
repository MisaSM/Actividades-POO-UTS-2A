static void comparacion(int a, int b)
{
    if (a == b)
    {
        Console.WriteLine($"{a} es igual que {b}");
    } 
        else 
        {
            Console.WriteLine($"{a} y {b} no son iguales");
        }
}
Console.WriteLine("Introduzca el primer numero");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Introduzca el segundo numero");
int num2 = Convert.ToInt32(Console.ReadLine());
comparacion(num1, num2);
