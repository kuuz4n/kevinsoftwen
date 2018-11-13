using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;


namespace SCVotingSystem
{
    public partial class LoginForm : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=JHUNROY\\SQLEXPRESS;Database=SchoolDatabase;Trusted_Connection=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        public LoginForm()
        {
            InitializeComponent();
        }

            
        private void login()
        {
            da = new SqlDataAdapter("Select *From Login where Username = @user and Password = @pass", conn);
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
                    MessageBox.Show("Thank You!");
                    this.Hide();
                    AdminForm asd = new AdminForm();
                    asd.Show();
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

    }
}
