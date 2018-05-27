using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCirculares
{
    class Base
    {
        private string _nombreBase;
        private int _tiempo;
        private Base _siguiente;

        public Base(string nb, int ti)
        {
            _nombreBase = nb;
            _tiempo = ti;
        }

        public string NombreBase
        {
            get { return _nombreBase; }
            set { _nombreBase = value; }
        }

        public int Tiempo
        {
            get { return _tiempo; }
            set { _tiempo = value; }
        }

        public Base Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }

        public override string ToString()
        {
            return "Base: " + _nombreBase + " | " + "Tiempo: " + _tiempo;
        }
    }
}
