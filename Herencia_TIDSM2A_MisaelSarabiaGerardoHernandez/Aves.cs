using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aves
{
    public class Aves
    {
        protected string nombre, colorplumas;

        public string _Nombre { get; set; }
        public string _ColorPlumas { get; set; }

        public Aves(string nombre, string colordeplumas) 
        {
        this.nombre = nombre;
        this.colorplumas = colordeplumas;
        }

    }
    public class Cuervo : Aves
    {
        public bool haceTravesuras;
        public Cuervo(string nombre, string colorplumas, bool haceTravesuras):base(nombre, colorplumas)
        {
            this.haceTravesuras = haceTravesuras;
        }
        public override string ToString()
        {
            return $"Cuervo: De nombre: {this.nombre} y con plumas de color: {this.colorplumas}.\nHace travesuras: {this.haceTravesuras}.";
        }
    }
    public class Aguila : Aves
    {
        public string formaPico;

        public Aguila(string nombre, string colorplumas, string formaPico) : base(nombre, colorplumas)
        {
            this.formaPico = formaPico;
        }
        public override string ToString()
        {
            return $"Aguila: De nombre: {this.nombre} y con plumas de color: {this.colorplumas}.\nCon pico de forma: {this.formaPico}.";
        }
    }
    public class Buho : Aves
    {
        public bool daMiedo;

        public Buho(string nombre, string colorplumas, bool daMiedo):base(nombre, colorplumas)
        {
            this.daMiedo = daMiedo;
        }
        public override string ToString()
        {
            return $"Buho: De nombre: {this.nombre} y con plumas de color: {this.colorplumas}.\nDa miedo: {this.daMiedo}.";
        }
    }
    public class Paloma : Aves
    {
        public string panFavorito;

        public Paloma(string nombre, string colorplumas, string panFavorito):base(nombre, colorplumas)
        {
            this.panFavorito = panFavorito;
        }
        public override string ToString()
        {
            return $"Paloma: De nombre: {this.nombre} y con plumas de color: {this.colorplumas}.\nSu pan favorito:: {this.panFavorito}.";
        }
    }
}

