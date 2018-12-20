using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string strings = File.ReadAllText("C:/Users/PIRAT/Desktop/test.txt");
            //Console.WriteLine("введите строку");

            //string strings = Console.ReadLine();
            string[] Words = strings.Split(' ', ',');
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
