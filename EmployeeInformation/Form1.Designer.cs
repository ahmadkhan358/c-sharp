namespace Employee_Information
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
            this.empnomaskedtxtbox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emplbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.nametxtbox = new System.Windows.Forms.TextBox();
            this.addresslbl = new System.Windows.Forms.Label();
            this.addresstxtbox = new System.Windows.Forms.TextBox();
            this.citycombobox = new System.Windows.Forms.ComboBox();
            this.citylbl = new System.Windows.Forms.Label();
            this.provincelbl = new System.Windows.Forms.Label();
            this.provincelistbox = new System.Windows.Forms.ListBox();
            this.datelbl = new System.Windows.Forms.Label();
            this.dobdatetimepicker = new System.Windows.Forms.DateTimePicker();
            this.agenumericupdown = new System.Windows.Forms.NumericUpDown();
            this.agelbl = new System.Windows.Forms.Label();
            this.genderlbl = new System.Windows.Forms.Label();
            this.maleradio = new System.Windows.Forms.RadioButton();
            this.femaleradio = new System.Windows.Forms.RadioButton();
            this.submitbtn = new System.Windows.Forms.Button();
            this.hobbieschecklist = new System.Windows.Forms.CheckedListBox();
            this.hobbieslbl = new System.Windows.Forms.Label();
            this.detailsgroupbox = new System.Windows.Forms.GroupBox();
            this.resulttxtbox = new System.Windows.Forms.TextBox();
            this.resetbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.agenumericupdown)).BeginInit();
            this.detailsgroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // empnomaskedtxtbox
            // 
            this.empnomaskedtxtbox.Location = new System.Drawing.Point(243, 150);
            this.empnomaskedtxtbox.Mask = "0000";
            this.empnomaskedtxtbox.Name = "empnomaskedtxtbox";
            this.empnomaskedtxtbox.Size = new System.Drawing.Size(28, 20);
            this.empnomaskedtxtbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Information";
            // 
            // emplbl
            // 
            this.emplbl.AutoSize = true;
            this.emplbl.Location = new System.Drawing.Point(165, 150);
            this.emplbl.Name = "emplbl";
            this.emplbl.Size = new System.Drawing.Size(63, 13);
            this.emplbl.TabIndex = 2;
            this.emplbl.Text = "Employee #";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(165, 184);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(35, 13);
            this.namelbl.TabIndex = 3;
            this.namelbl.Text = "Name";
            // 
            // nametxtbox
            // 
            this.nametxtbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.nametxtbox.Location = new System.Drawing.Point(243, 184);
            this.nametxtbox.Name = "nametxtbox";
            this.nametxtbox.Size = new System.Drawing.Size(100, 20);
            this.nametxtbox.TabIndex = 4;
            // 
            // addresslbl
            // 
            this.addresslbl.AutoSize = true;
            this.addresslbl.Location = new System.Drawing.Point(165, 228);
            this.addresslbl.Name = "addresslbl";
            this.addresslbl.Size = new System.Drawing.Size(45, 13);
            this.addresslbl.TabIndex = 5;
            this.addresslbl.Text = "Address";
            // 
            // addresstxtbox
            // 
            this.addresstxtbox.Location = new System.Drawing.Point(243, 225);
            this.addresstxtbox.Multiline = true;
            this.addresstxtbox.Name = "addresstxtbox";
            this.addresstxtbox.Size = new System.Drawing.Size(233, 140);
            this.addresstxtbox.TabIndex = 6;
            // 
            // citycombobox
            // 
            this.citycombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.citycombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.citycombobox.FormattingEnabled = true;
            this.citycombobox.Items.AddRange(new object[] {
            "Rawalpindi",
            "Lahore",
            "Islamabad",
            "Peshawar",
            "Karachi",
            "Quetta"});
            this.citycombobox.Location = new System.Drawing.Point(243, 389);
            this.citycombobox.Name = "citycombobox";
            this.citycombobox.Size = new System.Drawing.Size(121, 21);
            this.citycombobox.TabIndex = 7;
            // 
            // citylbl
            // 
            this.citylbl.AutoSize = true;
            this.citylbl.Location = new System.Drawing.Point(165, 389);
            this.citylbl.Name = "citylbl";
            this.citylbl.Size = new System.Drawing.Size(24, 13);
            this.citylbl.TabIndex = 8;
            this.citylbl.Text = "City";
            // 
            // provincelbl
            // 
            this.provincelbl.AutoSize = true;
            this.provincelbl.Location = new System.Drawing.Point(165, 439);
            this.provincelbl.Name = "provincelbl";
            this.provincelbl.Size = new System.Drawing.Size(49, 13);
            this.provincelbl.TabIndex = 9;
            this.provincelbl.Text = "Province";
            // 
            // provincelistbox
            // 
            this.provincelistbox.FormattingEnabled = true;
            this.provincelistbox.Items.AddRange(new object[] {
            "Punjab",
            "Sindh",
            "KPK",
            "Balochistan"});
            this.provincelistbox.Location = new System.Drawing.Point(243, 439);
            this.provincelistbox.Name = "provincelistbox";
            this.provincelistbox.Size = new System.Drawing.Size(121, 56);
            this.provincelistbox.TabIndex = 10;
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Location = new System.Drawing.Point(165, 523);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(30, 13);
            this.datelbl.TabIndex = 11;
            this.datelbl.Text = "DOB";
            // 
            // dobdatetimepicker
            // 
            this.dobdatetimepicker.Location = new System.Drawing.Point(243, 523);
            this.dobdatetimepicker.Name = "dobdatetimepicker";
            this.dobdatetimepicker.Size = new System.Drawing.Size(200, 20);
            this.dobdatetimepicker.TabIndex = 12;
            // 
            // agenumericupdown
            // 
            this.agenumericupdown.Location = new System.Drawing.Point(243, 557);
            this.agenumericupdown.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.agenumericupdown.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.agenumericupdown.Name = "agenumericupdown";
            this.agenumericupdown.Size = new System.Drawing.Size(120, 20);
            this.agenumericupdown.TabIndex = 13;
            this.agenumericupdown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // agelbl
            // 
            this.agelbl.AutoSize = true;
            this.agelbl.Location = new System.Drawing.Point(165, 557);
            this.agelbl.Name = "agelbl";
            this.agelbl.Size = new System.Drawing.Size(26, 13);
            this.agelbl.TabIndex = 14;
            this.agelbl.Text = "Age";
            // 
            // genderlbl
            // 
            this.genderlbl.AutoSize = true;
            this.genderlbl.Location = new System.Drawing.Point(165, 600);
            this.genderlbl.Name = "genderlbl";
            this.genderlbl.Size = new System.Drawing.Size(42, 13);
            this.genderlbl.TabIndex = 15;
            this.genderlbl.Text = "Gender";
            // 
            // maleradio
            // 
            this.maleradio.AutoSize = true;
            this.maleradio.Location = new System.Drawing.Point(243, 598);
            this.maleradio.Name = "maleradio";
            this.maleradio.Size = new System.Drawing.Size(48, 17);
            this.maleradio.TabIndex = 16;
            this.maleradio.TabStop = true;
            this.maleradio.Text = "Male";
            this.maleradio.UseVisualStyleBackColor = true;
            // 
            // femaleradio
            // 
            this.femaleradio.AutoSize = true;
            this.femaleradio.Location = new System.Drawing.Point(304, 597);
            this.femaleradio.Name = "femaleradio";
            this.femaleradio.Size = new System.Drawing.Size(59, 17);
            this.femaleradio.TabIndex = 17;
            this.femaleradio.TabStop = true;
            this.femaleradio.Text = "Female";
            this.femaleradio.UseVisualStyleBackColor = true;
            // 
            // submitbtn
            // 
            this.submitbtn.Location = new System.Drawing.Point(243, 728);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(75, 23);
            this.submitbtn.TabIndex = 19;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // hobbieschecklist
            // 
            this.hobbieschecklist.FormattingEnabled = true;
            this.hobbieschecklist.Items.AddRange(new object[] {
            "Gaming",
            "Gardening",
            "Painting"});
            this.hobbieschecklist.Location = new System.Drawing.Point(243, 635);
            this.hobbieschecklist.Name = "hobbieschecklist";
            this.hobbieschecklist.Size = new System.Drawing.Size(75, 49);
            this.hobbieschecklist.TabIndex = 20;
            // 
            // hobbieslbl
            // 
            this.hobbieslbl.AutoSize = true;
            this.hobbieslbl.Location = new System.Drawing.Point(165, 635);
            this.hobbieslbl.Name = "hobbieslbl";
            this.hobbieslbl.Size = new System.Drawing.Size(46, 13);
            this.hobbieslbl.TabIndex = 21;
            this.hobbieslbl.Text = "Hobbies";
            // 
            // detailsgroupbox
            // 
            this.detailsgroupbox.Controls.Add(this.resulttxtbox);
            this.detailsgroupbox.Location = new System.Drawing.Point(616, 184);
            this.detailsgroupbox.Name = "detailsgroupbox";
            this.detailsgroupbox.Size = new System.Drawing.Size(328, 500);
            this.detailsgroupbox.TabIndex = 22;
            this.detailsgroupbox.TabStop = false;
            this.detailsgroupbox.Text = "Details";
            // 
            // resulttxtbox
            // 
            this.resulttxtbox.Location = new System.Drawing.Point(6, 19);
            this.resulttxtbox.Multiline = true;
            this.resulttxtbox.Name = "resulttxtbox";
            this.resulttxtbox.Size = new System.Drawing.Size(316, 475);
            this.resulttxtbox.TabIndex = 0;
            // 
            // resetbtn
            // 
            this.resetbtn.Location = new System.Drawing.Point(776, 728);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(75, 23);
            this.resetbtn.TabIndex = 23;
            this.resetbtn.Text = "Reset";
            this.resetbtn.UseVisualStyleBackColor = true;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(869, 728);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(75, 23);
            this.exitbtn.TabIndex = 24;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 849);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.detailsgroupbox);
            this.Controls.Add(this.hobbieslbl);
            this.Controls.Add(this.hobbieschecklist);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.femaleradio);
            this.Controls.Add(this.maleradio);
            this.Controls.Add(this.genderlbl);
            this.Controls.Add(this.agelbl);
            this.Controls.Add(this.agenumericupdown);
            this.Controls.Add(this.dobdatetimepicker);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.provincelistbox);
            this.Controls.Add(this.provincelbl);
            this.Controls.Add(this.citylbl);
            this.Controls.Add(this.citycombobox);
            this.Controls.Add(this.addresstxtbox);
            this.Controls.Add(this.addresslbl);
            this.Controls.Add(this.nametxtbox);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.emplbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.empnomaskedtxtbox);
            this.Name = "Form1";
            this.Text = "Employeeinfo";
            ((System.ComponentModel.ISupportInitialize)(this.agenumericupdown)).EndInit();
            this.detailsgroupbox.ResumeLayout(false);
            this.detailsgroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox empnomaskedtxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label emplbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.TextBox nametxtbox;
        private System.Windows.Forms.Label addresslbl;
        private System.Windows.Forms.TextBox addresstxtbox;
        private System.Windows.Forms.ComboBox citycombobox;
        private System.Windows.Forms.Label citylbl;
        private System.Windows.Forms.Label provincelbl;
        private System.Windows.Forms.ListBox provincelistbox;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.DateTimePicker dobdatetimepicker;
        private System.Windows.Forms.NumericUpDown agenumericupdown;
        private System.Windows.Forms.Label agelbl;
        private System.Windows.Forms.Label genderlbl;
        private System.Windows.Forms.RadioButton maleradio;
        private System.Windows.Forms.RadioButton femaleradio;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.CheckedListBox hobbieschecklist;
        private System.Windows.Forms.Label hobbieslbl;
        private System.Windows.Forms.GroupBox detailsgroupbox;
        private System.Windows.Forms.TextBox resulttxtbox;
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.Button exitbtn;
    }
}

