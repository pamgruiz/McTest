using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace Problem2
{
    class Program
    {
        // circularArrayRotation function created by Pamela Goncalves

        public static List<int> circularArrayRotation(int[] a, int k, int[] queries)
        {
            int[] temp = new int[a.Length];
            List<int> result = new List<int>();

            for (int i = 0; i < a.Length; i++)
            {
                temp[(i + k) % a.Length] = a[i];
            }

            for (int i = 0; i < queries.Length; i++)
            {
                result.Add(temp[queries[i]]);
            }
            return result;
        }



        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter("OUTPUT2.TXT", true);

            string[] nkq = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nkq[0]);

            int k = Convert.ToInt32(nkq[1]);

            int q = Convert.ToInt32(nkq[2]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;

            int[] queries = new int[q];

            for (int i = 0; i < q; i++)
            {
                int queriesItem = Convert.ToInt32(Console.ReadLine());
                queries[i] = queriesItem;
            }

            List<int> result = circularArrayRotation(a, k, queries);

            textWriter.WriteLine(string.Join("\n", result));

            textWriter.Flush();
            textWriter.Close();
        }

    }
}
