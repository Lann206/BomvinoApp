using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonvinoApp.CapaNegocio
{
    class Varietal
    {
        #region [Atributos]

        private string descripcion;
        private float porcentaje;

        #endregion

        #region [Métodos get y set]
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public float Porcentaje { get => porcentaje; set => porcentaje = value; }

        #endregion

        /// <summary>
        /// Constructor de la clase Varietal
        /// </summary>
        /// <param name="descripcion"></param>
        /// <param name="porcentaje"></param>
        public Varietal(string descripcion, float porcentaje)
        {
            Descripcion = descripcion;
            Porcentaje = porcentaje;
        }


        #region [Métodos]

        //métodos propios de la clase

        #endregion
    }
}
