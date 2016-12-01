using AlgoComplex.DataTypes;
using System;
using System.Collections.Generic;
using System.IO;

namespace AlgoComplex.Utils
{
    public class Parser
    {
        public static List<WeatherData> ParseDir(string dir)
        {
            if (Directory.Exists(dir))
            {
                int amountOfData = 0;

                using (StreamReader sr = new StreamReader(File.Open(Path.Combine(dir, "Month.txt"), FileMode.Open)))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                        amountOfData++;
                }

                WeatherData[] parsedData = new WeatherData[amountOfData];
                //TODO: Parse
                foreach (string fileToParse in Directory.GetFiles(dir))
                {
                    int currentIndex = 0;
                    using (StreamReader reader = new StreamReader(File.Open(fileToParse, FileMode.Open)))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            //Console.WriteLine(currentIndex);
                            WeatherData current = (parsedData[currentIndex] == null ? new WeatherData() : parsedData[currentIndex]);

                            current.SetValue(Path.GetFileName(fileToParse), line);
                            parsedData[currentIndex++] = current;
                        }
                    }
                }

                return new List<WeatherData>(parsedData);
            }


            return null;
        }
    }
}
