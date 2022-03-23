using System.Text;

namespace practica1
{
    class problema
    {
        public struct Agenda
        {
            public string nombre;
            public string telefono;
            public int edad;


            public Agenda(string pNombre, string pTelefono, int pEdad)
            {
                nombre = pNombre;
                edad = pEdad;

                if (pTelefono.Length > 8)
                {
                    telefono = pTelefono;
                }
                else
                {
                    telefono = "Telefono no valido, verifique nuevamente";
                }
            }
            public Agenda(string pNombre,int pEdad)
            {
                nombre= pNombre;
                edad = pEdad;
                telefono = "sin telefono";

            }
            public Agenda(string pNombre)
            {
                nombre = pNombre;
                Console.WriteLine("ingresa tu edad:");
                edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingresa tu telefono:");
                telefono =Console.ReadLine();
                if (telefono.Length < 8)
                
                    telefono ="sin telefono";
                }
            }
            public Agenda(int codigo)
            {
                Console.WriteLine("ingresa tu nombre:");
                nombre = Console.ReadLine();
                Console.WriteLine("ingresa tu edad:");
                edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingresa tu telefono:");
                telefono = Console.ReadLine();
                if (telefono.Length < 8)
                {
                    telefono = "sin telefono";
                }
            }

            public override string ToString()
            {
                StringBuilder sb= new StringBuilder();
                sb.AppendFormat("Nombre: {0}, Telefono: {1}, Edad: {2}", nombre, telefono, edad);
                return (sb.ToString());
            }
            static void Main(string[] args)
            {
                Agenda amigo = new Agenda("Jorge","(+57)555-1234",35);
                Agenda amigo1 = new Agenda("Gerardo", "(+52)6441256288",22);
                Agenda amigo2 = new Agenda("karina", 22);
                Agenda amigo3 = new Agenda("karla");
                Agenda amigo4 = new Agenda(25);

                Console.WriteLine(amigo.ToString());
                Console.WriteLine(amigo1.ToString());
                Console.WriteLine(amigo2.ToString());
                Console.WriteLine(amigo3.ToString());
                Console.WriteLine(amigo4.ToString());
                Console.ReadKey();
            }
        }
    }
}
