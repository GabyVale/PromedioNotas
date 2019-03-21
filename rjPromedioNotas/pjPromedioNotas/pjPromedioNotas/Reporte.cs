using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjPromedioNotas
{
    public class Reporte : IDocumento
    {
        string _titulo; //atributo

        public Reporte() //Contuctor
        {
            _titulo = "Reporte";
            
        }

        public string tipo() //Metodo de mi interfaz
        {
            return _titulo;
        }
    }
}
