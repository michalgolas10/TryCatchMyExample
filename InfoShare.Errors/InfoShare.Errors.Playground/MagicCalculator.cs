using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoShare.Errors.Playground
{
    internal class MagicCalculator
    {
        private static List<string> Errors = new();

        public int CalculateMagicNumber(int seed)
        {            
            var result = Step1(seed);

            return result;
        }

        private int Step1(int seed)
        {            
            return seed * 2;
        }

        private int Step2(int number)
        {
            return number * DateTime.Now.Second;
        }

        public void Close()
        {
            Console.WriteLine("MagicCalculator is released now");
        }
    }
}
