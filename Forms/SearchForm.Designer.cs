namespace AlgoComplex.Forms
{
    partial class SearchForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.keyBox = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.numberSelect = new System.Windows.Forms.NumericUpDown();
            this.monthBox = new System.Windows.Forms.ComboBox();
            this.yearPicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numberSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search In";
            this.toolTip1.SetToolTip(this.label1, "What column do you want to search in?");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search For";
            this.toolTip1.SetToolTip(this.label2, "What column do you want to search in?");
            // 
            // keyBox
            // 
            this.keyBox.FormattingEnabled = true;
            this.keyBox.Items.AddRange(new object[] {
            "Year",
            "Month",
            "Weather Station 1 - Air Frost",
            "Weather Station 1 - Rain",
            "Weather Station 1 - Sunshine",
            "Weather Station 1 - Max Tempreture",
            "Weather Station 1 - Min Tempreture",
            "Weather Station 2 - Air Frost",
            "Weather Station 2 - Rain",
            "Weather Station 2 - Sunshine",
            "Weather Station 2 - Max Tempreture",
            "Weather Station 2 - Min Tempreture"});
            this.keyBox.Location = new System.Drawing.Point(121, 6);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(179, 21);
            this.keyBox.TabIndex = 1;
            this.keyBox.Text = "Please select a value...";
            this.keyBox.SelectedIndexChanged += new System.EventHandler(this.keyBox_SelectedIndexChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(12, 120);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(222, 120);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // numberSelect
            // 
            this.numberSelect.DecimalPlaces = 2;
            this.numberSelect.Location = new System.Drawing.Point(121, 56);
            this.numberSelect.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.numberSelect.Name = "numberSelect";
            this.numberSelect.Size = new System.Drawing.Size(179, 20);
            this.numberSelect.TabIndex = 5;
            // 
            // monthBox
            // 
            this.monthBox.FormattingEnabled = true;
            this.monthBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthBox.Location = new System.Drawing.Point(118, 108);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(179, 21);
            this.monthBox.TabIndex = 6;
            // 
            // yearPicker
            // 
            this.yearPicker.CustomFormat = "yyyy";
            this.yearPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.yearPicker.Location = new System.Drawing.Point(121, 82);
            this.yearPicker.Name = "yearPicker";
            this.yearPicker.Size = new System.Drawing.Size(179, 20);
            this.yearPicker.TabIndex = 7;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 155);
            this.Controls.Add(this.yearPicker);
            this.Controls.Add(this.monthBox);
            this.Controls.Add(this.numberSelect);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.label1);
            this.Name = "SearchForm";
            this.Text = "Search For";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox keyBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.NumericUpDown numberSelect;
        private System.Windows.Forms.ComboBox monthBox;
        private System.Windows.Forms.DateTimePicker yearPicker;
    }
}