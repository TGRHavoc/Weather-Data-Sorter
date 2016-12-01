using AlgoComplex.DataTypes;
using System;
using System.Collections.Generic;

namespace AlgoComplex.Utils
{
    public class BinarySearch
    {
        public BinarySearch()
        {
        }

        public static List<WeatherData> GetAllValues(List<WeatherData> array, string key, IComparable value)
        {
            List<WeatherData> tmp = new List<WeatherData>(array);
            List<WeatherData> toRet = new List<WeatherData>();

            int minIndex = 0;
            int maxIndex = tmp.Count - 1;
            int currentIndex;
            IComparable currentEle;

            while (minIndex <= maxIndex)
            {
                currentIndex =  (minIndex + maxIndex) / 2;
                currentEle = tmp[currentIndex].GetValue(key);

                if (MergeSort.IsLessThan(currentEle, value))
                {
                    Console.WriteLine(currentEle + " is less than " + value);
                    minIndex = currentIndex + 1;
                }
                else if (MergeSort.IsGreaterThan(currentEle, value))
                {
                    Console.WriteLine(currentEle + " is greater than " + value);
                    maxIndex = currentIndex - 1;
                }
                else
                {
                    Console.WriteLine("Found " + currentEle);
                    toRet.Add(tmp[currentIndex]);
                    tmp.RemoveAt(currentIndex);
                    minIndex = 0;
                    maxIndex = tmp.Count - 1;
                }

            }

            return toRet;
        }

        public static int SearchIndex(List<WeatherData> array, string key, IComparable value)
        {
            int minIndex = 0;
            int maxIndex = array.Count - 1;
            int currentIndex;
            IComparable currentEle;

            while (minIndex <= maxIndex)
            {
                currentIndex = (minIndex + maxIndex) / 2;
                currentEle = array[currentIndex].GetValue(key);

                if (MergeSort.IsLessThan(currentEle, value))
                {
                    minIndex = currentIndex + 1;
                }
                else if (MergeSort.IsGreaterThan(currentEle, value))
                {
                    maxIndex = currentIndex - 1;
                }
                else
                {
                    return currentIndex;
                }
            }

            return -1;
        }

        public static WeatherData Search(List<WeatherData> array, string key, IComparable value)
        {
            int minIndex = 0;
            int maxIndex = array.Count - 1;
            int currentIndex;
            IComparable currentEle;

            while (minIndex <= maxIndex)
            {
                currentIndex = (minIndex + maxIndex) / 2;
                currentEle = array[currentIndex].GetValue(key);

                if (MergeSort.IsLessThan(currentEle, value))
                {
                    minIndex = currentIndex + 1;
                }
                else if (MergeSort.IsGreaterThan(currentEle, value))
                {
                    maxIndex = currentIndex - 1;
                }
                else
                {
                    return array[currentIndex];
                }
            }

            return null;
        }
    }
}
