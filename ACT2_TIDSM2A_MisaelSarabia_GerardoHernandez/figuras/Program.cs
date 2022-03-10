Console.WriteLine("Introduzca un valor en centimetros para la base del triangulo");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Introduzca un valor en centimetros para la altura del triangulo");
int h = Convert.ToInt32(Console.ReadLine());

int area = (b * h) / 2;
Console.WriteLine($"El triangulo tiene una base de {b} cm y una altura de {h} cm por lo que su area es de {area} cm.");
