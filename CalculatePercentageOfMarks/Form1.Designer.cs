namespace Assignment1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainHeading = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.rollnolbl = new System.Windows.Forms.Label();
            this.nametxtbox = new System.Windows.Forms.TextBox();
            this.rollnotxtbox = new System.Windows.Forms.TextBox();
            this.scoresgroupbox = new System.Windows.Forms.GroupBox();
            this.urdutxtbox = new System.Windows.Forms.TextBox();
            this.urdulbl = new System.Windows.Forms.Label();
            this.computertxtbox = new System.Windows.Forms.TextBox();
            this.computerlbl = new System.Windows.Forms.Label();
            this.englishtxtbox = new System.Windows.Forms.TextBox();
            this.englishlbl = new System.Windows.Forms.Label();
            this.sciencetxtbox = new System.Windows.Forms.TextBox();
            this.sciencelbl = new System.Windows.Forms.Label();
            this.mathtxtbox = new System.Windows.Forms.TextBox();
            this.mathlbl = new System.Windows.Forms.Label();
            this.resultgroupbox = new System.Windows.Forms.GroupBox();
            this.resulttxtbox = new System.Windows.Forms.TextBox();
            this.resultlbl = new System.Windows.Forms.Label();
            this.divisiontxtbox = new System.Windows.Forms.TextBox();
            this.divisionlbl = new System.Windows.Forms.Label();
            this.percentagetxtbox = new System.Windows.Forms.TextBox();
            this.percentagelbl = new System.Windows.Forms.Label();
            this.obtainedtxtbox = new System.Windows.Forms.TextBox();
            this.obtainedlbl = new System.Windows.Forms.Label();
            this.totaltxtbox = new System.Windows.Forms.TextBox();
            this.totallbl = new System.Windows.Forms.Label();
            this.okbtn = new System.Windows.Forms.Button();
            this.newbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.scoresgroupbox.SuspendLayout();
            this.resultgroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainHeading
            // 
            this.mainHeading.AutoSize = true;
            this.mainHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainHeading.Location = new System.Drawing.Point(151, 34);
            this.mainHeading.Name = "mainHeading";
            this.mainHeading.Size = new System.Drawing.Size(313, 31);
            this.mainHeading.TabIndex = 0;
            this.mainHeading.Text = "Student Progress Report";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(161, 139);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(35, 13);
            this.namelbl.TabIndex = 1;
            this.namelbl.Text = "Name";
            // 
            // rollnolbl
            // 
            this.rollnolbl.AutoSize = true;
            this.rollnolbl.Location = new System.Drawing.Point(161, 180);
            this.rollnolbl.Name = "rollnolbl";
            this.rollnolbl.Size = new System.Drawing.Size(35, 13);
            this.rollnolbl.TabIndex = 2;
            this.rollnolbl.Text = "Roll #";
            // 
            // nametxtbox
            // 
            this.nametxtbox.Location = new System.Drawing.Point(225, 139);
            this.nametxtbox.Name = "nametxtbox";
            this.nametxtbox.Size = new System.Drawing.Size(100, 20);
            this.nametxtbox.TabIndex = 3;
            // 
            // rollnotxtbox
            // 
            this.rollnotxtbox.Location = new System.Drawing.Point(225, 180);
            this.rollnotxtbox.Name = "rollnotxtbox";
            this.rollnotxtbox.Size = new System.Drawing.Size(100, 20);
            this.rollnotxtbox.TabIndex = 4;
            // 
            // scoresgroupbox
            // 
            this.scoresgroupbox.Controls.Add(this.urdutxtbox);
            this.scoresgroupbox.Controls.Add(this.urdulbl);
            this.scoresgroupbox.Controls.Add(this.computertxtbox);
            this.scoresgroupbox.Controls.Add(this.computerlbl);
            this.scoresgroupbox.Controls.Add(this.englishtxtbox);
            this.scoresgroupbox.Controls.Add(this.englishlbl);
            this.scoresgroupbox.Controls.Add(this.sciencetxtbox);
            this.scoresgroupbox.Controls.Add(this.sciencelbl);
            this.scoresgroupbox.Controls.Add(this.mathtxtbox);
            this.scoresgroupbox.Controls.Add(this.mathlbl);
            this.scoresgroupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoresgroupbox.Location = new System.Drawing.Point(55, 227);
            this.scoresgroupbox.Name = "scoresgroupbox";
            this.scoresgroupbox.Size = new System.Drawing.Size(214, 214);
            this.scoresgroupbox.TabIndex = 5;
            this.scoresgroupbox.TabStop = false;
            this.scoresgroupbox.Text = "Scores";
            // 
            // urdutxtbox
            // 
            this.urdutxtbox.Location = new System.Drawing.Point(93, 174);
            this.urdutxtbox.Name = "urdutxtbox";
            this.urdutxtbox.Size = new System.Drawing.Size(100, 20);
            this.urdutxtbox.TabIndex = 9;
            this.urdutxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urdutxtbox_KeyPress);
            // 
            // urdulbl
            // 
            this.urdulbl.AutoSize = true;
            this.urdulbl.Location = new System.Drawing.Point(6, 174);
            this.urdulbl.Name = "urdulbl";
            this.urdulbl.Size = new System.Drawing.Size(30, 13);
            this.urdulbl.TabIndex = 8;
            this.urdulbl.Text = "Urdu";
            // 
            // computertxtbox
            // 
            this.computertxtbox.Location = new System.Drawing.Point(93, 137);
            this.computertxtbox.Name = "computertxtbox";
            this.computertxtbox.Size = new System.Drawing.Size(100, 20);
            this.computertxtbox.TabIndex = 7;
            this.computertxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.computertxtbox_KeyPress);
            // 
            // computerlbl
            // 
            this.computerlbl.AutoSize = true;
            this.computerlbl.Location = new System.Drawing.Point(6, 137);
            this.computerlbl.Name = "computerlbl";
            this.computerlbl.Size = new System.Drawing.Size(52, 13);
            this.computerlbl.TabIndex = 6;
            this.computerlbl.Text = "Computer";
            // 
            // englishtxtbox
            // 
            this.englishtxtbox.Location = new System.Drawing.Point(93, 101);
            this.englishtxtbox.Name = "englishtxtbox";
            this.englishtxtbox.Size = new System.Drawing.Size(100, 20);
            this.englishtxtbox.TabIndex = 5;
            this.englishtxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.englishtxtbox_KeyPress);
            // 
            // englishlbl
            // 
            this.englishlbl.AutoSize = true;
            this.englishlbl.Location = new System.Drawing.Point(6, 101);
            this.englishlbl.Name = "englishlbl";
            this.englishlbl.Size = new System.Drawing.Size(41, 13);
            this.englishlbl.TabIndex = 4;
            this.englishlbl.Text = "English";
            // 
            // sciencetxtbox
            // 
            this.sciencetxtbox.Location = new System.Drawing.Point(93, 64);
            this.sciencetxtbox.Name = "sciencetxtbox";
            this.sciencetxtbox.Size = new System.Drawing.Size(100, 20);
            this.sciencetxtbox.TabIndex = 3;
            this.sciencetxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sciencetxtbox_KeyPress);
            // 
            // sciencelbl
            // 
            this.sciencelbl.AutoSize = true;
            this.sciencelbl.Location = new System.Drawing.Point(6, 64);
            this.sciencelbl.Name = "sciencelbl";
            this.sciencelbl.Size = new System.Drawing.Size(46, 13);
            this.sciencelbl.TabIndex = 2;
            this.sciencelbl.Text = "Science";
            // 
            // mathtxtbox
            // 
            this.mathtxtbox.Location = new System.Drawing.Point(93, 27);
            this.mathtxtbox.Name = "mathtxtbox";
            this.mathtxtbox.Size = new System.Drawing.Size(100, 20);
            this.mathtxtbox.TabIndex = 1;
            this.mathtxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mathtxtbox_KeyPress);
            // 
            // mathlbl
            // 
            this.mathlbl.AutoSize = true;
            this.mathlbl.Location = new System.Drawing.Point(6, 27);
            this.mathlbl.Name = "mathlbl";
            this.mathlbl.Size = new System.Drawing.Size(31, 13);
            this.mathlbl.TabIndex = 0;
            this.mathlbl.Text = "Math";
            // 
            // resultgroupbox
            // 
            this.resultgroupbox.Controls.Add(this.resulttxtbox);
            this.resultgroupbox.Controls.Add(this.resultlbl);
            this.resultgroupbox.Controls.Add(this.divisiontxtbox);
            this.resultgroupbox.Controls.Add(this.divisionlbl);
            this.resultgroupbox.Controls.Add(this.percentagetxtbox);
            this.resultgroupbox.Controls.Add(this.percentagelbl);
            this.resultgroupbox.Controls.Add(this.obtainedtxtbox);
            this.resultgroupbox.Controls.Add(this.obtainedlbl);
            this.resultgroupbox.Controls.Add(this.totaltxtbox);
            this.resultgroupbox.Controls.Add(this.totallbl);
            this.resultgroupbox.Location = new System.Drawing.Point(348, 227);
            this.resultgroupbox.Name = "resultgroupbox";
            this.resultgroupbox.Size = new System.Drawing.Size(214, 214);
            this.resultgroupbox.TabIndex = 6;
            this.resultgroupbox.TabStop = false;
            this.resultgroupbox.Text = "Result";
            // 
            // resulttxtbox
            // 
            this.resulttxtbox.Location = new System.Drawing.Point(93, 174);
            this.resulttxtbox.Name = "resulttxtbox";
            this.resulttxtbox.ReadOnly = true;
            this.resulttxtbox.Size = new System.Drawing.Size(100, 20);
            this.resulttxtbox.TabIndex = 9;
            // 
            // resultlbl
            // 
            this.resultlbl.AutoSize = true;
            this.resultlbl.Location = new System.Drawing.Point(6, 174);
            this.resultlbl.Name = "resultlbl";
            this.resultlbl.Size = new System.Drawing.Size(37, 13);
            this.resultlbl.TabIndex = 8;
            this.resultlbl.Text = "Result";
            // 
            // divisiontxtbox
            // 
            this.divisiontxtbox.Location = new System.Drawing.Point(93, 137);
            this.divisiontxtbox.Name = "divisiontxtbox";
            this.divisiontxtbox.ReadOnly = true;
            this.divisiontxtbox.Size = new System.Drawing.Size(100, 20);
            this.divisiontxtbox.TabIndex = 7;
            // 
            // divisionlbl
            // 
            this.divisionlbl.AutoSize = true;
            this.divisionlbl.Location = new System.Drawing.Point(6, 137);
            this.divisionlbl.Name = "divisionlbl";
            this.divisionlbl.Size = new System.Drawing.Size(44, 13);
            this.divisionlbl.TabIndex = 6;
            this.divisionlbl.Text = "Division";
            // 
            // percentagetxtbox
            // 
            this.percentagetxtbox.Location = new System.Drawing.Point(93, 101);
            this.percentagetxtbox.Name = "percentagetxtbox";
            this.percentagetxtbox.ReadOnly = true;
            this.percentagetxtbox.Size = new System.Drawing.Size(100, 20);
            this.percentagetxtbox.TabIndex = 5;
            // 
            // percentagelbl
            // 
            this.percentagelbl.AutoSize = true;
            this.percentagelbl.Location = new System.Drawing.Point(6, 101);
            this.percentagelbl.Name = "percentagelbl";
            this.percentagelbl.Size = new System.Drawing.Size(62, 13);
            this.percentagelbl.TabIndex = 4;
            this.percentagelbl.Text = "Percentage";
            // 
            // obtainedtxtbox
            // 
            this.obtainedtxtbox.Location = new System.Drawing.Point(93, 64);
            this.obtainedtxtbox.Name = "obtainedtxtbox";
            this.obtainedtxtbox.ReadOnly = true;
            this.obtainedtxtbox.Size = new System.Drawing.Size(100, 20);
            this.obtainedtxtbox.TabIndex = 3;
            // 
            // obtainedlbl
            // 
            this.obtainedlbl.AutoSize = true;
            this.obtainedlbl.Location = new System.Drawing.Point(6, 64);
            this.obtainedlbl.Name = "obtainedlbl";
            this.obtainedlbl.Size = new System.Drawing.Size(50, 13);
            this.obtainedlbl.TabIndex = 2;
            this.obtainedlbl.Text = "Obtained";
            // 
            // totaltxtbox
            // 
            this.totaltxtbox.Location = new System.Drawing.Point(93, 27);
            this.totaltxtbox.Name = "totaltxtbox";
            this.totaltxtbox.ReadOnly = true;
            this.totaltxtbox.Size = new System.Drawing.Size(100, 20);
            this.totaltxtbox.TabIndex = 1;
            // 
            // totallbl
            // 
            this.totallbl.AutoSize = true;
            this.totallbl.Location = new System.Drawing.Point(6, 27);
            this.totallbl.Name = "totallbl";
            this.totallbl.Size = new System.Drawing.Size(31, 13);
            this.totallbl.TabIndex = 0;
            this.totallbl.Text = "Total";
            // 
            // okbtn
            // 
            this.okbtn.Location = new System.Drawing.Point(325, 485);
            this.okbtn.Name = "okbtn";
            this.okbtn.Size = new System.Drawing.Size(75, 23);
            this.okbtn.TabIndex = 7;
            this.okbtn.Text = "OK";
            this.okbtn.UseVisualStyleBackColor = true;
            this.okbtn.Click += new System.EventHandler(this.okbtn_Click);
            // 
            // newbtn
            // 
            this.newbtn.Location = new System.Drawing.Point(406, 485);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(75, 23);
            this.newbtn.TabIndex = 8;
            this.newbtn.Text = "New";
            this.newbtn.UseVisualStyleBackColor = true;
            this.newbtn.Click += new System.EventHandler(this.newbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(487, 485);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(75, 23);
            this.exitbtn.TabIndex = 9;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(628, 552);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.newbtn);
            this.Controls.Add(this.okbtn);
            this.Controls.Add(this.resultgroupbox);
            this.Controls.Add(this.scoresgroupbox);
            this.Controls.Add(this.rollnotxtbox);
            this.Controls.Add(this.nametxtbox);
            this.Controls.Add(this.rollnolbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.mainHeading);
            this.Name = "Form1";
            this.Text = "Form1";
            this.scoresgroupbox.ResumeLayout(false);
            this.scoresgroupbox.PerformLayout();
            this.resultgroupbox.ResumeLayout(false);
            this.resultgroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainHeading;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label rollnolbl;
        private System.Windows.Forms.TextBox nametxtbox;
        private System.Windows.Forms.TextBox rollnotxtbox;
        private System.Windows.Forms.GroupBox scoresgroupbox;
        private System.Windows.Forms.TextBox urdutxtbox;
        private System.Windows.Forms.Label urdulbl;
        private System.Windows.Forms.TextBox computertxtbox;
        private System.Windows.Forms.Label computerlbl;
        private System.Windows.Forms.TextBox englishtxtbox;
        private System.Windows.Forms.Label englishlbl;
        private System.Windows.Forms.TextBox sciencetxtbox;
        private System.Windows.Forms.Label sciencelbl;
        private System.Windows.Forms.TextBox mathtxtbox;
        private System.Windows.Forms.Label mathlbl;
        private System.Windows.Forms.GroupBox resultgroupbox;
        private System.Windows.Forms.TextBox resulttxtbox;
        private System.Windows.Forms.Label resultlbl;
        private System.Windows.Forms.TextBox divisiontxtbox;
        private System.Windows.Forms.Label divisionlbl;
        private System.Windows.Forms.TextBox percentagetxtbox;
        private System.Windows.Forms.Label percentagelbl;
        private System.Windows.Forms.TextBox obtainedtxtbox;
        private System.Windows.Forms.Label obtainedlbl;
        private System.Windows.Forms.TextBox totaltxtbox;
        private System.Windows.Forms.Label totallbl;
        private System.Windows.Forms.Button okbtn;
        private System.Windows.Forms.Button newbtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

