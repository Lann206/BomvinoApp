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
    public partial class SeleccionFormatoForm : Form
    {
        // Enumeración para los formatos de selección
        public enum FormatoSeleccion { PDF, Excel, Pantalla }
        public FormatoSeleccion FormatoSeleccionado { get; private set; }

        public SeleccionFormatoForm()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Determinar qué opción ha seleccionado el usuario y cerrar el formulario
            if (rbPDF.Checked)
            {
                FormatoSeleccionado = FormatoSeleccion.PDF;
            }
            else if (rbExcel.Checked)
            {
                FormatoSeleccionado = FormatoSeleccion.Excel;
            }
            else if (rbPantalla.Checked)
            {
                FormatoSeleccionado = FormatoSeleccion.Pantalla;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario sin seleccionar ninguna opción
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
