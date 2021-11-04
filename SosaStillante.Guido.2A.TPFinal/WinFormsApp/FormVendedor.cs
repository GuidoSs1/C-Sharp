using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WinFormsApp
{
    public partial class FormVendedor : Form
    {
        public Vendedor vendedor;

        /// <summary>
        /// Contructor del form que inicializa el combobox con los valores del enumerado de genero
        /// </summary>
        public FormVendedor()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            this.cboCompradorGenero.DataSource = Enum.GetValues(typeof(EGenero));
            this.cboCompradorGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboCompradorGenero.SelectedItem = EGenero.SinGenero;
        }

        /// <summary>
        /// Metodo que controla los datos ingresados por el usuario para agregar un vendedor, siendo obligatorios el dni y los btc, de no llenar los demas campos el vendedor se inicializara de forma anonima por defecto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            double btc;
            Double.TryParse(this.txtBtc.Text, out btc);
            int dni;
            Int32.TryParse(this.txtDocumento.Text, out dni);

            if (btc == 0 || dni == 0)
            {
                MessageBox.Show("Vuelva a Intentarlo");
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                if(String.IsNullOrWhiteSpace(this.txtNombre.Text) || String.IsNullOrWhiteSpace(this.txtApellido.Text))
                {
                    this.vendedor = new Vendedor(this.txtDocumento.Text, this.txtBtc.Text);
                    MessageBox.Show("El vendedor sera anonimo.");
                }
                else
                {
                    this.vendedor = new Vendedor(this.txtNombre.Text, this.txtApellido.Text,
                                this.txtDocumento.Text, (EGenero)this.cboCompradorGenero.SelectedItem, this.txtBtc.Text);
                }
                
                this.DialogResult = DialogResult.OK;
            }

        }

        /// <summary>
        /// Cancela la accion y cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        
    }
}
