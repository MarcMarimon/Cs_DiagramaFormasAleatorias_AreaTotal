using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Elipse : Forma
    {
        public double EjeMayor { get; set; }
        public double EjeMenor { get; set; }

        public Elipse(double ejeMayor, double ejeMenor)
        {
            EjeMayor = ejeMayor;
            EjeMenor = ejeMenor;
        }

        public override double Area()
        {
            return Math.PI * EjeMayor * EjeMenor;
        }

        public override double Perimetro()
        {
            // Aproximación de Ramanujan para el perímetro de una elipse
            return Math.PI * (3 * (EjeMayor + EjeMenor) - Math.Sqrt((3 * EjeMayor + EjeMenor) * (EjeMayor + 3 * EjeMenor)));
        }
    }
}
