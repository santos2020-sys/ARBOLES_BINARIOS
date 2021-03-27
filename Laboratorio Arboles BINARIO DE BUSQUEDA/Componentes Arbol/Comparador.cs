using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_Arboles_BINARIO_DE_BUSQUEDA.Componentes_Arbol
{
    interface Comparador
    {
        bool igualQue(Object q);
        bool menorQue(Object q);
        bool menorIgualQue(Object q);
        bool mayorQue(Object q);
        bool mayorIgualQue(Object q);
    }
}
