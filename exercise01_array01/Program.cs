﻿/*
 * C# program to convert a 2d array into an 1d array
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace exercise01_array01
{
    class twodmatrix
        /* Create a class for the 2d matrix */
    {
        int m, n;
        int[,] a;
        int[] b;
        twodmatrix(int x,int y)
            /* constructor */
        {
            m = x;
            n = y;
            a = new int[m, n];
            b = new int[m * n];
        }
        public void readmatrix()
            /* method 01 */
        {
            for (int i = 0; i < m; i++)
            {
                for ( int j = 0; j < n; j++)
                {
                    Console.WriteLine("Element @ a[{0},{1}]=", i, j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public void printd()
            /* method 02 */
        {
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", a[i, j]);
                }
                Console.Write("\n");
            }
        }
        public void convert()
            /* method 03 */
        {
            int k = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    b[k++] = a[i, j];
                }
            }
        }
        public void printoned()
            /* method 94 */
        {
            for(int i = 0; i < m * n; i++)
            {
                //Console.WriteLine("{0}\t", b[i]);
                Console.Write("{0}\t", b[i]);
            }
        }
        public static void Main(string[] args)
            /* MAIN */
        {
            twodmatrix obj = new twodmatrix(2, 3);
            Console.WriteLine("Enter the elements : ");
            obj.readmatrix();
            Console.WriteLine("\t\t Given 2-D Array(Matrix) is : ");
            obj.printd();
            obj.convert();
            Console.WriteLine("\t\t Converted 1-D Array is : ");
            obj.printoned();
            Console.ReadLine();
        }
    }
}
