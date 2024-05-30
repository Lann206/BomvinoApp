using BonvinoApp.CapaDatos;
using BonvinoApp.CapaPresentacion.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonvinoApp.CapaNegocio.Gestores
{
    class GestorGeneracionRankingVino
    {
        #region [Atributos]
        private PantallaGenerarRankingVino pantallaGenerarRankingVino;
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        SeleccionResenasForm.TipoResena tipoReseña;
        SeleccionFormatoForm.FormatoSeleccion formatoSeleccionVisualizacion;
        List<Vino> listaVinos;
        List<Vino> listaVinosFiltradosPeriodoSomelier;

        //todos los demas atributos

        #endregion

        public DateTime FechaDesde
        {
            get { return fechaDesde; }
        }
        public DateTime FechaHasta
        {
            get { return fechaHasta; }
        }
        public GestorGeneracionRankingVino(PantallaGenerarRankingVino pantallaGenerarRankingVino)
        {
            this.pantallaGenerarRankingVino = pantallaGenerarRankingVino;
            generalDAC general = new generalDAC();

            listaVinos = general.returnVinos();
        }

        #region [Métodos]

        public void generarRankingVinos()
        {
            pantallaGenerarRankingVino.solicitarFechaDesdeHasta();
        }

        public void tomarFechaDesdeHasta(DateTime fechaDesde, DateTime fechaHasta)
        {
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
            pantallaGenerarRankingVino.solicitarTipoReseña();
        }

        internal void tomarSeleccionFormaVisualizacion(SeleccionFormatoForm.FormatoSeleccion formatoSeleccionado) {
            this.formatoSeleccionVisualizacion = formatoSeleccionado;
            pantallaGenerarRankingVino.solicitarConfirmacionGeneracionReporte();
        }

        public void buscarVinosConReseñaEnPeriodo(DateTime fechaDesde, DateTime fechaHasta) {
            foreach (var vino in listaVinos)
            {
                this.listaVinosFiltradosPeriodoSomelier = vino.TenesReseñasDeTipoEnPeriodo(fechaDesde, fechaHasta,vino);
            }
        }

        public void calcularPjeDeSommelierEnPeriodo() { }

        public void ordenarVinosSegunCalificacion() { }

        public void generarExcel() { }

        public void finCU() { }

        internal void tomarTipoReseñaSommelier(SeleccionResenasForm.TipoResena resenaSeleccionada)
        {
            this.tipoReseña = resenaSeleccionada;
            pantallaGenerarRankingVino.solicitarSeleccionFormaVisualizacion();
        }

        internal void tomarConfirmacionGeneracionReporte(bool confirmacion)
        {
            if (confirmacion)
            {
                buscarVinosConReseñaEnPeriodo(fechaDesde, fechaHasta);
            }
        }

        #endregion

    }
}
