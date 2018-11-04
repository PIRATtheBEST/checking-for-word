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
            //Console.WriteLine(str.Count());
            int count = 0;

            for (int i = 0; i < str.Length - 4; i++)
            {
                if (str[i] + str[i + 1] + str[i + 2] + str[i + 3] == "мама")
                {
                    count++;
                }
            }
            Console.WriteLine(count);


            /*int count = str.Split().Count();
            ////Console.WriteLine(count);*/
            Console.ReadLine();
        }
    }
}
