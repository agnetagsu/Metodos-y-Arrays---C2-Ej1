using System;

namespace Metodos_y_Arrays___C2_Ej1
{
    class CalculaArea
    {
        public double circulo()
        {
            Console.WriteLine("Introduce el radio:");
            double radio = Convert.ToDouble(Console.ReadLine());
            return radio * radio * Math.PI;
        }
        public double triangulo()
        {
            Console.WriteLine("Introduce la base:");
            double labase = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce la altura:");
            double altura = Convert.ToDouble(Console.ReadLine());

            return (labase * altura)/2;
        }
        public double cuadrado()
        {
            Console.WriteLine("Introduce el lado:");
            double lado = Convert.ToDouble(Console.ReadLine());
           
            return (lado * lado);
        }
        static void Main(string[] args)
        {
            CalculaArea Area = new CalculaArea();
            Console.WriteLine("¿Para qué figura desea calcular el área? circulo, triangulo o cuadrado");

            string figura = Console.ReadLine();

            switch (figura)
            {
                case "circulo":
                    Console.WriteLine(Area.circulo());
                    break;
                case "triangulo":
                    Console.WriteLine(Area.triangulo());
                    break;
                case "cuadrado":
                    Console.WriteLine(Area.cuadrado());
                    break;

                default:
                    Console.WriteLine("Figura no permitida");
                    break;
            }

        }
    }
}
