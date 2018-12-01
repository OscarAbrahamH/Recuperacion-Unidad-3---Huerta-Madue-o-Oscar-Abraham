using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recu3
{
    //Que valores retornara durante la siguiente secuencia de operaciones de cola, si se 
    //ejecuta sobre una cola inicialmente vacia, enqueue(5), enqueue(3), dequeue(),enqueue(2),
    //enqueue(8), dequeue(), dequeue(), enqueue(9), enqueue(1),
    //dequeue(), enqueue(7), enqueue(6), dequeue(), dequeue(), enqueue(4),dequeue(), dequeue()

    class Recuperacion
    {
        public void Ejercicio2()
        {
            Queue Cola = new Queue(); //Creacion de la Cola
           
            Console.WriteLine("Valores que retornara: ");
            Cola.Enqueue(5); //Imprime el valor #1
            Cola.Enqueue(3); //Imprime el valor #2
            Console.Write(Cola.Dequeue() + "\t"); // Cola #1 inicialmente vacia
            Cola.Enqueue(2); //Imprime el valor #3
            Cola.Enqueue(8); //Imprime el valor #4
            Console.Write(Cola.Dequeue() + "\t"); // Cola #2 inicialmente vacia
            Console.Write(Cola.Dequeue() + "\t"); // Cola #3 inicialmente vacia
            Cola.Enqueue(9); //Imprime el valor #5
            Cola.Enqueue(1); //Imprime el valor #6
            Console.Write(Cola.Dequeue() + "\t"); // Cola #4 inicialmente vacia
            Cola.Enqueue(7); //Imprime el valor #7
            Cola.Enqueue(6); //Imprime el valor #8
            Console.Write(Cola.Dequeue() + "\t"); // Cola #5 inicialmente vacia
            Console.Write(Cola.Dequeue() + "\t"); // Cola #6 inicialmente vacia
            Cola.Enqueue(4); //Imprime el valor #9
            Console.Write(Cola.Dequeue() + "\t"); // Cola #7 inicialmente vacia
            Console.Write(Cola.Dequeue() + "\t"); // Cola #8 inicialmente vacia
        }

        static void Main(string[] args)
        {
            Recuperacion figura1 = new Recuperacion(); //Creacion del objeto
            figura1.Ejercicio2(); //Ejecutar
            Console.ReadKey();
        }
    }
}
