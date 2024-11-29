<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @try
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //predem si nadefinujeme promenne, ktere budeme v ramci prikladu vyuzivat
            string canContinue;
            string variableYesOrNo;
            string variableUsing = "";
            string[] variableName = new string[0]; //https://www.w3schools.com/cs/cs_arrays.php
            bool canContinue2 = true;
            int variableUsingCount;
            int variableAmount = 0;
            int operation;
            double firstNumber = 0;
            double secondNumber;
            double result;
            double[] variableNumber = new double[0];

            do // overeni vstupu, vyuziti funkce do-while, aby mi poprve probehla a pote zalezelo na odpovedi uzivatele
            {
                Console.WriteLine("chces si zalozit promennou, kterou budes moci pouzit? ano/ne"); // zeptame se, jestli uzivatel bude chtit pocitat s promennymi
                variableYesOrNo = Console.ReadLine().ToLower(); // prevedeme vstup na malá písmena pro jednodušší postup u kontroly (pomoci .ToLower()), jestli je odpoved zadana spravne, tento postup jsem zjistil tady: https://www.w3schools.com/cs/cs_strings.php

                if (variableYesOrNo != "ano" && variableYesOrNo != "ne")
                {
                    Console.WriteLine("neznama odpoved, zadej znovu ano/ne"); //do-while cyklus se bude opakovat, dokud nezadame hodnoty "ano" nebo "ne" bez ohledu na velka a mala pismena, diky vyse zminene funkci
                }
            } while (variableYesOrNo != "ano" && variableYesOrNo != "ne");

            if (variableYesOrNo == "ano") //pro pripad, ze uzivatel zada "ano", pokracuje tim, ze si uzivatel nadefinuje promenne
            {
                Console.WriteLine("kolik promennych chces zalozit?");
                variableAmount = System.Convert.ToInt32(Console.ReadLine()); // zjistime, kolik promennych chce uzivatel ulozit
                variableName = new string[variableAmount]; // definujeme velikost pole pro ulozeni nazvu promennych
                variableNumber = new double[variableAmount]; // definujeme velikost pole pro ulozeni hodnot promennych

                for (int i = 0; i < variableAmount; i++)
                {
                    Console.WriteLine("pojmenuj svoji " + (i + 1) + ". promennou");
                    variableName[i] = Console.ReadLine(); // Nadefinování názvu proměnných, postupně, díky cyklu for
                    Console.WriteLine("jakou hodnotu bude mit tvoje promenna?");
                    variableNumber[i] = System.Convert.ToDouble(Console.ReadLine()); // Nadefinování hodnot proměnných, postupně, díky cyklu for
                    Console.WriteLine("uspesne jsi do promenne " + variableName[i] + " ulozil hodnotu " + variableNumber[i]); // Oznámení o úspěšném uložení pro pozdější použití
                }
            }
            
                Console.WriteLine("jakou ciselnou operaci chces provest?\nscitani => 1;\nodcitani => 2;\nnasobeni => 3;\ndeleni => 4;\nmocneni na urcitou mocninu => 5;\nurceni mensiho z cisel => 6;\nmocneni na druhou => 7;\ndruha odmocnina => 8;\nabsolutni hodnota => 9");
                operation = System.Convert.ToInt32(Console.ReadLine());
            
            while (canContinue2) //timto si zajistime, ze kdyz uzivatel bude chtit po vypocitani prikladu skoncit, tak se program ukonci
            {
                while (operation < 1 || operation > 9) //vymezeni hodnot, pro ktere nemame definovane operace, vstup se opakuje, dokud uzivatel nezada platnou hodnotu
                {
                    Console.WriteLine("neznama operace, opakuj vstup");
                    Console.WriteLine("jakou ciselnou operaci chces provest?\nscitani => 1;\nodcitani => 2;\nnasobeni => 3;\ndeleni => 4;\nmocneni na urcitou mocninu => 5;\nurceni mensiho z cisel => 6;\nmocneni na druhou => 7;\ndruha odmocnina => 8;\nabsolutni hodnota => 9");
                    operation = System.Convert.ToInt32(Console.ReadLine());
                }

                switch (operation) //napise uzivateli, jakou operaci si vybral a ujisti ho o tom, ze si vybral to co chtel, vyuziti cyklu switch, podle toho, co jsme si rekli na hodine
                {
                    case 1:
                        Console.WriteLine("SCITANI");
                        break;
                    case 2:
                        Console.WriteLine("ODCITANI");
                        break;
                    case 3:
                        Console.WriteLine("NASOBENI");
                        break;
                    case 4:
                        Console.WriteLine("DELENI");
                        break;
                    case 5:
                        Console.WriteLine("MOCNENI PRVNIHO CISLA NA DRUHE");
                        break;
                    case 6:
                        Console.WriteLine("MINIMUM");
                        break;
                    case 7:
                        Console.WriteLine("MOCNENI CISLA NA DRUHOU");
                        break;
                    case 8:
                        Console.WriteLine("ODMOCNENI");
                        break;
                    case 9:
                        Console.WriteLine("ABSOSLUTNI HODNOTA");
                        break;
                }


                if (operation <= 6) // operace, ktere potrebuji dve cisla
                {
                    if (variableYesOrNo == "ano") //otazka, odkazujici na zacatek, kdy si uzivatel zvolil, jestli vubec chce vyuzivat promenne
                    {
                        Console.WriteLine("chces v teto operaci na prvni pozici vyuzit svou promennou? ano/ne");
                        variableUsing = System.Convert.ToString(Console.ReadLine());
                        if (variableUsing == "ano")
                        {
                            do
                            {
                                Console.WriteLine("kolikatou promennou chces pouzit? (vyber cislo od 1 do " + variableAmount + ")"); //uzivatel si zvoli, kolikatou promennou, kterou si nadefinoval, chce vyuzit
                                variableUsingCount = System.Convert.ToInt32(Console.ReadLine()) - 1;

                                if (variableUsingCount < 0 || variableUsingCount >= variableAmount)
                                {
                                    Console.WriteLine("zadany index neni platny, opakuj vstup"); //pro pripad ze uzivatel zada poradove jinou promennou nez ma nadefinovane
                                }

                            } while (variableUsingCount < 0 || variableUsingCount >= variableAmount);
                            firstNumber = variableNumber[variableUsingCount]; // ulozi hodnotu z arraye do firstNumber
                            Console.WriteLine("pouzivas promennou " + variableName[variableUsingCount] + " s hodnotou " + firstNumber);
                        }
                        else //pokud uzivatel nechce promennou vyuzit v ramci prvni hodnoty, zada si hodnotu, kterou vyuzije
                        {
                            Console.WriteLine("zadej prvni cislo pro operaci, kterou chces provest");
                            firstNumber = System.Convert.ToDouble(Console.ReadLine());
                        }

                    }
                    else //pokud uzivatel nechce vyuzivat promenne v kalkulacce, rovnou se zeptame na hodnotu prvniho cisla, ktere potrebujeme pro provedeni operace
                    {
                        Console.WriteLine("zadej prvni cislo pro operaci, kterou chces provest");
                        firstNumber = System.Convert.ToDouble(Console.ReadLine());
                    }
                    if (variableYesOrNo == "ano")
                    {
                        Console.WriteLine("chces v teto operaci na druhe pozici vyuzit svou promennou? ano/ne"); //bude promenna zahrnuta do druheho cisla?
                        variableUsing = System.Convert.ToString(Console.ReadLine());

                        if (variableUsing == "ano")
                        {
                            do
                            {
                                Console.WriteLine("kolikatou promennou chces pouzit? (vyber cislo od 1 do " + variableAmount + ")");
                                variableUsingCount = System.Convert.ToInt32(Console.ReadLine()) - 1;

                                if (variableUsingCount < 0 || variableUsingCount >= variableAmount)
                                {
                                    Console.WriteLine("zadany index neni platny, opakuj vstup");
                                }

                            } while (variableUsingCount < 0 || variableUsingCount >= variableAmount);
                            secondNumber = variableNumber[variableUsingCount]; // ulozi hodnotu z arraye do firstNumber
                            Console.WriteLine("pouzivas promennou " + variableName[variableUsingCount] + " s hodnotou " + secondNumber);
                        }
                        else //pokud uzivatel nechce promennou vyuzit v ramci druhe hodnoty, zada si hodnotu, kterou vyuzije
                        {
                            Console.WriteLine("zadej druhe cislo pro operaci, kterou chces provest");
                            secondNumber = System.Convert.ToDouble(Console.ReadLine());
                        }

                    }
                    else //pokud uzivatel nechce vyuzit promennou, zeprame se na hodnotu prvniho cisla, ktere potrebujeme pro provedeni operace
                    {
                        Console.WriteLine("zadej druhe cislo pro operaci, kterou chces provest");
                        secondNumber = System.Convert.ToDouble(Console.ReadLine());
                    }


                    switch (operation) //opet vyuziti cyklu switch, diky jednodussimu zadani i lepsi citelnosti (alespon z me strany), nadefinujeme si jednotlive operace, co se pri nich deje a jak vznikaji vysledky
                    {
                        case 1: //scitani
                            result = firstNumber + secondNumber;
                            Console.WriteLine("vysledek scitani je " + result);
                        break;
                        case 2: //odcitani
                            result = firstNumber - secondNumber;
                            Console.WriteLine("vysledek odcitani je " + result);
                        break;
                        case 3: //nasobeni
                            result = firstNumber * secondNumber;
                            Console.WriteLine("vysledek nasobeni je " + result);
                        break;
                        case 4: //deleni
                            if (secondNumber != 0) //potrebujeme omezit to, ze se nebude delit nulou
                            {
                                result = firstNumber / secondNumber;
                                Console.WriteLine("vysledek deleni je " + result);
                            }
                            else
                            {
                                Console.WriteLine("nelze delit nulou"); //zajistime, ze nedojde k deleni nulou, pokud uzivatel zada hodnotu 0, dostane informaci o tom, ze nulou delit nejde a je opet tazan, jakou operaci chce provest
                            }
                        break;
                        case 5: //mocneni prvniho cisla na druhe
                            result = Math.Pow(firstNumber, secondNumber); //objevil jsem, ze existuje neco jako knihovna Math, kde jsou ulozeny "vzorce" pro ruzne matematicke operace, viz odkaz https://learn.microsoft.com/en-us/dotnet/api/system.math?view=netframework-4.8
                            Console.WriteLine("umocnenim prvniho cisla na druhe cislo vychazi " + result);
                        break;
                        case 6: //minimum, urci mensi z cisel
                            result = Math.Min(firstNumber, secondNumber); //taky z knihovny Math
                            Console.WriteLine("mensi z cisel je " + result);
                        break;
                    }
                }

                if (operation == 7 || operation == 8 || operation == 9) //operace jen s jednim cislem
                {

                    if (variableYesOrNo == "ano") //zepta se jen ve chvili, kdy si na zacatku nejake promenne nadefinujeme, jinak tento krok neprobehne
                    {
                        Console.WriteLine("chces v teto operaci vyuzit svou promennou? ano/ne"); //bude promenna zahrnuta do prvniho cisla?
                        variableUsing = System.Convert.ToString(Console.ReadLine());
                    }
                    if (variableUsing == "ano") //krok se spusti jen ve chvili, kdyz uzivatel zada, ze chce vyuzit promennou
                    {
                        do
                        {
                            Console.WriteLine("kolikatou promennou chces pouzit? (vyber cislo od 1 do " + variableAmount + ")"); //uzivatel si urci, kterou z nadefinovanych promennych chce vyuzit pro operaci
                            variableUsingCount = System.Convert.ToInt32(Console.ReadLine()) - 1;

                            if (variableUsingCount < 0 || variableUsingCount >= variableAmount)
                            {
                                Console.WriteLine("zadany index neni platny, opakuj vstup");
                            }

                        } while (variableUsingCount < 0 || variableUsingCount >= variableAmount);
                        firstNumber = variableNumber[variableUsingCount]; // ulozi hodnotu z arraye do firstNumber
                        Console.WriteLine("pouzivas promennou " + variableName[variableUsingCount] + " s hodnotou " + firstNumber);
                    }
                    else
                    {
                        Console.WriteLine("zadej cislo pro operaci, kterou chces provest");
                        firstNumber = System.Convert.ToDouble(Console.ReadLine());
                    }

                }

                switch (operation) //definujeme, co se stane pro jednotlive ukony s jednim cislem
                {
                    case 7: //mocneni na druhou
                        result = firstNumber * firstNumber;
                        Console.WriteLine("vysledek mocneni na druhou je " + result);
                        break;
                    case 8: //druha odmocnina
                        if (firstNumber >= 0)
                        {
                            result = Math.Sqrt(firstNumber); //knihovna Math
                            Console.WriteLine("vysledek odmocneni je " + result);
                        }
                        else
                        {
                            Console.WriteLine("nelze odmocnovat zaporne cislo"); //pro pripad, ze by zadana hodnota byla mensi nez nula, operace se neprovede, uzivatel je informovan o tom, ze nelze odmocnovat zaporne cislo, a je tazan jestli chce pokracovat s dalsi operaci
                        }
                        break;
                    case 9: //absolutni hodnota
                        result = Math.Abs(firstNumber); //knihovna Math
                        Console.WriteLine("absolutni hodnota z cisla je " + result);
                        break;
                }

                Console.WriteLine("chces pokracovat? ano/ne"); //priklad skoncil, program se zepta, jestli chce uzivatel pokracovat s dalsim prikladem, nebo skoncit
                canContinue = System.Convert.ToString(Console.ReadLine());
                if (canContinue.Equals("ne", StringComparison.OrdinalIgnoreCase)) //tady mi nefungovalo klasicke zadani, nevim proc, takze jsem se poradil s chat.gpt, rad se doptam na hodine, proc to nefungovalo
                {
                    canContinue2 = false;
                    Console.WriteLine("uzivatel chce skoncit");
                    Console.ReadKey(); //cekame, dokud uzivatell nezmackne nejakou klavesu, pote program spadne
                    return;
                }
                else //pro pripad, ze chce uzivatel pokracovat s dalsi matematickou operaci
                {
                    Console.WriteLine("tak pokracujeme"); //pokud uzivatel nechce skoncit, zeptame se ho na dalsi operaci, kterou chce provest
                    Console.WriteLine("jakou ciselnou operaci chces provest?\nscitani => 1;\nodcitani => 2;\nnasobeni => 3;\ndeleni => 4;\nmocneni na urcitou mocninu => 5;\nurceni mensiho z cisel => 6;\nmocneni na druhou => 7;\ndruha odmocnina => 8;\nabsolutni hodnota => 9");
                    operation = System.Convert.ToInt32(Console.ReadLine()); //vraci uzivatele na zacatek cyklu while, diky nemuz je mozne program ukoncit a opakuje pocitani od zacatku, vyjma definovani promennych, ktere si uzivatel nadefinuje jen po prvnim spusteni programu
                }
            }
        }
    }
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @try
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //predem si nadefinujeme promenne, ktere budeme v ramci prikladu vyuzivat
            string canContinue;
            string variableYesOrNo;
            string variableUsing = "";
            string[] variableName = new string[0]; //https://www.w3schools.com/cs/cs_arrays.php
            bool canContinue2 = true;
            int variableUsingCount;
            int variableAmount = 0;
            int operation;
            double firstNumber = 0;
            double secondNumber;
            double result;
            double[] variableNumber = new double[0];

            do // overeni vstupu, vyuziti funkce do-while, aby mi poprve probehla a pote zalezelo na odpovedi uzivatele
            {
                Console.WriteLine("chces si zalozit promennou, kterou budes moci pouzit? ano/ne"); // zeptame se, jestli uzivatel bude chtit pocitat s promennymi
                variableYesOrNo = Console.ReadLine().ToLower(); // prevedeme vstup na malá písmena pro jednodušší postup u kontroly (pomoci .ToLower()), jestli je odpoved zadana spravne, tento postup jsem zjistil tady: https://www.w3schools.com/cs/cs_strings.php

                if (variableYesOrNo != "ano" && variableYesOrNo != "ne")
                {
                    Console.WriteLine("neznama odpoved, zadej znovu ano/ne"); //do-while cyklus se bude opakovat, dokud nezadame hodnoty "ano" nebo "ne" bez ohledu na velka a mala pismena, diky vyse zminene funkci
                }
            } while (variableYesOrNo != "ano" && variableYesOrNo != "ne");

            if (variableYesOrNo == "ano") //pro pripad, ze uzivatel zada "ano", pokracuje tim, ze si uzivatel nadefinuje promenne
            {
                Console.WriteLine("kolik promennych chces zalozit?");
                variableAmount = System.Convert.ToInt32(Console.ReadLine()); // zjistime, kolik promennych chce uzivatel ulozit
                variableName = new string[variableAmount]; // definujeme velikost pole pro ulozeni nazvu promennych
                variableNumber = new double[variableAmount]; // definujeme velikost pole pro ulozeni hodnot promennych

                for (int i = 0; i < variableAmount; i++)
                {
                    Console.WriteLine("pojmenuj svoji " + (i + 1) + ". promennou");
                    variableName[i] = Console.ReadLine(); // Nadefinování názvu proměnných, postupně, díky cyklu for
                    Console.WriteLine("jakou hodnotu bude mit tvoje promenna?");
                    variableNumber[i] = System.Convert.ToDouble(Console.ReadLine()); // Nadefinování hodnot proměnných, postupně, díky cyklu for
                    Console.WriteLine("uspesne jsi do promenne " + variableName[i] + " ulozil hodnotu " + variableNumber[i]); // Oznámení o úspěšném uložení pro pozdější použití
                }
            }
            
                Console.WriteLine("jakou ciselnou operaci chces provest?\nscitani => 1;\nodcitani => 2;\nnasobeni => 3;\ndeleni => 4;\nmocneni na urcitou mocninu => 5;\nurceni mensiho z cisel => 6;\nmocneni na druhou => 7;\ndruha odmocnina => 8;\nabsolutni hodnota => 9");
                operation = System.Convert.ToInt32(Console.ReadLine());
            
            while (canContinue2) //timto si zajistime, ze kdyz uzivatel bude chtit po vypocitani prikladu skoncit, tak se program ukonci
            {
                while (operation < 1 || operation > 9) //vymezeni hodnot, pro ktere nemame definovane operace, vstup se opakuje, dokud uzivatel nezada platnou hodnotu
                {
                    Console.WriteLine("neznama operace, opakuj vstup");
                    Console.WriteLine("jakou ciselnou operaci chces provest?\nscitani => 1;\nodcitani => 2;\nnasobeni => 3;\ndeleni => 4;\nmocneni na urcitou mocninu => 5;\nurceni mensiho z cisel => 6;\nmocneni na druhou => 7;\ndruha odmocnina => 8;\nabsolutni hodnota => 9");
                    operation = System.Convert.ToInt32(Console.ReadLine());
                }

                switch (operation) //napise uzivateli, jakou operaci si vybral a ujisti ho o tom, ze si vybral to co chtel, vyuziti cyklu switch, podle toho, co jsme si rekli na hodine
                {
                    case 1:
                        Console.WriteLine("SCITANI");
                        break;
                    case 2:
                        Console.WriteLine("ODCITANI");
                        break;
                    case 3:
                        Console.WriteLine("NASOBENI");
                        break;
                    case 4:
                        Console.WriteLine("DELENI");
                        break;
                    case 5:
                        Console.WriteLine("MOCNENI PRVNIHO CISLA NA DRUHE");
                        break;
                    case 6:
                        Console.WriteLine("MINIMUM");
                        break;
                    case 7:
                        Console.WriteLine("MOCNENI CISLA NA DRUHOU");
                        break;
                    case 8:
                        Console.WriteLine("ODMOCNENI");
                        break;
                    case 9:
                        Console.WriteLine("ABSOSLUTNI HODNOTA");
                        break;
                }


                if (operation <= 6) // operace, ktere potrebuji dve cisla
                {
                    if (variableYesOrNo == "ano") //otazka, odkazujici na zacatek, kdy si uzivatel zvolil, jestli vubec chce vyuzivat promenne
                    {
                        Console.WriteLine("chces v teto operaci na prvni pozici vyuzit svou promennou? ano/ne");
                        variableUsing = System.Convert.ToString(Console.ReadLine());
                        if (variableUsing == "ano")
                        {
                            do
                            {
                                Console.WriteLine("kolikatou promennou chces pouzit? (vyber cislo od 1 do " + variableAmount + ")"); //uzivatel si zvoli, kolikatou promennou, kterou si nadefinoval, chce vyuzit
                                variableUsingCount = System.Convert.ToInt32(Console.ReadLine()) - 1;

                                if (variableUsingCount < 0 || variableUsingCount >= variableAmount)
                                {
                                    Console.WriteLine("zadany index neni platny, opakuj vstup"); //pro pripad ze uzivatel zada poradove jinou promennou nez ma nadefinovane
                                }

                            } while (variableUsingCount < 0 || variableUsingCount >= variableAmount);
                            firstNumber = variableNumber[variableUsingCount]; // ulozi hodnotu z arraye do firstNumber
                            Console.WriteLine("pouzivas promennou " + variableName[variableUsingCount] + " s hodnotou " + firstNumber);
                        }
                        else //pokud uzivatel nechce promennou vyuzit v ramci prvni hodnoty, zada si hodnotu, kterou vyuzije
                        {
                            Console.WriteLine("zadej prvni cislo pro operaci, kterou chces provest");
                            firstNumber = System.Convert.ToDouble(Console.ReadLine());
                        }

                    }
                    else //pokud uzivatel nechce vyuzivat promenne v kalkulacce, rovnou se zeptame na hodnotu prvniho cisla, ktere potrebujeme pro provedeni operace
                    {
                        Console.WriteLine("zadej prvni cislo pro operaci, kterou chces provest");
                        firstNumber = System.Convert.ToDouble(Console.ReadLine());
                    }
                    if (variableYesOrNo == "ano")
                    {
                        Console.WriteLine("chces v teto operaci na druhe pozici vyuzit svou promennou? ano/ne"); //bude promenna zahrnuta do druheho cisla?
                        variableUsing = System.Convert.ToString(Console.ReadLine());

                        if (variableUsing == "ano")
                        {
                            do
                            {
                                Console.WriteLine("kolikatou promennou chces pouzit? (vyber cislo od 1 do " + variableAmount + ")");
                                variableUsingCount = System.Convert.ToInt32(Console.ReadLine()) - 1;

                                if (variableUsingCount < 0 || variableUsingCount >= variableAmount)
                                {
                                    Console.WriteLine("zadany index neni platny, opakuj vstup");
                                }

                            } while (variableUsingCount < 0 || variableUsingCount >= variableAmount);
                            secondNumber = variableNumber[variableUsingCount]; // ulozi hodnotu z arraye do firstNumber
                            Console.WriteLine("pouzivas promennou " + variableName[variableUsingCount] + " s hodnotou " + secondNumber);
                        }
                        else //pokud uzivatel nechce promennou vyuzit v ramci druhe hodnoty, zada si hodnotu, kterou vyuzije
                        {
                            Console.WriteLine("zadej druhe cislo pro operaci, kterou chces provest");
                            secondNumber = System.Convert.ToDouble(Console.ReadLine());
                        }

                    }
                    else //pokud uzivatel nechce vyuzit promennou, zeprame se na hodnotu prvniho cisla, ktere potrebujeme pro provedeni operace
                    {
                        Console.WriteLine("zadej druhe cislo pro operaci, kterou chces provest");
                        secondNumber = System.Convert.ToDouble(Console.ReadLine());
                    }


                    switch (operation) //opet vyuziti cyklu switch, diky jednodussimu zadani i lepsi citelnosti (alespon z me strany), nadefinujeme si jednotlive operace, co se pri nich deje a jak vznikaji vysledky
                    {
                        case 1: //scitani
                            result = firstNumber + secondNumber;
                            Console.WriteLine("vysledek scitani je " + result);
                        break;
                        case 2: //odcitani
                            result = firstNumber - secondNumber;
                            Console.WriteLine("vysledek odcitani je " + result);
                        break;
                        case 3: //nasobeni
                            result = firstNumber * secondNumber;
                            Console.WriteLine("vysledek nasobeni je " + result);
                        break;
                        case 4: //deleni
                            if (secondNumber != 0) //potrebujeme omezit to, ze se nebude delit nulou
                            {
                                result = firstNumber / secondNumber;
                                Console.WriteLine("vysledek deleni je " + result);
                            }
                            else
                            {
                                Console.WriteLine("nelze delit nulou"); //zajistime, ze nedojde k deleni nulou, pokud uzivatel zada hodnotu 0, dostane informaci o tom, ze nulou delit nejde a je opet tazan, jakou operaci chce provest
                            }
                        break;
                        case 5: //mocneni prvniho cisla na druhe
                            result = Math.Pow(firstNumber, secondNumber); //objevil jsem, ze existuje neco jako knihovna Math, kde jsou ulozeny "vzorce" pro ruzne matematicke operace, viz odkaz https://learn.microsoft.com/en-us/dotnet/api/system.math?view=netframework-4.8
                            Console.WriteLine("umocnenim prvniho cisla na druhe cislo vychazi " + result);
                        break;
                        case 6: //minimum, urci mensi z cisel
                            result = Math.Min(firstNumber, secondNumber); //taky z knihovny Math
                            Console.WriteLine("mensi z cisel je " + result);
                        break;
                    }
                }

                if (operation == 7 || operation == 8 || operation == 9) //operace jen s jednim cislem
                {

                    if (variableYesOrNo == "ano") //zepta se jen ve chvili, kdy si na zacatku nejake promenne nadefinujeme, jinak tento krok neprobehne
                    {
                        Console.WriteLine("chces v teto operaci vyuzit svou promennou? ano/ne"); //bude promenna zahrnuta do prvniho cisla?
                        variableUsing = System.Convert.ToString(Console.ReadLine());
                    }
                    if (variableUsing == "ano") //krok se spusti jen ve chvili, kdyz uzivatel zada, ze chce vyuzit promennou
                    {
                        do
                        {
                            Console.WriteLine("kolikatou promennou chces pouzit? (vyber cislo od 1 do " + variableAmount + ")"); //uzivatel si urci, kterou z nadefinovanych promennych chce vyuzit pro operaci
                            variableUsingCount = System.Convert.ToInt32(Console.ReadLine()) - 1;

                            if (variableUsingCount < 0 || variableUsingCount >= variableAmount)
                            {
                                Console.WriteLine("zadany index neni platny, opakuj vstup");
                            }

                        } while (variableUsingCount < 0 || variableUsingCount >= variableAmount);
                        firstNumber = variableNumber[variableUsingCount]; // ulozi hodnotu z arraye do firstNumber
                        Console.WriteLine("pouzivas promennou " + variableName[variableUsingCount] + " s hodnotou " + firstNumber);
                    }
                    else
                    {
                        Console.WriteLine("zadej cislo pro operaci, kterou chces provest");
                        firstNumber = System.Convert.ToDouble(Console.ReadLine());
                    }

                }

                switch (operation) //definujeme, co se stane pro jednotlive ukony s jednim cislem
                {
                    case 7: //mocneni na druhou
                        result = firstNumber * firstNumber;
                        Console.WriteLine("vysledek mocneni na druhou je " + result);
                        break;
                    case 8: //druha odmocnina
                        if (firstNumber >= 0)
                        {
                            result = Math.Sqrt(firstNumber); //knihovna Math
                            Console.WriteLine("vysledek odmocneni je " + result);
                        }
                        else
                        {
                            Console.WriteLine("nelze odmocnovat zaporne cislo"); //pro pripad, ze by zadana hodnota byla mensi nez nula, operace se neprovede, uzivatel je informovan o tom, ze nelze odmocnovat zaporne cislo, a je tazan jestli chce pokracovat s dalsi operaci
                        }
                        break;
                    case 9: //absolutni hodnota
                        result = Math.Abs(firstNumber); //knihovna Math
                        Console.WriteLine("absolutni hodnota z cisla je " + result);
                        break;
                }

                Console.WriteLine("chces pokracovat? ano/ne"); //priklad skoncil, program se zepta, jestli chce uzivatel pokracovat s dalsim prikladem, nebo skoncit
                canContinue = System.Convert.ToString(Console.ReadLine());
                if (canContinue.Equals("ne", StringComparison.OrdinalIgnoreCase)) //tady mi nefungovalo klasicke zadani, nevim proc, takze jsem se poradil s chat.gpt, rad se doptam na hodine, proc to nefungovalo
                {
                    canContinue2 = false;
                    Console.WriteLine("uzivatel chce skoncit");
                    Console.ReadKey(); //cekame, dokud uzivatell nezmackne nejakou klavesu, pote program spadne
                    return;
                }
                else //pro pripad, ze chce uzivatel pokracovat s dalsi matematickou operaci
                {
                    Console.WriteLine("tak pokracujeme"); //pokud uzivatel nechce skoncit, zeptame se ho na dalsi operaci, kterou chce provest
                    Console.WriteLine("jakou ciselnou operaci chces provest?\nscitani => 1;\nodcitani => 2;\nnasobeni => 3;\ndeleni => 4;\nmocneni na urcitou mocninu => 5;\nurceni mensiho z cisel => 6;\nmocneni na druhou => 7;\ndruha odmocnina => 8;\nabsolutni hodnota => 9");
                    operation = System.Convert.ToInt32(Console.ReadLine()); //vraci uzivatele na zacatek cyklu while, diky nemuz je mozne program ukoncit a opakuje pocitani od zacatku, vyjma definovani promennych, ktere si uzivatel nadefinuje jen po prvnim spusteni programu
                }
            }
        }
    }
>>>>>>> 9202edb6ea63ba68da8e2fcf0e7e9353f986e6e4
}