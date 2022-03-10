Console.WriteLine("¿Cual es tu nombre?");
var name = Console.ReadLine();
Console.WriteLine("¿Cual es tu edad?");
int age = Convert.ToInt32(Console.ReadLine());

if (age >= 18)
{
Console.WriteLine($"Tu nombre es {name} y eres mayor de edad.");
} 
else 
{
Console.WriteLine($"Tu nombre es {name} y eres menor de edad.");
}
