Console.WriteLine("De que numero quiere ver las tablas?");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{n} X {i} = {n*i}");
}
