using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_MisaelSarabia_GerardoHernandez_TIDSM2A
{
    public class Shape
    {
        protected int X { get; set; }
        protected int Y { get; set; }
        protected int Height { get; set; }
        protected int Width { get; set; }

        public virtual void Draw() 
        {
            Console.WriteLine("Realizando dibujo de clase base");
        }
    }
    public class Circle : Shape 
    {
        public override void Draw()
        {
            Console.WriteLine("Dibujando un circulo...");
            base.Draw();
        }
    }
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Dibujando un rectangulo...");
            base.Draw();
        }
    }
    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Dibujando un triangulo...");
            base.Draw();
        }
    }
}
