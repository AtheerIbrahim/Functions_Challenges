using System;
namespace Functions_Challenges
{
    public class Program
    {
        public static string StringNumberProcessor(string text1, int num1, int num2, string text2)
        {
            int result = num1+num2;
            return text1 + " " + text2 + ";" + " " + result;
        }
        public static void Main(string[] args)
        {
            // Challenge 1: String and Number Processor
            Console.WriteLine("Challenge 1: String and Number Processor");
            Console.WriteLine(StringNumberProcessor("Hello", 100, 200, "World"));
        }
    }
}