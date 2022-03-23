using System;

            public class program
{
    class ejemplocon
    {
        int a;
        int b;


        public ejemplocon(int x , int y)
        {
            a = x; 
            b = y; 
        }
        public int suma()
        {
            return a + b;
        }
        public int multi()
        {
            return a * b;
        }
    }

    public static void Main()
    {
        ejemplocon obj = new ejemplocon(20, 2);
        Console.WriteLine("La suma es:"+ obj.suma());
        Console.WriteLine("La multiplicacion es:"+ obj.multi());
    }
}