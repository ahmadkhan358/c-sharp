namespace SatelliteAssemblies
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
            this.cmblanguage = new System.Windows.Forms.ComboBox();
            this.resultlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmblanguage
            // 
            this.cmblanguage.FormattingEnabled = true;
            this.cmblanguage.Location = new System.Drawing.Point(189, 139);
            this.cmblanguage.Name = "cmblanguage";
            this.cmblanguage.Size = new System.Drawing.Size(121, 21);
            this.cmblanguage.TabIndex = 0;
            this.cmblanguage.SelectedIndexChanged += new System.EventHandler(this.cmblanguage_SelectedIndexChanged);
            // 
            // resultlbl
            // 
            this.resultlbl.AutoSize = true;
            this.resultlbl.Location = new System.Drawing.Point(344, 142);
            this.resultlbl.Name = "resultlbl";
            this.resultlbl.Size = new System.Drawing.Size(37, 13);
            this.resultlbl.TabIndex = 1;
            this.resultlbl.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 328);
            this.Controls.Add(this.resultlbl);
            this.Controls.Add(this.cmblanguage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmblanguage;
        private System.Windows.Forms.Label resultlbl;
    }
}

