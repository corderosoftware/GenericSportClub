using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSportClub
{
    public class EquipoBeisbol
    {
        public string NombreCoach { get; set; }
        public JugadorBeisbol[] Integrantes { get; set; }
        public EquipoBeisbol(int maxIntegrantes)
        {
            Integrantes = new JugadorBeisbol[maxIntegrantes];
        }
    }

}
