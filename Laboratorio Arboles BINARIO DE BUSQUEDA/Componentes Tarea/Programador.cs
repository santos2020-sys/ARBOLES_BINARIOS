using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratorio_Arboles_BINARIO_DE_BUSQUEDA.Componentes_Arbol;

namespace Laboratorio_Arboles_BINARIO_DE_BUSQUEDA.Componentes_Tarea
{
    class Programador:Comparador
    {
       public int Id_proyecto { get; set; }
        public String NombreTarea { get; set; }
       public String DuracionTarea { get; set; }
       public String PorAvance { get; set; }
       public String ProgramadorAsignado { get; set; }

        public Programador() 
        {

        }

        public Programador(int Id, String NomT, String DurT, String PorA, String ProgAs)
        {
            this.Id_proyecto = Id;
            this.NombreTarea = NomT;
            this.DuracionTarea = DurT;
            this.PorAvance = PorA;
            this.ProgramadorAsignado = ProgAs;
        }

        public bool igualQue(object q)
        {
            Programador Paux = (Programador)q;

            return Id_proyecto == Paux.Id_proyecto;
        }

        public bool menorQue(object q)
        {
            Programador Paux = (Programador)q;

            return Id_proyecto < Paux.Id_proyecto;
        }

        public bool menorIgualQue(object q)
        {
            throw new NotImplementedException();
        }

        public bool mayorQue(object q)
        {
            Programador Paux = (Programador)q;

            return Id_proyecto > Paux.Id_proyecto;
        }

        public bool mayorIgualQue(object q)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "(" + Id_proyecto + " --> " + NombreTarea + " --> " + DuracionTarea + " --> " + PorAvance + " --> " + ProgramadorAsignado + ")";
        }
    }
}
