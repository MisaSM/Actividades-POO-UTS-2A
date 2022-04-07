using Polimorfismo_MisaelSarabia_GerardoHernandez_TIDSM2A;
using Empleados_MisaelSarabia_GerardoHernandez_TIDSM2A;

Circle circle1 = new Circle();
Rectangle rectangle1 = new Rectangle();
Triangle triangle1 = new Triangle();

circle1.Draw();
rectangle1.Draw();
triangle1.Draw();

EmpleadosVentas empleado1 = new EmpleadosVentas("Alice", 1000, 500);
Empleados empleado2 = new Empleados("Bob", 1200);

Console.WriteLine(empleado1.ToString());
Console.WriteLine(empleado2.ToString());    
