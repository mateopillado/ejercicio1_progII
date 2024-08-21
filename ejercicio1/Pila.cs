using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Pila : IColleccion
    {

        private object[] elementos;

        private int contador;

        private int tamano;

        public object[] Elementos { get { return elementos; } set {  elementos = value; } }

        public int Contador {  get { return contador; } set {  contador = value; } }

        public int Tamano { get { return tamano; } set { tamano = value; } }

        public Pila(int tamano)
        {
            Tamano = tamano;
            Contador = 0;
            Elementos = new object[tamano];
        }


        public bool anadir(object obj)
        {
            if (Contador >= tamano - 1) return false;
            else
            {
                Console.WriteLine(obj);
                
                Elementos[Contador] = obj;
                Contador++;
                return true;
            }
  
        }

        public bool estaVacia()
        {
            if (contador == 0) return true;
            else return false;
        }

        public object extraer()
        {
            if (!estaVacia())
            {
                object devuelto = Elementos[Contador];
                Elementos[Contador] = null;
                return devuelto;
            }
            else return "Array Vacio";
        }

        public object primero()
        {
            return Elementos[Contador];
        }

      
    }
}
