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
    public partial class SeleccionResenasForm : Form
    {
        // Variables para almacenar la selección del usuario
        public enum TipoResena { Normales, Sommelier, Amigos }
        public TipoResena ResenaSeleccionada { get; private set; }

        public SeleccionResenasForm()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Determinar qué opción ha seleccionado el usuario y cerrar el formulario
            if (rbResenasNormales.Checked)
            {
                ResenaSeleccionada = TipoResena.Normales;
            }
            else if (rbResenasSommelier.Checked)
            {
                ResenaSeleccionada = TipoResena.Sommelier;
            }
            else if (rbResenasAmigos.Checked)
            {
                ResenaSeleccionada = TipoResena.Amigos;
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
