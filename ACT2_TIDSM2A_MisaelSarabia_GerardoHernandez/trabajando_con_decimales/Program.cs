Console.WriteLine("Hay otro tipo sobre el cual aprender en C# y es el decimal. Este tiene un rango menor pero mayor precision que el double, observa el ejemplo");

decimal min = decimal.MinValue;
decimal max = decimal.MaxValue;
Console.WriteLine($"El rango del tipo decimal es de {min} a {max}");

Console.WriteLine("Para probar la precision mayor del tipo decimal, observa la siguiente comparacion.");

double a = 1.0;
double b = 3.0;
Console.WriteLine(a / b);

decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d);
