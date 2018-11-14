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
            Console.WriteLine("введите нужное слово");
            string need = Convert.ToString(Console.ReadLine());

            string[] razb = str.Split(' ', ',');
            int count = 0;
            for (int i = 0; i < razb.Length ; i++)
            {
              //  Console.WriteLine(razb[i]);
                if (razb[i] == need)
                {
                    count++;
                } 
            }
            Console.WriteLine("колличество нужных слов - "+count);
           
            Console.ReadLine();
        }
    }
}
