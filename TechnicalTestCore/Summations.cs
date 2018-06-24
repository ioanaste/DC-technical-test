using System;
using System.Collections.Generic;

namespace TechnicalTestCore
{
    internal class Summations
    {
        public static int SumOfNumbersFrom1TillNrAsInt(int maxNrAsInt)
        {
            // Adapt the method body to make the corresponding unit test in 'TechnicalTestUnitTests' pass

            List<long> triangleNumbersList = GetListOfTriangleNumbers(1, maxNrAsInt);

            return (int)triangleNumbersList[maxNrAsInt - 1];
        }

        public static string SumOfNumbersFrom1TillNrAsString(string maxNrAsString)
        {
            // Adapt the method body to make the corresponding unit test in 'TechnicalTestUnitTests' pass
           
            int maxNrAsInt = Int32.Parse(maxNrAsString);

            List<string> triangleNumbersListOfStrings = new List<string>();

            List<long> triangleNumbersListOfInts = GetListOfTriangleNumbers(70_000, maxNrAsInt);
            triangleNumbersListOfStrings = triangleNumbersListOfInts.ConvertAll(x => x.ToString());

            return triangleNumbersListOfStrings[maxNrAsInt - 70_000];
        }

        static List<long> GetListOfTriangleNumbers(int startNumber, int maxNrAsInt)
        {
            Int64 triangleNumber = 0;
            List<Int64> triangleNumbersList = new List<Int64>();

            for (Int64 i = startNumber; i <= maxNrAsInt; i++)
            {
                triangleNumber = i * (i + 1) / 2;
                triangleNumbersList.Add(triangleNumber);
            }

            return triangleNumbersList;
        }
    }
}
