namespace AlgoComplex.Forms
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reverseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hTLMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.wS1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weatherStation2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.airFrostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rainfallRainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sunshineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxTempretureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minTemperatureTMinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.airFrostAfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rainfallRainToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sunshineSunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxTemperatureTMaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minTemperatureTMinToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortToolStripMenuItem,
            this.searcToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(1269, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortByToolStripMenuItem,
            this.reverseToolStripMenuItem});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.sortToolStripMenuItem.Text = "Sort";
            this.sortToolStripMenuItem.ToolTipText = "Set the sorting parameters";
            // 
            // sortByToolStripMenuItem
            // 
            this.sortByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateToolStripMenuItem,
            this.yearToolStripMenuItem,
            this.monthToolStripMenuItem,
            this.wS1ToolStripMenuItem,
            this.weatherStation2ToolStripMenuItem});
            this.sortByToolStripMenuItem.Name = "sortByToolStripMenuItem";
            this.sortByToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.sortByToolStripMenuItem.Text = "Sort By";
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dateToolStripMenuItem.Text = "Date";
            this.dateToolStripMenuItem.ToolTipText = "This will sort the data based on the year and month. E.G. 1999 Dec, 2000 Jan";
            this.dateToolStripMenuItem.Click += new System.EventHandler(this.dateToolStripMenuItem_Click);
            // 
            // yearToolStripMenuItem
            // 
            this.yearToolStripMenuItem.Name = "yearToolStripMenuItem";
            this.yearToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.yearToolStripMenuItem.Text = "Year";
            this.yearToolStripMenuItem.ToolTipText = "Sort the data by the year. E.g. 1999, 2000, 2001";
            this.yearToolStripMenuItem.Click += new System.EventHandler(this.yearToolStripMenuItem_Click);
            // 
            // monthToolStripMenuItem
            // 
            this.monthToolStripMenuItem.Name = "monthToolStripMenuItem";
            this.monthToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.monthToolStripMenuItem.Text = "Month";
            this.monthToolStripMenuItem.Click += new System.EventHandler(this.monthToolStripMenuItem_Click);
            // 
            // reverseToolStripMenuItem
            // 
            this.reverseToolStripMenuItem.CheckOnClick = true;
            this.reverseToolStripMenuItem.Name = "reverseToolStripMenuItem";
            this.reverseToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.reverseToolStripMenuItem.Text = "High to Low (Reverse)";
            this.reverseToolStripMenuItem.ToolTipText = "Check this to reverse the order the data appears in the table.\nHighest value goes" +
    " first, lowest last.";
            this.reverseToolStripMenuItem.Click += new System.EventHandler(this.reverseToolStripMenuItem_Click);
            // 
            // searcToolStripMenuItem
            // 
            this.searcToolStripMenuItem.Name = "searcToolStripMenuItem";
            this.searcToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searcToolStripMenuItem.Text = "Search";
            this.searcToolStripMenuItem.ToolTipText = "Search the data for a value in the given column";
            this.searcToolStripMenuItem.Click += new System.EventHandler(this.searcToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.ToolTipText = "Reset the data shown in the data view.\nOnly use is for seeing all the data";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hTLMToolStripMenuItem,
            this.textFileToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.exportToolStripMenuItem.Text = "Export as...";
            this.exportToolStripMenuItem.ToolTipText = "Save the data shown to the specified file";
            // 
            // hTLMToolStripMenuItem
            // 
            this.hTLMToolStripMenuItem.Name = "hTLMToolStripMenuItem";
            this.hTLMToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.hTLMToolStripMenuItem.Text = "HTML";
            this.hTLMToolStripMenuItem.Click += new System.EventHandler(this.hTLMToolStripMenuItem_Click);
            // 
            // textFileToolStripMenuItem
            // 
            this.textFileToolStripMenuItem.Name = "textFileToolStripMenuItem";
            this.textFileToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.textFileToolStripMenuItem.Text = "Text file";
            this.textFileToolStripMenuItem.Click += new System.EventHandler(this.textFileToolStripMenuItem_Click);
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridView.Location = new System.Drawing.Point(0, 24);
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.RowHeadersVisible = false;
            this.gridView.Size = new System.Drawing.Size(1269, 237);
            this.gridView.TabIndex = 1;
            // 
            // wS1ToolStripMenuItem
            // 
            this.wS1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.airFrostToolStripMenuItem,
            this.rainfallRainToolStripMenuItem,
            this.sunshineToolStripMenuItem,
            this.maxTempretureToolStripMenuItem,
            this.minTemperatureTMinToolStripMenuItem});
            this.wS1ToolStripMenuItem.Name = "wS1ToolStripMenuItem";
            this.wS1ToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.wS1ToolStripMenuItem.Text = "Weather Station 1";
            // 
            // weatherStation2ToolStripMenuItem
            // 
            this.weatherStation2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.airFrostAfToolStripMenuItem,
            this.rainfallRainToolStripMenuItem1,
            this.sunshineSunToolStripMenuItem,
            this.maxTemperatureTMaxToolStripMenuItem,
            this.minTemperatureTMinToolStripMenuItem1});
            this.weatherStation2ToolStripMenuItem.Name = "weatherStation2ToolStripMenuItem";
            this.weatherStation2ToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.weatherStation2ToolStripMenuItem.Text = "Weather Station 2";
            // 
            // airFrostToolStripMenuItem
            // 
            this.airFrostToolStripMenuItem.Name = "airFrostToolStripMenuItem";
            this.airFrostToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.airFrostToolStripMenuItem.Text = "Air Frost (Af)";
            this.airFrostToolStripMenuItem.Click += new System.EventHandler(this.airFrostToolStripMenuItem_Click);
            // 
            // rainfallRainToolStripMenuItem
            // 
            this.rainfallRainToolStripMenuItem.Name = "rainfallRainToolStripMenuItem";
            this.rainfallRainToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.rainfallRainToolStripMenuItem.Text = "Rainfall (Rain)";
            this.rainfallRainToolStripMenuItem.Click += new System.EventHandler(this.rainfallRainToolStripMenuItem_Click);
            // 
            // sunshineToolStripMenuItem
            // 
            this.sunshineToolStripMenuItem.Name = "sunshineToolStripMenuItem";
            this.sunshineToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.sunshineToolStripMenuItem.Text = "Sunshine (Sun)";
            this.sunshineToolStripMenuItem.Click += new System.EventHandler(this.sunshineToolStripMenuItem_Click);
            // 
            // maxTempretureToolStripMenuItem
            // 
            this.maxTempretureToolStripMenuItem.Name = "maxTempretureToolStripMenuItem";
            this.maxTempretureToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.maxTempretureToolStripMenuItem.Text = "Max temperature (TMax)";
            this.maxTempretureToolStripMenuItem.Click += new System.EventHandler(this.maxTempretureToolStripMenuItem_Click);
            // 
            // minTemperatureTMinToolStripMenuItem
            // 
            this.minTemperatureTMinToolStripMenuItem.Name = "minTemperatureTMinToolStripMenuItem";
            this.minTemperatureTMinToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.minTemperatureTMinToolStripMenuItem.Text = "Min temperature (TMin)";
            this.minTemperatureTMinToolStripMenuItem.Click += new System.EventHandler(this.minTemperatureTMinToolStripMenuItem_Click);
            // 
            // airFrostAfToolStripMenuItem
            // 
            this.airFrostAfToolStripMenuItem.Name = "airFrostAfToolStripMenuItem";
            this.airFrostAfToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.airFrostAfToolStripMenuItem.Text = "Air Frost (Af)";
            this.airFrostAfToolStripMenuItem.Click += new System.EventHandler(this.airFrostAfToolStripMenuItem_Click);
            // 
            // rainfallRainToolStripMenuItem1
            // 
            this.rainfallRainToolStripMenuItem1.Name = "rainfallRainToolStripMenuItem1";
            this.rainfallRainToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.rainfallRainToolStripMenuItem1.Text = "Rainfall (Rain)";
            this.rainfallRainToolStripMenuItem1.Click += new System.EventHandler(this.rainfallRainToolStripMenuItem1_Click);
            // 
            // sunshineSunToolStripMenuItem
            // 
            this.sunshineSunToolStripMenuItem.Name = "sunshineSunToolStripMenuItem";
            this.sunshineSunToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.sunshineSunToolStripMenuItem.Text = "Sunshine (Sun)";
            this.sunshineSunToolStripMenuItem.Click += new System.EventHandler(this.sunshineSunToolStripMenuItem_Click);
            // 
            // maxTemperatureTMaxToolStripMenuItem
            // 
            this.maxTemperatureTMaxToolStripMenuItem.Name = "maxTemperatureTMaxToolStripMenuItem";
            this.maxTemperatureTMaxToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.maxTemperatureTMaxToolStripMenuItem.Text = "Max temperature (TMax)";
            this.maxTemperatureTMaxToolStripMenuItem.Click += new System.EventHandler(this.maxTemperatureTMaxToolStripMenuItem_Click);
            // 
            // minTemperatureTMinToolStripMenuItem1
            // 
            this.minTemperatureTMinToolStripMenuItem1.Name = "minTemperatureTMinToolStripMenuItem1";
            this.minTemperatureTMinToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.minTemperatureTMinToolStripMenuItem1.Text = "Min temperature (TMin)";
            this.minTemperatureTMinToolStripMenuItem1.Click += new System.EventHandler(this.minTemperatureTMinToolStripMenuItem1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 261);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hTLMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reverseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wS1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weatherStation2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem airFrostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rainfallRainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sunshineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maxTempretureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minTemperatureTMinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem airFrostAfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rainfallRainToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sunshineSunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maxTemperatureTMaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minTemperatureTMinToolStripMenuItem1;
    }
}