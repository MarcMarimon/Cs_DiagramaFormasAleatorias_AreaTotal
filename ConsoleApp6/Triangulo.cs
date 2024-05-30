using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Triangulo : Poligono
    {
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }
        public double Lado3 { get; set; }

        public Triangulo(double lado1, double lado2, double lado3) :base(3)
        {
            Lado1 = lado1;
            Lado2 = lado2;
            Lado3 = lado3;
        }

        public override double Area()
        {
            double s = Perimetro() / 2;
            return Math.Sqrt(s * (s - Lado1) * (s - Lado2) * (s - Lado3));
        }

        public override double Perimetro()
        {
            return Lado1 + Lado2 + Lado3;
        }
    }
}
