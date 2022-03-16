using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celulares
{
   internal class Celular
    {
        public string marca = "";
        public string color = "";
        public int numCameras;

        public Celular(string marca, string color, int numCameras)
        {
            this.marca = marca;
            this.color = color;
            this.numCameras = numCameras;
        }
        public override string ToString()
        {
            return $"Celular: {this.marca}, color {this.color} con { this.numCameras} camaras";
        }
    }
}
