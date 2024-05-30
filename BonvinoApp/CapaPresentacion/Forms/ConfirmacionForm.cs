using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonvinoApp.CapaPresentacion.Forms
{
    public partial class ConfirmacionForm : Form
    {
        // Propiedad para almacenar la respuesta del usuario
        public bool Confirmacion { get; private set; }

        public ConfirmacionForm()
        {
            InitializeComponent();
            lblMensaje.Text = "Desea confirmar la operacion?";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Confirmacion = true;
            DialogResult = DialogResult.OK;
            //Close();
            ListadoVinos listadoVinos = new ListadoVinos();
            listadoVinos.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Confirmacion = false;
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ConfirmacionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
