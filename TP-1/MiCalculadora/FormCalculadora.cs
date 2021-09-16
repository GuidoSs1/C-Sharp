using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Operando.BinarioDecimal(this.lblResultado.Text);
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Operando.DecimalBinario(this.lblResultado.Text);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double num = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text[0]);
            
            if (num == double.MinValue)
                this.lblResultado.Text = "Operacion no valida";
            else
                this.lblResultado.Text = Convert.ToString(num);

            double n1;
            double n2;
            double.TryParse(this.txtNumero1.Text, out n1);
            double.TryParse(this.txtNumero1.Text, out n2);

            string item = n1.ToString() +" "+ this.cmbOperador.Text+" "+ n2.ToString() +" = "+ this.lblResultado.Text;
            this.lstOperaciones.Items.Add(item);
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de querer salir?", "Salir",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


        #region Metodos
        private void Limpiar()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperador.Text = " ";
            this.lblResultado.Text = "";
        }

        private static double Operar(string numero1, string numero2, char operador)
        {
            Operando n1 = new Operando(numero1);
            Operando n2 = new Operando(numero2);
            return Calculadora.Operar(n1, n2, operador);
        }
        #endregion
    }
}
