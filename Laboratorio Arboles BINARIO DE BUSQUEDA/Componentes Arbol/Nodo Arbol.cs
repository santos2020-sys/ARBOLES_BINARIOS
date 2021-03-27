using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_Arboles_BINARIO_DE_BUSQUEDA.Componentes_Arbol
{
    public class Nodo_Arbol
    {
        protected Object Dato;
        protected Nodo_Arbol Izdo;
        protected Nodo_Arbol Dcho;

        /// <summary>
        /// Metodo constructor de la raiz nodo el cual recibe un valor
        /// Y asigna a las hojas o hijos un valor nulo
        /// </summary>
        /// <param name = "valor">hhhhhhhhhhhhhhh</param>

        public Nodo_Arbol(Object valor) 
        {
            Dato = valor;
            Izdo = Dcho = null;
        }

        public Nodo_Arbol(Nodo_Arbol RamaIzdo, Object valor, Nodo_Arbol RamaDcha) 
        {
            this.Dato = valor;
            Izdo = RamaIzdo;
            Dcho = RamaDcha;
        }

        //Operaciones de acceso
        public Object ValorNodo() 
        {
            return Dato;
        }

        public Nodo_Arbol subarbolIzdo() 
        {
            return Izdo;
        }

        public Nodo_Arbol subarbolDcho()
        {
            return Dcho;
        }

        public void nuevoValor(Object d) 
        {
            Dato = d;
        }

        public void ramaIzdo(Nodo_Arbol n) 
        { 
            Izdo = n; 
        }
        public void ramaDcho(Nodo_Arbol n)
        {
            Dcho = n; 
        }
        public string visitar()
        {
            return Dato.ToString();
        }


    }
}
