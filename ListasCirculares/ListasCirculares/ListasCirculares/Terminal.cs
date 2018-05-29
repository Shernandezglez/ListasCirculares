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
                if(inicio == null)
                {
                    cdn = "vacio";
                }
                else
                {
                    cdn += temp.ToString() + "\r\n";
                    temp = temp.Siguiente;
                }
                

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

            if(inicio.Siguiente == inicio)
            {
                inicio = null;
            }
            else
            {
                inicio = inicio.Siguiente;
            }
           

            return temp;
        }
        // pr|  |  | ultimo           f   l
        // 1 | 2| 3| 4                1 2 3 3.sig = inicio;  4= null;   
        // aa|ss|dd| ff
        public Base eliminarUltimo()
        {
            Base temp = ultimo, temp2 = inicio ;

            while(temp2 != null)
            temp2 = temp2.Siguiente;
            ultimo = temp2.Siguiente;
            ultimo.Siguiente = inicio;

            return temp;
         
        }

        public Base eliminar(string nombreBase)
        {
            Base temp = inicio, tempU = ultimo;

            if(inicio.NombreBase == nombreBase)
            {
                temp = ultimo;
                ultimo = inicio.Siguiente;
                return temp;
            }
            else if(ultimo.NombreBase == nombreBase)
            {
                

                temp = temp.Siguiente;
                ultimo = temp.Siguiente;
                ultimo.Siguiente = inicio;
                return tempU;
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

                    if(c == inicio)
                    {
                        break;
                    }
                }

                if (num == pos)
                {
                    temp = c;
                    c.Siguiente = temp;
                    temp = c.Siguiente;
                    temp.Siguiente = ultimo;
                    ultimo.Siguiente = inicio;
                    c = b;
                    
                } 
            }


        }

        public string ruta(string nombreBase, DateTime horaInicio, DateTime horaFinal)
        {
            string cdn = "";
            DateTime tiempo;
            Base temp = inicio;

            while(temp.NombreBase != nombreBase)
            {
                temp = temp.Siguiente;

                if (temp == inicio)
                    break;
            }

            if(temp.NombreBase == nombreBase)
            {
                cdn = "";
                tiempo = horaInicio;
                //cdn = "Base: " + nombreBase + " Tiempo: " + tiempo.ToShortTimeString() + "\r\n";

                while(tiempo < horaFinal)
                {
                    cdn += "Base: " + temp.NombreBase + " Tiempo: " + tiempo.ToShortTimeString() + "\r\n";

                    temp = temp.Siguiente;
                    tiempo = tiempo.AddMinutes(temp.Tiempo);
                }
            }
            else
            {
                return null;
            }


            return cdn;
        }
      
     

    }
}
