using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Sem13._6._2
{
    class Program
    {
        private const int V = 10;

        static void Main(string[] args)
        {
            string text = File.ReadAllText("C:/Users/stfou/Downloads/Text1.txt");
            string[] ArString = text.Split(new char[] { ' ' });
            Dictionary<string, int> dr = new Dictionary<string, int>();

            foreach (string s in ArString)
                if (dr.Keys.Contains(s)) dr[s]++;
                else dr.Add(s, 1);
            string S = ""; int k = 0;
            foreach (KeyValuePair<string, int> kk in dr.OrderByDescending(x => x.Value))
            {
                S += kk.Key + " " + kk.Value.ToString() + "\n";
                if (k == V) break;
            }

            Console.WriteLine(S);
        }
    }
}
