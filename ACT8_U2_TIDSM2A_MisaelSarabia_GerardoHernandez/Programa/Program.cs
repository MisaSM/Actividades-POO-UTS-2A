string nombreCorto = "";
string nombreLargo = "";
string nombre = "";
int letras = 0;
for (int i = 1; i <= 5; i++) 
    {
    Console.WriteLine("Introduzca un nombre");
    nombre = Console.ReadLine();
    nombre = nombre.Replace(" ", "");
    letras += nombre.Length;
    if (i == 1) 
    {
        nombreLargo = nombre;
        nombreCorto = nombre;
    }
    if (nombre.Length > nombreLargo.Length) 
    {
        nombreLargo = nombre;
    }
    if (nombre.Length < nombreCorto.Length) 
    {
        nombreCorto = nombre;
    }
    }
Console.WriteLine($"Hay un total de {letras} letras en esos nombres");
Console.WriteLine($"El nombre más corto es {nombreCorto.ToLower()}");
Console.WriteLine($"El nombre más largo es {nombreLargo.ToUpper()}");
