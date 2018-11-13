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
    public partial class RegisterStudents : Form
    {
        SqlConnection con = new SqlConnection("Data Source=JHUNROY\\SQLEXPRESS;Database=SchoolDatabase;Trusted_Connection=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        string abc;
        int a = 1;

        public RegisterStudents()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (txtFN.Text == "" || txtLN.Text == "" || txtMN.Text == "" || txtLN.Text == "" || cbYear.Text == "" || cbSec.Text == "")
            {
                MessageBox.Show("Please Fill Up All the Requirements");
                txtStudNum.Text = "";
                txtFN.Text = "";
                txtMN.Text = "";
                txtLN.Text = "";
                cbSec.Text = "";
                cbYear.Text = "";
            }

            else
            {
                dd();
            }
        }

        private void addstudent()
        {
            cmd.CommandText = "INSERT INTO StudInfo (StudentNum, FirstName,MiddleName, LastName , Section , Year , VoteID) VALUES (@SN, @FN, @MN, @LN , @Sec , @Ye , @VI);";
            cmd.Parameters.AddWithValue("@SN", txtStudNum.Text);
            cmd.Parameters.AddWithValue("@FN", txtFN.Text);
            cmd.Parameters.AddWithValue("@MN", txtMN.Text);
            cmd.Parameters.AddWithValue("@LN", txtLN.Text);
            cmd.Parameters.AddWithValue("@Sec", cbSec.Text);
            cmd.Parameters.AddWithValue("@Ye", cbYear.Text);
            cmd.Parameters.AddWithValue("@VI", a);
            cmd.Connection = con;

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Register done !");
                con.Close();
                txtStudNum.Text = "";
                txtFN.Text = "";
                txtMN.Text = "";
                txtLN.Text = "";
                cbYear.Text = "";
                cbSec.Text = "";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                con.Close();
            }
        }

        private void dd()
        {
            da = new SqlDataAdapter("Select * From StudInfo where StudentNum= @user", con);
            da.SelectCommand.CommandType = CommandType.Text;
            da.SelectCommand.Parameters.AddWithValue("@user", txtStudNum.Text);
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
                        abc = rw["StudentNum"].ToString();
                    }
                }

                if (abc == txtStudNum.Text)
                {
                    MessageBox.Show("Student ID is already existed!");
                    con.Close();
                }

                else
                {
                    con.Close();
                    addstudent();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbYear.SelectedItem.ToString() == "I")
            {
                //ADD
                cbSec.Items.Add("Pasiphae");
                cbSec.Items.Add("Callisto");
                cbSec.Items.Add("Sinope");
                cbSec.Items.Add("Amalthea");
                cbSec.Items.Add("Adrasthea");
                cbSec.Items.Add("Ganymede");

                //Remove II

                cbSec.Items.Remove("Amaranthus");
                cbSec.Items.Remove("Gladiola");
                cbSec.Items.Remove("Marjoram");
                cbSec.Items.Remove("Collumbine");
                cbSec.Items.Remove("Hycinth");
                cbSec.Items.Remove("Anthurium");
                cbSec.Items.Remove("Freezia");

                //Remove III

                cbSec.Items.Remove("Rigel");
                cbSec.Items.Remove("Achernar");
                cbSec.Items.Remove("Capella");
                cbSec.Items.Remove("Procyon");
                cbSec.Items.Remove("Agena");
                cbSec.Items.Remove("Kentaurus");

                //Remove IV

                cbSec.Items.Remove("Camiguin");
                cbSec.Items.Remove("El Nido");
                cbSec.Items.Remove("Boracay");
                cbSec.Items.Remove("Caramoan");
                cbSec.Items.Remove("Puerto Asul");
                cbSec.Items.Remove("Achernar");
                cbSec.Items.Remove("Aman Pulo");
                cbSec.Items.Remove("Siargao");

            }
            
            else if (cbYear.SelectedItem.ToString() == "II")
            {
                //Remove I
                cbSec.Items.Remove("Pasiphae");
                cbSec.Items.Remove("Callisto");
                cbSec.Items.Remove("Sinope");
                cbSec.Items.Remove("Amalthea");
                cbSec.Items.Remove("Adrasthea");
                cbSec.Items.Remove("Ganymede");

                //Remove III

                cbSec.Items.Remove("Rigel");
                cbSec.Items.Remove("Achernar");
                cbSec.Items.Remove("Capella");
                cbSec.Items.Remove("Procyon");
                cbSec.Items.Remove("Agena");
                cbSec.Items.Remove("Kentaurus");

                //Remove IV

                cbSec.Items.Remove("Camiguin");
                cbSec.Items.Remove("El Nido");
                cbSec.Items.Remove("Boracay");
                cbSec.Items.Remove("Caramoan");
                cbSec.Items.Remove("Puerto Asul");
                cbSec.Items.Remove("Achernar");
                cbSec.Items.Remove("Aman Pulo");
                cbSec.Items.Remove("Siargao");


                //Add
                cbSec.Items.Add("Amaranthus");
                cbSec.Items.Add("Gladiola");
                cbSec.Items.Add("Marjoram");
                cbSec.Items.Add("Collumbine");
                cbSec.Items.Add("Hycinth");
                cbSec.Items.Add("Anthurium");
                cbSec.Items.Add("Freezia");
            }

            else if (cbYear.SelectedItem.ToString() == "III")
            {
                //ADD
                cbSec.Items.Add("Rigel");
                cbSec.Items.Add("Achernar");
                cbSec.Items.Add("Capella");
                cbSec.Items.Add("Procyon");
                cbSec.Items.Add("Agena");
                cbSec.Items.Add("Kentaurus");

                //Remove I
                cbSec.Items.Remove("Pasiphae");
                cbSec.Items.Remove("Callisto");
                cbSec.Items.Remove("Sinope");
                cbSec.Items.Remove("Amalthea");
                cbSec.Items.Remove("Adrasthea");
                cbSec.Items.Remove("Ganymede");

                //Remove II

                cbSec.Items.Remove("Amaranthus");
                cbSec.Items.Remove("Gladiola");
                cbSec.Items.Remove("Marjoram");
                cbSec.Items.Remove("Collumbine");
                cbSec.Items.Remove("Hycinth");
                cbSec.Items.Remove("Anthurium");
                cbSec.Items.Remove("Freezia");


                //Remove IV

                cbSec.Items.Remove("Camiguin");
                cbSec.Items.Remove("El Nido");
                cbSec.Items.Remove("Boracay");
                cbSec.Items.Remove("Caramoan");
                cbSec.Items.Remove("Puerto Asul");
                cbSec.Items.Remove("Achernar");
                cbSec.Items.Remove("Aman Pulo");
                cbSec.Items.Remove("Siargao");


            }

            else if (cbYear.SelectedItem.ToString() == "IV")
            {
                //ADD
                cbSec.Items.Add("Camiguin");
                cbSec.Items.Add("El Nido");
                cbSec.Items.Add("Boracay");
                cbSec.Items.Add("Caramoan");
                cbSec.Items.Add("Puerto Asul");
                cbSec.Items.Add("Achernar");
                cbSec.Items.Add("Aman Pulo");
                cbSec.Items.Add("Siargao");

                //Remove I
                cbSec.Items.Remove("Pasiphae");
                cbSec.Items.Remove("Callisto");
                cbSec.Items.Remove("Sinope");
                cbSec.Items.Remove("Amalthea");
                cbSec.Items.Remove("Adrasthea");
                cbSec.Items.Remove("Ganymede");


                //Remove II

                cbSec.Items.Remove("Amaranthus");
                cbSec.Items.Remove("Gladiola");
                cbSec.Items.Remove("Marjoram");
                cbSec.Items.Remove("Collumbine");
                cbSec.Items.Remove("Hycinth");
                cbSec.Items.Remove("Anthurium");
                cbSec.Items.Remove("Freezia");

                //Remove III

                cbSec.Items.Remove("Rigel");
                cbSec.Items.Remove("Achernar");
                cbSec.Items.Remove("Capella");
                cbSec.Items.Remove("Procyon");
                cbSec.Items.Remove("Agena");
                cbSec.Items.Remove("Kentaurus");

            }


        }

        private void txtStudNum_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtStudNum.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtStudNum.Text.Remove(txtStudNum.Text.Length - 1);
                txtStudNum.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminForm wes = new AdminForm();
            wes.Show();
            this.Hide();
        }

        private void txtFN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
