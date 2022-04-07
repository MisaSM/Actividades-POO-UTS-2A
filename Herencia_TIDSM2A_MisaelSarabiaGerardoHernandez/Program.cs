using Personas;
using Aves;
using Animales;
using System.Collections;

ArrayList persona1 = new ArrayList();
ArrayList animal1 = new ArrayList();
ArrayList aves1 = new ArrayList();

while (true)
{
    Console.Clear();
    Console.WriteLine("¿Que quiere registrar?");
    Console.WriteLine("1) Persona 2)Animal 3)Ave 4)Salir");
    int opcion = Convert.ToInt32(Console.ReadLine());
    if (opcion == 4) 
    {
        break;
    }

    if (opcion == 1) 
    {
        Console.WriteLine("¿Como se llama?");
        var _Nombre = Console.ReadLine();
        Console.WriteLine("¿Cual es su genero?");
        var _Genero = Console.ReadLine();
        Console.WriteLine("¿En cm, cuanto mide?");
        var _Estatura = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("¿En kg, cuanto pesa?");
        var _Peso = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("¿Cuantos años tiene?");
        var _Edad = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("¿Qué es esta persona?");
        Console.WriteLine("1) Doctor 2) Policia 3)Mama 4) Papa 5)Maestro");
        int eleccion = Convert.ToInt32(Console.ReadLine());
        switch (eleccion) 
        {
            case 1:
            Console.WriteLine("¿Cual es su especializacion medica?");
            var especialidadMedica = Console.ReadLine();
            Doctor doctor1 = new Doctor(_Nombre, _Genero, _Estatura, _Peso, _Edad, especialidadMedica);
            persona1.Add(doctor1);
            break;
            case 2:
            Console.WriteLine("¿Tiene entrenamiento con armas? S/N");
            var entrenamientoConArmas = Console.ReadLine() == "S";
            Console.WriteLine("¿A que escuadron pertenece?");
            var escuadron = Console.ReadLine();
            Policia policia1 = new Policia(_Nombre, _Genero, _Estatura, _Peso, _Edad, entrenamientoConArmas, escuadron);
            persona1.Add(policia1);
            break;
            case 3:
            Console.WriteLine("¿Mamá es jubilada? S/N");
            var esJubilada = Console.ReadLine() == "S";
            Mama mama1 = new Mama(_Nombre, _Genero, _Estatura, _Peso, _Edad, esJubilada);
            persona1.Add(mama1);
            break;
            case 4:
            Console.WriteLine("¿Papá es jubilado? S/N");
            var esJubilado = Console.ReadLine() == "S";
            Papa papa1 = new Papa(_Nombre, _Genero, _Estatura, _Peso, _Edad, esJubilado);
            break;
            case 5:
            Console.WriteLine("¿Cual es la especializacion del maestro?");
            var especializacion = Console.ReadLine();
            Console.WriteLine("¿En que grado imparte clases?");
            var gradoEscolar = Console.ReadLine();
            Maestro maestro1 = new Maestro(_Nombre, _Genero, _Estatura, _Peso, _Edad, especializacion, gradoEscolar);
            break;
        } 
    }
    if (opcion == 2) 
    {
        Console.WriteLine("¿Cual es el nombre del animal?");
        var _Nombre = Console.ReadLine();
        Console.WriteLine("¿Cuantas patas tiene?");
        var _NumPatas = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("¿Cual es su habitat?");
        var _Habitat = Console.ReadLine();
        Console.WriteLine("¿Cual es su alimento?");
        var _Alimento = Console.ReadLine();
        Console.WriteLine("¿Que es este animal?");
        Console.WriteLine("1) Caballo 2) Erizo 3) Perro 4) Gato 5) Conejo");
        int eleccionAnimal = Convert.ToInt32(Console.ReadLine());
        switch (eleccionAnimal) 
        {
            case 1:
                Console.WriteLine("¿De que color es el cabello del caballo?");
                var colorCabello = Console.ReadLine();
                Console.WriteLine("¿Es raza pura el cabello? S/N");
                var razaPura = Console.ReadLine() == "S";
                Caballo caballo1 = new Caballo(_NumPatas, _Alimento, _Habitat, _Nombre, colorCabello, razaPura);
                animal1.Add(caballo1);
                break;
            case 2:
                Console.WriteLine("¿Este erizo es sonic? S/N");
                var EsSonic = Console.ReadLine() == "S";
                Console.WriteLine("¿Cuantas espinas tiene?");
                var numEspinas = Convert.ToInt32(Console.ReadLine());
                Erizo erizo1 = new Erizo(_NumPatas, _Alimento, _Habitat, _Nombre, EsSonic, numEspinas);
                animal1.Add(erizo1);
                break;
            case 3:
                Console.WriteLine("¿Que raza es el perro?");
                var raza = Console.ReadLine();
                Perro perro1 = new Perro(_NumPatas, _Alimento, _Habitat, _Nombre, raza);
                animal1.Add(perro1);
                break;
            case 4:
                Console.WriteLine("¿Es jugueton el gato?");
                var esJugueton = Console.ReadLine() == "S";
                Gato gato1 = new Gato(_NumPatas, _Alimento, _Habitat, _Nombre, esJugueton);
                animal1.Add(gato1);
                break;
            case 5:
                Console.WriteLine("¿Cuantos hijos tiene el conejo?");
                var numHijos = Convert.ToInt32(Console.ReadLine());
                Conejo conejo1 = new Conejo(_NumPatas, _Alimento, _Habitat, _Nombre, numHijos);
                break;
        }
    }
    if (opcion == 3) 
    {
        Console.WriteLine("¿Cual es el nombre del pajaro?");
        var nombre = Console.ReadLine();
        Console.WriteLine("¿De que color son sus plumas?");
        var colorPlumas = Console.ReadLine();
        Console.WriteLine("¿Que es este pajaro?");
        Console.WriteLine("1) Cuervo 2)Aguila 3)Buho 4)Paloma");
        int opcionAve = Convert.ToInt32(Console.ReadLine());
        switch (opcionAve) 
        {
            case 1:
                Console.WriteLine("¿Este cuervo hace travesuras?");
                var haceTravesuras = Console.ReadLine() == "Si";
                Cuervo cuervo1 = new Cuervo(nombre, colorPlumas, haceTravesuras);
                aves1.Add(cuervo1);
                break;
            case 2:
                Console.WriteLine("¿Cual es la forma de pico de esta aguila?");
                var formaPico = Console.ReadLine();
                Aguila aguila1 = new Aguila(nombre, colorPlumas, formaPico);
                aves1.Add(aguila1);
                break;
            case 3:
                Console.WriteLine("¿Da miedo este buho?");
                var daMiedo = Console.ReadLine() == "S";
                Buho buho1 = new Buho(nombre, colorPlumas, daMiedo);
                aves1.Add(buho1);
                break;
            case 4:
                Console.WriteLine("¿Cual es el pan favorito de esta paloma?");
                var panFavorito = Console.ReadLine();
                Paloma paloma1 = new Paloma(nombre, colorPlumas, panFavorito);
                aves1.Add(paloma1);
                break;
        }
    }
}
foreach (var Maestro in persona1) 
{
    Console.WriteLine(Maestro.ToString());
}


foreach (var Caballo in animal1)
{
    Console.WriteLine(Caballo.ToString());
}



    foreach (var Cuervo in aves1)
    {
        Console.WriteLine(Cuervo.ToString());
    }
