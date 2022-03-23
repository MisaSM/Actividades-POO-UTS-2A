namespace formas 
{
    public class formulas 
    {
        public static double triangulo(double b, double h) 
        {
            double  areaTri = b * h / 2;
            return areaTri;
        }
        public static double cuadrado(double lado1, double lado2) 
        {
            double areaCua = lado1 * lado2;
            return areaCua;
        }

        public static double circulo(double radio) 
        {
            double areaCir = Math.Pow((3.1416 * radio),2);
            return areaCir;
        }
    }

}
