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


namespace Problem3
{
    class Result
    {

        //Coded and Tested by Pamela Goncalves
        public static int pickingNumbers(List<int> a)
        {
            int[] arr = a.ToArray();
            int max = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                int temp = 0;
                Array.Sort(arr);
                for(int j = i; j < arr.Length; j++)
                {
                    if (Math.Abs(arr[i] - arr[j]) <= 1)
                        temp++;
                    else
                        break;
                }
                if(temp>max)
                {
                    max = temp;
                }
            }
            return max;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter("OUTPUT3.TXT", true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = Result.pickingNumbers(a);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}
