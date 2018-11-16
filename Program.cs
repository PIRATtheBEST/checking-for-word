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
            string str = Convert.ToString(Console.ReadLine());
            string[] razb = str.Split(' ', ',');
            var razbnew = razb.Union(razb);
            int count = 0;
            foreach (string word in razbnew)
                count++;
            Console.WriteLine("колличество уникальных слов - " + (count-1));

            Console.ReadLine();
        }
    }
}
