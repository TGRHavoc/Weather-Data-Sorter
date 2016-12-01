using AlgoComplex.DataTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace AlgoComplex.Forms
{
    partial class MainWindow
    {
        private void UncheckAllSorts()
        {
            yearToolStripMenuItem.Checked = false;
            monthToolStripMenuItem.Checked = false;
            dateToolStripMenuItem.Checked = false;

            airFrostToolStripMenuItem.Checked = false;
            rainfallRainToolStripMenuItem.Checked = false;
            sunshineToolStripMenuItem.Checked = false;
            maxTempretureToolStripMenuItem.Checked = false;
            minTemperatureTMinToolStripMenuItem.Checked = false;

            airFrostAfToolStripMenuItem.Checked = false;
            rainfallRainToolStripMenuItem1.Checked = false;
            sunshineSunToolStripMenuItem.Checked = false;
            maxTemperatureTMaxToolStripMenuItem.Checked = false;
            minTemperatureTMinToolStripMenuItem1.Checked = false;


            Sort();// They all call this anyways...
        }

        private void Search(string key, IComparable value)
        {
            _sorted = Utils.MergeSort.Sort(_data, key); //Make sure we have a sorted array to search
            _sorted = Utils.BinarySearch.GetAllValues(_sorted, key, value);
            
            //Re sort them by date because search is "messy"
            _sorted = Utils.MergeSort.Sort(_sorted, sortBy, highToLow);

            if (_sorted.Count <= 0)
            {
                MessageBox.Show(string.Format("I couldn't find anything witth the value \"{0}\" using the key \"{1}\"", value, key));
            }

            BindList(_sorted);
        }

        private void Sort()
        {
            _sorted = Utils.MergeSort.Sort(_sorted, sortBy, highToLow);
            BindList(_sorted);
        }


        private void BindList(List<WeatherData> toBind)
        {
            var bindingList = new BindingList<WeatherData>(toBind);
            var source = new BindingSource(bindingList, null);
            gridView.DataSource = source;
        }

    }
}
