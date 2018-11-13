namespace SCVotingSystem
{
    partial class LoginForm
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
            this.FormLogin = new MonoFlat.MonoFlat_ThemeContainer();
            this.monoFlat_ControlBox1 = new MonoFlat.MonoFlat_ControlBox();
            this.txtPass = new MonoFlat.MonoFlat_TextBox();
            this.monoFlat_Label2 = new MonoFlat.MonoFlat_Label();
            this.txtUser = new MonoFlat.MonoFlat_TextBox();
            this.monoFlat_Label1 = new MonoFlat.MonoFlat_Label();
            this.LoginButton = new MonoFlat.MonoFlat_Button();
            this.FormLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormLogin
            // 
            this.FormLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.FormLogin.Controls.Add(this.monoFlat_ControlBox1);
            this.FormLogin.Controls.Add(this.txtPass);
            this.FormLogin.Controls.Add(this.monoFlat_Label2);
            this.FormLogin.Controls.Add(this.txtUser);
            this.FormLogin.Controls.Add(this.monoFlat_Label1);
            this.FormLogin.Controls.Add(this.LoginButton);
            this.FormLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormLogin.Location = new System.Drawing.Point(0, 0);
            this.FormLogin.Name = "FormLogin";
            this.FormLogin.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.FormLogin.RoundCorners = true;
            this.FormLogin.Sizable = true;
            this.FormLogin.Size = new System.Drawing.Size(434, 430);
            this.FormLogin.SmartBounds = true;
            this.FormLogin.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormLogin.TabIndex = 0;
            this.FormLogin.Text = "Voting System";
            // 
            // monoFlat_ControlBox1
            // 
            this.monoFlat_ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monoFlat_ControlBox1.EnableHoverHighlight = false;
            this.monoFlat_ControlBox1.EnableMaximizeButton = true;
            this.monoFlat_ControlBox1.EnableMinimizeButton = true;
            this.monoFlat_ControlBox1.Location = new System.Drawing.Point(322, 15);
            this.monoFlat_ControlBox1.Name = "monoFlat_ControlBox1";
            this.monoFlat_ControlBox1.Size = new System.Drawing.Size(100, 25);
            this.monoFlat_ControlBox1.TabIndex = 5;
            this.monoFlat_ControlBox1.Text = "monoFlat_ControlBox1";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Transparent;
            this.txtPass.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtPass.Image = null;
            this.txtPass.Location = new System.Drawing.Point(152, 198);
            this.txtPass.MaxLength = 32767;
            this.txtPass.Multiline = false;
            this.txtPass.Name = "txtPass";
            this.txtPass.ReadOnly = false;
            this.txtPass.Size = new System.Drawing.Size(173, 41);
            this.txtPass.TabIndex = 4;
            this.txtPass.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPass.UseSystemPasswordChar = false;
            // 
            // monoFlat_Label2
            // 
            this.monoFlat_Label2.AutoSize = true;
            this.monoFlat_Label2.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monoFlat_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.monoFlat_Label2.Location = new System.Drawing.Point(67, 207);
            this.monoFlat_Label2.Name = "monoFlat_Label2";
            this.monoFlat_Label2.Size = new System.Drawing.Size(79, 21);
            this.monoFlat_Label2.TabIndex = 3;
            this.monoFlat_Label2.Text = "Password:";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Transparent;
            this.txtUser.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtUser.Image = null;
            this.txtUser.Location = new System.Drawing.Point(152, 151);
            this.txtUser.MaxLength = 32767;
            this.txtUser.Multiline = false;
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = false;
            this.txtUser.Size = new System.Drawing.Size(173, 41);
            this.txtUser.TabIndex = 2;
            this.txtUser.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUser.UseSystemPasswordChar = false;
            // 
            // monoFlat_Label1
            // 
            this.monoFlat_Label1.AutoSize = true;
            this.monoFlat_Label1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monoFlat_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.monoFlat_Label1.Location = new System.Drawing.Point(62, 161);
            this.monoFlat_Label1.Name = "monoFlat_Label1";
            this.monoFlat_Label1.Size = new System.Drawing.Size(84, 21);
            this.monoFlat_Label1.TabIndex = 1;
            this.monoFlat_Label1.Text = "Username:";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LoginButton.Image = null;
            this.LoginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginButton.Location = new System.Drawing.Point(152, 312);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(146, 41);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 430);
            this.Controls.Add(this.FormLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voting System";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormLogin.ResumeLayout(false);
            this.FormLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MonoFlat.MonoFlat_ThemeContainer FormLogin;
        private MonoFlat.MonoFlat_TextBox txtPass;
        private MonoFlat.MonoFlat_Label monoFlat_Label2;
        private MonoFlat.MonoFlat_TextBox txtUser;
        private MonoFlat.MonoFlat_Label monoFlat_Label1;
        private MonoFlat.MonoFlat_Button LoginButton;
        private MonoFlat.MonoFlat_ControlBox monoFlat_ControlBox1;


    }
}

