namespace Database_Connectivity
{
    partial class Form2
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
            this.namelbl = new System.Windows.Forms.Label();
            this.designationlbl = new System.Windows.Forms.Label();
            this.salarylbl = new System.Windows.Forms.Label();
            this.nametxtbox = new System.Windows.Forms.TextBox();
            this.designationtxtbox = new System.Windows.Forms.TextBox();
            this.salarytxtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.insertbtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.resetbtn = new System.Windows.Forms.Button();
            this.showdatagrid = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.showbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.showdatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(34, 88);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(35, 13);
            this.namelbl.TabIndex = 0;
            this.namelbl.Text = "Name";
            // 
            // designationlbl
            // 
            this.designationlbl.AutoSize = true;
            this.designationlbl.Location = new System.Drawing.Point(34, 130);
            this.designationlbl.Name = "designationlbl";
            this.designationlbl.Size = new System.Drawing.Size(63, 13);
            this.designationlbl.TabIndex = 1;
            this.designationlbl.Text = "Designation";
            // 
            // salarylbl
            // 
            this.salarylbl.AutoSize = true;
            this.salarylbl.Location = new System.Drawing.Point(34, 173);
            this.salarylbl.Name = "salarylbl";
            this.salarylbl.Size = new System.Drawing.Size(36, 13);
            this.salarylbl.TabIndex = 2;
            this.salarylbl.Text = "Salary";
            // 
            // nametxtbox
            // 
            this.nametxtbox.Location = new System.Drawing.Point(137, 88);
            this.nametxtbox.Name = "nametxtbox";
            this.nametxtbox.Size = new System.Drawing.Size(100, 20);
            this.nametxtbox.TabIndex = 3;
            // 
            // designationtxtbox
            // 
            this.designationtxtbox.Location = new System.Drawing.Point(137, 130);
            this.designationtxtbox.Name = "designationtxtbox";
            this.designationtxtbox.Size = new System.Drawing.Size(100, 20);
            this.designationtxtbox.TabIndex = 4;
            // 
            // salarytxtbox
            // 
            this.salarytxtbox.Location = new System.Drawing.Point(137, 173);
            this.salarytxtbox.Name = "salarytxtbox";
            this.salarytxtbox.Size = new System.Drawing.Size(100, 20);
            this.salarytxtbox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Insert Details";
            // 
            // insertbtn
            // 
            this.insertbtn.Location = new System.Drawing.Point(37, 262);
            this.insertbtn.Name = "insertbtn";
            this.insertbtn.Size = new System.Drawing.Size(75, 23);
            this.insertbtn.TabIndex = 7;
            this.insertbtn.Text = "Insert";
            this.insertbtn.UseVisualStyleBackColor = true;
            this.insertbtn.Click += new System.EventHandler(this.insertbtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(137, 262);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(75, 23);
            this.updatebtn.TabIndex = 8;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // resetbtn
            // 
            this.resetbtn.Location = new System.Drawing.Point(234, 262);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(75, 23);
            this.resetbtn.TabIndex = 9;
            this.resetbtn.Text = "Reset";
            this.resetbtn.UseVisualStyleBackColor = true;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // showdatagrid
            // 
            this.showdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showdatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.Update});
            this.showdatagrid.Location = new System.Drawing.Point(353, 88);
            this.showdatagrid.Name = "showdatagrid";
            this.showdatagrid.Size = new System.Drawing.Size(417, 197);
            this.showdatagrid.TabIndex = 10;
            this.showdatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showdatagrid_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.Text = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            // 
            // showbtn
            // 
            this.showbtn.Location = new System.Drawing.Point(512, 325);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(75, 23);
            this.showbtn.TabIndex = 11;
            this.showbtn.Text = "Show";
            this.showbtn.UseVisualStyleBackColor = true;
            this.showbtn.Click += new System.EventHandler(this.showbtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showbtn);
            this.Controls.Add(this.showdatagrid);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.insertbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.salarytxtbox);
            this.Controls.Add(this.designationtxtbox);
            this.Controls.Add(this.nametxtbox);
            this.Controls.Add(this.salarylbl);
            this.Controls.Add(this.designationlbl);
            this.Controls.Add(this.namelbl);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.showdatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label designationlbl;
        private System.Windows.Forms.Label salarylbl;
        private System.Windows.Forms.TextBox nametxtbox;
        private System.Windows.Forms.TextBox designationtxtbox;
        private System.Windows.Forms.TextBox salarytxtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button insertbtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.DataGridView showdatagrid;
        private System.Windows.Forms.Button showbtn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
    }
}