using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCloud
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "The quick brown fox jumps Jumps over the lazy dog.";
            string[] words = phrase.Split(' ');
            var lower = words.Select(s => s.ToLowerInvariant()).ToArray();
            Dictionary<string, int> DictionaryList = new Dictionary<string, int>();

            foreach (string word in lower)
            {
                if (!DictionaryList.ContainsKey(word))
                {
                    DictionaryList.Add(word, 1);
                }
                else
                {
                    DictionaryList[word] += 1;
                }
            }



            foreach (var item in DictionaryList)
            {
                Console.WriteLine($"Key: {item.Key} ------ Values: {item.Value}" );
            }


                Console.ReadLine();
        }
    }
}
