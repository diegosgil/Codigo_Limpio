/* 4)En un centro de atención telefónica se atienden N llamadas al día, cada una de ellas tiene una
duración dada en segundos, el cual se compone de dos tiempos, conversación y
documentación. Se dice que si una llamada tiene una duración de cero segundos esta debe ser
contabilizada como un abandono. Se solicita realizar un programa que permita:
a. Conocer la duración promedio de todas las llamadas sin incluir las abandonadas.
b. Saber la cantidad de llamadas abandonadas.
c. Calcular el tiempo total en el estado de conversación y documentación.
d. Indicar la llamada con mayor tiempo en conversación.
e. Indicar la llamada con menor tiempo en documentación.
Ejemplo:
Llamada 1
Duración Total = 60 segundos
Duración Conversación = 40 segundos
Duración Documentación = 20 segundos*/

using System;

namespace punto4TallerLenguajes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese la cantidad de llamadas a contabilizar");
            String n = Console.ReadLine();
            int[] conversacion = new int[int.Parse(n)];
            int[] documentacion = new int[int.Parse(n)];
            String aux;
            for (int i=0; i < int.Parse(n); i++)
            {
                Console.WriteLine("ingrese el tiempo en segundos para la conversación de la llamada {0}", i);
                aux=Console.ReadLine();
                conversacion[i]=int.Parse(aux);
                Console.WriteLine("ingrese el tiempo en segundos para la documentación de la llamada {0}", i);
                aux = Console.ReadLine();
                documentacion[i] = int.Parse(aux);
            }
            int [] suma_total_porLlamada = new int[int.Parse(n)];
            for (int i=0; i<int.Parse(n); i++)
            {
                suma_total_porLlamada[i] += conversacion[i] + documentacion[i];

            }
            int suma_total = 0;
            for (int i = 0; i < int.Parse(n); i++)
            {
                suma_total += suma_total_porLlamada[i];
            }
            int prom = suma_total / (int.Parse(n));
            Console.WriteLine("El promedio por llamada es de {0}", prom);
            int cont_abandono = 0;
            for (int i=0; i<int.Parse(n); i++)
            {
                if (suma_total_porLlamada[i] == 0)
                {
                    cont_abandono += 1;
                }
            }
            Console.WriteLine("el total de llamadas abandonadas es de {0}", cont_abandono);
            int suma_conversacion = 0;
            int suma_documentacion = 0;
            int mayorCo = 0;
            int mayorDO = 0;
            for (int i = 0; i < int.Parse(n); i++)
            {
                suma_conversacion += conversacion[i];
                suma_documentacion += documentacion[i];
                if (conversacion[i] > mayorCo)
                {
                    mayorCo = conversacion[i]; 
                }
                if (documentacion[i] > mayorDO)
                {
                    mayorDO = documentacion[i]; 
                }
            }
            Console.WriteLine("el total de tiempo en conversacion es de {0} segundos", suma_conversacion);
            Console.WriteLine("el total de tiempo para documentacion es de {0} segundos", suma_documentacion);
            Console.WriteLine("el tiempo de conversacion mas larga fue de {0} segundos", mayorCo);
            Console.WriteLine("el tiempo de documentacion mas larga fue de {0} segundos", mayorDO);

        }
    }
}
