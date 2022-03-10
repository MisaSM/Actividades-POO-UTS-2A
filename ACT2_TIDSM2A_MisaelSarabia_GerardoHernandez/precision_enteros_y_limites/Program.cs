int a = 7;
int b = 4;
int c = 3;
int d = (a+b) / c;
int e = (a+b) % c;
Console.Clear();
Console.WriteLine("Tambien es posible extraer el residuo de una division usando el operador '%' ");
Console.WriteLine($"Cociente: {d}");
Console.WriteLine($"Residuo: {e}");

Console.WriteLine("-----------");

Console.WriteLine("Los enteros en C# difieren de los enteros matematicos, ya que los enteros tienen limites minimos y maximos que se muestran a continuacion.");
int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"El rango de los enteros es de {min} a {max}");

Console.WriteLine("-----------");

Console.WriteLine("Si un calculo produce un valor que exceda esos limites, se tiene una condicion de underflow u overflow.");

int what = max + 3;
Console.WriteLine($"Un ejemplo de overflow: {what}");
