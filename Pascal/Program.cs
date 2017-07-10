using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("triangle lenght ");
            pascalTriangle(int.Parse(Console.ReadLine()) );
            Console.ReadLine();
        }
        static void pascalTriangle(int k)
        {
            var values = new int[] {};
            pascal(k,values);

        }
        static void pascal(int current , int[] values )
        {
            int[] nextRow = new int[values.Length + 1];
            nextRow[0] = 1;
            for (int i = 1; i < values.Length; i++)
            {
                nextRow[i] = values[i - 1] + values[i];
            }
            nextRow[nextRow.Length - 1] = 1;
            foreach (var number in nextRow)
            {
                Console.Write(number);
            }
            Console.WriteLine();
            if (current > 1)
                pascal(current - 1, nextRow);
        }
    }
}
