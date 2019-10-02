using System;

namespace exeMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];
            for(int i = 0; i < n; i++)
            {
                string linha = Console.ReadLine();
                string[] li  = linha.Split(' ');
                for(int j = 0; j < n; j++){
                    mat[i, j] = int.Parse(li[j]);
                }
            }

            int cont = 0;
            Console.WriteLine("--------------------------------");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < n; j++)
                {
                    if(mat[i,j] <= 0)
                    {
                        cont++;
                    }
                    Console.Write(mat[i,j]+" ");
                }
            }
            Console.WriteLine();
            Console.Write("Diagonal : ");
            for(int k = 0; k < n; k++)
            {
                Console.Write(mat[k,k] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("quantidade de numeros negativos : " + cont);




        }
    }
}
