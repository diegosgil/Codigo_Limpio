/*Crear la clase Benefactor, la cual debe guardar la identificación del benefactor, el nombre y
el valor de ayuda que le da a la Fundación. La aplicación debe permitir que se registren
benefactores de la Fundación.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Benefactor
    {
        private string identificacionBenefactor;
        private string nombreBenefactor;
        private int valorAyudaBenefactor;

        public Benefactor(string identificacionBenefactor, string nombreBenefactor, int valorAyudaBenefactor)
        {
            this.identificacionBenefactor = identificacionBenefactor;
            this.nombreBenefactor = nombreBenefactor;
            this.valorAyudaBenefactor = valorAyudaBenefactor;
        }

        public string IdentificacionBenefactor { get => identificacionBenefactor; set => identificacionBenefactor = value; }
        public string NombreBenefactor { get => nombreBenefactor; set => nombreBenefactor = value; }
        public int ValorAyudaBenefactor { get => valorAyudaBenefactor; set => valorAyudaBenefactor = value; }

        public void ayudaDeBenefacor(int donacionBene)
        {
            this.valorAyudaBenefactor = this.valorAyudaBenefactor + donacionBene;
        }
    }
}
