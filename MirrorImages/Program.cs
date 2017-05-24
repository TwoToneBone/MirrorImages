using System;
using System.Collections.Generic;
using System.Linq;

namespace MirrorImages
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            List<List<string>> outputs = new List<List<string>>();

            for (int i = 0; i < t; i++)
            {
                List<string> inputs = new List<string>();
                int[] rowsAndCols = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);

                for (int j = 0; j < rowsAndCols[0]; j++)
                {
                    inputs.Add(new string(Console.ReadLine().Reverse().ToArray()));
                }

                inputs.Add($"Test {i + 1}");
                outputs.Add(inputs);                
            }

            foreach (var list in outputs)
            {
                for (int i = list.Count() - 1; i >= 0; i--)
                {
                    Console.WriteLine(list[i]);
                }
            }
        }
    }
}
