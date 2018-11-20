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
            List<string> template = new List<string> { };
            for (int i = 0; i < razb.Length; i++)
            {
                template.Add(razb[i]);
            }
            for (int i = 0; i < (razb.Length-1); i++)
            {
                if (!(template[i].Equals(template[i + 1])))
                {
                    count++;
                }
            };
            Console.WriteLine("колличество уникальных слов - " + count);

            Console.ReadLine();
        }
    }
}
