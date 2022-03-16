using Celulares;
Console.WriteLine("¿Cuantos celulares quiere registrar?");
int numCelulares = Convert.ToInt32(Console.ReadLine());
Celular[] celularesRegistrados = new Celular[numCelulares];

for (int i = 0; i < numCelulares; i++) 
{
    Console.WriteLine($"¿De que marca es el telefono {i + 1}?");
    var marca = Console.ReadLine();
    Console.WriteLine($"¿De que color es el telefono {i + 1}?");
    var color = Console.ReadLine();
    Console.WriteLine($"¿Cuantas camaras tiene el telefono {i + 1}?");
    int numCameras = Convert.ToInt32(Console.ReadLine());
    celularesRegistrados[i] = new Celular(marca, color, numCameras);
}
foreach (Celular celular in celularesRegistrados) 
{
    Console.WriteLine(celular.ToString());
}

Console.ReadKey();
