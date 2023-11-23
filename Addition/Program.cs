using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
    internal class Program
    {
        public void Addition()
        {
            int a, b, c;

            a= Convert.ToInt32(Console.ReadLine());

            b= Convert.ToInt32(Console.ReadLine());

            c = a + b;

            Console.WriteLine(c);

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Addition();

            Console.ReadLine();
        }
    }
}
