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
        private List<Reseña> reseñas;

        #endregion

        #region [Métodos get y set]

        public string AñadaImagenEtiqueta { get => añadaImagenEtiqueta; set => añadaImagenEtiqueta = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string NotaDeCataBodega { get => notaDeCataBodega; set => notaDeCataBodega = value; }
        public float Precio { get => precio; set => precio = value; }
        public List<Reseña> Reseñas { get => reseñas; set => reseñas = value; }

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
            Reseñas = new List<Reseña>();
        }


        #region [Métodos]

        //métodos propios de la clase
        /// <summary>
        /// Verifica si hay reseñas de un sommelier en un período determinado.
        /// </summary>
        public List<Reseña> TenesReseñasDeTipoEnPeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<Reseña> reseñasFiltradas = new List<Reseña>();

            foreach (var reseña in Reseñas)
            {
                if (reseña.sosDePeriodo(fechaDesde, fechaHasta) && reseña.sosDeSommelier())
                {
                    reseñasFiltradas.Add(reseña);
                }
            }
            return reseñasFiltradas;
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

        /// <summary>
        /// Busca información de la bodega.
        /// </summary>
        public void BuscarInfoBodega()
        {
            if (reseñasFiltradas.Count > 0)
            {
                if (Bodega != null)
                { 
                    Bodega.getNombre();
                  Console.WriteLine($"Buscando información de la bodega: {Bodega.Nombre}");
                }
                else
                { 
                    Console.WriteLine($"No hay información de bodega asociada al vino: {Nombre}"); 
                }
                
            }
            else
            {
                Console.WriteLine($"No hay reseñas de sommeliers en el período especificado para el vino: {Nombre}");
            }

                
        }

        /// <summary>
        /// Busca información del varietal.
        /// </summary>
        public void BuscarVarietal()
        {
            // Lógica para buscar información del varietal
            Console.WriteLine($"Buscando información del varietal: {Varietal.Nombre}");
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
