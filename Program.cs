using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите строку");
            string str = Console.ReadLine();
            string[] words = str.Split(' ', ',');
            if (words.Length > 1)
            {
                List<String> WordsList = words.ToList();
                for (int i = 0; i < WordsList.Count; i++)
                {
                    for (int j = i + 1; j < WordsList.Count-1; j++)
                    {
                        while (WordsList[i].Equals(WordsList[j]))
                        {
                            WordsList.RemoveAt(j);
                        };

                    };
                };
                
                if (WordsList[0].Equals(WordsList.Last()))
                {
                    Console.WriteLine("колличество уникальных слов - " + (WordsList.Count - 1));
                };


                //foreach (String s in WordsList) { Console.WriteLine(s); };             
            }
            else { Console.WriteLine("колличество уникальных слов - 1"); }
            Console.ReadLine();
            
        }
    }
}
