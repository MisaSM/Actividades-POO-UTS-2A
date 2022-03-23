namespace Deporte
{
    public class Bicicleta 
    {
        public string Color;
        public string Descripcion;
        public string Marca;
        public string Modelo;
        public int Rodada;
        public int Velocidades;
    
        public void Acelerar()
        {
            Console.WriteLine("La bicicleta esta acelerando");
        }

        public void Frenar() 
        {
            Console.WriteLine("La bicicleta esta frenando");

        }
        public void CambioVelocidades() 
        {
            Console.WriteLine("La bicicleta esta cambiando de velocidad");
        }

        public void MostrarInformacion() 
        {
            Console.WriteLine($"Descripcion:{Descripcion}");
            Console.WriteLine($"Modelo:{Modelo}");
            Console.WriteLine($"Marca:{Marca}");
            Console.WriteLine($"Color:{Color}");
            Console.WriteLine($"Velocidades:{Velocidades}");
            Console.WriteLine($"Rodada:{Rodada}");
        }
    }
}
