

using System.Drawing;

namespace EjercicioClase
{
    public class SuperHeroe
    {
        /// <summary>
        /// Identificador de Nombre
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Identificador de Identidad Secreta 
        /// </summary>
        public string IdentidadSecreta { get; set; }

        /// <summary>
        /// Identificador de la cuidad
        /// </summary>
        public string Ciudad { get; set; }

        /// <summary>
        /// Identificador de super poder
        /// </summary>
        public SuperPoder SuperPoder { get; set; }

        /// <summary>
        /// Identificador si tiene capacidad de volar
        /// </summary>
        public bool PuedeVolar { get; set; }

        /// <summary>
        /// Constructor 
        /// </summary>
        public SuperHeroe()
        {
            PuedeVolar = false;
        }

        /// <summary>
        /// Muestra cada uno de los atributos de la clase  
        /// </summary>
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Identidad Secreta: {IdentidadSecreta}");
            Console.WriteLine($"Ciudad: {Ciudad}");
            Console.WriteLine($"Puede Volar: {(PuedeVolar ? "Sí" : "No")}");
            
        }
    }
}
