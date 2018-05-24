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
        private Base _siguiente;

        public Base(string nb)
        {
            _nombreBase = nb;
            
        }

        public string NombreBase
        {
            get { return _nombreBase; }
            set { _nombreBase = value; }
        }

        public Base Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }

        public override string ToString()
        {
            return "Base: " + _nombreBase;
        }
    }
}
