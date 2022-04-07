using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    public class Persona
    {
        protected string nombre, genero;
        protected int estatura, peso;
        protected int edad; 
        public string _Nombre { get; set; }
        public string _Genero { get; set; }
        public int _Estatura { get; set; }
        public int _Peso { get; set; }
        public int _Edad { get; set; }

        public Persona(string nombre, string genero, int estatura, int peso, int edad) 
        {
            this.nombre = nombre;
            this.genero = genero;
            this.estatura = estatura;
            this.peso = peso;
            this.edad = edad;
        }

        }

        public class Maestro : Persona
        {
            private string especializacion;
            private string gradoEscolar;
        public Maestro(string nombre, string genero, int estatura, int peso, int edad, string especializacion, string gradoEscolar) :base(nombre, genero, estatura, peso, edad) 
        {
            this.especializacion = especializacion;
            this.gradoEscolar = gradoEscolar;
        }
        public override string ToString()
        {
            return $"Maestro: De nombre: {this.nombre} y {this.edad} años de edad.\nDe genero: {this.genero}\nCon estatura de: {this.estatura} metros y peso de: {this.peso} kilos\nCon especializacion en: {this.especializacion} Impartido en {this.gradoEscolar}";
        }

    }
        public class Policia : Persona
        {
            private bool entrenamientoConArmas;
            private string escuadron;


        public Policia(string nombre, string genero, int estatura, int peso, int edad, bool entrenamientoConArmas, string escuadron):base(nombre, genero, estatura, peso, edad) 
        {
            this.entrenamientoConArmas = entrenamientoConArmas;
            this.escuadron = escuadron;
        }
        public override string ToString()
        {
            return $"Policia: De nombre: {this.nombre} y {this.edad} años de edad.\nDe genero: {this.genero}\nCon estatura de: {this.estatura} metros y peso de: {this.peso} kilos\nPerteneciente al escuadron: {this.escuadron} Entrenamiento de armas: {this.entrenamientoConArmas}";
        }
    }

        public class Doctor : Persona
        {
            private string especialidadMedica;
        public Doctor(string nombre, string genero, int estatura, int peso, int edad, string especialidadMedica):base(nombre, genero, estatura, peso, edad)
        {
            this.especialidadMedica = especialidadMedica;
        }
        public override string ToString()
        {
            return $"Doctor: De nombre: {this.nombre} y {this.edad} años de edad.\nDe genero: {this.genero}\nCon estatura de: {this.estatura} metros y peso de: {this.peso} kilos\nCon especializacion en: {this.especialidadMedica}";
        }
    }
        public class Mama : Persona
        {
            private bool esJubilada;

        public Mama(string nombre, string genero, int estatura, int peso, int edad, bool esJubilada):base(nombre, genero, estatura, peso, edad)
        {
            this.esJubilada = esJubilada;
        }
        public override string ToString()
        {
            return $"Mama: De nombre: {this.nombre} y {this.edad} años de edad.\nDe genero: {this.genero}\nCon estatura de: {this.estatura} metros y peso de: {this.peso} kilos\nJubilada: {this.esJubilada}";
        }
    }
        public class Papa : Persona
        {
            private bool esJubilado;
        public Papa(string nombre, string genero, int estatura, int peso, int edad, bool jubi):base(nombre,genero,estatura,peso,edad)
        {
            this.esJubilado = esJubilado;
        }
        public override string ToString()
        {
            return $"Papa: De nombre: {this.nombre} y {this.edad} años de edad.\nDe genero: {this.genero}\nCon estatura de: {this.estatura} metros y peso de: {this.peso} kilos\nJubilada: {this.esJubilado}";
        }
    }


    }
