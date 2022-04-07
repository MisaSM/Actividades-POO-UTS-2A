using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
        public class Animales
        {
            protected int numPatas;
            protected string alimento, habitat, nombre;

            public string _Nombre { get; set; }
            public int _NumPatas { get; set; }
            public string _Alimento { get; set; }
            public string _Habitat { get; set; }
        public Animales(int numpatas, string alimento, string habitat, string nombre) 
        {
            this.numPatas = numpatas; 
            this.alimento = alimento;   
            this.habitat = habitat;
            this.nombre = nombre;
        }
        }
        public class Caballo : Animales
        {
            public string colorCabello;
            public bool razaPura;
        public Caballo(int numpatas, string alimento, string habitat, string nombre, string colorCabello, bool razaPura):base(numpatas, alimento, habitat, nombre) 
        {
            this.colorCabello = colorCabello;
            this.razaPura = razaPura;
        }
        public override string ToString()
        {
            return $"Caballo: De nombre: {this.nombre} y con {this.numPatas} patas.\nSe alimenta de: {this.alimento}\nY vive en: {this.habitat} \nColor cabello: {this.colorCabello} Raza pura: {this.razaPura}";
        }
    }
        public class Erizo : Animales
        {
            public bool EsSonic;
            public int numEspinas;


        public Erizo(int numpatas, string alimento, string habitat,  string nombre, bool EsSonic, int numEspinas):base(numpatas, alimento, habitat, nombre) 
        {
            this.EsSonic = EsSonic;
            this.numEspinas = numEspinas;
        }
        public override string ToString()
        {
            return $"Erizo: De nombre: {this.nombre} y con {this.numPatas} patas.\nSe alimenta de: {this.alimento}\nY vive en: {this.habitat} \nEs sonic: {this.EsSonic} Con: {this.numEspinas} espinas.";
        }
    }

        public class Perro : Animales
        {
            public string raza;

        public Perro(int numpatas, string alimento, string habitat, string nombre, string raza):base(numpatas, alimento, habitat, nombre) 
        {
            this.raza = raza;
        }
        public override string ToString()
        {
            return $"Perro: De nombre: {this.nombre} y con {this.numPatas} patas.\nSe alimenta de: {this.alimento}\nY vive en: {this.habitat} \nRaza: {this.raza}.";
        }
    }
        public class Gato : Animales
        {
            public bool esJugueton;

        public Gato(int numpatas, string alimento, string habitat, string nombre, bool esJugueton) : base(numpatas, alimento, habitat, nombre)
        {
            this.esJugueton = esJugueton;
        }
        public override string ToString()
        {
            return $"Gato: De nombre: {this.nombre} y con {this.numPatas} patas.\nSe alimenta de: {this.alimento}\nY vive en: {this.habitat} \nEs jugueton: {this.esJugueton}.";
        }
    }
        public class Conejo : Animales
        {
            public int numHijos;


        public Conejo(int numpatas, string alimento, string habitat, string nombre, int numHijos) : base(numpatas, alimento, habitat, nombre)
        {
            this.numHijos = numHijos; 
        }
        public override string ToString()
        {
            return $"Conejo: De nombre: {this.nombre} y con {this.numPatas} patas.\nSe alimenta de: {this.alimento}\nY vive en: {this.habitat} \nNumero de hijos: {this.numHijos}.";
        }
    }
}

