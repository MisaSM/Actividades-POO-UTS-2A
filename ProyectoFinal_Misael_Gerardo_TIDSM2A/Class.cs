using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispositivos
{
    public class Dispositivo
    {
        protected string marca, color, sistema;

        public string Marca { get; set; }
        public string Color { get; set; }
        public string Sistema { get; set; }

        public Dispositivo(string marca, string color, string sistema)
        {
            this.marca = marca;
            this.color = color;
            this.sistema = sistema;
        }

        public virtual void descargarApp() 
        {
            Console.WriteLine("Descargando aplicacion");
        }

        public override string ToString() 
        {
            StringBuilder disp = new StringBuilder();
            disp.AppendFormat($"Dispositivo marca: {this.marca}\nColor: {this.color}\nSistema Operativo: {this.sistema}");
            return disp.ToString();
        }

    }
    public class Telefono : Dispositivo
    {
        protected string compañiaTelefonica;
        protected string numTelefonico;
        public string numCamaras;
        public string GetNumeroTel() 
        {
            return numTelefonico;
        }
        public void SetNumeroTel(string numTelefonico) 
        {
            this.numTelefonico = numTelefonico;
        }
        public string GetCompañia() 
        {
            return compañiaTelefonica;
        }
        public void SetCompañia(string compañiaTelefonica) 
        {
            this.compañiaTelefonica = compañiaTelefonica;
        }

        public Telefono(string marca, string color, string sistema, string compañiaTelefonica, string numTelefonico, string numCamaras):base(marca, color, sistema)
        {
            this.compañiaTelefonica = compañiaTelefonica;
            this.numTelefonico = numTelefonico;
            this.numCamaras = numCamaras;
        }
        public override void descargarApp()
        {
            Console.WriteLine("Descargando app...");
            Thread.Sleep(5000);
            Console.WriteLine("App descargada!");
            Console.ReadKey();
            base.descargarApp();
        }
      
        public override string ToString()
        {
            StringBuilder disp = new StringBuilder();
            disp.AppendFormat($"Celular marca: {this.marca}\nColor: {this.color}\nSistema Operativo: {this.sistema}\nCompañia Telefonica: {this.compañiaTelefonica}\nNumero telefonico: {this.numTelefonico}\nNumero de camaras: {this.numCamaras}");
            return disp.ToString();
        }



    }

    public class Computadora : Dispositivo
    {
        protected string memRam, tipoAlmacenamiento, marcaProce;

        public string GetRam() 
        {
            return memRam;
        }
        public void SetRam(string memRam) 
        {
            this.memRam = memRam;
        }
        public string GetAlmacenamiento() 
        {
            return tipoAlmacenamiento;
        }
        public void SetAlmacenamiento(string tipoAlmacenamiento) 
        {
            this.tipoAlmacenamiento = tipoAlmacenamiento;
        }
        public string GetProce() 
        {
            return marcaProce;
        }
        public void SetProce(string marcaProce) 
        {
            this.marcaProce = marcaProce;
        }

        public string GetSistema() 
        {
            return sistema;
        }
        public void SetSistema(string sistema) 
        {
            this.sistema = sistema;
        }

        public Computadora(string marca, string color, string sistema, string memRam, string tipoAlmacenamiento, string marcaProce):base(marca, color, sistema)
        {
            this.memRam = memRam;
            this.tipoAlmacenamiento = tipoAlmacenamiento;
            this.marcaProce = marcaProce;
        }

        public override void descargarApp()
        {
            Console.WriteLine("Descargando app...");
            Thread.Sleep(5000);
            Console.WriteLine("App descargada!");
            Console.ReadKey();
            base.descargarApp();
        }

        public override string ToString()
        {
            StringBuilder disp = new StringBuilder();
            disp.AppendFormat($"Computadora marca: {this.marca}\nGabinete color: {this.color}\nSistema Operativo: {this.sistema}\nProcesador: {this.marcaProce}\nTipo almacenamiento: {this.tipoAlmacenamiento}\nMemoria RAM: {this.memRam}");
            return disp.ToString();
        }
    }
}
