using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Print2DArray(int[,] arrayToPrint )
        {
            
            char[] chars = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };
            Console.WriteLine("  1 2 3 4 5 6 7 8 9 10");
            for (int i = 0; i < arrayToPrint.GetLength(0); i++)
            {
                Console.Write(chars[i] + " ");



                for (int j = 0; j < arrayToPrint.GetLength(1); j++)
                {

                    Console.Write(arrayToPrint[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void Reset2DArray(int[,] arrayToReset)
        {
            for (int i = 0; i < arrayToReset.GetLength(0); i++)
            {
                for (int j = 0; j < arrayToReset.GetLength(1); j++)
                {
                    arrayToReset[i, j] = i * 0 + j * 0;
                }
            }
        }
        static void PrintRules()
        {
            Console.WriteLine("PRAVIDLA PRO HRU LODE");
            Console.WriteLine("Pole velikosti 10x10 poli, kdy svisle hodnoty jsou oznaceny pismeny a-j, vodorovne hodnoty cisly 1-10");
            
        }

        static void Main(string[] args)
        {
            int[,] array = new int[10, 10];
            Reset2DArray(array);
            Print2DArray(array);
            PrintRules();






            string input = Console.ReadLine();
            char firstChar = input[0];
            List<char> rows = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', };
            int index = rows.IndexOf(firstChar);



            Console.ReadKey();

        }
    }
    
}
