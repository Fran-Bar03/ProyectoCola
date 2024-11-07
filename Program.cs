using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cola micola = null;
            int op = 0;
            do
            {
                Console.WriteLine("|-----------------------------------|");
                Console.WriteLine("|--------- PROYECTO COLA ----------|");
                Console.WriteLine("|-----------------------------------|");
                Console.WriteLine("");
                Console.WriteLine("1.Insertar tamaño");
                Console.WriteLine("2.Insert");
                Console.WriteLine("3.Extract");
                Console.WriteLine("4.Count");
                Console.WriteLine("5.Imprimir");
                Console.WriteLine("6.Salir");
                Console.WriteLine("");
                Console.WriteLine("Seleccionar opcion =>");
                op = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("");


                switch (op)
                {
                    case 1:
                        Console.WriteLine("Dame el numero a insertar");
                        int max = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("");
                        if (max > 0)
                        {
                            micola = new Cola(max);
                        }
                        else
                        {
                            Console.WriteLine("Introduzca un tamaño de cola mayor");
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }
                        break;


                    case 2:
                        if (micola == null)
                        {
                            Console.WriteLine("Introduzca un tamaño de cola primero");
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("Ingrese el numero a insertar");
                            int num = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("");
                            Console.WriteLine("");
                            micola.Insert(num);
                        }
                        break;


                    case 3:
                        if (micola == null)
                        {
                            Console.WriteLine("Introduzca un tamaño de cola primero");
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }
                        else
                        {
                            micola.Extract();
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }
                        break;


                    case 4:
                        if (micola == null)
                        {
                           Console.WriteLine("Introduzca un tamaño de cola primero");
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }

                        else if(micola.Count() == 0) 
                        {
                            Console.WriteLine("La cola está vacía");
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine($"La cola tiene {micola.Count()} nodos");
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }
                        break;

                    case 5:
                        if (micola == null)
                        {
                            Console.WriteLine("Introduzca un tamaño de cola primero");
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }
                        else
                        {
                            micola.Print();
                        }
                        break;


                    case 6:
                        Console.WriteLine("Saliendo.....");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        break;

                    default:
                        Console.WriteLine("Introduzca una opcion valida");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        break;
                }
            } while (op != 6);
        }
    }
}
