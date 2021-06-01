/*Crear la clase Familia, la cual debe almacenar la identificación del responsable de la familia,
el nombre, los apellidos, la dirección, el estrato, el barrio, la edad y el valor de la ayuda
económica que se le brinda (inicialmente este valor es cero). La aplicación debe permitir el
registro de familias.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Familia
    {
        private string idFamilia;
        private string nombreFamilia;
        private string apellidoFamilia;
        private string direccion;
        private int estrato;
        private string barrio;
        private int edad;
        private int ayudaEconomicaFamilia;

        public Familia(string idFamilia, string nombreFamilia, string apellidoFamilia,
            string direccion, int estrato, string barrio, int edad, int ayudaEconomicaFamilia)
        {
            this.idFamilia = idFamilia;
            this.nombreFamilia = nombreFamilia;
            this.apellidoFamilia = apellidoFamilia;
            this.direccion = direccion;
            this.estrato = estrato;
            this.barrio = barrio;
            this.edad = edad;
            this.ayudaEconomicaFamilia = ayudaEconomicaFamilia;
        }

        public string IdFamilia { get => idFamilia; set => idFamilia = value; }
        public string NombreFamilia { get => nombreFamilia; set => nombreFamilia = value; }
        public string ApellidoFamilia { get => apellidoFamilia; set => apellidoFamilia = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Estrato { get => estrato; set => estrato = value; }
        public string Barrio { get => barrio; set => barrio = value; }
        public int Edad { get => edad; set => edad = value; }
        public int AyudaEconomicaFamilia { get => ayudaEconomicaFamilia; set => ayudaEconomicaFamilia = value; }

        public void ayudaEconomicaBrindada(int montoRetirado)
        {
            this.ayudaEconomicaFamilia = this.ayudaEconomicaFamilia + montoRetirado;
        }
    }
}