using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class GeraBD
    {
        public int[][] bd;

        public int[][] GeraMatriz()
        {
            // Esse código NAO deve ser alterado, mas pode
            // ver se desejar
            bd = new int[40][];
            for (int i = 0; i < bd.Length; i++)
            {
                bd[i] = new int[40];
            }
            Random produto = new Random();
            Random gaveta = new Random();

            for (int i = 0; i < bd.Length; i++)
            {
                for (int j = 0; j < bd[i].Length; j++)
                {
                    if (gaveta.Next(0, 4) == 0)
                    {
                        bd[i][j] = produto.Next(1, 5);
                    }
                    else
                    {
                        bd[i][j] = 0;
                    }
                }
            }

            return bd;
        }
    }
}
