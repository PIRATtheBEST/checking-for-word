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
            string[] Words = str.Split(' ', ',');
            List<String> WordsList = Words.ToList();
            List<string> WordsLonely = new List<string>();
            while (WordsList.Count > 0)
            {
                WordsLonely.Add(WordsList[0]);
                WordsList.RemoveAll(words => (words == WordsList[0]));
            };
            if (WordsLonely[0] == WordsLonely[WordsLonely.Count - 1]) { WordsLonely.RemoveAt(WordsLonely.Count - 1); };
            Console.WriteLine("колличество уникальных слов - " + (WordsLonely.Count));
            foreach (String s in WordsLonely) { Console.WriteLine(s); };
            Console.ReadLine();            
        }
    }
}
