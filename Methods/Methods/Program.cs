using System;
using System.Collections.Generic;

namespace Methods
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Menu: 1-Show List; 2-Input New Name; 3-Check Name; 4-Show Index; 0-EXIT");

            string[] namesArray = { "Marcus", "Andreas", "Ronaldinio", "Lois" };

            while (true)
            {
                string input = Console.ReadLine(); //Istifadeciden secim etmesini isteyirik

                if (input == "0")
                    break;

                switch (input)
                {
                    case "1"://Butun Adlari gostermek ucun olan case'miz
                        Console.WriteLine("Butun Adlar");
                        foreach (string name in namesArray)
                        {
                            Console.WriteLine(name);
                        }
                        break;
                    case "2":
                        Console.WriteLine("Yeni Ad Daxil Edin");
                        string newWord = Console.ReadLine();
                        bool check = false;
                        bool checkIfDigit = false;
                        bool minNum = newWord.Length > 2;
                        foreach (char c in newWord)
                        {
                            if (char.IsDigit(c))
                                checkIfDigit = true;
                            break;
                        }
                        if (checkIfDigit || !minNum)
                        {
                            if (checkIfDigit)
                            {
                                Console.WriteLine("Ad Reqem Ile Baslaya Bilmez");
                            }
                            if (!minNum)
                            {
                                Console.WriteLine("Ad 2 Simvoldan Az Ola Bilmez");
                            }
                        }
                        else
                        {
                            for (int i = 0; i < namesArray.Length; i++)
                            {
                                if (namesArray[i] == newWord) // Adi listde olub olmadigini yoxlayaq
                                {
                                    check = true;
                                    break;
                                }
                            }
                            if (check)
                            {
                                Console.WriteLine("Bu Ad Artiq Var");
                            }
                            else
                            {
                                AddName(ref namesArray, newWord);
                                foreach (string name in namesArray)
                                {
                                    Console.WriteLine(name);
                                }
                            }
                        }
                        break;
                    case "3"://Adi input etmeklerini isteyib onu listde olub olmadigini yoxlayaq
                        Console.WriteLine("Ad Daxil Edin");
                        string checkName = Console.ReadLine();
                        bool secondcheck = false;
                        for (int i = 0; i < namesArray.Length; i++)
                        {
                            if (namesArray[i] == checkName)
                            {
                                secondcheck = true;
                                break;
                            }

                        }
                        if (secondcheck)
                        {
                            Console.WriteLine("Bu ad siyahida var ");
                        }
                        else
                        {
                            Console.WriteLine("Bu ad yoxdur");
                            break;
                        }
                        break;
                    case "4":
                        for (int i = 0; i < namesArray.Length; i++)
                        {
                            //indexleri gosterek
                            foreach (string item in namesArray)
                            {
                                Console.WriteLine("Indexler: " + i++ + " - " + item);
                            }
                            Console.WriteLine("Index Daxil Edin: ");
                            int indexInput = int.Parse(Console.ReadLine());
                            if (indexInput >= 0 && indexInput < namesArray.Length)// yeni daxil etdiymiz reqem 0 dan boyuk ve arrayin uzunluqundan kicikdirse
                            {
                                Console.WriteLine(namesArray[indexInput]);//true olanda arrayin icinde daxil olunan index, inputda ki reqemde olan adi secir
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Olmayan Index Secildi");
                                break;
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Sehv Secdiniz");
                        break;
                }


            }
        }
        public static void AddName(ref string[] name, string newName)
        {
            string[] newArray = new string[name.Length + 1];
            for (int i = 0; i < name.Length; i++)
            {
                newArray[i] = name[i];
            }
            newArray[name.Length] = newName;
            name = newArray;
        }

    }
}
