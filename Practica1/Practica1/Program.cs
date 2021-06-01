using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Program
    {
        static public List<Benefactor> Benefac = new List<Benefactor>();
        static public List<Familia> Family = new List<Familia>();

        static void Main(string[] args)
        {
            Fundacion fundaAnhelos = new Fundacion("2056001900-1", "Anhelos", 0);
            fundaAnhelos.imprimirFundacion();

            int opcion = 0;
            int menu()
            {
                Console.WriteLine("\n----MENÚ----");
                Console.WriteLine("1. Deseas donar dinero");
                Console.WriteLine("2. Entregar dinero a las familias");
                Console.WriteLine("3. Registrar benefactor");
                Console.WriteLine("4. Registrar familia");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opcion: ");
                Console.Write("");
                opcion = Convert.ToInt32(Console.ReadLine());

                return opcion;
            }

            while (opcion != 5)
            {
                opcion = menu();
                switch (opcion)
                {
                    case 1:
                        Console.Write("\n¿Cuanto dinero deseas depositar? : ");
                        string aux1 = Console.ReadLine();
                        int donacionBene = int.Parse(aux1);
                        if (donacionBene > 0)
                        {
                            fundaAnhelos.DonativoBenefactor(donacionBene);
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine("Depositaste el valor de ${0}", donacionBene);
                            Console.WriteLine("Tu saldo actual es ${0} espero sigas donando c:", fundaAnhelos.SaldoFundacion);
                            Console.WriteLine("--------------------------------------------");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("El saldo a ingresar debe ser positivo");
                            break;
                        }

                    case 2:
                        Console.Write("\n¿Que monto deseas retirar? : ");
                        string aux2 = Console.ReadLine();
                        int montoRetirado = int.Parse(aux2);

                        if (montoRetirado <= fundaAnhelos.SaldoFundacion)
                        {
                            fundaAnhelos.ayudaFamilia(montoRetirado);
                            Console.WriteLine("--------------------------------------------");
                            Console.WriteLine("Retiraste el valor de ${0}", montoRetirado);
                            Console.WriteLine("Tu saldo actual es ${0}", fundaAnhelos.SaldoFundacion);
                            Console.WriteLine("--------------------------------------------");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Saldo insuficiente");
                            Console.WriteLine("Tu saldo actual es ${0}", fundaAnhelos.SaldoFundacion);
                            break;
                        }
                        
                    case 3:
                        Console.Write("\n¿Cuantos benefactores deseas registrar?: ");
                        int numBenefactores = Convert.ToInt32(Console.ReadLine());
                        for (int contB = 0; contB < numBenefactores; contB++)
                        {
                            Console.Write("Ingresa identificacion: ");
                            string idBene = Console.ReadLine();
                            Console.Write("Ingresa nombre: ");
                            string nombreBene = Console.ReadLine();
                            Console.Write("Ingresa el valor de ayuda: ");
                            int valorAyudaBene = Convert.ToInt32(Console.ReadLine());
                            Benefactor agregarBenefac = new Benefactor(idBene, nombreBene, valorAyudaBene);
                            Benefac.Add(agregarBenefac);
                            fundaAnhelos.DonativoBenefactor(valorAyudaBene);
                        }
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("Benefactores registrados: {0}", Benefac.Count);
                        Console.WriteLine("Tu saldo actual es ${0}", fundaAnhelos.SaldoFundacion);
                        Console.WriteLine("--------------------------------------------");
                        break;

                    case 4:
                        Console.Write("¿Cuantas familias deseas registrar: ");
                        int numFamilias = Convert.ToInt32(Console.ReadLine());
                        for (int contF = 0; contF < numFamilias; contF++)
                        {
                            Console.Write("Ingrese identificacion: ");
                            string idFam = Console.ReadLine();
                            Console.Write("Ingrese nombre: ");
                            string nomFam = Console.ReadLine();
                            Console.Write("Ingresa apellido: ");
                            string apelliFam = Console.ReadLine();
                            Console.Write("Ingresa direccion: ");
                            string dirFam = Console.ReadLine();
                            Console.Write("Ingresa estrato: ");
                            int estratoFam = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Ingresa barrio: ");
                            string barrioFam = Console.ReadLine();
                            Console.Write("Ingresa edad: ");
                            int edadFam = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Ayuda economica brindada: ");
                            int ayudaFam = Convert.ToInt32(Console.ReadLine());
                            if (fundaAnhelos.SaldoFundacion == 0 || fundaAnhelos.SaldoFundacion < ayudaFam)
                            {
                                Console.WriteLine("--------------------------------------------");
                                Console.WriteLine("Fondo insuficiente para la familia");
                                Familia agregarFamilia = new Familia(idFam, nomFam, apelliFam,
                                    dirFam, estratoFam, barrioFam, edadFam, 0);
                                Family.Add(agregarFamilia);
                                fundaAnhelos.ayudaFamilia(0);
                            }
                            else
                            {
                                Familia agregarFamilia = new Familia(idFam, nomFam, apelliFam,
                                    dirFam, estratoFam, barrioFam, edadFam, ayudaFam);
                                Family.Add(agregarFamilia);
                                fundaAnhelos.ayudaFamilia(ayudaFam);
                            }

                        }
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("Familias registrados: {0}", Family.Count);
                        Console.WriteLine("Tu saldo actual es ${0}", fundaAnhelos.SaldoFundacion);
                        Console.WriteLine("--------------------------------------------");
                        break;

                    default:
                        Console.WriteLine("La opcion ingresada no es valida");
                        break;
                }
            }
        }
    }
}

