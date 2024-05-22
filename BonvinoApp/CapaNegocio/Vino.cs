using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonvinoApp.CapaNegocio
{
    class Vino
    {
        #region [Atributos]

        private string añadaImagenEtiqueta;
        private string nombre;
        private string notaDeCataBodega;
        private float precio;
        private Varietal varietal;
        private Bodega bodega;

        #endregion

        #region [Métodos get y set]

        public string AñadaImagenEtiqueta { get => añadaImagenEtiqueta; set => añadaImagenEtiqueta = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string NotaDeCataBodega { get => notaDeCataBodega; set => notaDeCataBodega = value; }
        public float Precio { get => precio; set => precio = value; }

        #endregion

        /// <summary>
        /// Constructor de la clase Vino
        /// </summary>
        /// <param name="añadaImagenEtiqueta"></param>
        /// <param name="nombre"></param>
        /// <param name="notaDeCataBodega"></param>
        /// <param name="precio"></param>
        public Vino(string añadaImagenEtiqueta, string nombre, string notaDeCataBodega, float precio)
        {
            AñadaImagenEtiqueta = añadaImagenEtiqueta;
            Nombre = nombre;
            NotaDeCataBodega = notaDeCataBodega;
            Precio = precio;
        }


        #region [Métodos]

        //métodos propios de la clase

        #endregion
    }
}
