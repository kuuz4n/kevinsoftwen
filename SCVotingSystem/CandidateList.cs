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
    public partial class CandidateList : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=JHUNROY\\SQLEXPRESS;Database=SchoolDatabase;Trusted_Connection=True");

        public CandidateList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection("Data Source=JHUNROY\\SQLEXPRESS;Database=SchoolDatabase;Trusted_Connection=True"))
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("Please Select A Candidate");
                }

                if (comboBox1.Text == "President")
                {
                    using (SqlDataAdapter da = new SqlDataAdapter("select CanID,Name,Party from CandidInfo where Position='President'", connect))
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        da.SelectCommand.ExecuteNonQuery();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }

                if (comboBox1.Text == "Vice President")
                {
                    using (SqlDataAdapter da = new SqlDataAdapter("select CanID,Name,Party from CandidInfo where Position='Vice President'", connect))
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        da.SelectCommand.ExecuteNonQuery();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }

                if (comboBox1.Text == "Secretary")
                {
                    using (SqlDataAdapter da = new SqlDataAdapter("select CanID,Name,Party from CandidInfo where Position='Secretary'", connect))
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        da.SelectCommand.ExecuteNonQuery();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }

                if (comboBox1.Text == "Auditor")
                {
                    using (SqlDataAdapter da = new SqlDataAdapter("select CanID,Name,Party from CandidInfo where Position='Auditor'", connect))
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        da.SelectCommand.ExecuteNonQuery();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }

                if (comboBox1.Text == "Treasurer")
                {
                    using (SqlDataAdapter da = new SqlDataAdapter("select CanID,Name,Party from CandidInfo where Position='Treasurer'", connect))
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        da.SelectCommand.ExecuteNonQuery();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }

                if (comboBox1.Text == "1st Yr. Representative")
                {
                    using (SqlDataAdapter da = new SqlDataAdapter("select CanID,Name,Party from CandidInfo where Position='1st Yr. Representative'", connect))
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        da.SelectCommand.ExecuteNonQuery();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }

                if (comboBox1.Text == "2nd Yr. Representative")
                {
                    using (SqlDataAdapter da = new SqlDataAdapter("select CanID,Name,Party from CandidInfo where Position='2nd Yr. Representative'", connect))
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        da.SelectCommand.ExecuteNonQuery();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }

                if (comboBox1.Text == "3rd Yr. Representative")
                {
                    using (SqlDataAdapter da = new SqlDataAdapter("select CanID,Name,Party from CandidInfo where Position='3rd Yr. Representative'", connect))
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        da.SelectCommand.ExecuteNonQuery();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }

                if (comboBox1.Text == "4th Yr. Representative")
                {
                    using (SqlDataAdapter da = new SqlDataAdapter("select CanID,Name,Party from CandidInfo where Position='4th Yr. Representative'", connect))
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        da.SelectCommand.ExecuteNonQuery();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            delete();
            update();
        }

        private void delete()
        {
            try
            {
                int selectedIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow row = dataGridView1.Rows[selectedIndex];              
                string wew = row.Cells["CanID"].Value.ToString();
                SqlDataAdapter delcmd = new SqlDataAdapter("DELETE FROM CandidInfo WHERE CanID= '" + wew + "'", conn);
                conn.Open();
                DataTable dt = new DataTable();
                delcmd.SelectCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Row Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void update()
        {
            using (SqlConnection connect = new SqlConnection("Data Source=JHUNROY\\SQLEXPRESS;Database=SchoolDatabase;Trusted_Connection=True"))
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("Please Select A Candidate");
                }

                if (comboBox1.Text == "President")
                {
                    using (SqlDataAdapter da = new SqlDataAdapter("select CanID,Name,Party from CandidInfo where Position='President'", connect))
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        da.SelectCommand.ExecuteNonQuery();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }

                if (comboBox1.Text == "Vice President")
                {
                    using (SqlDataAdapter da = new SqlDataAdapter("select CanID,Name,Party from CandidInfo where Position='Vice President'", connect))
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        da.SelectCommand.ExecuteNonQuery();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }

                if (comboBox1.Text == "Secretary")
                {
                    using (SqlDataAdapter da = new SqlDataAdapter("select CanID,Name,Party from CandidInfo where Position='Secretary'", connect))
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        da.SelectCommand.ExecuteNonQuery();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }

                if (comboBox1.Text == "Auditor")
                {
                    using (SqlDataAdapter da = new SqlDataAdapter("select CanID,Name,Party from CandidInfo where Position='Auditor'", connect))
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        da.SelectCommand.ExecuteNonQuery();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }

                if (comboBox1.Text == "Treasurer")
                {
                    using (SqlDataAdapter da = new SqlDataAdapter("select CanID,Name,Party from CandidInfo where Position='Treasurer'", connect))
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        da.SelectCommand.ExecuteNonQuery();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }

                if (comboBox1.Text == "1st Yr. Representative")
                {
                    using (SqlDataAdapter da = new SqlDataAdapter("select CanID,Name,Party from CandidInfo where Position='1st Yr. Representative'", connect))
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        da.SelectCommand.ExecuteNonQuery();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }

                if (comboBox1.Text == "2nd Yr. Representative")
                {
                    using (SqlDataAdapter da = new SqlDataAdapter("select CanID,Name,Party from CandidInfo where Position='2nd Yr. Representative'", connect))
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        da.SelectCommand.ExecuteNonQuery();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }

                if (comboBox1.Text == "3rd Yr. Representative")
                {
                    using (SqlDataAdapter da = new SqlDataAdapter("select CanID,Name,Party from CandidInfo where Position='3rd Yr. Representative'", connect))
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        da.SelectCommand.ExecuteNonQuery();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }

                if (comboBox1.Text == "4th Yr. Representative")
                {
                    using (SqlDataAdapter da = new SqlDataAdapter("select CanID,Name,Party from CandidInfo where Position='4th Yr. Representative'", connect))
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        da.SelectCommand.ExecuteNonQuery();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }

        private void CandidateList_Load(object sender, EventArgs e)
        {
            if (LoginForm.Role == "admin")
            {
                button3.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (LoginForm.Role == "admin")
            {
                AdminForm af = new AdminForm();
                af.Show();
                this.Hide();
            }

            else
            {
                StaffForm sf = new StaffForm();
                sf.Show();
                this.Hide();
            }
        }      
    }
}
