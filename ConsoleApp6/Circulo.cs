using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Circulo : Elipse
    {
        public double Radio
        {
            get { return EjeMayor; }
            set { EjeMayor = EjeMenor = value; }
        }
        public Circulo (double radio) : base (radio, radio) { }
    }
}
