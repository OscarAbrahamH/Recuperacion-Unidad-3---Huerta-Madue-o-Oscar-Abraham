using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Collections.Concurrent;

namespace Ejercicio_Num_1
{

    //1.- Implementa la el metodo clone() de ArrayList de la siguiente lista (2,3,4,7.5,4,H,U,J,67,23,9,80) creando una lista nueva.

    class Recu3
    {
        public static void ImprimirValores(IEnumerable Coleccion, char Separador) //Metodo para imprimir la lista clonada
        {
            foreach (Object obj in Coleccion)
            Console.Write("{0}{1}", Separador, obj);
            Console.WriteLine();
        }

        public void Ejercicio1()
        {
            ArrayList Lista = new ArrayList(); //Creacion de la lista original
            ArrayList Copia = new ArrayList(); //Creacion de la lista donde se pasaran los datos originales
            //Se le asignarn valores a los datos de lista, en este caso asignados por el profesor ya predefinidos
            Lista.Add(2); //Valor 1
            Lista.Add(3); //Valor 2
            Lista.Add(4); //Valor 3
            Lista.Add(7.5); //Valor 4
            Lista.Add("H"); //Valor 5
            Lista.Add("U"); //Valor 6
            Lista.Add("J"); //Valor 7
            Lista.Add(67); //Valor 8
            Lista.Add(23); //Valor 9
            Lista.Add(9); //Valor 10
            Lista.Add(80); //Valor 11
            Console.WriteLine("Lista clonada: ");
            Copia = (ArrayList)Lista.Clone(); //Se almacenan los datos en la lista "Copia" con la extension Clone() de esta forma
            //DATO: Si se elimina la linea de codigo de la parte de arriba, no se desplegara nada en consola...
            ImprimirValores(Copia, '\n'); //Se imprime la lista "Copia" donde se guardaron los datos de la lista "Lista"

            Console.ReadKey(); //Para que no se cierre el programita:(
         
        }


        static void Main(string[] args)
        {
            Recu3 figura1 = new Recu3(); //Creacion de objeto
            figura1.Ejercicio1(); //Ejecucion
        }
    }
}
