


namespace EjercicioClase
{
    public class SuperPoder
    {
        /// <summary>
        /// Identificador de Nombre
        /// </summary>
        public string Nombre { get; set; }
       
        /// <summary>
        /// Nombre de Super Fuerza 
        /// </summary>
        public string SuperFuerza { get; set; }
       
        /// <summary>
        /// Nombre de descripcion 
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Nombre de Nivel 
        /// </summary>
        public int Nivel { get; set; }

        /// <summary>
        /// Constructor 
        /// </summary>
        public SuperPoder()
        {
            Nivel = 0;
        }

        /// <summary>
        /// Muestra cada uno de los atributos de la clase  
        /// </summary>
        public void MostrarInformacion()
         {
        Console.WriteLine($"Super Poder: {SuperFuerza}");
        Console.WriteLine($"Descripción: {Descripcion}");
        Console.WriteLine($"Nivel: {Nivel}");
        Console.WriteLine();
        Console.WriteLine();
        }
    }
}
