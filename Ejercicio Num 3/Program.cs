using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ejercicio_num_3
{
    class Recu3
    {
        //3.- Haga un metodo recursivo para remover todos los elementos de un stack 
        //El stack puede tener elementos como lo siguiente : 2,3,6,4,7,j,2,0.1,Tec,23,65,

        public void Ejercicio3()
        {
            
            Stack Stack1 = new Stack(); //Creacion de Stack
            //Agregar valor a cada uno de los datos del Stack
            Stack1.Push("VALOR VISIBLE COMO EJEMPLO"); //Valor que se desplegara en pantalla como un ejemplo de que se eliminaran los otros datos
            //Stack asignado por el profesor para elimniar
            Stack1.Push(2); //---------1
            Stack1.Push(3); //---------2
            Stack1.Push(6); //---------3
            Stack1.Push(4); //---------4
            Stack1.Push(7); //---------5
            Stack1.Push("j"); //---------6
            Stack1.Push(2); //---------7
            Stack1.Push(0.1); //---------8
            Stack1.Push("Tec"); //---------9
            Stack1.Push(23); //---------10
           
            //Eliminacion de datos de del Stack
            for (int X = 0; X < 10; X++) //Se agrega un for con el numero de datos de la lista, en este caso son 10 y por ello se aplica menor que 10
            {
                Stack1.Pop(); //Pop es la extension que se utilizar para la eliminacion
            }
           
            foreach (Object Objeto in Stack1) //Impresion de la lista si se elimina el metodo Pop para eliminacion de ella
            {
                Console.WriteLine(Objeto);
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Recu3 figura1 = new Recu3(); //Creacion del objeto
            figura1.Ejercicio3(); //Ejecucion
            Console.ReadKey(); //Para que no se cierra el programa
        }
    }
}
