namespace Database_Connectivity
{
    partial class Report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.filterbtn = new System.Windows.Forms.Button();
            this.sorttxtbox = new System.Windows.Forms.TextBox();
            this.sortlbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.tblEmployeeDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HRDBDataSet1 = new Database_Connectivity.HRDBDataSet1();
            this.tblEmployeeDetailsTableAdapter = new Database_Connectivity.HRDBDataSet1TableAdapters.tblEmployeeDetailsTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HRDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.refreshbtn);
            this.panel1.Controls.Add(this.filterbtn);
            this.panel1.Controls.Add(this.sorttxtbox);
            this.panel1.Controls.Add(this.sortlbl);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 100);
            this.panel1.TabIndex = 0;
            // 
            // refreshbtn
            // 
            this.refreshbtn.Location = new System.Drawing.Point(560, 38);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(75, 23);
            this.refreshbtn.TabIndex = 3;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = true;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // filterbtn
            // 
            this.filterbtn.Location = new System.Drawing.Point(425, 38);
            this.filterbtn.Name = "filterbtn";
            this.filterbtn.Size = new System.Drawing.Size(75, 23);
            this.filterbtn.TabIndex = 2;
            this.filterbtn.Text = "Filter";
            this.filterbtn.UseVisualStyleBackColor = true;
            this.filterbtn.Click += new System.EventHandler(this.filterbtn_Click);
            // 
            // sorttxtbox
            // 
            this.sorttxtbox.Location = new System.Drawing.Point(286, 38);
            this.sorttxtbox.Name = "sorttxtbox";
            this.sorttxtbox.Size = new System.Drawing.Size(100, 20);
            this.sorttxtbox.TabIndex = 1;
            // 
            // sortlbl
            // 
            this.sortlbl.AutoSize = true;
            this.sortlbl.Location = new System.Drawing.Point(145, 38);
            this.sortlbl.Name = "sortlbl";
            this.sortlbl.Size = new System.Drawing.Size(103, 13);
            this.sortlbl.TabIndex = 0;
            this.sortlbl.Text = "Sort by Employee ID";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Location = new System.Drawing.Point(12, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 320);
            this.panel2.TabIndex = 1;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblEmployeeDetailsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Database_Connectivity.ReportWizard.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(770, 314);
            this.reportViewer1.TabIndex = 0;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(808, 25);
            this.fillByToolStrip.TabIndex = 2;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // tblEmployeeDetailsBindingSource
            // 
            this.tblEmployeeDetailsBindingSource.DataMember = "tblEmployeeDetails";
            this.tblEmployeeDetailsBindingSource.DataSource = this.HRDBDataSet1;
            // 
            // HRDBDataSet1
            // 
            this.HRDBDataSet1.DataSetName = "HRDBDataSet1";
            this.HRDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblEmployeeDetailsTableAdapter
            // 
            this.tblEmployeeDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 458);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HRDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.Button filterbtn;
        private System.Windows.Forms.TextBox sorttxtbox;
        private System.Windows.Forms.Label sortlbl;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblEmployeeDetailsBindingSource;
        private HRDBDataSet1 HRDBDataSet1;
        private HRDBDataSet1TableAdapters.tblEmployeeDetailsTableAdapter tblEmployeeDetailsTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
    }
}