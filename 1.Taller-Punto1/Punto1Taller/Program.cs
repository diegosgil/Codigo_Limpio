/*1) En la Compañía OBDC necesitan un líder administrativo, para elegirlo se realizarán tres 
 * pruebas con un valor ponderado del 35%, 30% y 35%, respectivamente. Por cada uno de los 
 * 40 participantes en el proceso, se informa el número de identificación, el nombre y los 
 * resultados de cada una de las tres pruebas. 
 * Hacer un programa que muestre el resultado final de cada participante y el nombre y número 
 * de identificación de la persona que obtiene el mayor puntaje.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1Taller
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();  
            String[] nombre = new String[3];
            int[] identificacion = new int[nombre.Length];  //Crea un vector tipo double que se llama prueba 1 y le va crear uno nuevo double de 3 posiciones
            double[] prueba1 = new double[nombre.Length];   //Crea un vector tipo double que se llama prueba 1 y le va crear uno nuevo double de 3 posiciones
            double[] prueba2 = new double[nombre.Length];
            double[] prueba3 = new double[nombre.Length];
            double[] resultadosPruebas = new double[nombre.Length];


            for (int i = 0; i < nombre.Length; i++)
            {
                prueba1[i] = rnd.Next(1, 10);   //Prueba1 es un vector en la posicion i es igual a rnd que es el objeto de ramdon y esta llamando al metodo Next y le pasa dos atributos 1=limite inferior y 10=limite superior
                prueba2[i] = rnd.Next(1, 10);
                prueba3[i] = rnd.Next(1, 10);
                Console.WriteLine("Ingrese la identificacion: ");
                String aux = Console.ReadLine();
                identificacion[i] = int.Parse(aux); //identificacion en la posicion i es igual a lo que ingreso en la variable auxiliar
                Console.WriteLine("Ingrese el nombre: ");
                nombre[i] = (Console.ReadLine());
            }
            for (int i = 0; i < nombre.Length; i++) //la variable i empieza en cero; y termina hasta 1 menor que la posicion nombre
            {
                prueba1[i] = prueba1[i] * 0.35;    
                prueba2[i] = prueba2[i] * 0.3;
                prueba3[i] = prueba3[i] * 0.35;
            }
            for (int i = 0; i < nombre.Length; i++)
            {
                resultadosPruebas[i] = prueba1[i] + prueba2[i] + prueba3[i];
            }
            double pruebaMayor = 0.0;
            int posicion = 0;
            for (int i = 0; i < nombre.Length; i++)
            {
                if (resultadosPruebas[i] > pruebaMayor) //Si resultadosPrueba en la posicion i es mayor que pruebaMayor
                {
                    pruebaMayor = resultadosPruebas[i]; //entonces pruebaMayor sera igual a resultadorPruebas en la posicion i
                    posicion = i;   // y se guarda en la posicion de ese resultado (la posicion i se guardara en la variable posicion)
                }
            }
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine("El nombre es {0} y su identificación es {1} y su puntaje es {2}", nombre[i], identificacion[i], resultadosPruebas[i]);
                Console.ReadKey();
            }
            Console.WriteLine("El nombre {0} con identificación {1} con mayor puntaje fue de {2}", nombre[posicion], identificacion[posicion], pruebaMayor);
            Console.ReadKey();
        }
    }
}
