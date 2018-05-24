using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCirculares
{
    class Terminal
    {
        Base inicio = null;
        Base ultimo = null;

        public void agregarFinal(Base nuevo)
        {
           if(inicio == null)
            {
                inicio = nuevo;
                inicio.Siguiente = inicio;
                ultimo = inicio;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = inicio;
                ultimo = nuevo;
            }
        }

        public string listar()
        {
            string cdn = "";

            Base temp = inicio;

            do
            {
                cdn += temp.ToString() + "\r\n";
                temp = temp.Siguiente;

            } while (temp != inicio);


            return cdn;
        }

        public Base buscar(string nombre)
        {
            Base temp = inicio;

            do
            {
                if (temp.NombreBase == nombre)
                {
                    return temp;
                }
                temp = temp.Siguiente;
               
            } while (temp != inicio);

            return null;
        }


        public Base eliminarInicio()
        {

            Base temp = inicio;

            inicio = inicio.Siguiente;

            return temp;
        }

        public Base eliminarUltimo()
        {
           Base temp = ultimo;

            return temp;
         
        }

        public Base eliminar(string nombreBase)
        {
            Base temp = inicio;

            if(inicio.NombreBase == nombreBase)
            {
                temp = ultimo;
                ultimo = inicio.Siguiente;
                return temp;
            }
            else if(ultimo.NombreBase == nombreBase)
            {

            }
            else
            {
                do
                {
                    if (temp.NombreBase == nombreBase)
                    {
                        temp.Siguiente = temp.Siguiente.Siguiente;
                        
                        return temp;
                    }
                    temp = temp.Siguiente;
                } while (temp != inicio);
            }

            return null;
        }
        // 1  2  3  4                       1  2  3  4  5
       // aa ss dd ff   b = gg pos= 3 ---> aa ss gg dd ff
        public void insertar(Base b, int pos)
        {
            Base c = inicio;
            Base temp;
            int num = 1;

            if(inicio == null)
            {
                inicio = b;
                ultimo = b;
            }
            else
            {
                while(num != pos)
                {
                    c = c.Siguiente;
                    num++;
                }
                temp = c;
                temp = b;
                temp.Siguiente = c;
                ultimo = ultimo.Siguiente;
                
               
                
            }


        }

        public string ruta(string nombreBase, int horaInicio, int horaFinal)
        {
            string cdn = "";
            Base temp = inicio;

            do
            {
                if(temp.NombreBase == nombreBase && temp == inicio)
                {
                    cdn = "Ruta 7 " + " | " + "Hora de inicio: " + horaInicio + " | " + "Hora final: " + horaFinal; 
                }
                else
                {

                }

                temp = temp.Siguiente;

            } while (temp != inicio);


            return cdn;
        }
      
     

    }
}
