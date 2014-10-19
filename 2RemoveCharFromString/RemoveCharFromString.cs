using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2RemoveCharFromString
{
    class RemoveCharFromString
    {

        internal string remove(char[] c, char[] str)
        {
            string results = "";
            foreach (char i in c) {
                if (i != str[0])
                { 
                    results += i;
                }
            }
            return results;
        }
    }
}
