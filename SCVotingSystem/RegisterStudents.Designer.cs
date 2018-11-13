namespace SCVotingSystem
{
    partial class RegisterStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterStudents));
            this.button1 = new System.Windows.Forms.Button();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.txtMN = new System.Windows.Forms.TextBox();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.txtStudNum = new System.Windows.Forms.TextBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbSec = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(259, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 33);
            this.button1.TabIndex = 37;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLN
            // 
            this.txtLN.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLN.Location = new System.Drawing.Point(229, 233);
            this.txtLN.Multiline = true;
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(164, 29);
            this.txtLN.TabIndex = 34;
            // 
            // txtMN
            // 
            this.txtMN.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMN.Location = new System.Drawing.Point(229, 185);
            this.txtMN.Multiline = true;
            this.txtMN.Name = "txtMN";
            this.txtMN.Size = new System.Drawing.Size(164, 29);
            this.txtMN.TabIndex = 33;
            // 
            // txtFN
            // 
            this.txtFN.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFN.Location = new System.Drawing.Point(229, 144);
            this.txtFN.Multiline = true;
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(164, 29);
            this.txtFN.TabIndex = 32;
            this.txtFN.TextChanged += new System.EventHandler(this.txtFN_TextChanged);
            // 
            // txtStudNum
            // 
            this.txtStudNum.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudNum.Location = new System.Drawing.Point(229, 101);
            this.txtStudNum.Multiline = true;
            this.txtStudNum.Name = "txtStudNum";
            this.txtStudNum.Size = new System.Drawing.Size(164, 29);
            this.txtStudNum.TabIndex = 31;
            this.txtStudNum.TextChanged += new System.EventHandler(this.txtStudNum_TextChanged);
            // 
            // cbYear
            // 
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV"});
            this.cbYear.Location = new System.Drawing.Point(229, 278);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(100, 28);
            this.cbYear.TabIndex = 35;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
            // 
            // cbSec
            // 
            this.cbSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSec.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSec.FormattingEnabled = true;
            this.cbSec.Location = new System.Drawing.Point(229, 321);
            this.cbSec.Name = "cbSec";
            this.cbSec.Size = new System.Drawing.Size(164, 28);
            this.cbSec.TabIndex = 36;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(3, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 30);
            this.button3.TabIndex = 40;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // RegisterStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(501, 423);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cbSec);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtLN);
            this.Controls.Add(this.txtMN);
            this.Controls.Add(this.txtFN);
            this.Controls.Add(this.txtStudNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterStudents";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.TextBox txtMN;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.TextBox txtStudNum;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.ComboBox cbSec;
        private System.Windows.Forms.Button button3;
    }
}