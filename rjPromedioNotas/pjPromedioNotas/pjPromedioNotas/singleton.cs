using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjPromedioNotas
{
    public sealed class singleton
    {
        private static singleton instance = null;
        private static readonly object padlock = new object();
        private string _nombre;

        singleton() //constructor
        {
            _nombre = "Directora Angelica L. Flores";
        }

        public static singleton Instance
        {
            get
            {
                if (null == instance)
                    instance = new singleton();
                return instance;
            }
        }
        public string Nombre
        {      
            get { return _nombre; }

            //set { myVar = value; }
        

    }

    }
}
