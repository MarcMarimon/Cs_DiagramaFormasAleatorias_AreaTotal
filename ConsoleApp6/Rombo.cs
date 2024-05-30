using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Rombo : Poligono 
    {
        public double DiagonalMayor {  get; set; }
        public double DiagonalMenor { get; set; }
        public double Lado {  get; set; }

        public Rombo (double diagonalMayor, double diagonalMenor, double lado) :base(4)
        {
            DiagonalMayor = diagonalMayor;
            DiagonalMenor = diagonalMenor;
            Lado = lado;
        }

        public override double Area()
        {
            return (DiagonalMayor * DiagonalMenor) / 2;
        }
        public override double Perimetro()
        {
            return 4 * Lado;
        }
    }
}
