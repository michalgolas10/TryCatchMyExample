using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InfoShare.Errors.Playground
{
    internal class MagicCalculator
    {
        private static List<string> Errors = new();
        
        public int CalculateMagicNumber(int seed)
        {
            try
            {
                if (seed > 100 || seed < 1)
                {
                    throw new ArgumentException();
                }
                var result = Step1(seed);
                return result;
            }
            catch (Exception ex)
            {
                Errors.Add(ex.Message);
                throw;
            }
        }

        private int Step1(int seed)
        {      
            if(seed == 50 ) 
            {
                throw new InvalidOperationException();
            }
            var result = Step2(seed * 2);
            return result;
            
        }

        private int Step2(int number)
        {
            if (number >30)
            {
                throw new NotImplementedException();
            }
                return number * DateTime.Now.Second;

        }

        public void Close()
        {
            Console.WriteLine("MagicCalculator is released now");
        }
    }
}
