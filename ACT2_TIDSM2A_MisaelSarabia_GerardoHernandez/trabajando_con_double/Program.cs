Console.WriteLine("Los numeros de tipo double representan un numero decimal de precision doble, este es un termino relativo el cual representa el numero de digitos binarios usados para almacenar un valor.");

double a = 5;
double b = 4;
double c = 2;
double d = (a + b) / c;
Console.WriteLine(d);

Console.WriteLine("Cabe notar que esa respuesta incluye la porcion decimal del cociente, esta es una expresion mas complicada con doubles.");

double ae = 19;
double be = 23;
double ce = 8;
double de = (ae + be) / ce;
Console.WriteLine(de);

Console.WriteLine("------------");

Console.WriteLine("El rango de un numero de tipo double es mucho mayor que el de un entero comun");
double max = double.MaxValue;
double min = double.MinValue;
Console.WriteLine($"El rango de double es de {min} a {max}");
Console.WriteLine("Estos numeros estan escritos en notacion cientifica. El numero a la izquierda de 'E' es la mantisa, mientras que el numero a la derecha es el exponente como potencia de diez.");
Console.WriteLine("------------");
Console.WriteLine("Al igual que los decimales en las matematicas, los doubles en C# pueden tener error al redondear. Un ejemplo se muestra a continuacion");

double third = 1.0/3.0;
Console.WriteLine(third);
