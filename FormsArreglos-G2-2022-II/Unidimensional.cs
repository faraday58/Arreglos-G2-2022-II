using System;

namespace FormsArreglos_G2_2022_II
{
    class Unidimensional:Matriz
    {
        private float[] A;

        public Unidimensional(int N)
        {
            this.N = N;
            A = new float[N];
        }

        public static Unidimensional Leer (string A)
        {
            //4,3,5,6
            string[] columnas = A.Split(',');
            Unidimensional aux = new Unidimensional(columnas.Length);
            for( int i=0; i < aux.N;  i++ )
            {
                aux.A[i] = float.Parse(columnas[i]);
            }

            return aux;
        }

        public override string ToString()
        {
            //4,3,5,6  Matriz ingresada
            string A = "";
            for (int i=0; i< N;i++)
            {
                A = A + " " + this.A[i].ToString();
            }
            //4 3 5 6  Matriz devuelta

            return A;
        }


    }
}
