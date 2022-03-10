Console.Clear();
Console.WriteLine("Introduzca un numero (A):");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Introduzca un numero (B):");
double b = Convert.ToDouble(Console.ReadLine());

//Al pasar algo a la consola, esto es introducido como tipo String, por lo que se tiene que convertir para trabajarlo
//Usa el metodo Convert.ToDouble para pasarlo a un tipo Double y usarlo en operaciones matemáticas con punto decimal

double suma = a + b;
double resta = a - b;
double mult = a * b;
double division = a / b;

Console.WriteLine($"¿Que quiere hacer con los numeros {a} y {b} ?");
Console.WriteLine("(1) Suma (2) Resta (3) Multiplicacion (4) Division (X) Salir");
switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine($"La suma de {a} y {b} es igual a: {suma}");
                break;

            case "2":
                Console.WriteLine($"La resta de  {a} y {b} es igual a: {resta}");
                break;

            case "3":
                Console.WriteLine($"La multiplicación de {a} y {b} es igual a: {mult}");
                break;

            case "4":
                Console.WriteLine($"La división de {a} y {b} es igual a: {division}");
                break;

            case "X":
                Console.Clear();
                Console.WriteLine("Adios!");
                break;
        }