using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjPromedioNotas
{
    class Reconocimiento : IDocumento
    {
        string _titulo; //Atributo

        public Reconocimiento() //Constructor
        {
            _titulo = "Reconocimiento a estudiantes";
        }

        public string tipo() //Metodo de m
        {
            return _titulo;
        }
    }
}
