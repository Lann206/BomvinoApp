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
        
        //todos los demas atributos

        #endregion

        public GestorGeneracionRankingVino(PantallaGenerarRankingVino pantallaGenerarRankingVino) {
            this.pantallaGenerarRankingVino = pantallaGenerarRankingVino;
            generalDAC general = new generalDAC();

            List < Vino > listaVinos = general.returnVinos();
        }

        #region [Métodos]

        public void generarRankingVinos() {
            pantallaGenerarRankingVino.solicitarFechaDesdeHasta();
        }

        public void tomarFechaDesdeHasta() { }

        public void tomarTipoReseñaSommelier() { }

        public void tomarSeleccionFormaVisualizacion() { }

        public void tomarConfirmacionGeneracionReporte() { }

        public void buscarVinosConReseñaEnPeriodo() { }

        public void calcularPjeDeSommelierEnPeriodo() { }

        public void ordenarVinosSegunCalificacion() { }

        public void generarExcel() { }

        public void finCU() { }

        #endregion

    }
}
