using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonvinoApp.CapaNegocio
{
    class Provincia
    {
        #region [Atributos]

        private string nombre;
        private List<RegionVitivinicola> regionVitivinicola;

        #endregion

        #region [Métodos get y set]

        public string Nombre { get => nombre; set => nombre = value; }

        #endregion

        /// <summary>
        /// Constructor de la clase Provincia
        /// </summary>
        /// <param name="nombre"></param>
        public Provincia(string nombre)
        {
            Nombre = nombre;
        }

        #region [Métodos]

        //métodos propios de la clase

        #endregion
    }
}
