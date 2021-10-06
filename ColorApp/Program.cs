using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Color colors = new Color();
            foreach (var item in colors)
            {
                Console.WriteLine(item);
            }
            Color1 color1s = new Color1();
            Console.WriteLine();
            foreach (var item in color1s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Color2 colors2 = new Color2();
            foreach (var item in colors2.GetEnumerator())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            ColorsLetter letter = new ColorsLetter();
            foreach (var item in letter.GetEnumerator(20)) 
            {
                Console.WriteLine(item);
            }
        }
    }
}
