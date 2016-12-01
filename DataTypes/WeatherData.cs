using System;
using System.Collections.Generic;

namespace AlgoComplex.DataTypes
{
    public class WeatherData
    {
        string _month; //Month of the data set
        string _year; //Year of the data set. When sorting by year, month must be sorted Jan->Dec

        //Data for weather station 1
        int _ws1Af;
        double _ws1Rain;
        double _ws1Sun;
        double _ws1TMax;
        double _ws1TMin;

        //Data for weather station 2
        int _ws2Af; // Days of Air frost 
        double _ws2Rain; // Rainfall (mm)
        double _ws2Sun; // Total hours of sunshine
        double _ws2TMax; // Temp max
        double _ws2TMin; //Temp min

        public string Month
        {
            get { return _month; }
        }
        public string Year
        {
            get { return _year; }
        }
        public int Ws1Af
        {
            get { return _ws1Af; }
        }
        public double Ws1Rain
        {
            get { return _ws1Rain; }
        }
        public double Ws1Sun
        {
            get { return _ws1Sun; }
        }
        public double Ws1TMax
        {
            get { return _ws1TMax; }
        }
        public double Ws1TMin
        {
            get { return _ws1TMin; }
        }

        public int Ws2Af
        {
            get { return _ws2Af; }
        }
        public double Ws2Rain
        {
            get { return _ws2Rain; }
        }
        public double Ws2Sun
        {
            get { return _ws2Sun; }
        }
        public double Ws2TMax
        {
            get { return _ws2TMax; }
        }
        public double Ws2TMin
        {
            get { return _ws2TMin; }
        }

        public WeatherData()
        {
        }

        public IComparable GetValue(string toGet)
        {
            toGet = toGet.ToLower();
            switch (toGet)
            {
                case "month":
                    return Utils.DateUtil.MonthStringToInt(_month);
                case "date": //For sorting only... Allows use to get dates in real order rather than alphabetical
                    return DateTime.Parse("1/" + Utils.DateUtil.MonthStringToInt(_month) + "/" + _year);
                case "year":
                    return _year;
                case "ws1_af":
                    return _ws1Af;
                case "ws1_rain":
                    return _ws1Rain;
                case "ws1_sun":
                    return _ws1Sun;
                case "ws1_tmax":
                    return _ws1TMax;
                case "ws1_tmin":
                    return _ws1TMin;

                case "ws2_af":
                    return _ws2Af;
                case "ws2_rain":
                    return _ws2Rain;
                case "ws2_sun":
                    return _ws2Sun;
                case "ws2_tmax":
                    return _ws2TMax;
                case "ws2_tmin":
                    return _ws2TMin;
            }

            return null;
        }

        public override string ToString()
        {
            return string.Format("{0,20}\t{1,20}\t{2,20}\t{3,20}\t{4,20}\t{5,20}\t{6,20}\t{7,20}\t{8,20}\t{9,20}\t{10,20}\t{11,20}", _month, _year, _ws1Af, _ws1Rain, _ws1Sun, _ws1TMax, _ws1TMin,
                                _ws2Af, _ws2Rain, _ws2Sun, _ws2TMax, _ws2TMin);
        }

        public void SetValue(string fileName, string value)
        {
            if (string.IsNullOrEmpty(value))
                return;

            switch (fileName)
            {
                case "Month.txt":
                    _month = value;
                    break;
                case "Year.txt":
                    _year = value;
                    break;
                case "WS1_AF.txt":
                    _ws1Af = int.Parse(value);
                    break;
                case "WS1_TMin.txt":
                    _ws1TMin = double.Parse(value);
                    break;
                case "WS1_TMax.txt":
                    _ws1TMax = double.Parse(value);
                    break;
                case "WS1_Sun.txt":
                    _ws1Sun = double.Parse(value);
                    break;
                case "WS1_Rain.txt":
                    _ws1Rain = double.Parse(value);
                    break;

                case "WS2_AF.txt":
                    _ws2Af = int.Parse(value);
                    break;
                case "WS2_TMin.txt":
                    _ws2TMin = double.Parse(value);
                    break;
                case "WS2_TMax.txt":
                    _ws2TMax = double.Parse(value);
                    break;
                case "WS2_Sun.txt":
                    _ws2Sun = double.Parse(value);
                    break;
                case "WS2_Rain.txt":
                    _ws2Rain = double.Parse(value);
                    break;
            }
        }
    }
}
