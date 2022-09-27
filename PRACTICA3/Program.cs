using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Hacer un programa que calcule el permietro de cualquier poligono*/

            string numerolados, numerocm;
            int  numero1, numero2, resultado;

            //pedir datos a capturar//
            Console.Write("Cual es la cantidad de lados de tu poligono?");
            numerolados = Console.ReadLine();
            //covertir la cadena int a string
            numero1 = Convert.ToInt32(numerolados);

            // pedir centimetros del lado del poligono//
            Console.Write("Cual es la medida en centrimetros de tu poligono?");
            numerocm = Console.ReadLine();
            //covertir la cadena int a string
            numero2 = Convert.ToInt32(numerocm);

            //resultado//
            resultado = numero1 * numero2;

            //mostrar resultado//
            Console.WriteLine("el perimetro del poligono es: {0} centimetros :D", resultado);




        }
    }
}
