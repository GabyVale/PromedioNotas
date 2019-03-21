using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjPromedioNotas
{
    class Boleta : IDocumento //Hereda de la interfaz IDocumento
    {
        string titulo; //Atributo

        public Boleta()//Constructor
        {
            titulo = "Boleta de calificaciones";
        }
        public string tipo()//Metodo de mi interfaz
        {
            return titulo;
        }
    }
}
