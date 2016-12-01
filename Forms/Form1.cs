using System;
using System.IO;

using System.Windows.Forms;
using AlgoComplex.Utils;
using AlgoComplex.Forms;

namespace AlgoComplex
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            folderSelector.SelectedPath = Path.Combine(Directory.GetCurrentDirectory(), "data");
        }

        private void folderSelector_HelpRequest(object sender, EventArgs e)
        {

        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            if (folderSelector.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //Loaded :D
                    new MainWindow(Parser.ParseDir(folderSelector.SelectedPath)).Show();
                    Hide();
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Just for testing :)
            //new MainWindow(Parser.ParseDir("data")).Show();
            //Hide();
        }
    }
}
