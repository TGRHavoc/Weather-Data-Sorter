using AlgoComplex.DataTypes;
using System;
using System.Collections.Generic;

namespace AlgoComplex.Utils
{
    static class MergeSort
    {

        /// <summary>
        /// Use the merge sort algorithm to sort a list of WeatherData by the specified value in "sortBy" variable.
        /// </summary>
        /// <param name="toSort">A list of WeatherData to sort</param>
        /// <param name="sortBy">string variable that represents a variable name in WeatherData class.. See WeatherData.GetValue for possible values.</param>
        /// <param name="reverse">Reverse the sorting process. (Largest first, smallest last) default = false</param>
        /// <returns>A List that is sorted using the given params</returns>
        public static List<WeatherData> Sort(List<WeatherData> toSort, string sortBy, bool reverse = false)
        {
            List<WeatherData> result = new List<WeatherData>();
            List<WeatherData> left = new List<WeatherData>();
            List<WeatherData> right = new List<WeatherData>();

            if (toSort.Count <= 1)
                return toSort;

            int midpoint = toSort.Count / 2;
            for (int i = 0; i < midpoint; i++)
                left.Add(toSort[i]);
            for (int i = midpoint; i < toSort.Count; i++)
                right.Add(toSort[i]);

            left = Sort(left, sortBy, reverse);
            right = Sort(right, sortBy, reverse);
            result = (reverse ? ReverseMerge(left, right, sortBy) : Merge(left, right, sortBy));

            return result;
        }

        static List<WeatherData> ReverseMerge(List<WeatherData> left, List<WeatherData> right, string sortBy)
        {
            List<WeatherData> merged = new List<WeatherData>();
            int leftIndex = 0;
            int rightIndex = 0;

            while (left.Count > leftIndex && right.Count > rightIndex)
            {
                if (IsLessThan(left[leftIndex].GetValue(sortBy), right[rightIndex].GetValue(sortBy)))
                {
                    merged.Add(right[rightIndex++]);
                }
                else
                {
                    merged.Add(left[leftIndex++]);
                }
            }

            while (left.Count > leftIndex)
                merged.Add(left[leftIndex++]);

            while (right.Count > rightIndex)
                merged.Add(right[rightIndex++]);

            return merged;
        }

        static List<WeatherData> Merge(List<WeatherData> left, List<WeatherData> right, string sortBy)
        {
            List<WeatherData> merged = new List<WeatherData>();
            int leftIndex = 0;
            int rightIndex = 0;

            while(left.Count > leftIndex && right.Count > rightIndex)
            {
                if (IsLessThan(left[leftIndex].GetValue(sortBy), right[rightIndex].GetValue(sortBy)))
                {
                    merged.Add(left[leftIndex++]);
                }
                else
                {
                    merged.Add(right[rightIndex++]);
                }
            }

            while(left.Count > leftIndex)
                merged.Add(left[leftIndex++]);

            while(right.Count > rightIndex)
                merged.Add(right[rightIndex++]);

            return merged;
        }


        public static bool IsLessThan<T>(T obj1, T obj2) where T : IComparable
        {
            return obj1 != null && obj1.CompareTo(obj2) < 0;
        }

        public static bool IsGreaterThan<T> (T obj1, T obj2) where T : IComparable
        {
            return obj1 != null && obj1.CompareTo(obj2) > 0;
        }
    }
}
