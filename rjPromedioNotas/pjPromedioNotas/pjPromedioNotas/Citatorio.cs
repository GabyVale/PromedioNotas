using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjPromedioNotas
{
    class Citatorio : IDocumento // Hereda de la interfaz IDocumento
    {
        string titulo; //Atributo

        public Citatorio()//Contructor
        {
            titulo = "Citatorio para padres de familia";
        }

        public string tipo() //Metodo de mi interfaz
        {
            return titulo;
        }
    }
}
