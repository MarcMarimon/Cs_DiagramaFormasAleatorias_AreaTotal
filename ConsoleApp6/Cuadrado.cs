using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Cuadrado : Rectangulo
    {
        public double Lado
        {
            get { return LadoLargo; }
            set { LadoLargo = LadoAncho = value; }
        }
        public Cuadrado (double lado) : base (lado, lado) { }
    }
}
