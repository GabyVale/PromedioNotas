using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjPromedioNotas
{
    class Promedio
    {
        //Atributos====================================================
        public string alumno;
        public int nota1;
        public int nota2;
        public int nota3;
        public int nota4;
        public string maestro;

        //Metodos=======================================================
        //masBaja retorna la clalificacion mas baja del alumno
        public int masBaja() 
        {
            int menor = int.MaxValue;
            if (nota1 < nota2) menor = nota1;
            else menor = nota2;
            if (nota3 < menor) menor = nota3;
            if (nota4 < menor) menor = nota4;
            return menor;
        }

        //Calcula el promedio del alumno
        public double calculaPromedio()
        {
            return (nota1+nota2+nota3+nota4-masBaja())/3.0;
        }

        //Asigna la condicion del alumno
        public string asignaCondicion()
        {
            double promedio = calculaPromedio();
            if (promedio < 10)
            {
                return "Desaprobado";
            }
            else if (promedio > 10 && promedio <= 12.5)
            {
                return "Recuperacion";
            }
            else
            {
                return "Aprobado";
                
            }
        }
    }
}
