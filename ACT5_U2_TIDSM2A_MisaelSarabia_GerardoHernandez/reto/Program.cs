Console.WriteLine("¿Cuantos productos va a llevar?");
int productos = Convert.ToInt32(Console.ReadLine());
if (productos < 10)
{
   Console.WriteLine("No recibirá un descuento");

}
if (productos >= 10)
{
  if (productos <= 24)
  {
    Console.WriteLine("Recibirá un descuento del 10% en su compra");
  }
}
if (productos >= 25)
{
    if (productos <= 100)
    {
        Console.WriteLine("Recibirá un descuento del 20% en su compra");
    }
}
if (productos > 100)
{
    Console.WriteLine("Recibirá un descuento del 40% en su compra!");
}
