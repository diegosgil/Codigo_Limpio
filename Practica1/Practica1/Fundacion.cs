/*Crear la clase Fundación, la cual debe almacenar el NIT de la Fundación, el nombre y el saldo.
Este saldo aumenta con la ayuda de cada benefactor y disminuye con la ayuda que se le
entrega a cada una de las familias.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Fundacion
    {
        private string nit;
        private string nombre;
        private int saldoFundacion;

        //Constructor
        public Fundacion(string nit, string nombre, int saldoFundacion)
        {
            this.nit = nit;
            this.nombre = nombre;
            this.saldoFundacion = saldoFundacion;
        }

        //get: sirve para acceder atributos privados desde afuera de la clase con su nombre dado
        //set: es para poder asignar o cambiar el valor al atributo
        public string Nit { get => nit; set => nit = value; }       
        public string Nombre { get => nombre; set => nombre = value; }
        public int SaldoFundacion { get => saldoFundacion; set => saldoFundacion = value; }

        public void imprimirFundacion()
        {
            Console.WriteLine("Nit de la fundacion: {0}", nit);
            Console.WriteLine("Nombre de la fundacion: {0}", nombre);
            Console.WriteLine("Saldo actual: {0}", saldoFundacion);
        }

        public void DonativoBenefactor(int valorDonacion)
        {
            this.saldoFundacion = this.saldoFundacion + valorDonacion;
        }

        public void ayudaFamilia(int moneyFamily)
        {
            this.saldoFundacion = this.saldoFundacion - moneyFamily;
        }
    }
}
