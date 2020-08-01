namespace Database_Connectivity
{
    partial class ValidationForm
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
            this.emailtxtbox = new System.Windows.Forms.TextBox();
            this.fnametxtbox = new System.Windows.Forms.TextBox();
            this.nametxtbox = new System.Windows.Forms.TextBox();
            this.emaillbl = new System.Windows.Forms.Label();
            this.fnamelbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.cnfrmpasstxtbox = new System.Windows.Forms.TextBox();
            this.passtxtbox = new System.Windows.Forms.TextBox();
            this.cnfrmpasslbl = new System.Windows.Forms.Label();
            this.passlbl = new System.Windows.Forms.Label();
            this.cniclbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.validatebtn = new System.Windows.Forms.Button();
            this.cnicmaskedtxtbox = new System.Windows.Forms.MaskedTextBox();
            this.errorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).BeginInit();
            this.SuspendLayout();
            // 
            // emailtxtbox
            // 
            this.emailtxtbox.Location = new System.Drawing.Point(428, 165);
            this.emailtxtbox.Name = "emailtxtbox";
            this.emailtxtbox.Size = new System.Drawing.Size(100, 20);
            this.emailtxtbox.TabIndex = 11;
            // 
            // fnametxtbox
            // 
            this.fnametxtbox.Location = new System.Drawing.Point(428, 122);
            this.fnametxtbox.Name = "fnametxtbox";
            this.fnametxtbox.Size = new System.Drawing.Size(100, 20);
            this.fnametxtbox.TabIndex = 10;
            // 
            // nametxtbox
            // 
            this.nametxtbox.Location = new System.Drawing.Point(428, 80);
            this.nametxtbox.Name = "nametxtbox";
            this.nametxtbox.Size = new System.Drawing.Size(100, 20);
            this.nametxtbox.TabIndex = 9;
            this.nametxtbox.Validating += new System.ComponentModel.CancelEventHandler(this.nametxtbox_Validating);
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Location = new System.Drawing.Point(325, 165);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(32, 13);
            this.emaillbl.TabIndex = 8;
            this.emaillbl.Text = "Email";
            // 
            // fnamelbl
            // 
            this.fnamelbl.AutoSize = true;
            this.fnamelbl.Location = new System.Drawing.Point(325, 122);
            this.fnamelbl.Name = "fnamelbl";
            this.fnamelbl.Size = new System.Drawing.Size(68, 13);
            this.fnamelbl.TabIndex = 7;
            this.fnamelbl.Text = "Father Name";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(325, 80);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(35, 13);
            this.namelbl.TabIndex = 6;
            this.namelbl.Text = "Name";
            // 
            // cnfrmpasstxtbox
            // 
            this.cnfrmpasstxtbox.Location = new System.Drawing.Point(428, 300);
            this.cnfrmpasstxtbox.Name = "cnfrmpasstxtbox";
            this.cnfrmpasstxtbox.Size = new System.Drawing.Size(100, 20);
            this.cnfrmpasstxtbox.TabIndex = 17;
            // 
            // passtxtbox
            // 
            this.passtxtbox.Location = new System.Drawing.Point(428, 257);
            this.passtxtbox.Name = "passtxtbox";
            this.passtxtbox.Size = new System.Drawing.Size(100, 20);
            this.passtxtbox.TabIndex = 16;
            // 
            // cnfrmpasslbl
            // 
            this.cnfrmpasslbl.AutoSize = true;
            this.cnfrmpasslbl.Location = new System.Drawing.Point(325, 300);
            this.cnfrmpasslbl.Name = "cnfrmpasslbl";
            this.cnfrmpasslbl.Size = new System.Drawing.Size(91, 13);
            this.cnfrmpasslbl.TabIndex = 14;
            this.cnfrmpasslbl.Text = "Confirm Password";
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.Location = new System.Drawing.Point(325, 257);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(53, 13);
            this.passlbl.TabIndex = 13;
            this.passlbl.Text = "Password";
            // 
            // cniclbl
            // 
            this.cniclbl.AutoSize = true;
            this.cniclbl.Location = new System.Drawing.Point(325, 215);
            this.cniclbl.Name = "cniclbl";
            this.cniclbl.Size = new System.Drawing.Size(32, 13);
            this.cniclbl.TabIndex = 12;
            this.cniclbl.Text = "CNIC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(359, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Registration";
            // 
            // validatebtn
            // 
            this.validatebtn.Location = new System.Drawing.Point(416, 359);
            this.validatebtn.Name = "validatebtn";
            this.validatebtn.Size = new System.Drawing.Size(75, 23);
            this.validatebtn.TabIndex = 19;
            this.validatebtn.Text = "Validate";
            this.validatebtn.UseVisualStyleBackColor = true;
            // 
            // cnicmaskedtxtbox
            // 
            this.cnicmaskedtxtbox.Location = new System.Drawing.Point(428, 215);
            this.cnicmaskedtxtbox.Mask = "00000-000000-0";
            this.cnicmaskedtxtbox.Name = "cnicmaskedtxtbox";
            this.cnicmaskedtxtbox.Size = new System.Drawing.Size(100, 20);
            this.cnicmaskedtxtbox.TabIndex = 20;
            // 
            // errorProviderApp
            // 
            this.errorProviderApp.ContainerControl = this;
            // 
            // ValidationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cnicmaskedtxtbox);
            this.Controls.Add(this.validatebtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cnfrmpasstxtbox);
            this.Controls.Add(this.passtxtbox);
            this.Controls.Add(this.cnfrmpasslbl);
            this.Controls.Add(this.passlbl);
            this.Controls.Add(this.cniclbl);
            this.Controls.Add(this.emailtxtbox);
            this.Controls.Add(this.fnametxtbox);
            this.Controls.Add(this.nametxtbox);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.fnamelbl);
            this.Controls.Add(this.namelbl);
            this.Name = "ValidationForm";
            this.Text = "ValidationForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailtxtbox;
        private System.Windows.Forms.TextBox fnametxtbox;
        private System.Windows.Forms.TextBox nametxtbox;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.Label fnamelbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.TextBox cnfrmpasstxtbox;
        private System.Windows.Forms.TextBox passtxtbox;
        private System.Windows.Forms.Label cnfrmpasslbl;
        private System.Windows.Forms.Label passlbl;
        private System.Windows.Forms.Label cniclbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button validatebtn;
        private System.Windows.Forms.MaskedTextBox cnicmaskedtxtbox;
        private System.Windows.Forms.ErrorProvider errorProviderApp;
    }
}