using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_28._02._19
{
    public class CountWords
    {
        public static Dictionary<string, int> dict;

        public CountWords()
        {
            dict = new Dictionary<string, int>();
        }

        public void AddWord(string word)
        {
            if (dict.ContainsKey(word))
            {
                dict[word] += 1;
            }
            else
            {
                dict.Add(word, 1);
            }
        }

        public void Print()
        {
            foreach (var i in dict)
            {
                Console.WriteLine(" {0} - {1} раз.", i.Key, i.Value);
            }
        }
    }
}
