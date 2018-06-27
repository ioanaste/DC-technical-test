using System;

namespace TechnicalTestCore
{
    internal class Summations
    {
        public static int SumOfNumbersFrom1TillNrAsInt(int maxNrAsInt)
        {
            // Adapt the method body to make the corresponding unit test in 'TechnicalTestUnitTests' pass

            int Sum = 0;

            for (int i = 1; i <= maxNrAsInt; i++)
            {
                Sum = Sum + i;
            }

            return Sum;
        }

        public static string SumOfNumbersFrom1TillNrAsString(string maxNrAsString)
        {
            // Adapt the method body to make the corresponding unit test in 'TechnicalTestUnitTests' pass

            int maxNrAsInt = Int32.Parse(maxNrAsString);

            long Sum = 0;

            for (int i = 1; i <= maxNrAsInt; i++)
            {
                Sum = Sum + i;
            }

            return Sum.ToString();
        }
    }
}
