using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParolTesters
{
    public class Parl
    {
        public int CheckerParol(string a)
        {
            int b = 0;
            if (a.Any(char.IsLower))
                b++;
            if (a.Any(char.IsUpper))
                b++;
            if (a.Any(char.IsDigit))
                b++;
            if (a.Length > 10)
                b++;
            if (a.Any(x => !char.IsLetterOrDigit(x)))
                b++;
            return b;
        }
    }
}