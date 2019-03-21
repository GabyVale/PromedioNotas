using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjPromedioNotas
{
    public static class factoryMethod 
    {
       
        public static IDocumento Build (string _doc)
        {
            switch (_doc)
            {
                case "Reporte":
                    return new Reporte();
                    break;
                case "Boleta":
                    return new Boleta();
                    break;
                case "Citatorio":
                    return new Citatorio();
                    break;
                default:
                    return new Reconocimiento();
            }
         

        }
       
    }
}
