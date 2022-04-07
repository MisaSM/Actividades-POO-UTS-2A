using Dispositivos;
using System.Collections;

ArrayList computadoras = new ArrayList();
ArrayList telefonos = new ArrayList();
bool eleccionCorrecta;

while (true) 
{
    Console.Clear();
    Console.WriteLine("Bienvenido al sistema de registro de dispositivos!\n¿Que quiere registrar?\n1) Telefono 2) Computadora 3)Acceder dispositivo 4) Salir");
    int opcion = Convert.ToInt32(Console.ReadLine());
    if (opcion == 4)
    {
        Console.Clear();
        Console.WriteLine("Dispositivos registrados...");
        break;
    }
    if (opcion == 1) 
    {
        Console.WriteLine("¿Cual es la marca del telefono?");
        var marca = Console.ReadLine();
        Console.WriteLine("¿De que color es el telefono?");
        var color = Console.ReadLine();
        Console.WriteLine("¿Que sistema operativo usa?");
        var sistema = Console.ReadLine();
        Console.WriteLine("¿Con que compañia telefonica lo registro?");
        var compañiaTelefonica = Console.ReadLine();
        Console.WriteLine("¿Con que numero telefonico?");
        var numTelefonico = Console.ReadLine();
        Console.WriteLine("¿Cuantas camaras tiene?");
        var numCamaras = Console.ReadLine();
        Telefono telefono1 = new Telefono(marca, color, sistema, compañiaTelefonica, numTelefonico, numCamaras);
        telefonos.Add(telefono1);
    }
    if (opcion == 2) 
    {
        Console.WriteLine("¿De que marca es la computadora?");
        var marca = Console.ReadLine();
        Console.WriteLine("¿De que color es el gabinete?");
        var color = Console.ReadLine();
        Console.WriteLine("¿Que sistema operativo usa?");
        var sistema = Console.ReadLine();
        Console.WriteLine("¿Cuanta memoria ram tiene?");
        var memRam = Console.ReadLine();
        Console.WriteLine("¿Que tipo de almacenamiento usa?");
        var tipoAlmacenamiento = Console.ReadLine();
        Console.WriteLine("¿Que marca es el procesador?");
        var marcaProce = Console.ReadLine();

        Computadora computadora1 = new Computadora(marca, color, sistema ,memRam, tipoAlmacenamiento, marcaProce);
        computadoras.Add(computadora1);
    }

    if (opcion == 3)
    {
        Console.WriteLine("¿A que quiere acceder?\n1)Telefono 2)Computadora");
        var eleccionDispositivo = Console.ReadLine();
        if (eleccionDispositivo == "1")
        {
            for (int i = 0; i < telefonos.Count; i++) 
            {
                Console.WriteLine($"{i+1} {telefonos[i].ToString()}");
            }
           Telefono telVar = null;
           int eleccionCelular = 0;
           eleccionCorrecta = true;
           while (eleccionCorrecta) 
            {
                Console.WriteLine("¿A que telefono quiere acceder?");
                eleccionCelular = Convert.ToInt32(Console.ReadLine()) - 1;
                try
                {
                    telVar = (Telefono)telefonos[eleccionCelular];
                    eleccionCorrecta = false;
                }
                catch (Exception error) { Console.WriteLine("Ese dispositivo no existe, intente de nuevo."); }
            }

            Console.WriteLine($"¿Que le quiere hacer al celular {eleccionCelular + 1}?\n1)Cambiar numero\n2)Cambiar compañía\n3)Descargar app\n4)Salir");
           int opcionTel = Convert.ToInt32(Console.ReadLine());

            switch (opcionTel)
            {
                case 1:
                    Console.WriteLine("Escriba el nuevo numero");
                    string numTelefonico = Console.ReadLine();
                    telVar.SetNumeroTel(numTelefonico);
                    break;
                case 2:
                    Console.WriteLine("Escriba la nueva compañia");
                    string compañiaTelefonica = Console.ReadLine();
                    telVar.SetCompañia(compañiaTelefonica);
                    break;
                case 3:
                    telVar.descargarApp();
                    break;
                case 4:
                    break;
            }

        }
        if (eleccionDispositivo == "2") 
        {
            for (int i = 0; i < computadoras.Count; i++)
            {
                Console.WriteLine($"{i + 1} {computadoras[i].ToString()}");
            }
            Computadora pcvar = null;
            int eleccionPc = 0;
            eleccionCorrecta = true;
            while(eleccionCorrecta) 
            {
                Console.WriteLine("¿A que computadora quiere acceder?");
                eleccionPc = Convert.ToInt32(Console.ReadLine()) - 1;
                try
                {
                    pcvar = (Computadora)computadoras[eleccionPc];
                    eleccionCorrecta = false;
                }
                catch (Exception error) { Console.WriteLine("Escogió una computadora que no existe"); }
            }

            Console.WriteLine($"¿Que quiere hacerle a la computadora {eleccionPc + 1}?\n1)Actualizar sistema 2)Cambiar proce 3) Cambiar RAM 4) Descargar app 5)Cancelar");
            int opcionPc = Convert.ToInt32(Console.ReadLine());
            switch (opcionPc) 
            {
                case 1:
                    Console.WriteLine("Escriba el sistema que va a instalar");
                    string nuevoSistema = Console.ReadLine();
                    pcvar.SetSistema(nuevoSistema);
                    break;
                case 2:
                    Console.WriteLine("Escriba la marca del procesador nuevo");
                    string nuevoProce = Console.ReadLine();
                    pcvar.SetProce(nuevoProce);
                    break;
                case 3:
                    Console.WriteLine("Escriba la nueva ram que pondra");
                    string nuevaRam = Console.ReadLine();
                    pcvar.SetRam(nuevaRam);
                    break;
                case 4:
                    pcvar.descargarApp();
                    break;
                case 5:
                    break;
            }

        }
    }
}

foreach (var Celular in telefonos) 
{
    Console.WriteLine(Celular.ToString());   
}
foreach (var Computadora in computadoras) 
{
    Console.WriteLine(Computadora.ToString());
}
