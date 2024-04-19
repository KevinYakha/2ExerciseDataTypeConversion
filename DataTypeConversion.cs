using System.Globalization;

namespace DataTypeConversion
{
    class DataTypeConversion()
    {
        public static string[] values = { "12.3", "45", "ABC", "11", "DEF" };

        int value1 = 11;
        decimal value2 = 6.2m;
        float value3 = 4.3f;

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

            // Your code here to set result1
            // Hint: You need to round the result to nearest integer (don't just truncate)
            Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

            // Your code here to set result2
            Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

            // Your code here to set result3
            Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
        }
    }
}