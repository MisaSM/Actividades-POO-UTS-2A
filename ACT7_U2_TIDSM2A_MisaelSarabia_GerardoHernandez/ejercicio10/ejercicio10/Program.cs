int[] num = new int[10];
int nomina = 0;
int i = 0;

while (i < num.Length)
{
    Console.WriteLine($"Introduzca el sueldo del empleado {i+1}");
    num[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}
foreach (int a in num)
{
    nomina += a;
}

Console.WriteLine($"La nomina es de: {nomina} pesos.");
Console.ReadKey();