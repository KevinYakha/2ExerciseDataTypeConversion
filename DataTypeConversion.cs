using System.Globalization;

namespace DataTypeConversion
{
    class DataTypeConversion()
    {
        public static string[] values = { "12.3", "45", "ABC", "11", "DEF" };
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
        }
    }
}