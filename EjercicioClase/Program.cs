using EjercicioClase;

//Creando objeto #1
SuperHeroe SuperHeroe = new SuperHeroe();
SuperHeroe.Nombre = "Superman";
SuperHeroe.IdentidadSecreta = "Clark Kent";
SuperHeroe.Ciudad = "Metropolis";
SuperHeroe.PuedeVolar = true;
SuperHeroe.MostrarInformacion();

SuperPoder SuperPoder = new SuperPoder();
SuperPoder.SuperFuerza = "Super Fuerza";
SuperPoder.Descripcion = "Capacidad de levantar objetos muy pesados";
SuperPoder.Nivel = 9;
SuperPoder.MostrarInformacion();

//Creando objeto #2
SuperHeroe SuperHeroe2 = new SuperHeroe();
SuperHeroe.Nombre = "Batman";
SuperHeroe.IdentidadSecreta = "Bruce Wayne";
SuperHeroe.Ciudad = "Gotiga";
SuperHeroe.PuedeVolar = false;
SuperHeroe.MostrarInformacion();

SuperPoder SuperPoder2 = new SuperPoder();
SuperPoder.SuperFuerza = "Coeficiente Intelectial Superior";
SuperPoder.Descripcion = "Capacidad de utilizar alta tecnologia y experto en artes marciales";
SuperPoder.Nivel = 5;
SuperPoder.MostrarInformacion();

//Creando objeto #3
SuperHeroe SuperHeroe3 = new SuperHeroe();
SuperHeroe.Nombre = "Hulk";
SuperHeroe.IdentidadSecreta = "Bruce Banner";
SuperHeroe.Ciudad = "Dayton";
SuperHeroe.PuedeVolar = false;
SuperHeroe.MostrarInformacion();

SuperPoder SuperPoder3 = new SuperPoder();
SuperPoder.SuperFuerza = "Super fuerza, salto, velocidad, regeneracion";
SuperPoder.Descripcion = "Su fuerza se trasmite proporcional a su nivel de ira";
SuperPoder.Nivel = 7;
SuperPoder.MostrarInformacion();