using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlgoComplex.Forms
{
    public partial class SearchForm : Form
    {
        Action<string, IComparable> callback;

        List<string> lazyList = new List<string>()
        {
            "year", "month",
            "ws1_af", "ws1_rain", "ws1_sun", "ws1_tmax", "ws1_tmin",
            "ws2_af", "ws2_rain", "ws2_sun", "ws2_tmax", "ws2_tmin"
        };
        public SearchForm(Action<string, IComparable> callback)
        {
            InitializeComponent();

            this.callback = callback;

            monthBox.Hide();
            numberSelect.Hide();
            yearPicker.Hide();

            monthBox.Location = new System.Drawing.Point(121, 56);
            numberSelect.Location = new System.Drawing.Point(121, 56);
            yearPicker.Location = new System.Drawing.Point(121, 56);
        }

        private void keyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(keyBox.Text == "Month")
            {
                monthBox.Show();
                numberSelect.Hide();
                yearPicker.Hide();
            }
            else if (keyBox.Text == "Year")
            {
                monthBox.Hide();
                numberSelect.Hide();
                yearPicker.Show();
            }
            else
            {
                monthBox.Hide();
                numberSelect.Show();
                yearPicker.Hide();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (keyBox.Text == "Please select a value...")
            {
                MessageBox.Show("Please select a value.", "Error", MessageBoxButtons.OK);
                return;
            }

            Console.WriteLine("Sorting by : " + lazyList[keyBox.SelectedIndex]);
            
            if(keyBox.Text == "Month")
            {
                callback(lazyList[keyBox.SelectedIndex], Utils.DateUtil.MonthStringToInt(monthBox.Text));
            }
            else if (keyBox.Text == "Year")
            {
                callback(lazyList[keyBox.SelectedIndex], yearPicker.Text);
            }
            else
            {
                if (keyBox.Text.Contains("Air Frost"))
                {
                    callback(lazyList[keyBox.SelectedIndex], (int)numberSelect.Value);
                }
                else
                {
                    callback(lazyList[keyBox.SelectedIndex], (double)numberSelect.Value);
                }
            }

            Dispose(true);

        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }
    }
}
