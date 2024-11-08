using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {

        static void PrintList(List<string> list)
        {
            

        }
        static void Main(string[] args)
        {

            List<string> myStringList = new List<string>();
            myStringList.Add("karel");
            myStringList.Add("xenie");
            myStringList.Add("lojza");
            myStringList.Add("androméda");
            myStringList.Add("xaver");
            myStringList.Add("cecílie");

            PrintList(myStringList);

            myStringList.Remove("karel");

            PrintList(myStringList);

            myStringList.RemoveAt(2);

            PrintList(myStringList);



            Dictionary <string,string> favouriteFoods = new Dictionary<string,string>();
            favouriteFoods["Karel"] = "Buchtičky se šodo";
            favouriteFoods["Lojza"] = "Výppečky se zelím";
            favouriteFoods["Xaver"] = "Šišky s mákem";
            favouriteFoods["Xénie"] = "Jitrnice s hořčicí";
            favouriteFoods["Androméda"] = "Kabanos";
            favouriteFoods["Cecílie"] = "Kebab";

            foreach (KeyValuePair<string, string> studentAndFood in favouriteFoods)
            {
                string name = studentAndFood.Key;
                string food = studentAndFood.Value;
                Console.WriteLine("Oblíbené jídlo studenta " + name + " je " + food);
            }

            if (favouriteFoods.ContainsKey("Martin"))
            {
                Console.WriteLine("Martin je v seznamu");
            }
            else
            {
                Console.WriteLine("Martin není v seznamu");
            }




            Console.ReadKey();

        }
    }
}
