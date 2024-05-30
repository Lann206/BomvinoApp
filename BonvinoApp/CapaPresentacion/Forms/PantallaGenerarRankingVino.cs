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

        /// <summary>
        /// Abre un cuadro de diálogo para que el usuario ingrese las fechas desde y hasta, 
        /// valida el período de fechas y realiza acciones correspondientes con las fechas seleccionadas.
        /// </summary>
        public void solicitarFechaDesdeHasta()
        {
            // Mostrar un cuadro de diálogo para que el usuario ingrese las fechas desde y hasta
            var frmFechas = new SeleccionFechasForm();
            if (frmFechas.ShowDialog() == DialogResult.OK)
            {
                DateTime fechaDesde = frmFechas.FechaDesde;
                DateTime fechaHasta = frmFechas.FechaHasta;

                var esPeriodoValido = validarPeriodo(fechaDesde, fechaHasta);

                if (esPeriodoValido)
                {
                    gestorVinos.tomarFechaDesdeHasta(fechaDesde, fechaHasta);
                }
                else
                {
                    MessageBox.Show("El período de fechas no es válido");
                }

                // Realizar acciones con las fechas seleccionadas, como filtrar los vinos por ese rango de fechas
                // Por ejemplo: gestorVinos.FiltrarVinosPorFecha(fechaDesde, fechaHasta);
            }

        }

        /// <summary>
        /// Valida dos fechas para asegurar que la fecha desde no sea posterior a la fecha hasta
        /// y que ninguna de las fechas sea futura en relación a la fecha actual.
        /// </summary>
        /// <param name="fechaDesde">La fecha de inicio a validar.</param>
        /// <param name="fechaHasta">La fecha de fin a validar.</param>
        /// <returns>
        /// True si la fecha está dentro de un período válido, False en caso contrario.
        /// </returns>
        private bool validarPeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            DateTime fechaActual = DateTime.Now;

            if (fechaDesde > fechaHasta)
            {
                return false;
            }

            if (fechaDesde > fechaActual || fechaHasta > fechaActual)
            {
                return false;
            }
            return true;
        }

        public void solicitarTipoReseña()
        {
            var frmSeleccionReseñas = new SeleccionResenasForm();
            if (frmSeleccionReseñas.ShowDialog() == DialogResult.OK)
            {
                this.tomarTipoReseñaSommelier(frmSeleccionReseñas.ResenaSeleccionada);
            }
        }

        private void tomarTipoReseñaSommelier(SeleccionResenasForm.TipoResena resenaSeleccionada)
        {
            gestorVinos.tomarTipoReseñaSommelier(resenaSeleccionada);
        }

        internal void solicitarSeleccionFormaVisualizacion()
        {
            var frmFormatoForm = new SeleccionFormatoForm();
            if (frmFormatoForm.ShowDialog() == DialogResult.OK)
            {
                gestorVinos.tomarSeleccionFormaVisualizacion(frmFormatoForm.FormatoSeleccionado);
            }
        }

        internal void solicitarConfirmacionGeneracionReporte()
        {
            var frmConfirmacionForm = new ConfirmacionForm();
            if (frmConfirmacionForm.ShowDialog() == DialogResult.OK)
            {
                gestorVinos.tomarConfirmacionGeneracionReporte(frmConfirmacionForm.Confirmacion);
            }
        }

        private void PantallaGenerarRankingVino_Load(object sender, EventArgs e)
        {

        }
    }
}
