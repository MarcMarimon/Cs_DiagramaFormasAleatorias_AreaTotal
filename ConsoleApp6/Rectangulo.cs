using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Rectangulo : Poligono
    {
        public double LadoLargo { get; set; }
        public double LadoAncho { get; set; }

        public Rectangulo(double ladoLargo, double ladoAncho) :base(4)
        {
            LadoLargo = ladoLargo;
            LadoAncho = ladoAncho;
        }

        public override double Area()
        {
            return LadoLargo * LadoAncho;
        }

        public override double Perimetro()
        {
            return 2*(LadoLargo + LadoAncho);
        }
    }
}
