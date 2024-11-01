using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2024-2025.
 * Extended by students.
 */

namespace ArrayPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové pole a naplň ho pěti libovolnými čísly.
            int[] myArray = { 10, 20, 30, 40, 50 };


            //TODO 2: Vypiš do konzole všechny prvky pole, zkus jak klasický for, kde i využiješ jako index v poli, tak foreach.
            Console.WriteLine("vypisovani for cyklem");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.WriteLine("vypisovani foreach cyklem");
            foreach (int number in myArray)
            {
                Console.WriteLine(number);
            }
            //TODO 3: Spočti sumu všech prvků v poli a vypiš ji uživateli.
            int sum = 0;
            Console.WriteLine("suma pomoci for cyklu");
            for (int i = 0; i < myArray.Length; i++)
            {
                sum = sum + myArray[i];
            }
            Console.WriteLine("soucet je " + sum);

            Console.WriteLine("suma pomoci jednoradkoveho zapisu");
            sum = myArray.Sum();
            Console.WriteLine("soucet je " + sum);

            //TODO 4: Spočti průměr prvků v poli a vypiš ho do konzole.
            int average;
            average = sum / myArray.Length;
            Console.WriteLine("prumer je " + average);


            //TODO 5: Najdi maximum v poli a vypiš ho do konzole.
            int max = 0;
            for (int i = 0;i < myArray.Length;i++)
            {
                if (myArray[i] > max)
                    max = myArray[i];
            }
            Console.WriteLine("maximum je " + max);


            //TODO 6: Najdi minimum v poli a vypiš ho do konzole.
            int min = max;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < min)
                {
                    min = myArray[i];
                }
            }
            Console.WriteLine("minimum je " + min);


            //TODO 7: Vyhledej v poli číslo, které zadá uživatel, a vypiš index nalezeného prvku do konzole.
            Console.WriteLine("napis cislo ktere chces najit");
            int numberToFind = int.Parse(Console.ReadLine());
            bool foundNumber = false;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == numberToFind)
                {
                    Console.WriteLine("index cisla " + numberToFind + " je " + i);
                    foundNumber = true;
                }
            }
            if (!foundNumber)
            {
                Console.WriteLine("cislo v poli neni");
            }
            //TODO 8: Přepiš pole na úplně nové tak, že bude obsahovat 100 náhodně vygenerovaných čísel od 0 do 9.
            Random rng = new Random();
            myArray = new int[100];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rng.Next(0,10);
            }


            //TODO 9: Spočítej kolikrát se každé číslo v poli vyskytuje a spočítané četnosti vypiš do konzole.
            int[] counts = new int[10];



            //TODO 10: Vytvoř druhé pole, do kterého zkopíruješ prvky z prvního pole v opačném pořadí.




            //Zkus is dál hrát s polem dle své libosti. Můžeš třeba prohodit dva prvky, ukládat do pole prvky nějaké posloupnosti (a pak si je vyhledávat) nebo cokoliv dalšího tě napadne

            Console.ReadKey();
        }
    }
}
