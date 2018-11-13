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
    public partial class AddCandidate : Form
    {
        SqlConnection con = new SqlConnection("Data Source=JHUNROY\\SQLEXPRESS;Database=SchoolDatabase;Trusted_Connection=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        public AddCandidate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO CandidInfo (CanID, Name ,Position , Party) VALUES (@CID, @FN, @Pos , @Par);";
            cmd.Parameters.AddWithValue("@CID", txtCanID.Text);
            cmd.Parameters.AddWithValue("@FN", txtFN.Text);
            cmd.Parameters.AddWithValue("@Pos", cbPos.Text);
            cmd.Parameters.AddWithValue("@Par", cbPar.Text);
            cmd.Connection = con;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Register done !");
                con.Close();

                txtCanID.Text = "";
                txtFN.Text = "";
                cbPar.Text = "";
                cbPar.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                con.Close();
            }
        }


        private void txtFN_TextChanged(object sender, EventArgs e)
        {
            //if (!System.Text.RegularExpressions.Regex.IsMatch(txtFN.Text, "^[a-zA-Z]"))
            //{
            //    MessageBox.Show("This textbox accepts only alphabetical characters");
            //    txtFN.Text = "";
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CandidateList cl = new CandidateList();
            cl.Show();
        }

        private void cbPos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPos.SelectedItem.ToString() == "President")
            {
                txtCanID.Text = "PresC";
            }

            else if (cbPos.Text == "Vice President")
            {
                txtCanID.Text = "VP";
            }
            else if (cbPos.Text == "Secretary")
            {
                txtCanID.Text = "Sec";
            }

            else if (cbPos.Text == "Treasurer")
            {
                txtCanID.Text = "Tre";
            }

            else if (cbPos.Text == "Auditor")
            {
                txtCanID.Text = "Aud";
            }

            else if (cbPos.Text == "1st Yr. Representative")
            {
                txtCanID.Text = "1stCan";
            }

            else if (cbPos.Text == "2nd Yr. Representative")
            {
                txtCanID.Text = "2ndCan";
            }

            else if (cbPos.Text == "3rd Yr. Representative")
            {
                txtCanID.Text = "3rdCan";
            }

            else if (cbPos.Text == "4th Yr. Representative")
            {
                txtCanID.Text = "4thCan";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AdminForm wes = new AdminForm();
            wes.Show();
            this.Hide();
        }
    }
}
