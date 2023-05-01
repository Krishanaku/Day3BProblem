using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3BProb
{
    public class PrivateConstructor
    {
        private PrivateConstructor() 
        {
            Console.WriteLine("This is Private Constructor Only Access in same Class");
        }
        public static void Main(string[] args)
        {
            PrivateConstructor instance = new PrivateConstructor();

        }
    }
}
