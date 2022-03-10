Console.Clear();
Console.WriteLine("¿Que va a comprar?");
var objetoComprado = Console.ReadLine();
Console.WriteLine($"¿Cuanto cuesta {objetoComprado} ?");
double precioObjeto = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("¿Cuanto va a pagar?");
double pago = Convert.ToDouble(Console.ReadLine());

Console.Clear();
if (pago < precioObjeto)
{
    Console.WriteLine($"Usted no tiene suficiente dinero.");
    Console.WriteLine($"le faltan { precioObjeto - pago} pesos para completar la compra");
} else
{
    Console.WriteLine($"Usted compro: {objetoComprado} con un precio de: {precioObjeto} pesos");
    Console.WriteLine($"Pago un total de {pago} pesos, su cambio es de: {pago - precioObjeto} pesos.");
}

if (precioObjeto <= 0)
{
    Console.WriteLine($"Este producto es gratis, su cambio es de {pago} pesos.");
}