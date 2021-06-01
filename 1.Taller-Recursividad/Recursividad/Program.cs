using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividad
{
    class Program
    {
        static int Potencia(int bas, int exponente)
        {
            //Caso base
            if (exponente == 0)
            {
                return 1;
            }
            //Caso general
            return bas * Potencia(bas, exponente - 1);            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Siendo base 4^3 el resultado usando recursividad es: " + Potencia(4, 3));
            Console.WriteLine("\n Integrantes: \n -Emanuel Rico Ruiz \n -Juan Jose Aranzales Ochoa \n -Juan Diego Salazar Gil ");
            Console.ReadKey();
        }
    }
}
