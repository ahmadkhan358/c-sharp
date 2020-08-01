namespace Database_Connectivity
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
            this.showinfolbl = new System.Windows.Forms.Label();
            this.showbtn = new System.Windows.Forms.Button();
            this.showdatagrid = new System.Windows.Forms.DataGridView();
            this.insertbtn = new System.Windows.Forms.Button();
            this.showvalidationbtn = new System.Windows.Forms.Button();
            this.reportbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.showdatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // showinfolbl
            // 
            this.showinfolbl.AutoSize = true;
            this.showinfolbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.showinfolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showinfolbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.showinfolbl.Location = new System.Drawing.Point(243, 33);
            this.showinfolbl.Name = "showinfolbl";
            this.showinfolbl.Size = new System.Drawing.Size(225, 46);
            this.showinfolbl.TabIndex = 0;
            this.showinfolbl.Text = "Show Data";
            // 
            // showbtn
            // 
            this.showbtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.showbtn.Location = new System.Drawing.Point(251, 478);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(75, 23);
            this.showbtn.TabIndex = 2;
            this.showbtn.Text = "Show";
            this.showbtn.UseVisualStyleBackColor = true;
            this.showbtn.Click += new System.EventHandler(this.showbtn_Click);
            // 
            // showdatagrid
            // 
            this.showdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showdatagrid.Location = new System.Drawing.Point(12, 113);
            this.showdatagrid.Name = "showdatagrid";
            this.showdatagrid.Size = new System.Drawing.Size(640, 336);
            this.showdatagrid.TabIndex = 3;
            // 
            // insertbtn
            // 
            this.insertbtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.insertbtn.Location = new System.Drawing.Point(393, 478);
            this.insertbtn.Name = "insertbtn";
            this.insertbtn.Size = new System.Drawing.Size(75, 23);
            this.insertbtn.TabIndex = 4;
            this.insertbtn.Text = "Insert";
            this.insertbtn.UseVisualStyleBackColor = true;
            this.insertbtn.Click += new System.EventHandler(this.insertbtn_Click);
            // 
            // showvalidationbtn
            // 
            this.showvalidationbtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.showvalidationbtn.Location = new System.Drawing.Point(41, 478);
            this.showvalidationbtn.Name = "showvalidationbtn";
            this.showvalidationbtn.Size = new System.Drawing.Size(156, 23);
            this.showvalidationbtn.TabIndex = 5;
            this.showvalidationbtn.Text = "Show Validation Form";
            this.showvalidationbtn.UseVisualStyleBackColor = true;
            this.showvalidationbtn.Click += new System.EventHandler(this.showvalidationbtn_Click);
            // 
            // reportbtn
            // 
            this.reportbtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.reportbtn.Location = new System.Drawing.Point(520, 478);
            this.reportbtn.Name = "reportbtn";
            this.reportbtn.Size = new System.Drawing.Size(75, 23);
            this.reportbtn.TabIndex = 6;
            this.reportbtn.Text = "Report";
            this.reportbtn.UseVisualStyleBackColor = true;
            this.reportbtn.Click += new System.EventHandler(this.reportbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(664, 529);
            this.Controls.Add(this.reportbtn);
            this.Controls.Add(this.showvalidationbtn);
            this.Controls.Add(this.insertbtn);
            this.Controls.Add(this.showdatagrid);
            this.Controls.Add(this.showbtn);
            this.Controls.Add(this.showinfolbl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.showdatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label showinfolbl;
        private System.Windows.Forms.Button showbtn;
        private System.Windows.Forms.DataGridView showdatagrid;
        private System.Windows.Forms.Button insertbtn;
        private System.Windows.Forms.Button showvalidationbtn;
        private System.Windows.Forms.Button reportbtn;
    }
}

