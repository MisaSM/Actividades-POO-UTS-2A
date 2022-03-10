int[] num = new int[10];
int numMay = 0;
int numMen = 0;
int i = 0;

while (i < num.Length) 
{
    Console.WriteLine("Introduzca un numero");
    num[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}
foreach (int a in num)
{
    if (Array.IndexOf(num, a) == 0) 
    {
        numMay = a;
        numMen = a;
    }
    if (a > numMay) numMay = a;
    if (a < numMen) numMen = a;
}
if (numMay == numMen)
{
    Console.WriteLine("Todos los numeros son iguales.");
}
else
{
    Console.WriteLine($"El numero más grande es {numMay} y el más pequeño es {numMen}");
}

Console.ReadKey();
