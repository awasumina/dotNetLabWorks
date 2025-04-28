using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace dotnetClassWorks
{
    class Palindrome
    {
        public bool checkpalin(string inputstring)
        {
            int len = inputstring.Length;
            string checkpalinstring = "";
            for (int i = len - 1; i >= 0; i--)
            {
                checkpalinstring = checkpalinstring + inputstring[i];
            }
            if (checkpalinstring == inputstring)
            {
                return true;
            }
            else
                return false;
        }

    }
}