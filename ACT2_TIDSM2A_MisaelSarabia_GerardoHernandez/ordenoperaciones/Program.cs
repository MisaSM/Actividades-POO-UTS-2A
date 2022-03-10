int a = 5;
int b = 4;
int c = 2;
int d = a + b * c;
Console.WriteLine("El resultado es: "+ d);
Console.WriteLine("----------");

Console.WriteLine("Se puede especificar un orden distinto al encerrar parte de la operacion en parentesis");
int e = (a+b) * c;
Console.WriteLine("Al priorizar la suma, el resultado es: " + e);

Console.WriteLine("----------");

Console.WriteLine("Se pueden combinar todo tipo de operadores, por ejemplo...");
int f = (a+b) - 6 * c + (12+4) / 3 + 12;
Console.WriteLine(f);
Console.WriteLine("----------");

Console.WriteLine("La division entre numeros enteros siempre devuelve un entero, incluso cuando deberia arrojar un decimal");
int ejemplo1 = 7;
int ejemplo2 = 4;
int ejemplo3 = 3;
int opejemplo = (ejemplo1+ejemplo2)/ejemplo3;
Console.WriteLine(opejemplo);
