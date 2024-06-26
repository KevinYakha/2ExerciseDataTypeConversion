﻿using System.Globalization;

namespace DataTypeConversion
{
    class DataTypeConversion()
    {
        public static string[] values = { "12.3", "45", "ABC", "11", "DEF" };

        public static int value1 = 11;
        public static decimal value2 = 6.2m;
        public static float value3 = 4.3f;

        public static string pangram = "The quick brown fox jumps over the lazy dog";

        public static string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

        public static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US");

            float sum = 0.0f;
            string message = "";
            for(int i = 0; i < values.Length; i++)
            {
                if (float.TryParse(values[i], out float result))
                    sum += result;
                else
                    message += values[i];
            }
            Console.WriteLine("Message: " + message);
            Console.WriteLine("Total: " + sum);

            int result1 = Convert.ToInt32(value1 / value2);
            // Hint: You need to round the result to nearest integer (don't just truncate)
            Console.WriteLine($"\nDivide value1 by value2, display the result as an int: {result1}");

            decimal result2 = value2 / (decimal)value3;
            Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

            float result3 = value3 / value1;
            Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}\n");

            string[] words = pangram.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                char[] temp = words[i].ToCharArray();
                Array.Reverse(temp);
                words[i] = new string(temp);
            }
            Console.WriteLine(string.Join(" ", words) + "\n");

            foreach (string order in orderStream.Split(','))
                Console.WriteLine(order.Length == 4 ? order : order + "\t- Error");
        }
    }
}