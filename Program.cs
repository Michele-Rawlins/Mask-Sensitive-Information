using System;

namespace Mask_Sensitive_Information
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello Sir, What is your card number?");
            var input = Console.ReadLine();

            var length = input.Length;
            var result = new String('X', length - 4) + input.Substring(length - 4);

            Console.WriteLine(result);
        }

    }
}
