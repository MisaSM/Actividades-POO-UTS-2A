using ejercicio1;
namespace POO 
{
    class Programa 
    {
        static void Main (string[] args) 
        {
            Computadora PC1 = new Computadora();
            PC1.Procesador = "Intel";
            PC1.memoriaRam = "4GB";
            PC1.tipoAlmacenamiento = "SSD";
            PC1.tipoDispositivo = "De escritorio";
            PC1.Encender();
            PC1.Apagar();
            PC1.Jugar();
            PC1.navegarInternet();
            PC1.mostrarInformacion();
         }
    }
}
