using misaMath;

Console.Clear();
Console.WriteLine("Introduzca un numero (A):");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Introduzca un numero (B):");
double b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"¿Que quiere hacer con los numeros {a} y {b} ?");
Console.WriteLine("(1) Suma (2) Resta (3) Multiplicacion (4) Division (X) Salir");
switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine($"La suma de {a} y {b} es igual a: {operaciones.sumar(a, b)}");
                break;

            case "2":
                Console.WriteLine($"La resta de  {a} y {b} es igual a: {operaciones.restar(a,b)}");
                break;

            case "3":
                Console.WriteLine($"La multiplicación de {a} y {b} es igual a: {operaciones.multiplicar(a,b)}");
                break;

            case "4":
                Console.WriteLine($"La división de {a} y {b} es igual a: {operaciones.dividir(a,b)}");
                break;

            case "X":
                Console.Clear();
                Console.WriteLine("Adios!");
                break;
        }
