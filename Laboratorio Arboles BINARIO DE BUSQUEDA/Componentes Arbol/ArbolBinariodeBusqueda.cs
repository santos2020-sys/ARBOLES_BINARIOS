using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_Arboles_BINARIO_DE_BUSQUEDA.Componentes_Arbol
{
    class ArbolBinariodeBusqueda:ArbolBinario
    {
        public ArbolBinariodeBusqueda() : ba        se()
        {
        }

        public ArbolBinariodeBusqueda(Nodo_Arbol nodo) : base(nodo)
        {
        }

        public Nodo_Arbol buscar(Object buscado)
        {
            Comparador dato;
            dato = (Comparador)buscado;
            if (Raiz == null)
                return null;
            else
                return buscar(raizArbol(), dato);
        }
        protected Nodo_Arbol buscar(Nodo_Arbol raizSub, Comparador buscado)
        {
            if (raizSub == null)
                return null;
            else if (buscado.igualQue(raizSub.ValorNodo()))
                return raizSub;
            else if (buscado.menorQue(raizSub.ValorNodo()))
                return buscar(raizSub.subarbolIzdo(), buscado);
            else
                return buscar(raizSub.subarbolDcho(), buscado);
        }

        public Nodo_Arbol buscarIterativo(Object buscado)
        {
            Comparador dato;
            bool encontrado = false;
            Nodo_Arbol raizSub = Raiz;
            dato = (Comparador)buscado;
            while (!encontrado && raizSub != null)
            {
                if (dato.igualQue(raizSub.ValorNodo()))
                    encontrado = true;
                else if (dato.menorQue(raizSub.ValorNodo()))
                    raizSub = raizSub.subarbolIzdo();
                else
                    raizSub = raizSub.subarbolDcho();
            }
            return raizSub;
        }

        public bool insertar(Object valor)
        {
            try
            {
                Comparador dato;
                dato = (Comparador)valor;
                Raiz = insertar(Raiz, dato);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

            
        }

        //método interno para realizar la operación
        protected Nodo_Arbol insertar(Nodo_Arbol raizSub, Comparador dato)
        {
            if (raizSub == null)
                raizSub = new Nodo_Arbol(dato);
            else if (dato.menorQue(raizSub.ValorNodo()))
            {
                Nodo_Arbol iz;
                iz = insertar(raizSub.subarbolIzdo(), dato);
                raizSub.ramaIzdo(iz);
            }
            else if (dato.mayorQue(raizSub.ValorNodo()))
            {
                Nodo_Arbol dr;
                dr = insertar(raizSub.subarbolDcho(), dato);
                raizSub.ramaDcho(dr);
            }
            else throw new Exception("Nodo duplicado");
            return raizSub;
        }


        public void eliminar(Object valor)
        {
            Comparador dato;
            dato = (Comparador)valor;
            Raiz = eliminar(Raiz, dato);
        }

        //método interno para realizar la operación
        protected Nodo_Arbol eliminar(Nodo_Arbol raizSub, Comparador dato)
        {
            if (raizSub == null)
                throw new Exception("No encontrado el nodo con la clave");
            else if (dato.menorQue(raizSub.ValorNodo()))
            {
                Nodo_Arbol iz;
                iz = eliminar(raizSub.subarbolIzdo(), dato);
                raizSub.ramaIzdo(iz);
            }
            else if (dato.mayorQue(raizSub.ValorNodo()))
            {
                Nodo_Arbol dr;
                dr = eliminar(raizSub.subarbolDcho(), dato);
                raizSub.ramaDcho(dr);
            }
            else // Nodo encontrado
            {
                Nodo_Arbol q;
                q = raizSub; // nodo a quitar del árbol
                if (q.subarbolIzdo() == null)
                    raizSub = q.subarbolDcho();
                else if (q.subarbolDcho() == null)
                    raizSub = q.subarbolIzdo();
                else
                { // tiene rama izquierda y derecha
                    q = reemplazar(q);
                }
                q = null;
            }
            return raizSub;
        }

        // método interno para susutituir por el mayor de los menores
        private Nodo_Arbol reemplazar(Nodo_Arbol act)
        {
            Nodo_Arbol a, p;
            p = act;
            a = act.subarbolIzdo(); // rama de nodos menores
            while (a.subarbolDcho() != null)
            {
                p = a;
                a = a.subarbolDcho();
            }
            act.nuevoValor(a.ValorNodo());
            if (p == act)
                p.ramaIzdo(a.subarbolIzdo());
            else
                p.ramaDcho(a.subarbolIzdo());
            return a;
        }



    }
}
