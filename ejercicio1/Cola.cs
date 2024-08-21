using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Cola : IColleccion
    {

        List<object> elementos;

        public Cola()
        {
            elementos = new List<object>();
        }

        public bool anadir(object obj)
        {
            elementos.Add(obj);
            return true;
        }

        public bool estaVacia()
        {
            if (elementos.Count == 0)
            {
                return true;
            }else return false;
        }

        public object extraer()
        {
            object obj = elementos[0];
            elementos.RemoveAt(0);
            return obj;
        }

        public object primero()
        {
            return elementos[0];
        }
    }
}
