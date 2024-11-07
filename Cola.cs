using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCola
{
    internal class Cola
    {
        private Nodo inicio;
        private int count = 0;
        private int MAX;

        public Cola(int max)
        {
            MAX = max;
            inicio = null;
        }

        private bool underflow()
        {
            if (inicio == null)
                return true;
            else
                return false;
        }

        private bool overflow()
        {
            if (count == MAX)
                return true;
            else
                return false;
        }

        public void Print()
        {
            if (underflow())
            {
                Console.WriteLine("La cola esta vacia");
                Console.WriteLine("");
                Console.WriteLine("");
            }
            else
            {
                Nodo actual = inicio;

                while (actual != null)
                {
                    Console.Write($"--- {actual.Valor} ---> ");
                    actual = actual.Sig;

                }
                Console.WriteLine("");
                Console.WriteLine("");
            }
        }

        public int Count()
        {
            return count;    
        }
        
        public bool Insert(int num)
        {
            if (overflow())
            {
                Console.WriteLine("La cola esta llena");
                Console.WriteLine("");
                return false;
            }

            Nodo nuevo = new Nodo(num);
            
            if (underflow())
            {
                inicio = nuevo;
            } 
            
            else
            {
                Nodo actual = inicio;
                while(actual.Sig != null)
                {
                    actual = actual.Sig;
                }
                actual.Sig = nuevo;
            }
            count++;
            return true;

            //regresa true al insertar exitosamente
            //false si la cola esta llena y no se pudo insertar
        }
        
        public int Extract()
        {
            if (underflow())
            {
                Console.WriteLine("No pudo ser extraido, cola vacia");
                return -1;
            }

            int ValorExtraido = inicio.Valor;
            inicio = inicio.Sig;
            count--;

            Console.WriteLine($"El numero sacado de la cola : {ValorExtraido}");

            return ValorExtraido;
            
            //regresa el valor extraido de la cola
            //si esta vacia regresa -1 porque no pudo extraer
        }
    }
}
