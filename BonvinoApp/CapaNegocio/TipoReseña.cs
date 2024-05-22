using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonvinoApp.CapaNegocio
{
    class TipoReseña
    {
        #region [Atributos]

        private string nombre;

        #endregion

        /// <summary>
        /// Constructor de la clase TipoReseña
        /// </summary>
        /// <param name="nombre"></param>
        public TipoReseña(string nombre)
        {
            this.nombre = nombre;
        }


        #region [Métodos]

        public string Nombre { get => nombre; set => nombre = value; }

        #endregion
    }
}
