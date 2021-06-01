using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AhorroEPM
{
    public partial class Form1 : Form
    {
        //Creo la listaUsuarios
        static public List<Usuario> listaUsuarios = new List<Usuario>();

        public Form1()
        {
            InitializeComponent();
        }

        //CREAR USUARIO
        public void crearUsuario(string cedula, int estrato, int metaAhorro, int consumoActual)
        {
            Usuario usuario = new Usuario(cedula, estrato, metaAhorro, consumoActual);
            listaUsuarios.Add(usuario);
            valorTotalUsu(cedula);
            limpiarCampos();
        }

        public void InicializarComboEstrato()
        {
            List<string> listaEstrato = new List<string>();
            listaEstrato.Add("");
            listaEstrato.Add("1");
            listaEstrato.Add("2");
            listaEstrato.Add("3");
            listaEstrato.Add("4");
            listaEstrato.Add("5");
            listaEstrato.Add("6");
            cmbEstrato.DataSource = listaEstrato;
        }

        //PLANTILLA PRINCIPAL
        private void Form1_Load_1(object sender, EventArgs e)
        {
            InicializarComboEstrato();
        }

        //BOTON GUARDAR
        public void btGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (maskedtxtboxCedula.Text == "" || cmbEstrato.Text == "" ||
                    maskedtxtboxMetaAhorro.Text == "" || maskedtxtboxConsumoActual.Text == "")
                {
                    throw new Exception("Por favor diligencia todos los datos");
                }
                else
                {
                    string idCedula = maskedtxtboxCedula.Text;
                    string numEstrato = cmbEstrato.Text;
                    int mtAhorro = Convert.ToInt32(maskedtxtboxMetaAhorro.Text);
                    int consActual = Convert.ToInt32(maskedtxtboxConsumoActual.Text);

                    if (idCedula.Length == 0 || idCedula.Length > 10)
                    {
                        throw new Exception("Por favor ingresa la cédula correctamente");
                    }

                    if (numEstrato == "")
                    {
                        throw new Exception("Por favor selecciona un estrato");
                    }

                    if (mtAhorro <= 0)
                    {
                        throw new Exception("Ingresa una meta de ahorro válida");
                    }

                    if (consActual < 0)
                    {
                        throw new Exception("Ingresa una meta de ahorro válida");
                    }
                    crearUsuario(idCedula, Convert.ToInt32(numEstrato), mtAhorro, consActual);
                    MessageBox.Show("La información ha sido guardada correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCampos();
                    maskedtxtboxCedula.Focus();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        public void limpiarCampos()
        {
            maskedtxtboxCedula.Text = "";
            cmbEstrato.SelectedIndex = 0;
            maskedtxtboxMetaAhorro.Text = "";
            maskedtxtboxConsumoActual.Text = "";
        }

        //BOTON DE SALIR
        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘•◘

        //1.VALOR TOTAL CLIENTE
        public int valorTotalUsu(string idCC)
        {
            int valorPagar = 0;
            foreach (Usuario usuario in listaUsuarios)
            {
                if (idCC == usuario.Cedula1)
                {
                    valorPagar = usuario.calcularValorTotal();
                }
            }
            return valorPagar;
        }

        //1.BOTON
        private void btMostrarResultados_Click(object sender, EventArgs e)
        {
            try
            {
                if (maskedtxtboxValorTotalCedula.Text == "")
                {
                    throw new Exception("Por favor ingresa una cédula");
                }
                else
                {
                    string idCC = maskedtxtboxValorTotalCedula.Text;
                    {
                        if (idCC.Length == 0 || idCC.Length > 10)
                        {
                            throw new Exception("Por favor ingresa la cédula correctamente");
                        }
                        else
                        {
                            int comparacion = valorTotalUsu(idCC);

                            if (comparacion > 0)
                            {
                                //MessageBox.Show("El Valor a pagar es: " + valorPagar);
                                txtCedulaValorTotal.Text = comparacion.ToString();
                            }
                            else
                            {
                                throw new Exception("La cédula ingresada no existe");
                            }
                            limpiarCamposValorTotal();
                        }
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        //1.LIMPIAR BOTON VALOR TOTAL CLIENTE
        public void limpiarCamposValorTotal()
        {
            maskedtxtboxValorTotalCedula.Text = "";
        }


        //2.PROMEDIO DEL CONSUMO ACTUAL
        private void btPromedioConsumo_Click(object sender, EventArgs e)
        {
            int totalConsumoActual = 0;
            foreach (Usuario usuario in listaUsuarios)
            {
                totalConsumoActual = totalConsumoActual + usuario.ConsumoActual1;
            }
            int promedioConsumo = totalConsumoActual / listaUsuarios.Count();
            txtPromedioConsumo.Text = promedioConsumo.ToString();
        }


        //3.VALOR TOTAL POR DESCUENTO
        static public int valorTotalDesc()
        {
            int suma_descuentos = 0;
            foreach (Usuario usuario in listaUsuarios)
            {
                if (usuario.ValorIncentivo1 > 0)
                {
                    suma_descuentos += usuario.ValorIncentivo1;
                }
            }
            return suma_descuentos;
        }

        //3.BOTON
        private void btValorTotalDescuentos_Click(object sender, EventArgs e)
        {           
            txtValorTotalDescuentos.Text = valorTotalDesc().ToString();
        }


        //4.PORCENTAJES DE AHORRO POR ESTRATO
        public int[] calcularPorcentajeAhorro()
        {
            int[] porcentajes;
            int cantidadEstratos = 6;
            porcentajes = new int[cantidadEstratos];

            for (int i = 0; i < cantidadEstratos; i++)
            {
                int sumaAhorro = 0;

                foreach (Usuario usuario in listaUsuarios)
                {
                    if (usuario.Estrato1 == i + 1)
                    {
                        if (usuario.ValorIncentivo1 > 0)
                        {
                            sumaAhorro += usuario.ValorIncentivo1;
                        }
                    }
                }
                int resultado = (sumaAhorro * 100) / valorTotalDesc();
                porcentajes[i] = resultado;
            }
            return porcentajes;
        }

        //4.BOTON
        private void btPorcentajeAhorroEstrato_Click(object sender, EventArgs e)
        {
            var porcentajes = calcularPorcentajeAhorro();

            StringBuilder porcResultados = new StringBuilder();

            for (int i = 0; i < 6; i++)
            {
                porcResultados.AppendLine("Estrato " + (i+1) + " : " + porcentajes[i] + "%");
            }
            txtPorcentajeEstrato.Text = porcResultados.ToString();
            txtPorcentajeEstrato.ReadOnly = true;           
        }


        //5.CONTABILIZAR LOS CLIENTES DE COBRO ADICIONAL
        static public int ContabilizarClientes()
        {
            int numeroClientes = 0;
            foreach (Usuario usuario in listaUsuarios)
            {
                if (usuario.ConsumoActual1 > usuario.MetaAhorro1)
                {
                    numeroClientes++;
                }
            }
            return numeroClientes;
        }

        //5.BOTON
        private void btClienteCobroAdicional_Click(object sender, EventArgs e)
        {
            txtClienteCobroAdicional.Text = ContabilizarClientes().ToString();
        }
    }
}
