Console.WriteLine("Seleccione el tipo de envio");
Console.WriteLine("(N) Normal (E) Express");
string envio = Console.ReadLine();

Console.WriteLine("Introduzca el peso del objeto en gramos:");
double peso = Convert.ToDouble(Console.ReadLine());
double total = 0;

if (envio == "N");
{
    if (peso <= 500) 
    {
        total = 150;
    }
       else
        {
            total = 150 + ((peso - 500) * 0.35);
        }
} if (envio =="E")
{
    if (peso <= 500)
    total = 250;
}
    else
    {
        total = 250 + ((peso - 500) * 0.75);
    }
Console.WriteLine($"El total es de: {total} pesos.");