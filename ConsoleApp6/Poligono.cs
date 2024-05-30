using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public abstract class Poligono : Forma
    {
        public int NumeroLados { get; }
        
        protected Poligono (int numeroLados)
        {
           NumeroLados = numeroLados;
        }
    }
}
