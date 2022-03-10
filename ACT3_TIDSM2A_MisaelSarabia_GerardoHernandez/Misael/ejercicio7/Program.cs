Console.WriteLine("¿De cuantos dias quiere saber los segundos?");
int dias = Convert.ToInt32(Console.ReadLine());

if (dias > 1)
{
    Console.WriteLine($"Hay {dias * 86400} segundos en {dias} dias.");
}
else
{
    Console.WriteLine($"Hay {dias * 86400} segundos en {dias} dia.");
}

