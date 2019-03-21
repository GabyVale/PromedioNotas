using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjPromedioNotas
{
    public class calificacionException : Exception
    {
        public int _calificacion { get; private set; }

        public calificacionException(int _cal) : base ("¡La calificacion no puede ser mayor a 10")
        {
            _calificacion = _cal;
        }
    }
}
