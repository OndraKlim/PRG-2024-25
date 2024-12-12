using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2024-2025.
 * Extended by students.
 */

namespace _2D_Array_Playground
{
    internal class Program
    {
        static void Print2DArray(int[,] arrayToPrint)
        {
            for (int i = 0; i < arrayToPrint.GetLength(0); i++)
            {
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
                    arrayToReset[i, j] = i * 5 + j + 1;
                }
            }
        }

        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové 2D pole velikosti 5 x 5, naplň ho čísly od 1 do 25 a vypiš ho do konzole (5 řádků po 5 číslech).

            int[,] array = new int[5, 5];
            Reset2DArray(array);
            Print2DArray(array);
            //TODO 2: Vypiš do konzole n-tý řádek pole, kde n určuje proměnná nRow.
            int nRow = 0;

            //TODO 3: Vypiš do konzole n-tý sloupec pole, kde n určuje proměnná nColumn.
            int nColumn = 0;

            //TODO 4: Prohoď prvek na souřadnicích [xFirst, yFirst] s prvkem na souřadnicích [xSecond, ySecond] a vypiš celé pole do konzole po prohození.
            //Nápověda: Budeš potřebovat proměnnou navíc, do které si uložíš první z prvků před tím, než ho přepíšeš druhým, abys hodnotou prvního prvku potom mohl přepsat druhý
            int xFirst, yFirst, xSecond, ySecond;

            //TODO 5: Prohoď n-tý řádek v poli s m-tým řádkem (n je dáno proměnnou nRowSwap, m mRowSwap) a vypiš celé pole do konzole po prohození.
            int nRowSwap = 0;
            int mRowSwap = 1;

            //TODO 6: Prohoď n-tý sloupec v poli s m-tým sloupcem (n je dáno proměnnou nColSwap, m mColSwap) a vypiš celé pole do konzole po prohození.
            int nColSwap = 0;
            int mColSwap = 1;

            //TODO 7: Otoč pořadí prvků na hlavní diagonále (z levého horního rohu do pravého dolního rohu) a vypiš celé pole do konzole po otočení.

            Console.WriteLine("Prohozeni hodnot na hlavni diagonale");
            Reset2DArray (array);
            for (int i = 0; i < array.GetLength(1)/2; i++)
            {
                int secondCoord = array.GetLength(1) - 1 - i;
                int temporary = array[i, i];
                array[i, i] = array [secondCoord, secondCoord];
                array[secondCoord, secondCoord] = temporary;
            }
            Print2DArray(array);

            //TODO 8: Otoč pořadí prvků na vedlejší diagonále (z pravého horního rohu do levého dolního rohu) a vypiš celé pole do konzole po otočení.

            Console.WriteLine("Prohozeni hodnot na hlavni diagonale");
            for (int i = 0; i < array.GetLength(1) / 2; i++)
            {
                int secondCoord = array.GetLength(1) - 1 - i;
                int temporary = array[i, secondCoord];
                array[i, secondCoord] = array [secondCoord, i];
                array[secondCoord, i] = temporary;
            }
            Print2DArray (array);

            Console.ReadKey();
        }
    }
}
