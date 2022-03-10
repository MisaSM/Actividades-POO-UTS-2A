Console.WriteLine("¿Cuantos estudiantes hay en el salon?");
int estudiantes = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("¿Cuantos son niños?");
int estudiantesM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("¿Cuantas son niñas?");
int estudiantesF = Convert.ToInt32(Console.ReadLine());

int propF = estudiantesF/estudiantesM;
int propM = estudiantesM/estudiantesF;

if (propF > propM)
{
    Console.WriteLine("La proporcion mayor es de niñas.");
}
if (propM > propF)
{
    Console.WriteLine("La proporcion mayor es de niños.");
}
if (propM == propF)
{
    Console.WriteLine("La proporcion es equitativa.");
}