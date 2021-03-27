using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_Arboles_BINARIO_DE_BUSQUEDA.Componentes_Arbol
{
    class ArbolBinario
    {
        protected Nodo_Arbol Raiz;

        public ArbolBinario() 
        {
            Raiz = null;
        }

        public ArbolBinario(Nodo_Arbol Raiz)
        {
            this.Raiz = Raiz;
        }

        /// <summary>
        /// Este metodo debuelve la Raiz del Arbol
        /// </summary>
        /// <returns></returns>

        public Nodo_Arbol raizArbol()
        {
            return Raiz;
        }

        /// <summary>
        /// Comprueba si el árbol esta vacio
        /// </summary>
        /// <returns></returns>
        bool esVacio()
        {
            return Raiz == null;
        }

        //binario en preorden
        public static string preorden(Nodo_Arbol r)
        {
            if (r != null)
            {
                return r.visitar() + preorden(r.subarbolIzdo()) +
                    preorden(r.subarbolDcho());
            }
            return "";
        }

        // Recorrido de un árbol binario en inorden
        public static string inorden(Nodo_Arbol r)
        {
            if (r != null)
            {
                return inorden(r.subarbolIzdo())
                    + r.visitar() + inorden(r.subarbolDcho());
            }
            return "";
        }

        // Recorrido de un árbol binario en postorden
        public static string postorden(Nodo_Arbol r)
        {
            if (r != null)
            {
                return postorden(r.subarbolIzdo()) + postorden(r.subarbolDcho()) + r.visitar();
            }
            return "";
        }

        //Devuelve el número de nodos que tiene el árbol
        public static int numNodos(Nodo_Arbol raiz)
        {
            if (raiz == null)
                return 0;
            else
                return 1 + numNodos(raiz.subarbolIzdo()) +
                numNodos(raiz.subarbolDcho());
        }


    }
}

