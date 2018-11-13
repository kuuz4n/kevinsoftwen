using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;


namespace SCVotingSystem
{
    public partial class LoginForm : Form
    {

        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='testing_login';username=root;password=");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();
        public static string User;
        public static string Role;
        public LoginForm()
        {
            InitializeComponent();
        }


        private void login()
        {
            da = new MySqlDataAdapter("SELECT `username`, `password` FROM `login_table` WHERE `username` = '" + txtUser.Text + "' AND `password` = '" + txtPass.Text + "'", conn);
            da.SelectCommand.CommandType = CommandType.Text;
            da.SelectCommand.Parameters.AddWithValue("@user", txtUser.Text);
            da.SelectCommand.Parameters.AddWithValue("@pass", txtPass.Text);
            da.SelectCommand.Connection = conn;


            try
            {
                conn.Open();
                da.SelectCommand.ExecuteNonQuery();
                DataTable tb = new DataTable();
                da.Fill(tb);
                if (tb.Rows.Count > 0)
                {
                    //foreach (DataRow rw in tb.Rows)
                    //{
                    //    User = rw["Username"].ToString();
                    //    Role = rw["Role"].ToString();
                    //}

                    AdminLogin();

                }

                else
                {
                    MessageBox.Show("Login Error!");
                    txtPass.Text = "";
                    txtUser.Text = "";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            finally
            {
                conn.Close();
                da.Dispose();
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            login();
        }

        private void AdminLogin()
        {
           // if (Role == "admin")
            //{
                this.Hide();
                AdminForm asd = new AdminForm();
                asd.Show();
            //}

            //else if (Role == "staff")
            //{
              //  this.Hide();
                //StaffForm sf = new StaffForm();
                //sf.Show();
            //}

            //else
            //{
              //  MessageBox.Show("Error!");
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            bool enteredLetter = false;
            Queue<char> text = new Queue<char>();
            foreach (var ch in this.txtUser.Text)
            {
                if (char.IsDigit(ch))
                {
                    text.Enqueue(ch);
                }
                else
                {
                    enteredLetter = true;
                }
            }

            if (enteredLetter)
            {
                StringBuilder sb = new StringBuilder();
                while (text.Count > 0)
                {
                    sb.Append(text.Dequeue());
                }

                this.txtUser.Text = sb.ToString();
                this.txtUser.SelectionStart = this.txtUser.Text.Length;
            }
        }
    }
}
