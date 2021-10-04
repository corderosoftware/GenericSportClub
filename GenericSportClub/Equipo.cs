using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSportClub
{
    public class Equipo<T> where T : Atleta
    {
        static int posicion = 0;
        public string NombreCoach { get; set; }
        public T[] Integrantes { get; set; }
        public Equipo(int maxIntegrantes)
        {
            Integrantes = new T[maxIntegrantes];
        }

        public void AgregarIntegrante(T integrante)
        {
           Integrantes[posicion] = integrante;
           posicion++;
        }

        public string MostrarEquipo()
        {
            string result = "";

            foreach (T item in Integrantes)
            {

                result += item.Nombre + Environment.NewLine;

            }

            return result;

        }

    }

}
