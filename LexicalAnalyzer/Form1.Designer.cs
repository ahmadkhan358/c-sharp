namespace LexicalAnalyzer
{
    partial class LA
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
            this.runbtn = new System.Windows.Forms.Button();
            this.stacktxtbox = new System.Windows.Forms.TextBox();
            this.slrparserlbl = new System.Windows.Forms.Label();
            this.stacklbl = new System.Windows.Forms.Label();
            this.inputstrlbl = new System.Windows.Forms.Label();
            this.inputstrtxtbox = new System.Windows.Forms.TextBox();
            this.actionlbl = new System.Windows.Forms.Label();
            this.actiontxtbox = new System.Windows.Forms.TextBox();
            this.lalbl = new System.Windows.Forms.Label();
            this.grammertxtbox = new System.Windows.Forms.Button();
            this.lextokenlbl = new System.Windows.Forms.Label();
            this.inputtxtbox = new System.Windows.Forms.TextBox();
            this.inputlbl = new System.Windows.Forms.Label();
            this.lextokenlist = new System.Windows.Forms.ListView();
            this.lexeme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.token = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // runbtn
            // 
            this.runbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runbtn.Location = new System.Drawing.Point(225, 715);
            this.runbtn.Name = "runbtn";
            this.runbtn.Size = new System.Drawing.Size(75, 25);
            this.runbtn.TabIndex = 6;
            this.runbtn.Text = "▶ Run";
            this.runbtn.UseVisualStyleBackColor = true;
            this.runbtn.Click += new System.EventHandler(this.runbtn_Click);
            // 
            // stacktxtbox
            // 
            this.stacktxtbox.Location = new System.Drawing.Point(17, 480);
            this.stacktxtbox.Multiline = true;
            this.stacktxtbox.Name = "stacktxtbox";
            this.stacktxtbox.ReadOnly = true;
            this.stacktxtbox.Size = new System.Drawing.Size(202, 196);
            this.stacktxtbox.TabIndex = 7;
            // 
            // slrparserlbl
            // 
            this.slrparserlbl.AutoSize = true;
            this.slrparserlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slrparserlbl.Location = new System.Drawing.Point(255, 375);
            this.slrparserlbl.Name = "slrparserlbl";
            this.slrparserlbl.Size = new System.Drawing.Size(135, 26);
            this.slrparserlbl.TabIndex = 8;
            this.slrparserlbl.Text = "SLR Parser";
            // 
            // stacklbl
            // 
            this.stacklbl.AutoSize = true;
            this.stacklbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stacklbl.Location = new System.Drawing.Point(12, 434);
            this.stacklbl.Name = "stacklbl";
            this.stacklbl.Size = new System.Drawing.Size(72, 26);
            this.stacklbl.TabIndex = 9;
            this.stacklbl.Text = "Stack";
            // 
            // inputstrlbl
            // 
            this.inputstrlbl.AutoSize = true;
            this.inputstrlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputstrlbl.Location = new System.Drawing.Point(220, 434);
            this.inputstrlbl.Name = "inputstrlbl";
            this.inputstrlbl.Size = new System.Drawing.Size(65, 26);
            this.inputstrlbl.TabIndex = 11;
            this.inputstrlbl.Text = "Input";
            // 
            // inputstrtxtbox
            // 
            this.inputstrtxtbox.Location = new System.Drawing.Point(225, 480);
            this.inputstrtxtbox.Multiline = true;
            this.inputstrtxtbox.Name = "inputstrtxtbox";
            this.inputstrtxtbox.ReadOnly = true;
            this.inputstrtxtbox.Size = new System.Drawing.Size(202, 196);
            this.inputstrtxtbox.TabIndex = 10;
            // 
            // actionlbl
            // 
            this.actionlbl.AutoSize = true;
            this.actionlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionlbl.Location = new System.Drawing.Point(428, 434);
            this.actionlbl.Name = "actionlbl";
            this.actionlbl.Size = new System.Drawing.Size(79, 26);
            this.actionlbl.TabIndex = 13;
            this.actionlbl.Text = "Action";
            // 
            // actiontxtbox
            // 
            this.actiontxtbox.Location = new System.Drawing.Point(433, 480);
            this.actiontxtbox.Multiline = true;
            this.actiontxtbox.Name = "actiontxtbox";
            this.actiontxtbox.ReadOnly = true;
            this.actiontxtbox.Size = new System.Drawing.Size(202, 196);
            this.actiontxtbox.TabIndex = 12;
            // 
            // lalbl
            // 
            this.lalbl.AutoSize = true;
            this.lalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalbl.Location = new System.Drawing.Point(255, 37);
            this.lalbl.Name = "lalbl";
            this.lalbl.Size = new System.Drawing.Size(100, 26);
            this.lalbl.TabIndex = 14;
            this.lalbl.Text = "Scanner";
            // 
            // grammertxtbox
            // 
            this.grammertxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grammertxtbox.Location = new System.Drawing.Point(308, 715);
            this.grammertxtbox.Name = "grammertxtbox";
            this.grammertxtbox.Size = new System.Drawing.Size(119, 25);
            this.grammertxtbox.TabIndex = 15;
            this.grammertxtbox.Text = "See Grammer";
            this.grammertxtbox.UseVisualStyleBackColor = true;
            // 
            // lextokenlbl
            // 
            this.lextokenlbl.AutoSize = true;
            this.lextokenlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lextokenlbl.Location = new System.Drawing.Point(336, 98);
            this.lextokenlbl.Name = "lextokenlbl";
            this.lextokenlbl.Size = new System.Drawing.Size(191, 26);
            this.lextokenlbl.TabIndex = 4;
            this.lextokenlbl.Text = "Lexemes/Tokens";
            // 
            // inputtxtbox
            // 
            this.inputtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputtxtbox.Location = new System.Drawing.Point(133, 140);
            this.inputtxtbox.Multiline = true;
            this.inputtxtbox.Name = "inputtxtbox";
            this.inputtxtbox.Size = new System.Drawing.Size(202, 196);
            this.inputtxtbox.TabIndex = 0;
            // 
            // inputlbl
            // 
            this.inputlbl.AutoSize = true;
            this.inputlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputlbl.Location = new System.Drawing.Point(128, 98);
            this.inputlbl.Name = "inputlbl";
            this.inputlbl.Size = new System.Drawing.Size(128, 26);
            this.inputlbl.TabIndex = 3;
            this.inputlbl.Text = "Input Code";
            // 
            // lextokenlist
            // 
            this.lextokenlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lexeme,
            this.token});
            this.lextokenlist.HideSelection = false;
            this.lextokenlist.Location = new System.Drawing.Point(341, 140);
            this.lextokenlist.Name = "lextokenlist";
            this.lextokenlist.Size = new System.Drawing.Size(202, 196);
            this.lextokenlist.TabIndex = 16;
            this.lextokenlist.UseCompatibleStateImageBehavior = false;
            this.lextokenlist.View = System.Windows.Forms.View.Details;
            // 
            // lexeme
            // 
            this.lexeme.Text = "Lexeme";
            this.lexeme.Width = 80;
            // 
            // token
            // 
            this.token.Text = "Token";
            // 
            // LA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 779);
            this.Controls.Add(this.lextokenlist);
            this.Controls.Add(this.grammertxtbox);
            this.Controls.Add(this.lalbl);
            this.Controls.Add(this.actionlbl);
            this.Controls.Add(this.actiontxtbox);
            this.Controls.Add(this.inputstrlbl);
            this.Controls.Add(this.inputstrtxtbox);
            this.Controls.Add(this.stacklbl);
            this.Controls.Add(this.slrparserlbl);
            this.Controls.Add(this.stacktxtbox);
            this.Controls.Add(this.runbtn);
            this.Controls.Add(this.lextokenlbl);
            this.Controls.Add(this.inputlbl);
            this.Controls.Add(this.inputtxtbox);
            this.Name = "LA";
            this.Text = "Lexical Analyzer and Parser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button runbtn;
        private System.Windows.Forms.TextBox stacktxtbox;
        private System.Windows.Forms.Label slrparserlbl;
        private System.Windows.Forms.Label stacklbl;
        private System.Windows.Forms.Label inputstrlbl;
        private System.Windows.Forms.TextBox inputstrtxtbox;
        private System.Windows.Forms.Label actionlbl;
        private System.Windows.Forms.TextBox actiontxtbox;
        private System.Windows.Forms.Label lalbl;
        private System.Windows.Forms.Button grammertxtbox;
        private System.Windows.Forms.Label lextokenlbl;
        private System.Windows.Forms.TextBox inputtxtbox;
        private System.Windows.Forms.Label inputlbl;
        private System.Windows.Forms.ListView lextokenlist;
        private System.Windows.Forms.ColumnHeader lexeme;
        private System.Windows.Forms.ColumnHeader token;
    }
}

