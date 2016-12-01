using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlgoComplex.DataTypes;

namespace AlgoComplex.Forms
{
    public partial class MainWindow : Form
    {

        private List<WeatherData> _data; //Original list of data (unsorted)
        private List<WeatherData> _sorted; //List that we can do our operations on. Make sure to re-bind

        private string sortBy = "date"; //How should I sort the data?
        private bool highToLow = false; //Should I show highest values first?

        public MainWindow(List<WeatherData> data)
        {
            InitializeComponent();

            _data = _sorted = data;

            BindList(_sorted);
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _sorted = _data;
            BindList(_sorted);
        }

        private void searcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SearchForm(Search).Show();
        }

        private void hTLMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.OutputGenerator.GenerateHTML(_sorted, "Sorted Output");
            MessageBox.Show("Your data has been put in \"output.html\"");
        }

        private void textFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.OutputGenerator.GenerateTxt(_sorted);
            MessageBox.Show("Your data has been put in \"output.txt\"");
        }

        private void reverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            highToLow = reverseToolStripMenuItem.Checked;

            Sort();
        }

        //Sorting menu items
        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortBy = "date";
            UncheckAllSorts();
            dateToolStripMenuItem.Checked = true;
        }

        private void yearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortBy = "date";
            UncheckAllSorts();
            yearToolStripMenuItem.Checked = true;
        }

        private void monthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortBy = "month";
            UncheckAllSorts();
            monthToolStripMenuItem.Checked = true;
        }

        private void sunshineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortBy = "ws1_sun";
            UncheckAllSorts();
            sunshineSunToolStripMenuItem.Checked = true;
        }

        private void airFrostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortBy = "ws1_af";
            UncheckAllSorts();
            airFrostToolStripMenuItem.Checked = true;
        }

        private void rainfallRainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortBy = "ws1_rain";
            UncheckAllSorts();
            rainfallRainToolStripMenuItem.Checked = true;
        }

        private void maxTempretureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortBy = "ws1_tmax";
            UncheckAllSorts();
            maxTempretureToolStripMenuItem.Checked = true;
        }

        private void minTemperatureTMinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortBy = "ws1_tmin";
            UncheckAllSorts();
            minTemperatureTMinToolStripMenuItem.Checked = true;
        }

        private void airFrostAfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortBy = "ws2_af";
            UncheckAllSorts();
            airFrostAfToolStripMenuItem.Checked = true;
        }

        private void rainfallRainToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sortBy = "ws2_rain";
            UncheckAllSorts();
            rainfallRainToolStripMenuItem1.Checked = true;
        }

        private void sunshineSunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortBy = "ws2_sun";
            UncheckAllSorts();
            sunshineSunToolStripMenuItem.Checked = true;
        }

        private void maxTemperatureTMaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortBy = "ws2_tmax";
            UncheckAllSorts();
            maxTemperatureTMaxToolStripMenuItem.Checked = true;
        }

        private void minTemperatureTMinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sortBy = "ws2_tmin";
            UncheckAllSorts();
            minTemperatureTMinToolStripMenuItem.Checked = true;
        }
    }
}
