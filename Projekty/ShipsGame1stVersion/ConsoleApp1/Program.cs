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
        static void PrintArray(string[,] arrayToPrint)
        {
            Console.WriteLine("   a b c d e f g h i j");
            for (int i = 0; i < arrayToPrint.GetLength(0); i++)
            {
                if (i == 9) 
                    Console.Write(i + 1 + " "); 
                else 
                    Console.Write(i + 1 + "  ");
                for (int j = 0; j < arrayToPrint.GetLength(1); j++) Console.Write(arrayToPrint[i, j] + " ");
                    Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void PlayerPlacement(string[,] playerPlacementArray)
        {
            List<string> columns = new List<string> { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };
            List<string> shipTypes = new List<string> { "Torpedoborec", "Ponorka", "Kriznik", "Bitevni", "Letadlova" };
            List<string> shipTypesLetters = new List<string> { "T", "P", "K", "B", "L" };

            bool redo;
            for (int i = 0; i < shipTypes.Count; i++)
            {
                do
                {
                    redo = false;
                    try
                    {
                        Console.WriteLine(shipTypes[i]);
                        int shipIndex = i;
                        Console.WriteLine("Urcete si souradnice pro umisteni prvniho bodu vasi lode");
                        Console.WriteLine("Napiste radek 1 az 10");
                        int xCoordinate = int.Parse(Console.ReadLine()) - 1;
                        Console.WriteLine("Napiste sloupec a az j");
                        int yCoordinate = columns.IndexOf(Console.ReadLine());
                        Console.WriteLine("Napiste smer orientace lode (U - up; D - down; L - left; R - right)");
                        string ShipDirection = Console.ReadLine();
                        switch (ShipDirection)
                        {
                            case "U":
                                for (int j = 0; j < shipIndex + 1; j++)
                                {
                                    if (shipTypesLetters.Contains(playerPlacementArray[xCoordinate - j - 1, yCoordinate]))
                                    {
                                        Console.WriteLine("Lodě nemohou ležet přes sebe!");
                                        redo = true;
                                    }
                                }
                                if (redo == false)
                                {
                                    for (int j = 0; j < shipIndex + 1; j++)
                                        playerPlacementArray[xCoordinate - 1 - j, yCoordinate] = shipTypesLetters[shipIndex];
                                }
                                break;
                            case "R":
                                for (int j = 0; j < shipIndex + 1; j++)
                                {
                                    if (shipTypesLetters.Contains(playerPlacementArray[xCoordinate, yCoordinate + 1 + j]))
                                    {
                                        Console.WriteLine("Lodě nemohou ležet přes sebe!");
                                        redo = true;
                                    }
                                }
                                if (redo == false)
                                {
                                    for (int j = 0; j < shipIndex + 1; j++)
                                        playerPlacementArray[xCoordinate, yCoordinate + 1 + j] = shipTypesLetters[shipIndex];
                                }
                                break;
                            case "D":
                                for (int j = 0; j < shipIndex + 1; j++)
                                {
                                    if (shipTypesLetters.Contains(playerPlacementArray[xCoordinate + 1 + j, yCoordinate]))
                                    {
                                        Console.WriteLine("Lodě nemohou ležet přes sebe!");
                                        redo = true;
                                    }
                                }
                                if (redo == false)
                                {
                                    for (int j = 0; j < shipIndex + 1; j++)
                                        playerPlacementArray[xCoordinate + 1 + j, yCoordinate] = shipTypesLetters[shipIndex];
                                }
                                break;
                            case "L":
                                for (int j = 0; j < shipIndex + 1; j++)
                                {
                                    if (shipTypesLetters.Contains(playerPlacementArray[xCoordinate, yCoordinate - 1 - j]))
                                    {
                                        Console.WriteLine("Lodě nemohou ležet přes sebe!");
                                        redo = true;
                                    }
                                }
                                if (redo == false)
                                {
                                    for (int j = 0; j < shipIndex + 1; j++)
                                        playerPlacementArray[xCoordinate, yCoordinate - 1 - j] = shipTypesLetters[shipIndex];
                                }
                                break;
                            default:
                                Console.WriteLine("Chyba zadavani");
                                redo = true;
                                break;
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("error");
                        redo = true;
                    }
                }
                while (redo);
                PrintArray(playerPlacementArray);
            }
            
        }
            static void PrintRules()
        {
            Console.WriteLine("PRAVIDLA PRO HRU LODE");
            Console.WriteLine("Pole velikosti 10x10 poli, kdy svisle hodnoty jsou oznaceny pismeny a-j, vodorovne hodnoty cisly 1-10");
            
        }

        static void Main(string[] args)
        {
            PrintRules();
            Console.ReadKey();

        }
    }
    
}
