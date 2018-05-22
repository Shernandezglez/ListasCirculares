using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCirculares
{
    class Terminal
    {
        Ruta inicio = null;

        public void agregarFinal(Ruta nuevo)
        {
            if (inicio == null)
            {
                inicio = nuevo;
            }
                
            else
            {
                Ruta temp = inicio; 
                while(temp.Siguiente != null)
                {
                    temp = temp.Siguiente;
                    temp.Siguiente = inicio;
                }
                temp.Siguiente = nuevo;
            }
        }

        public Ruta buscar(string nombre)
        {
            Ruta temp = inicio;

            while(temp != null)
            {
                if(temp.NombreRuta == nombre)
                {
                    return temp;
                }

                temp = temp.Siguiente;
            }
            return null;
        }

        public Ruta eliminarInicio()
        {
            Ruta temp = inicio;
            temp = inicio.Siguiente;
            temp.Siguiente = temp;

            return inicio;
        }

        public Ruta eliminarUltimo()
        {
             
        }
    }
}
