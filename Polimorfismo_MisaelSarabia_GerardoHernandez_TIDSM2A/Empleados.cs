using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados_MisaelSarabia_GerardoHernandez_TIDSM2A
{
    public class Empleados
    {
        protected string nombre;
        protected decimal sueldo;

        public Empleados(string Pnombre, decimal Psueldo)
        {
            nombre = Pnombre;
            sueldo = Psueldo;
        }

        public string Nombre { get; set; }
        public decimal Sueldo { get; set; }

        public virtual decimal CalcularPago()
        {
            return sueldo;
        }

        public override string ToString()
        {
            StringBuilder emp = new StringBuilder();
            emp.AppendFormat($"Nombre: {nombre}, Sueldo: {sueldo}");
            return emp.ToString();
        }
    }

    public class EmpleadosVentas : Empleados
    {
        private decimal BonoVenta;

        public EmpleadosVentas(string pNombre, decimal pSueldo, decimal pBonoVenta):base(pNombre, pSueldo)
        {
            BonoVenta = pBonoVenta;
        }
        public override decimal CalcularPago()
        {
            sueldo = sueldo + BonoVenta;
            return sueldo;
        }
        public override string ToString()
        {
            StringBuilder emp = new StringBuilder();
            emp.AppendFormat($"Nombre: {nombre}, Sueldo: {CalcularPago()}");
            return emp.ToString();
        }
    }
}
