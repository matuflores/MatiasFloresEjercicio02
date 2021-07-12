using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatiasFloresEjercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Dadas las medidas informar de que triangulo se trata";

            double lado1, lado2, lado3;

            Console.Write("Ingrese el 1er lado: ");
            lado1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el 2do lado: ");
            lado2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el 3er lado: ");
            lado3 = Convert.ToDouble(Console.ReadLine());

            if (lado1>0 && lado1>0 && lado3>0)
            {
                if (lado1==lado2 && lado2==lado3)
                {
                    Console.WriteLine("El triangulo ingresado es un triangulo EQUILATERO");
                }
                else
                {
                    if (lado1!=lado2 && lado2!=lado3 && lado3!=lado1)
                    {
                        Console.WriteLine("El triangulo ingresado es un triangulo ESCALENO");
                    }
                    else
                    {
                        Console.WriteLine("El triangulo ingresado es un triangulo ISOSCELES");
                    }
                }
            }
            else
            {
                Console.WriteLine("Las medidas ingresadas no son validas");
            }
            Console.ReadLine();
        }
    }
}
