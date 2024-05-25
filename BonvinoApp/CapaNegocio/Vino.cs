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
        private List<Varietal> varietal;
        private Bodega bodega;
        private List<Reseña> reseñas;

        #endregion

        #region [Métodos get y set]

        public string AñadaImagenEtiqueta { get => añadaImagenEtiqueta; set => añadaImagenEtiqueta = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string NotaDeCataBodega { get => notaDeCataBodega; set => notaDeCataBodega = value; }
        public float Precio { get => precio; set => precio = value; }
        public List<Reseña> Reseñas { get => reseñas; set => reseñas = value; }
        public List<Varietal> Varietal { get => varietal; set => varietal = value; }
        public Bodega Bodega { get => bodega; set => bodega = value; }

        #endregion

        /// <summary>
        /// Constructor de la clase Vino
        /// </summary>
        /// <param name="añadaImagenEtiqueta"></param>
        /// <param name="nombre"></param>
        /// <param name="notaDeCataBodega"></param>
        /// <param name="precio"></param>
        public Vino(string añadaImagenEtiqueta, string nombre, string notaDeCataBodega, float precio, List<Varietal> varietales, List<Reseña> reseñas, Bodega bodega)
        {
            AñadaImagenEtiqueta = añadaImagenEtiqueta;
            Nombre = nombre;
            NotaDeCataBodega = notaDeCataBodega;
            Precio = precio;
            Varietal = varietales;
            Bodega = bodega;
            Reseñas = reseñas;
        }


        #region [Métodos]

        /// <summary>
        /// Busca todos los vinos que tienen reseñas del tipo sommelier dentro del período especificado.
        /// </summary>
        /// <param name="fechaDesde">La fecha de inicio del período.</param>
        /// <param name="fechaHasta">La fecha de fin del período.</param>
        /// <param name="vinos">La lista de vinos en la que se realizará la búsqueda de reseñas.</param>
        /// <returns>Una lista de todos los vinos que tienen reseñas del tipo sommelier dentro del período especificado.</returns>
        public List<Vino> TenesReseñasDeTipoEnPeriodo(DateTime fechaDesde, DateTime fechaHasta, Vino vino)
        {
            List<Vino> vinosConReseñaEnPeriodo = new List<Vino>();

                foreach (var reseña in vino.reseñas)
                {
                    if (reseña.sosDePeriodo(fechaDesde, fechaHasta) && reseña.sosDeSommelier())
                    {
                        vinosConReseñaEnPeriodo.Add(vino);
                        break; // Salir del bucle interno ya que encontramos una reseña que cumple con las condiciones
                    }
                }
            

            return vinosConReseñaEnPeriodo;
        }

        /// <summary>
        /// Obtiene el nombre del vino.
        /// </summary>
        /// <returns>Nombre del vino</returns>
        public string GetNombre()
        {
            return Nombre;
        }

        /// <summary>
        /// Obtiene el precio del vino.
        /// </summary>
        /// <returns>Precio del vino</returns>
        public float GetPrecio()
        {
            return Precio;
        }

        ///// <summary>
        ///// Busca información de la bodega.
        ///// </summary>
        //public void BuscarInfoBodega()
        //{
        //    if (reseñasFiltradas.Count > 0)
        //    {
        //        if (Bodega != null)
        //        {
        //            Bodega.getNombre();
        //            Console.WriteLine($"Buscando información de la bodega: {Bodega.Nombre}");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"No hay información de bodega asociada al vino: {Nombre}");
        //        }

        //    }
        //    else
        //    {
        //        Console.WriteLine($"No hay reseñas de sommeliers en el período especificado para el vino: {Nombre}");
        //    }


        //}

        /// <summary>
        /// Busca información del varietal.
        /// </summary>
        public void BuscarVarietal()
        {
            // Lógica para buscar información del varietal
        }

        /// <summary>
        /// Calcula el puntaje de sommelier en un período determinado.
        /// </summary>
        public void CalcularPjeDeSommelierEnPeriodo()
        {
            // Lógica para calcular el puntaje de sommelier en un período específico
            Console.WriteLine("Calculando el puntaje de sommelier en el período especificado...");
        }


        #endregion
    }
}
