using System;

namespace GenericSportClub
{
    class Program
    {
        static void Main(string[] args)
        {
            //var RiverPlate = new EquipoFutbol(18);

            //Equipo<JugadorFutbol> RiverPlate = new Equipo<JugadorFutbol>(18);

            var RiverPlate = new Equipo<JugadorFutbol>(4);

            RiverPlate.AgregarIntegrante(new JugadorFutbol { Nombre = "Armani", Equipo = "River" });
            RiverPlate.AgregarIntegrante(new JugadorFutbol { Nombre = "Pedro", Equipo = "River" });
            RiverPlate.AgregarIntegrante(new JugadorFutbol { Nombre = "Nahuel", Equipo = "River" });
            RiverPlate.AgregarIntegrante(new JugadorFutbol { Nombre = "Gerardo", Equipo = "River" });

            Console.WriteLine(RiverPlate.MostrarEquipo());

            //RiverPlate.Integrantes[0] = new JugadorFutbol { Nombre = "Armani", Equipo = "River" };
            //RiverPlate.Integrantes[1] = new JugadorFutbol { Nombre = "Pedro" };
            //RiverPlate.Integrantes[2] = new JugadorFutbol { Nombre = "Jose" };


            //var Aguilas = new Equipo<JugadorBeisbol>(25);
            //Aguilas.Integrantes[0] = new JugadorBeisbol { Nombre = "Julio Gonzalez" };


            Console.ReadLine();

        }
    }
}
