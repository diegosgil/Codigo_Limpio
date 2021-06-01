/*2) La Secretaría de Salud de la ciudad de Medellín desea utilizar los datos recolectados, durante el mes de 
 * enero, de las diferentes clínicas y hospitales de la ciudad para analizar las instituciones con mejor manejo 
 * de los pacientes con COVID-19. Por cada una de las 22 instituciones se pide el nombre, el total de pacientes 
 *con COVID-19, total de recuperados, total de camas de UCI y total de camas de UCI ocupadas.
Los resultados estadísticos que pide la Secretaría de Salud son:
a. Institución de salud con mayor número de recuperados.
b. Total de camas UCI disponibles.
c. Institución de salud con mayor número de camas disponibles.
d. Total de pacientes recuperados.*/

using System;

namespace tallerLenguajes
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            String[] nombres = new String[4];
            int[] pacientes = new int[nombres.Length];
            int[] recuperados = new int[nombres.Length];
            int[] camas = new int[nombres.Length];
            int[] camasOcu = new int[nombres.Length];
            String aux;
            bool entrada = true;
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("ingrese el nombre del hospital" + i);
                nombres[i] = Console.ReadLine();
                Console.WriteLine("ingrese el total de pacientes con covid-19 para el hospital " + nombres[i]);
                aux = Console.ReadLine();
                pacientes[i] = int.Parse(aux);
                Console.WriteLine("ingrese el total de recuperados de covid-19 para el hospital " + nombres[i]);
                aux = Console.ReadLine();
                recuperados[i] = int.Parse(aux);
                Console.WriteLine("ingrese el total de camas para el hospital " + nombres[i]);
                aux = Console.ReadLine();
                camas[i] = int.Parse(aux);
                do
                {
                    Console.WriteLine("ingrese el total de camas ocupadas para el hospital " + nombres[i]);
                    aux = Console.ReadLine();
                    camasOcu[i] = int.Parse(aux);
                    if (camasOcu[i] > camas[i])
                    {
                        Console.WriteLine("el total de camas no puede ser menor a total de camas ocupadas");
                    }
                    else
                    {
                        entrada = false;
                    }
                }
                while (entrada);
            }
            int mayor_recuperados = 0;
            int pos_mayor = 0;
            for (int i = 0; i < recuperados.Length; i++)
            {
                if (recuperados[i] > mayor_recuperados)
                {
                    mayor_recuperados = recuperados[i];
                    pos_mayor = i;
                }
            }
            Console.WriteLine("El hospital con mayor numero de recuperados es {0} ", nombres[pos_mayor]);
            int total_camas = 0;
            for (int i = 0; i < camas.Length; i++)
            {
                total_camas += camas[i];
            }
            Console.WriteLine("el total de camas UCI disponibles es {0}", total_camas);
            int[] camas_dispo = new int[nombres.Length];
            for (int i = 0; i < camas.Length; i++)
            {
                camas_dispo[i] = camas[i] - camasOcu[i];
            }
            int mayor_camas = 0;
            int pos_mayor2 = 0;
            for (int i = 0; i < camas_dispo.Length; i++)
            {
                if (camas_dispo[i] > mayor_camas)
                {
                    mayor_camas = camas_dispo[i];
                    pos_mayor2 = i;
                }
            }
            Console.WriteLine("el hospital con mayor numero de camas disponibles es {0}", nombres[pos_mayor]);
            int total_pacientes = 0;
            for (int i = 0; i < recuperados.Length; i++)
            {
                total_pacientes += recuperados[i];
            }
            Console.WriteLine("El total de pacientes recuperados es {0}", total_pacientes);
        }
    }
}