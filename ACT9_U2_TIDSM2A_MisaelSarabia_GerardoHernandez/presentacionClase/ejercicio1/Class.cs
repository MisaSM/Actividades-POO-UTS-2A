namespace ejercicio1 
{
    public class Computadora 
    {
        public string Procesador;
        public string memoriaRam;
        public string tipoAlmacenamiento;
        public string tipoDispositivo;
        public void Encender() 
        {
            Console.WriteLine("La computadora esta encendida");
        }
        public void Apagar() 
        {
            Console.WriteLine("La computadora esta apagada");
        }
        public void Jugar() 
        {
            Console.WriteLine("No hay ningun juego ahora mismo");
        }
        public void navegarInternet()
        {
            Console.WriteLine("Es peligroso ir solo, lleva esto!");
            Console.WriteLine("HAS OBTENIDO: PROXY");
        }
        public void mostrarInformacion() 
        {
            Console.WriteLine($"Procesador:{Procesador}");
            Console.WriteLine($"Memoria Ram:{memoriaRam}");
            Console.WriteLine($"Tipo Almacenamiento:{tipoAlmacenamiento}");
            Console.WriteLine($"Tipo Dispositivo:{tipoDispositivo}");
            
        }
    }
}
