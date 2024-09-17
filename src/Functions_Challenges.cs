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
        public static void SwapObjects(ref dynamic input1 , ref dynamic input2)
        {
            if (input1.GetType() != input2.GetType())
            {
                Console.WriteLine($"Error: Objects must be of same types");
            }
            else if (input1.GetType() == typeof(int))
            {
                if (input1 > 18 && input2 > 18)
                {
                    dynamic temp = input1;
                    input1 = input2;
                    input2 = temp;
                }
                else
                {
                    Console.WriteLine($"Error: Values must be more than 18");
                }
            }
            else if(input1.GetType() == typeof(string))
            {
                if (input1.Length > 5 && input2.Length > 5)
                {
                    dynamic temp = input1;
                    input1 = input2;
                    input2 = temp;
                }
                else
                {
                    Console.WriteLine($"Error: Length must be more than 5");
                }
            }
            else
            {
                Console.WriteLine($"Error: Unsupported data type");
            }
        }
        public static void Main(string[] args)
        {
            // Challenge 1: String and Number Processor
            Console.WriteLine("Challenge 1: String and Number Processor");
            Console.WriteLine(StringNumberProcessor("Hello", 100, 200, "World"));

            // Challenge 2: Object Swapper
            Console.WriteLine("\nChallenge 2: Object Swapper");
            dynamic num1 = 25, num2 = 30, num3 = 10;
            dynamic str1 = "HelloWorld", str2 = "Programming", str3 = "Hi";
            dynamic bool1 = true , bool2 = false;

            SwapObjects(ref num1, ref num2); // Expected outcome: num1 = 30, num2 = 25 
            Console.WriteLine($"Numbers: {num1}, {num2}"); 
            SwapObjects(ref num3, ref num2); // Error: Value must be more than 18

            SwapObjects(ref str1, ref str2); // Expected outcome: str1 = "Programming", str2 = "HelloWorld"
            Console.WriteLine($"Strings: {str1}, {str2}");
            SwapObjects(ref str3, ref str2); // Error: Length must be more than 5

            SwapObjects(ref bool1, ref bool2); // Error: Unsupported data type
            SwapObjects(ref num1, ref str1); // Error: Objects must be of same types  
        }
    }
}