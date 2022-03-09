using System;

namespace Arreglos_G2_2022_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrEnteros= new int[10];
            //int var = 10;

            //for(int i=0; i < 10 ; i++ )
            for (int i = 0; i < arrEnteros.Length; i++)
            {
                Console.Write(" {0} ", arrEnteros[i] );
            }
            Console.WriteLine("\n *******************Arreglo relleno de valores aleatorios************");
            Random aleatorio = new Random();
            
            for(int i=0; i < arrEnteros.Length/2; i++  )
            {
                //arrEnteros[i] = aleatorio.Next(); Genera un número aleatorio de 32 bits
                arrEnteros[i] = aleatorio.Next(0,20);//Genera un número aleatorio entre 0 y 20
                Console.Write(" {0}", arrEnteros[i]);
            }
            Console.WriteLine("\n *******************Arreglo relleno de valores constantes************");

            float[] arrFloat = { 2.2f, 3.3f, 4.4f };
            for (int i=0; i< arrFloat.Length; i++)
            {
                Console.Write(" {0} ",arrFloat[i]);
            }

            Console.WriteLine("\n *******************Arreglo de valores ordenados***********");
            Array.Sort(arrEnteros); //Ordenando de manera ascendente

            for (int i = 0; i < arrEnteros.Length; i++)
            {              
                Console.Write(" {0}", arrEnteros[i]);
            }
            Console.WriteLine("\n *******************Arreglo de valores en orden inverso***********");
            Array.Reverse(arrEnteros);
            foreach(int entero in arrEnteros  )
            {
                Console.Write(" {0} ",entero );
            }





            //Console.WriteLine(arrEnteros.ToString()); Esto solamente muestra el tipo de dato del arreglo
            Console.ReadLine();
        }
    }
}
