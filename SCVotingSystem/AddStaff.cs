using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SCVotingSystem
{
    public partial class AddStaff : Form
    {
        SqlConnection con = new SqlConnection("Data Source=JHUNROY\\SQLEXPRESS;Database=SchoolDatabase;Trusted_Connection=True");
        SqlDataAdapter da = new SqlDataAdapter();
        string role = "staff"; 
        string usern;


        public AddStaff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dd();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminForm af = new AdminForm();
            af.Show();
            this.Hide();
        }

        private void log()
        {
            da = new SqlDataAdapter("INSERT INTO Loginn (Username,Password,Role) VALUES (@User, @Pass,@ro)", con);
            da.SelectCommand.CommandType = CommandType.Text;
            da.SelectCommand.Parameters.AddWithValue("@user", txtUser.Text);
            da.SelectCommand.Parameters.AddWithValue("@pass", txtPass.Text);
            da.SelectCommand.Parameters.AddWithValue("@ro", role);
            da.SelectCommand.Connection = con;


            try
            {
                con.Open();
                da.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Register Successfully!");
                con.Close();
                AdminForm af = new AdminForm();
                this.Hide();
                af.Show();
            }

            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());
            }
        }

        private void dd()
        {
            da = new SqlDataAdapter("Select * From Loginn where Username= @user", con);
            da.SelectCommand.CommandType = CommandType.Text;
            da.SelectCommand.Parameters.AddWithValue("@user", txtUser.Text);
            da.SelectCommand.Connection = con;

            try
            {
                con.Open();
                da.SelectCommand.ExecuteNonQuery();
                DataTable tb = new DataTable();
                da.Fill(tb);
                if (tb.Rows.Count > 0)
                {
                    foreach (DataRow rw in tb.Rows)
                    {
                        usern = rw["Username"].ToString();
                    }                  
                }

                if (usern == txtUser.Text)
                {
                    MessageBox.Show("Username is already existed!");
                    txtUser.Text = "";
                    txtPass.Text = "";
                    con.Close();
                }

                else
                {
                    con.Close();
                    log();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminForm af = new AdminForm();
            af.Show();
            this.Hide();
        }
    }
}
