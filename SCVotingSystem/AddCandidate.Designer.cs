namespace SCVotingSystem
{
    partial class AddCandidate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCandidate));
            this.txtCanID = new System.Windows.Forms.TextBox();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.cbPos = new System.Windows.Forms.ComboBox();
            this.cbPar = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCanID
            // 
            this.txtCanID.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCanID.Location = new System.Drawing.Point(221, 152);
            this.txtCanID.Multiline = true;
            this.txtCanID.Name = "txtCanID";
            this.txtCanID.Size = new System.Drawing.Size(178, 28);
            this.txtCanID.TabIndex = 18;
            // 
            // txtFN
            // 
            this.txtFN.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFN.Location = new System.Drawing.Point(221, 198);
            this.txtFN.Multiline = true;
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(178, 28);
            this.txtFN.TabIndex = 19;
            this.txtFN.TextChanged += new System.EventHandler(this.txtFN_TextChanged);
            // 
            // cbPos
            // 
            this.cbPos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPos.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPos.FormattingEnabled = true;
            this.cbPos.Items.AddRange(new object[] {
            "President",
            "Vice President",
            "Secretary",
            "Auditor",
            "Treasurer",
            "1st Yr. Representative",
            "2nd Yr. Representative",
            "3rd Yr. Representative",
            "4th Yr. Representative"});
            this.cbPos.Location = new System.Drawing.Point(221, 112);
            this.cbPos.Name = "cbPos";
            this.cbPos.Size = new System.Drawing.Size(178, 28);
            this.cbPos.TabIndex = 22;
            this.cbPos.SelectedIndexChanged += new System.EventHandler(this.cbPos_SelectedIndexChanged);
            // 
            // cbPar
            // 
            this.cbPar.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPar.FormattingEnabled = true;
            this.cbPar.Items.AddRange(new object[] {
            "S.T.A.R.",
            "S.W.A.T."});
            this.cbPar.Location = new System.Drawing.Point(221, 242);
            this.cbPar.Name = "cbPar";
            this.cbPar.Size = new System.Drawing.Size(144, 28);
            this.cbPar.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(250, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 31);
            this.button1.TabIndex = 24;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(1, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 30);
            this.button2.TabIndex = 40;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // AddCandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(500, 385);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbPar);
            this.Controls.Add(this.cbPos);
            this.Controls.Add(this.txtFN);
            this.Controls.Add(this.txtCanID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCandidate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCandidate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCanID;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.ComboBox cbPos;
        private System.Windows.Forms.ComboBox cbPar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}