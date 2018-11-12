using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindElementByKey
{
    public class Program
    {
        private static readonly IDictionary _dictionary = new Dictionary<string, string>();

        static void Main(string[] args)
        {

            _dictionary.Add("text", "notepad");
            _dictionary.Add("jpeg", "photoshop");
            _dictionary.Add("mov", "sony-vegas");

            FindEntryValueByKey("jpeg");

        }

        private static void FindEntryValueByKey(string key)
        {
            foreach (DictionaryEntry entry in _dictionary)
            {
                if (entry.Key.Equals(key))
                {
                    Console.WriteLine(entry.Value.ToString());
                    return;
                }
            }

            Console.WriteLine("No element with \"{0}\" key was found.", key);
        }
    }
}
