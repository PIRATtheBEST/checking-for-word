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
            string[] razb = str.Split(' ', ',');
            bool checking = false;
            int count = 0;
            var razb1 = razb.Distinct();
            foreach(string s in razb1)
            {
                count++;
            }
            Console.WriteLine("колличество уникальных слов - " + count);

            Console.ReadLine();
        }
    }
}
