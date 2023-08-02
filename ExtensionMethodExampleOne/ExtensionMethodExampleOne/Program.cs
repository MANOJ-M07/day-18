using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodExampleOne
{

    public static class StringExtensions
    {
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            return char.ToUpper(input[0]) + input.Substring(1);
        }
    }
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("enter a sentence:");
            string inputSentence = Console.ReadLine();

            string capitalizedSentence = inputSentence.CapitalizeFirstLetter();
            Console.WriteLine($"Capitalized Sentence: {capitalizedSentence}");

            Console.ReadKey();
        }
    }
}
