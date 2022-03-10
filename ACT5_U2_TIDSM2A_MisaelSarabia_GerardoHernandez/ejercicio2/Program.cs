Console.WriteLine("Introduzca el primer numero");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Introduzca el segundo numero");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Introduzca el tercer numero");
int c = Convert.ToInt32(Console.ReadLine());

if (a < b) 
{
    if (a < c)
    {
                Console.WriteLine($"{a} es menor que {b} y {c}");
        
    }
}
if (b < a)
{
    if (b < c)
        {
            Console.WriteLine($"{b} es menor que {a} y {c}");
        }
}
     if (c < a)
        {
            if (c < b)
            {
                 Console.WriteLine($"{c} es menor que {a} y {b}");
            }
         }
