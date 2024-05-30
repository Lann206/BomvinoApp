using BonvinoApp.CapaNegocio;
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
    public partial class ListadoVinos : Form
    {
        private Vino vino;
        private GestorGeneracionRankingVino gestor;
        
        public ListadoVinos()
        {
            InitializeComponent();
            PopularDataGrid();
        }

        private void PopularDataGrid()
        {

            DateTime fechaDesde = gestor.FechaDesde;
            DateTime fechaHasta = gestor.FechaDesde;
            List<Vino> vinosConResena = new List<Vino>();
            
            vinosConResena = vino.TenesReseñasDeTipoEnPeriodo(fechaDesde, fechaHasta, vino);

            dtgVinos.DataSource = vinosConResena;
        }

        private void ListadoVinos_Load(object sender, EventArgs e)
        {

        }
    }
}
