using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Calcular área y perímetro de un Elipse");
                Console.WriteLine("2. Calcular área y perímetro de un Circulo");
                Console.WriteLine("3. Calcular área y perímetro de un Rombo");
                Console.WriteLine("4. Calcular área y perímetro de un Rectangulo");
                Console.WriteLine("5. Calcular área y perímetro de un Cuadrado");
                Console.WriteLine("6. Calcular área y perímetro de un Triángulo");
                Console.WriteLine("7. Crear diagrama de flujo y calcular área total");
                Console.WriteLine("0. Salir");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        CalcularElipse();
                        break;
                    case "2":
                        CalcularCirculo();
                        break;
                    case "3":
                        CalcularRombo();
                        break;
                    case "4":
                        CalcularRectangulo();
                        break;
                    case "5":
                        CalcularCuadrado();
                        break;
                    case "6":
                        CalcularTriangulo();
                        break;
                    case "7":
                        CrearDiagrama();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Presione Enter para continuar...");
                        Console.ReadLine();
                        break;
                }
            }
        }
        
        static void CalcularElipse()
        {
            double ejeMayor = SolicitarDouble("Ingrese el eje mayor: ");
            double ejeMenor = SolicitarDouble("Ingrese el eje menor: ");

            Elipse elipse = new Elipse(ejeMayor, ejeMenor);

            Console.WriteLine($"Area: {elipse.Area()}");
            Console.WriteLine($"Perimetro: {elipse.Perimetro()}");
            Console.WriteLine("Presione Enter para continuar...");
            Console.ReadLine();
        }

        static void CalcularCirculo()
        {
            double radio = SolicitarDouble("Ingrese el radio: ");

            Circulo circulo = new Circulo(radio);

            Console.WriteLine($"Area: {circulo.Area()}");
            Console.WriteLine($"Perimetro: {circulo.Perimetro()}");
            Console.WriteLine("Presione Enter para continuar...");
            Console.ReadLine();
        }

        static void CalcularRombo()
        {
            
            double diagonalMayor = SolicitarDouble("Ingrese la diagonal mayor: ");
            double diagonalMenor = SolicitarDouble("Ingrese la diagonal menor: ");
            double lado = SolicitarDouble("Ingrese el lado: ");

            Rombo rombo = new Rombo(diagonalMayor,diagonalMenor,lado);

            Console.WriteLine($"Área: {rombo.Area()}");
            Console.WriteLine($"Perímetro: {rombo.Perimetro()}");
            Console.WriteLine("Presione Enter para continuar...");
            Console.ReadLine();
        }
        static void CalcularRectangulo()
        {
            double ladoLargo = SolicitarDouble("Ingrese el lado del largo: ");
            double ladoAncho = SolicitarDouble("Ingrese el lado del ancho: ");

            Rectangulo rectangulo = new Rectangulo (ladoLargo, ladoAncho);

            Console.WriteLine($"Área: {rectangulo.Area()}");
            Console.WriteLine($"Perímetro: {rectangulo.Perimetro()}");
            Console.WriteLine("Presione Enter para continuar...");
            Console.ReadLine();
        }

        static void CalcularCuadrado()
        { 
            double lado = SolicitarDouble("Ingrese el lado: ");

            Cuadrado cuadrado = new Cuadrado (lado);

            Console.WriteLine($"Área: {cuadrado.Area()}");
            Console.WriteLine($"Perímetro: {cuadrado.Perimetro()}");
            Console.WriteLine("Presione Enter para continuar...");
            Console.ReadLine();
        }

        static void CalcularTriangulo()
        {
            double lado1 = SolicitarDouble("Ingrese el lado 1: ");
            double lado2 = SolicitarDouble("Ingrese el lado 2: ");
            double lado3 = SolicitarDouble("Ingrese el lado 3: ");

            Triangulo triangulo = new Triangulo(lado1, lado2, lado3);

            Console.WriteLine($"Área: {triangulo.Area()}");
            Console.WriteLine($"Perímetro: {triangulo.Perimetro()}");
            Console.WriteLine("Presione Enter para continuar...");
            Console.ReadLine();
        }

        static void CrearDiagrama() 
        {
            Console.WriteLine("Estas son las formas de tu diagrama de flujo: ");

            Diagrama diagrama = new Diagrama ();
            diagrama.ListarFormas();

            Console.WriteLine($"El area total del diagrama es: {diagrama.CalcularAreaTotal()}");
            Console.WriteLine("Presione Enter para continuar...");
            Console.ReadLine();
        }

        static double SolicitarDouble(string mensaje)
        {
            double resultado;
            Console.Write(mensaje);

            while (!double.TryParse(Console.ReadLine(), out resultado))
            {
                Console.WriteLine("Valor no válido. Por favor, ingrese un número.");
                Console.Write(mensaje);
            }

            return resultado;
        }
    }
}
