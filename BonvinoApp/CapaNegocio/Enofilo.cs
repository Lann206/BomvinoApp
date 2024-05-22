using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonvinoApp.CapaNegocio
{
    class Enofilo
    {
        #region [Atributos]

        private string nombre;
        private string apellido;
        private string imagenPerfil;
        private Reseña reseña;

        #endregion

        #region [Métodos get y set]
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string ImagenPerfil { get => imagenPerfil; set => imagenPerfil = value; }
        internal Reseña Reseña { get => reseña; set => reseña = value; }

        #endregion

        /// <summary>
        /// Constructor de la clase Enofilo
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="imagenPerfil"></param>
        public Enofilo(string nombre, string apellido, string imagenPerfil)
        {
            Nombre = nombre;
            Apellido = apellido;
            ImagenPerfil = imagenPerfil;
        }

        #region [Métodos]

        //métodos propios de la clase

        #endregion
    }
}
