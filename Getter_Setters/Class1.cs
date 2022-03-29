using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celulares
{
   internal class Celular
    {
        private string _Marca = "";
        private string _Color = "";
        private int _NumCameras;
        private string _CompaniaTelefonica = "";
        private string _NumTelefonico;
        public Celular(string _Marca, string _Color, int _NumCameras, string _NumTelefonico, string _CompaniaTelefonica)
        {
            this._Marca = _Marca;
            this._Color = _Color;
            this._NumCameras = _NumCameras;
            this._CompaniaTelefonica = _CompaniaTelefonica;
            this._NumTelefonico = _NumTelefonico;
        }
        public override string ToString()
        {
            return $"Celular: {this._Marca}, color {this._Color} con { this._NumCameras} camaras\nBajo la compañia: {this._CompaniaTelefonica} con el numero: {this._NumTelefonico}";
        }

        public string GetNumeroTelefonico() 
        {
            return _NumTelefonico;
        }

        public void SetNumeroTelefonico(string _NumTelefonico) 
        {
            this._NumTelefonico = _NumTelefonico;
        }

        public string GetCompaniaTelefonica()
        {
            return _CompaniaTelefonica;
        }

        public void SetCompaniaTelefonico(string _CompaniaTelefonica)
        {
            this._CompaniaTelefonica = _CompaniaTelefonica;
        }

        public string GetMarca() 
        {
            return _Marca;
        }

    }
}
