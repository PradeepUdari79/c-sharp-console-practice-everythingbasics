

using System;
using System.Linq;

namespace c_sharp_console_practice_everythingbasics
{
    class Program
    {
     
            
        static void Main(string[] args)
        {



            // string name = "my favourite lover is god ";

            //string  result = name.Replace("favourite", "beautiful");
            // Console.WriteLine(result);

            int[] numbrs = { 1, 2, 4, 5, 8, 9 } ;
            var lownumbers = from n in numbrs where (n >4 && n<8) select n;
            foreach(var x in lownumbers)
            {
                Console.WriteLine(x);

            }
            Console.ReadLine();










        }
    }
}
