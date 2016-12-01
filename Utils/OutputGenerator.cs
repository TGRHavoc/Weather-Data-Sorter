using System;
using System.Collections.Generic;
using System.Reflection;
using System.IO;

using AlgoComplex.DataTypes;
using System.Text;

namespace AlgoComplex.Utils
{
    public class OutputGenerator
    {
        public static void GenerateHTML(List<WeatherData> toOutput, string title, string htmlName = "output.html")
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            StringBuilder html = new StringBuilder();
            using (StreamReader sr = new StreamReader(assembly.GetManifestResourceStream("AlgoComplex.resources.Template.html")))
            {
                html.Append(sr.ReadToEnd());
            }

            string body = "<table class=\"tg\">";

            body += "<tr><th class=\"tg-baqh\">Year</th><th class=\"tg-baqh\">Month</th>"
                    + "<th class=\"tg-baqh\">Air Frost (WS1)</th><th class=\"tg-baqh\">Rainfall (WS1)</th><th class=\"tg-baqh\">Total hours of sunshine (WS1)</th><th class=\"tg-baqh\">Maximum temp (WS1)</th><th class=\"tg-baqh\">Minimum temp (WS1)</th>"
                    + "<th class=\"tg-baqh\">Air Frost (WS2)</th><th class=\"tg-baqh\">Rainfall (WS2)</th><th class=\"tg-baqh\">Total hours of sunshine (WS2)</th><th class=\"tg-baqh\">Maximum temp (WS2)</th><th class=\"tg-baqh\">Minimum temp (WS2)</th></tr>";

            foreach (WeatherData data in toOutput)
            {
                body += "<tr>";

                body += string.Format("<td class=\"tg-yq6s\">{0}</td>", data.Year);
                body += string.Format("<td class=\"tg-yq6s\">{0}</td>", data.Month);
                body += string.Format("<td class=\"tg-yq6s\">{0}</td>", data.Ws1Af.ToString());
                body += string.Format("<td class=\"tg-yq6s\">{0}</td>", data.Ws1Rain.ToString());
                body += string.Format("<td class=\"tg-yq6s\">{0}</td>", data.Ws1Sun.ToString());
                body += string.Format("<td class=\"tg-yq6s\">{0}</td>", data.Ws1TMax.ToString());
                body += string.Format("<td class=\"tg-yq6s\">{0}</td>", data.Ws1TMin.ToString());

                body += string.Format("<td class=\"tg-yq6s\">{0}</td>", data.Ws2Af.ToString());
                body += string.Format("<td class=\"tg-yq6s\">{0}</td>", data.Ws2Rain.ToString());
                body += string.Format("<td class=\"tg-yq6s\">{0}</td>", data.Ws2Sun.ToString());
                body += string.Format("<td class=\"tg-yq6s\">{0}</td>", data.Ws2TMax.ToString());
                body += string.Format("<td class=\"tg-yq6s\">{0}</td>", data.Ws2TMin.ToString());

                body += "</tr>";
            }

            body += "</table>";

            html.Replace("{title}", title);
            html.Replace("{body}", body);

            using(StreamWriter sw = new StreamWriter(File.Open(htmlName, FileMode.Create)))
            {
                sw.Write(html);
            }

            Console.WriteLine("Outputted html: " + htmlName);
        }

        public static void GenerateTxt(List<WeatherData> toOutput, string filename = "output.txt")
        {
            StringBuilder content = new StringBuilder();

            content.Append(string.Format("{0,20}\t{1,20}\t{2,20}\t{3,20}\t{4,20}\t{5,20}\t{6,20}\t{7,20}\t{8,20}\t{9,20}\t{10,20}\t{11,20}\r\n",
                "Year", "Month", "Air Frost - WS1", "Rain - WS1", "Sunshine - WS1", "Max Temp - WS1", "Min Temp - WS1",
                "Air Frost - WS2", "Rain - WS2", "Sunshine - WS2", "Max Temp - WS2", "Min Temp - WS2"));

            foreach (WeatherData data in toOutput)
            {
                content.Append(data.ToString() + "\r\n");
            }

            using (StreamWriter sw = new StreamWriter(File.Open(filename, FileMode.Create)))
            {
                sw.Write(content.ToString());
            }
        }

    }
}
