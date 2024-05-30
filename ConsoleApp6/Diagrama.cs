using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Diagrama
    {
        private List<Forma> formas;

        public Diagrama()
        {
            formas = new List<Forma>();
            CrearFormasAleatorias();
        }

        private void CrearFormasAleatorias()
        {
            Random random = new Random();
            int cantidadFormas = random.Next(5, 21);

            for (int i = 0; i < cantidadFormas; i++)
            {
                int tipoForma = random.Next(1, 7);

                switch(tipoForma)
                {
                    case 1:
                        formas.Add(new Elipse(random.NextDouble() * 10 + 1, random.NextDouble() * 10 + 1));
                        break;
                    case 2:
                        formas.Add(new Circulo(random.NextDouble()*10 +1));
                        break;
                    case 3:
                        formas.Add(new Rombo (random.NextDouble()*10 + 1, random.NextDouble() *10 +1, random.NextDouble() * 10 + 1));
                        break;
                    case 4:
                        formas.Add(new Rectangulo(random.NextDouble() * 10 + 1, random.NextDouble() * 10 + 1));
                        break;
                    case 5:
                        formas.Add(new Cuadrado(random.NextDouble() * 10 + 1));
                        break;
                    case 6:
                        formas.Add(GenerarTrianguloValido(random));
                        break;
                }
            }
        }

        private Triangulo GenerarTrianguloValido(Random random)
        {
            double lado1, lado2, lado3;

            do
            {
                lado1 = random.NextDouble() * 10 + 1;
                lado2 = random.NextDouble() * 10 + 1;
                lado3 = random.NextDouble() * 10 + 1;
            } while (!(lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1));

            return new Triangulo(lado1, lado2, lado3);
        }
        public double CalcularAreaTotal()
        {
            double areaTotal = 0;
            foreach (var forma in formas)
            {
                areaTotal += forma.Area();
            }
            return areaTotal;
        }

        public void ListarFormas()
        {
            foreach (var forma in formas)
            {
                Console.WriteLine($"{forma.GetType().Name} - Area: {forma.Area()}");
            }
        }
    }
}
