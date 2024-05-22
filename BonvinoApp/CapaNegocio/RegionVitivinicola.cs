using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonvinoApp.CapaNegocio
{
    class RegionVitivinicola
    {
        #region [Atributos]

        private string nombre;
        private Bodega bodega;

        #endregion

        #region [Métodos get y set]
        public string Nombre { get => nombre; set => nombre = value; }

        #endregion

        /// <summary>
        /// Constructor de la clase RegionVitivinicola
        /// </summary>
        /// <param name="nombre"></param>
        public RegionVitivinicola(string nombre)
        {
            Nombre = nombre;
        }


        #region [Métodos]

        //métodos propios de la clase

        #endregion
    }
}
