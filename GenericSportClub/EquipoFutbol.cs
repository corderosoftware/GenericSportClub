using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSportClub
{
    public class EquipoFutbol
    {
        public string NombreCoach { get; set; }
        public JugadorFutbol[] Integrantes { get; set; }
        public EquipoFutbol(int maxIntegrantes)
        {
            Integrantes = new JugadorFutbol[maxIntegrantes];
        }
    }

}
