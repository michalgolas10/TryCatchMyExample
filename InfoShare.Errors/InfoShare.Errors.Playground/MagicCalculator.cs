using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoShare.Errors.Playground
{
    internal class MagicCalculator
    {
        public int CalculateMagicNumber(int seed)
        {            
            var result = Step1(seed);

            return result;
        }

        private int Step1(int seed)
        {            
            return seed * 2;
        }
    }
}
