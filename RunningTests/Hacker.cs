using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunningTests
{
    public class Hacker
    {

        public static string Pangram(string sentence)
        {
            var comparison = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
                'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
            };

            var input = sentence.ToLower();
            int count = 0;

            foreach (var item in comparison)
            {
                if (input.Contains(item.ToString()))
                {
                    count++;
                }
            }

            if (count == 26)
            {
                return "pangram";
            }
            else
            {
                return "not pangram";
            }
        }
    }
}
