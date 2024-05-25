using BonvinoApp.CapaNegocio.Gestores;
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
    public partial class PantallaGenerarRankingVino : Form
    {
        private GestorGeneracionRankingVino gestorVinos;
        public PantallaGenerarRankingVino()
        {
            InitializeComponent();
            gestorVinos = new GestorGeneracionRankingVino(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gestorVinos.generarRankingVinos();
        }

        public void solicitarFechaDesdeHasta() {

            // Mostrar un cuadro de diálogo para que el usuario ingrese las fechas desde y hasta
            var frmFechas = new SeleccionFechasForm();
            if (frmFechas.ShowDialog() == DialogResult.OK)
            {
                DateTime fechaDesde = frmFechas.FechaDesde;
                DateTime fechaHasta = frmFechas.FechaHasta;

                // Realizar acciones con las fechas seleccionadas, como filtrar los vinos por ese rango de fechas
                // Por ejemplo: gestorVinos.FiltrarVinosPorFecha(fechaDesde, fechaHasta);
            }

        }
    }
}
