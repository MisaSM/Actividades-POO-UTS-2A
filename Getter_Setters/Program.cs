using Celulares;
Console.WriteLine("¿Cuantos celulares quiere registrar?");
int numCelulares = Convert.ToInt32(Console.ReadLine());
Celular[] celularesRegistrados = new Celular[numCelulares];

for (int i = 0; i < numCelulares; i++) 
{
    Console.WriteLine($"¿De que marca es el telefono {i + 1}?");
    var _Marca = Console.ReadLine();
    Console.WriteLine($"¿De que color es el telefono {i + 1}?");
    var _Color = Console.ReadLine();
    Console.WriteLine($"¿Cuantas camaras tiene el telefono {i + 1}?");
    int _NumCameras = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"¿Con que compañía telefonica lo registró?");
    var _CompaniaTelefonica = Console.ReadLine();
    Console.WriteLine($"¿Cual es su numero telefonico?");
    var _NumTelefonico = Console.ReadLine();
    celularesRegistrados[i] = new Celular(_Marca, _Color, _NumCameras, _CompaniaTelefonica, _NumTelefonico);
}

while (true)
{
    Console.WriteLine("¿Que desea hacer?");
    Console.WriteLine("1) Actualizar numero\n2) Actualizar compañia\n3) Salir");
    int opcion = Convert.ToInt32(Console.ReadLine());
    if (opcion == 3) 
    {
        break; 
    }

    for (int i = 0; i < numCelulares; i++) 
    {
        Celular celActual = celularesRegistrados[i];
        Console.WriteLine($"Marca de telefono {i+1}: {celActual.GetMarca()}\nNumero {i+1}: {celActual.GetNumeroTelefonico()}\nBajo compañia: {celActual.GetCompaniaTelefonica()} ");
    }

    Console.WriteLine("¿Que celular eliges para editar?");
    int eleccionCelular = Convert.ToInt32(Console.ReadLine());

    if (opcion == 1)
    {
        Console.WriteLine("Escriba el nuevo numero de telefono");
        string nuevoNumero = Console.ReadLine();
        celularesRegistrados[eleccionCelular - 1].SetNumeroTelefonico(nuevoNumero);
    }

    if (opcion == 2)
    {
        Console.WriteLine("Escriba la nueva compañia telefonica:");
        string nuevaCompañia = Console.ReadLine();
        celularesRegistrados[eleccionCelular - 1].SetCompaniaTelefonico(nuevaCompañia);
    }

}

foreach (Celular celular in celularesRegistrados) 
{
    Console.WriteLine(celular.ToString());
}

Console.ReadKey();
