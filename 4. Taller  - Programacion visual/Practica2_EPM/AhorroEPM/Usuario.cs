using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhorroEPM
{
    public class Usuario
    {
        private string Cedula;
        private int Estrato;
        private int MetaAhorro;
        private int ConsumoActual;
        private int ValorPagar;
        private int ValorIncentivo;

        public Usuario(string idCedula, int numEstrato, int mtAhorro, int consActual,
            int vlrPagar = 0, int vlrIncentivo = 0)
        {
            this.Cedula = idCedula;
            this.Estrato = numEstrato;
            this.MetaAhorro = mtAhorro;
            this.ConsumoActual = consActual;
            this.ValorPagar = vlrPagar;
            this.ValorIncentivo = vlrIncentivo;
        }

        public string Cedula1 { get => Cedula; set => Cedula = value; }
        public int Estrato1 { get => Estrato; set => Estrato = value; }
        public int MetaAhorro1 { get => MetaAhorro; set => MetaAhorro = value; }
        public int ConsumoActual1 { get => ConsumoActual; set => ConsumoActual = value; }
        public int ValorPagar1 { get => ValorPagar; set => ValorPagar = value; }
        public int ValorIncentivo1 { get => ValorIncentivo; set => ValorIncentivo = value;
        }
       
        //CALCULAR EL VALOR TOTAL A PAGAR
        public int calcularValorTotal()
        {
            int valorKilovatio = 500;
            int valorParcial = ConsumoActual * valorKilovatio;
            ValorIncentivo = (MetaAhorro - ConsumoActual) * valorKilovatio;
            int ValorAPagar = valorParcial - (ValorIncentivo);
            return ValorAPagar;
        }       
    }
}
