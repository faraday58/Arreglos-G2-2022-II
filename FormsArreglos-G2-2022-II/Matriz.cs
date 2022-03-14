using System;

namespace FormsArreglos_G2_2022_II
{
    class Matriz
    {
        private int n;
        private int m;
//        private int[] A;
/*
        public Matriz(int n)
        {
            N= n ;
            A = new int[N];            
        }
*/
        #region Propiedades
        public int N { 
            get => n;
            set {
                if( value < 2)
                {
                    n = 2;
                }
                else
                {
                    n = value;
                }                
            }
        }

        public int M { get => m;
            set
            {
                if(value < 2)
                {
                    n = 2;
                }
                else
                {
                    m = value;
                }
                
            }
        }
        #endregion
        /*   public static Matriz Leer(string A)
           {
               // 1,3,6,7

               string [] columnas = A.Split(',');
               Matriz m1 = new Matriz(columnas.Length);


           }
        */
        /*
                public static Matriz operator +(Matriz m1,Matriz m2  )
                {
                    Matriz aux =  new Matriz(m1.N);
                    for(int i =0; i < aux.N; i++ )
                    {
                        aux.A[i] = m1.A[i] + m2.A[i];
                    }

                    return aux;

                }
        */
    }
}
