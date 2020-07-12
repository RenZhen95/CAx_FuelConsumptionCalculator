namespace CAx_FuelConsumptionCalculator
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LiterKilometerBox = new MetroFramework.Controls.MetroTextBox();
            this.MilesGallonBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.DataGrid_LogEntries = new MetroFramework.Controls.MetroGrid();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.Consumption_Box = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.DistanceDriven_Box = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.Milage_Box = new MetroFramework.Controls.MetroTextBox();
            this.LoadData_Btn = new MetroFramework.Controls.MetroButton();
            this.Add_Btn = new MetroFramework.Controls.MetroButton();
            this.Delete_Btn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_LogEntries)).BeginInit();
            this.SuspendLayout();
            // 
            // LiterKilometerBox
            // 
            // 
            // 
            // 
            this.LiterKilometerBox.CustomButton.Image = null;
            this.LiterKilometerBox.CustomButton.Location = new System.Drawing.Point(92, 2);
            this.LiterKilometerBox.CustomButton.Name = "";
            this.LiterKilometerBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.LiterKilometerBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LiterKilometerBox.CustomButton.TabIndex = 1;
            this.LiterKilometerBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LiterKilometerBox.CustomButton.UseSelectable = true;
            this.LiterKilometerBox.CustomButton.Visible = false;
            this.LiterKilometerBox.Lines = new string[0];
            this.LiterKilometerBox.Location = new System.Drawing.Point(337, 143);
            this.LiterKilometerBox.MaxLength = 32767;
            this.LiterKilometerBox.Name = "LiterKilometerBox";
            this.LiterKilometerBox.PasswordChar = '\0';
            this.LiterKilometerBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LiterKilometerBox.SelectedText = "";
            this.LiterKilometerBox.SelectionLength = 0;
            this.LiterKilometerBox.SelectionStart = 0;
            this.LiterKilometerBox.ShortcutsEnabled = true;
            this.LiterKilometerBox.Size = new System.Drawing.Size(120, 30);
            this.LiterKilometerBox.TabIndex = 0;
            this.LiterKilometerBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LiterKilometerBox.UseSelectable = true;
            this.LiterKilometerBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LiterKilometerBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MilesGallonBox
            // 
            // 
            // 
            // 
            this.MilesGallonBox.CustomButton.Image = null;
            this.MilesGallonBox.CustomButton.Location = new System.Drawing.Point(92, 2);
            this.MilesGallonBox.CustomButton.Name = "";
            this.MilesGallonBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.MilesGallonBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MilesGallonBox.CustomButton.TabIndex = 1;
            this.MilesGallonBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MilesGallonBox.CustomButton.UseSelectable = true;
            this.MilesGallonBox.CustomButton.Visible = false;
            this.MilesGallonBox.Lines = new string[0];
            this.MilesGallonBox.Location = new System.Drawing.Point(468, 143);
            this.MilesGallonBox.MaxLength = 32767;
            this.MilesGallonBox.Name = "MilesGallonBox";
            this.MilesGallonBox.PasswordChar = '\0';
            this.MilesGallonBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MilesGallonBox.SelectedText = "";
            this.MilesGallonBox.SelectionLength = 0;
            this.MilesGallonBox.SelectionStart = 0;
            this.MilesGallonBox.ShortcutsEnabled = true;
            this.MilesGallonBox.Size = new System.Drawing.Size(120, 30);
            this.MilesGallonBox.TabIndex = 1;
            this.MilesGallonBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MilesGallonBox.UseSelectable = true;
            this.MilesGallonBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MilesGallonBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(334, 121);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(115, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Liter per 100km";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(465, 121);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(118, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Miles per Gallon";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // DataGrid_LogEntries
            // 
            this.DataGrid_LogEntries.AllowUserToResizeColumns = false;
            this.DataGrid_LogEntries.AllowUserToResizeRows = false;
            this.DataGrid_LogEntries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid_LogEntries.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGrid_LogEntries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid_LogEntries.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGrid_LogEntries.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_LogEntries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_LogEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid_LogEntries.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid_LogEntries.EnableHeadersVisualStyles = false;
            this.DataGrid_LogEntries.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DataGrid_LogEntries.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGrid_LogEntries.Location = new System.Drawing.Point(11, 189);
            this.DataGrid_LogEntries.Name = "DataGrid_LogEntries";
            this.DataGrid_LogEntries.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_LogEntries.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid_LogEntries.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGrid_LogEntries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_LogEntries.Size = new System.Drawing.Size(577, 150);
            this.DataGrid_LogEntries.TabIndex = 6;
            this.DataGrid_LogEntries.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_LogEntries_CellValueChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(168, 121);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(141, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Consumption [Liter]";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Consumption_Box
            // 
            // 
            // 
            // 
            this.Consumption_Box.CustomButton.Image = null;
            this.Consumption_Box.CustomButton.Location = new System.Drawing.Point(92, 2);
            this.Consumption_Box.CustomButton.Name = "";
            this.Consumption_Box.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.Consumption_Box.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Consumption_Box.CustomButton.TabIndex = 1;
            this.Consumption_Box.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Consumption_Box.CustomButton.UseSelectable = true;
            this.Consumption_Box.CustomButton.Visible = false;
            this.Consumption_Box.Lines = new string[0];
            this.Consumption_Box.Location = new System.Drawing.Point(177, 143);
            this.Consumption_Box.MaxLength = 32767;
            this.Consumption_Box.Name = "Consumption_Box";
            this.Consumption_Box.PasswordChar = '\0';
            this.Consumption_Box.PromptText = "Enter Value";
            this.Consumption_Box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Consumption_Box.SelectedText = "";
            this.Consumption_Box.SelectionLength = 0;
            this.Consumption_Box.SelectionStart = 0;
            this.Consumption_Box.ShortcutsEnabled = true;
            this.Consumption_Box.Size = new System.Drawing.Size(120, 30);
            this.Consumption_Box.TabIndex = 7;
            this.Consumption_Box.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Consumption_Box.UseSelectable = true;
            this.Consumption_Box.WaterMark = "Enter Value";
            this.Consumption_Box.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Consumption_Box.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(17, 121);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(148, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Distance Driven [km]";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // DistanceDriven_Box
            // 
            // 
            // 
            // 
            this.DistanceDriven_Box.CustomButton.Image = null;
            this.DistanceDriven_Box.CustomButton.Location = new System.Drawing.Point(92, 2);
            this.DistanceDriven_Box.CustomButton.Name = "";
            this.DistanceDriven_Box.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.DistanceDriven_Box.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DistanceDriven_Box.CustomButton.TabIndex = 1;
            this.DistanceDriven_Box.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DistanceDriven_Box.CustomButton.UseSelectable = true;
            this.DistanceDriven_Box.CustomButton.Visible = false;
            this.DistanceDriven_Box.Lines = new string[0];
            this.DistanceDriven_Box.Location = new System.Drawing.Point(25, 143);
            this.DistanceDriven_Box.MaxLength = 32767;
            this.DistanceDriven_Box.Name = "DistanceDriven_Box";
            this.DistanceDriven_Box.PasswordChar = '\0';
            this.DistanceDriven_Box.PromptText = "Enter Value";
            this.DistanceDriven_Box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DistanceDriven_Box.SelectedText = "";
            this.DistanceDriven_Box.SelectionLength = 0;
            this.DistanceDriven_Box.SelectionStart = 0;
            this.DistanceDriven_Box.ShortcutsEnabled = true;
            this.DistanceDriven_Box.Size = new System.Drawing.Size(120, 30);
            this.DistanceDriven_Box.TabIndex = 9;
            this.DistanceDriven_Box.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DistanceDriven_Box.UseSelectable = true;
            this.DistanceDriven_Box.WaterMark = "Enter Value";
            this.DistanceDriven_Box.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DistanceDriven_Box.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(17, 61);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(90, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Milage [km]";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Milage_Box
            // 
            // 
            // 
            // 
            this.Milage_Box.CustomButton.Image = null;
            this.Milage_Box.CustomButton.Location = new System.Drawing.Point(92, 2);
            this.Milage_Box.CustomButton.Name = "";
            this.Milage_Box.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.Milage_Box.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Milage_Box.CustomButton.TabIndex = 1;
            this.Milage_Box.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Milage_Box.CustomButton.UseSelectable = true;
            this.Milage_Box.CustomButton.Visible = false;
            this.Milage_Box.Lines = new string[0];
            this.Milage_Box.Location = new System.Drawing.Point(25, 83);
            this.Milage_Box.MaxLength = 32767;
            this.Milage_Box.Name = "Milage_Box";
            this.Milage_Box.PasswordChar = '\0';
            this.Milage_Box.PromptText = "Enter Value";
            this.Milage_Box.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Milage_Box.SelectedText = "";
            this.Milage_Box.SelectionLength = 0;
            this.Milage_Box.SelectionStart = 0;
            this.Milage_Box.ShortcutsEnabled = true;
            this.Milage_Box.Size = new System.Drawing.Size(120, 30);
            this.Milage_Box.TabIndex = 11;
            this.Milage_Box.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Milage_Box.UseSelectable = true;
            this.Milage_Box.WaterMark = "Enter Value";
            this.Milage_Box.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Milage_Box.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LoadData_Btn
            // 
            this.LoadData_Btn.Location = new System.Drawing.Point(177, 83);
            this.LoadData_Btn.Name = "LoadData_Btn";
            this.LoadData_Btn.Size = new System.Drawing.Size(75, 23);
            this.LoadData_Btn.TabIndex = 13;
            this.LoadData_Btn.Text = "Load Data";
            this.LoadData_Btn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LoadData_Btn.UseSelectable = true;
            this.LoadData_Btn.Click += new System.EventHandler(this.LoadData_Btn_Click);
            // 
            // Add_Btn
            // 
            this.Add_Btn.Location = new System.Drawing.Point(336, 83);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(75, 23);
            this.Add_Btn.TabIndex = 14;
            this.Add_Btn.Text = "Add";
            this.Add_Btn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Add_Btn.UseSelectable = true;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.Location = new System.Drawing.Point(465, 83);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(75, 23);
            this.Delete_Btn.TabIndex = 15;
            this.Delete_Btn.Text = "Delete";
            this.Delete_Btn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Delete_Btn.UseSelectable = true;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 351);
            this.Controls.Add(this.Delete_Btn);
            this.Controls.Add(this.Add_Btn);
            this.Controls.Add(this.LoadData_Btn);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.Milage_Box);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.DistanceDriven_Box);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.Consumption_Box);
            this.Controls.Add(this.DataGrid_LogEntries);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.MilesGallonBox);
            this.Controls.Add(this.LiterKilometerBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "Drive Log Book";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_LogEntries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox LiterKilometerBox;
        private MetroFramework.Controls.MetroTextBox MilesGallonBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroGrid DataGrid_LogEntries;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox Consumption_Box;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox DistanceDriven_Box;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox Milage_Box;
        private MetroFramework.Controls.MetroButton LoadData_Btn;
        private MetroFramework.Controls.MetroButton Add_Btn;
        private MetroFramework.Controls.MetroButton Delete_Btn;
    }
}

