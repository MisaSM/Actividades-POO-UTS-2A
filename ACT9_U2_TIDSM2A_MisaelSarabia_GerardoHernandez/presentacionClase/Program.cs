using Deporte;

namespace POO {
	class Programa 
	{
		static void Main(string[] args) 
		{
        Bicicleta Bicicleta1 = new Bicicleta();
        Bicicleta1.Descripcion="NMX 32 Bicicleta Montaña";
        Bicicleta1.Marca="BIMEX";
        Bicicleta1.Modelo="NMX32";
        Bicicleta1.Color="Rojo";
        Bicicleta1.Velocidades=5;
        Bicicleta1.Rodada=26;
        Bicicleta1.Acelerar();
        Bicicleta1.Frenar();
        Bicicleta1.CambioVelocidades();
        Bicicleta1.MostrarInformacion();
		}
	}
}


