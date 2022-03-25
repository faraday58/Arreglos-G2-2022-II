using System;

namespace FormsArreglos_G2_2022_II
{
    class Multidimensional:Matriz
    {
        private float[,] A;

        public Multidimensional(int M, int N)
        {
            this.M = M;
            this.N = N;
            A = new float[M, N];
        }

        public static Multidimensional Leer(string A  )
        {
            // 1,2,3;4,5,6    2x3

            string[] renglones = A.Split(';');
            // renglones[0] = "1,2,3"
            // renglones[1] = "4,5,6";
            string[] columnas = renglones[0].Split(',');
            // columnas[0]= 1
            // columnas[1]= 2
            // columnas[2]= 3

            Multidimensional matriz = new Multidimensional(renglones.Length, columnas.Length);

            for ( int i=0;  i < matriz.M; i++  )
            {

                columnas = renglones[i].Split(',');
                for ( int j=0; j < matriz.N;  j++   )
                {
                    matriz.A[i, j] = float.Parse(columnas[j]);
                }

            }

            return matriz;
        }


        public static Multidimensional operator +(Multidimensional m1, Multidimensional m2 )
        {
            Multidimensional m3 = new Multidimensional(m1.M, m2.N);

            for( int i=0; i < m3.M; i++  )
            {
                for( int j=0; j < m3.N; j++)
                {
                    m3.A[i, j] = m1.A[i, j] + m2.A[i, j];
                }
            }

            return m3;
        }


        public static Multidimensional operator *(Multidimensional a, Multidimensional b )
        {
            Multidimensional c = new Multidimensional(a.M, b.N);
            for(int i=0;i < a.M; i++ )
            {
                for( int j=0; j < b.N  ; j++ )
                {
                    float sum = 0;//a.N = b.M
                    for(int k=0; k < a.N; k++  )
                    {
                        sum = sum + a.A[i, k] * b.A[k,j ];
                    }
                    c.A[i, j] = sum;
                }
            }
            return c;

        }

        public static Multidimensional operator %( Multidimensional m1, bool radianes  )
        {
            for(int i=0; i < m1.M; i++)
            {
                for( int j=0; j< m1.N; j++)
                {
                    if(  radianes == true )
                    {
                        m1.A[i, j] = (float)Math.Sin(m1.A[i, j]);
                    }
                    else
                    {
                        //Transformando a Radianes
                        m1.A[i, j] = (float)Math.Sin(Math.PI*m1.A[i, j]/180);
                    }
                    
                }
            }
            return m1;

        }


        public override string ToString()
        {
            // 1 2 3
            // 4 5 6
            string A="";
            string Auxf = "";
            for( int i=0; i< M; i ++  )
            {
                for ( int j =0; j< N; j++)
                {
                    Auxf = String.Format("{0:f3}",this.A[i,j]);
                    //  A = A + " " + this.A[i, j].ToString(); // 1 2 3 
                    A = A + " " + Auxf;
                }
                A = A + "\n";

            }

            return A;
        }
    }
}
