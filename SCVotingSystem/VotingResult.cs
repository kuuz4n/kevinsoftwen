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
    public partial class VotingResult : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=JHUNROY\\SQLEXPRESS;Database=SchoolDatabase;Trusted_Connection=True");
        public int x;
        public string wew;
        double compute;
        int isangdaan = 100;
        double gg;
        
        
        
        public VotingResult()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            VRCHART.Visible = true;
            using (SqlConnection connect = new SqlConnection("Data Source=JHUNROY\\SQLEXPRESS;Database=SchoolDatabase;Trusted_Connection=True"))
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("Please Select A Candidate");
                }

                if (comboBox1.Text == "President")
                {
                    using (SqlDataAdapter da = new SqlDataAdapter("select Name,Count(Name) as Votes from PresidentVotes group by Name order by Votes DESC", connect))
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        da.SelectCommand.ExecuteNonQuery();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                        connect.Close();

                    }

                    using (SqlDataAdapter gg = new SqlDataAdapter("select COUNT(Name) as VoteResult, Name from PresidentVotes Group By Name order by VoteResult DESC", connect))
                    {
                        try
                        {
                            connect.Open();
                            gg.SelectCommand.ExecuteNonQuery();
                            VRCHART.Series["Vote Count"].YValueMembers = "VoteResult";
                            VRCHART.Series["Vote Count"].XValueMember = "Name";
                            DataTable tb = new DataTable();
                            gg.Fill(tb);
                            VRCHART.DataSource = tb;
                            VRCHART.DataBind();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    totalresult();
                }

                else if (comboBox1.Text == "Vice President")
                {
                    using (SqlDataAdapter daf = new SqlDataAdapter("select Name,Count(Name) as Votes from VPresVT group by Name order by Votes DESC ", connect))
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        daf.SelectCommand.ExecuteNonQuery();
                        daf.Fill(dt);
                        dataGridView1.DataSource = dt;
                        connect.Close();
                    }

                    using (SqlDataAdapter gg = new SqlDataAdapter("select COUNT(Name) as VoteResult, Name from VPresVT Group By Name order by VoteResult DESC", connect))
                    {
                        try
                        {
                            connect.Open();
                            gg.SelectCommand.ExecuteNonQuery();
                            VRCHART.Series["Vote Count"].YValueMembers = "VoteResult";
                            VRCHART.Series["Vote Count"].XValueMember = "Name";
                            DataTable tb = new DataTable();
                            gg.Fill(tb);
                            VRCHART.DataSource = tb;
                            VRCHART.DataBind();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    totalresult();
                }


                else if (comboBox1.Text == "Secretary")
                {
                    using (SqlDataAdapter daf = new SqlDataAdapter("select Name,Count(Name) as Votes from SecretaryVT group by Name order by Votes DESC ", connect))
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        daf.SelectCommand.ExecuteNonQuery();
                        daf.Fill(dt);
                        dataGridView1.DataSource = dt;
                        connect.Close();
                    }

                    using (SqlDataAdapter gg = new SqlDataAdapter("select COUNT(Name) as VoteResult, Name from SecretaryVT Group By Name order by VoteResult DESC", connect))
                    {
                        try
                        {
                            connect.Open();
                            gg.SelectCommand.ExecuteNonQuery();
                            VRCHART.Series["Vote Count"].YValueMembers = "VoteResult";
                            VRCHART.Series["Vote Count"].XValueMember = "Name";
                            DataTable tb = new DataTable();
                            gg.Fill(tb);
                            VRCHART.DataSource = tb;
                            VRCHART.DataBind();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        totalresult();
                    }
                }

                else if (comboBox1.Text == "Auditor")
                {
                    using (SqlDataAdapter daf = new SqlDataAdapter("select Name,Count(Name) as Votes from AuditVT group by Name order by Votes DESC ", connect))
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        daf.SelectCommand.ExecuteNonQuery();
                        daf.Fill(dt);
                        dataGridView1.DataSource = dt;
                        connect.Close();
                    }

                    using (SqlDataAdapter gg = new SqlDataAdapter("select COUNT(Name) as VoteResult, Name from AuditVT Group By Name order by VoteResult DESC", connect))
                    {
                        try
                        {
                            connect.Open();
                            gg.SelectCommand.ExecuteNonQuery();
                            VRCHART.Series["Vote Count"].YValueMembers = "VoteResult";
                            VRCHART.Series["Vote Count"].XValueMember = "Name";
                            DataTable tb = new DataTable();
                            gg.Fill(tb);
                            VRCHART.DataSource = tb;
                            VRCHART.DataBind();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        totalresult();
                    }
                }

                else if (comboBox1.Text == "Treasurer")
                {
                    using (SqlDataAdapter tres = new SqlDataAdapter("select Name, Count(Name) as Votes from TreasurerVT group by Name order by Votes DESC", connect))
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        tres.SelectCommand.ExecuteNonQuery();
                        tres.Fill(dt);
                        dataGridView1.DataSource = dt;
                        connect.Close();
                        tres.Dispose();
                    }

                    using (SqlDataAdapter tres = new SqlDataAdapter("select COUNT(Name) as VoteResult, Name from TreasurerVT Group By Name order by VoteResult DESC", connect))
                    {
                        try
                        {
                            connect.Open();
                            tres.SelectCommand.ExecuteNonQuery();
                            VRCHART.Series["Vote Count"].YValueMembers = "VoteResult";
                            VRCHART.Series["Vote Count"].XValueMember = "Name";
                            DataTable tb = new DataTable();
                            tres.Fill(tb);
                            VRCHART.DataSource = tb;
                            VRCHART.DataBind();
                            tres.Dispose();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        totalresult();
                    }
                }

                if (comboBox1.Text == "1st Yr. Representative")
                {
                    using (SqlDataAdapter daf = new SqlDataAdapter("select Name,Count(Name) as Votes from FirstRepVT group by Name order by Votes DESC ", connect))
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        daf.SelectCommand.ExecuteNonQuery();
                        daf.Fill(dt);
                        dataGridView1.DataSource = dt;
                        connect.Close();
                    }

                    using (SqlDataAdapter gg = new SqlDataAdapter("select COUNT(Name) as VoteResult, Name from FirstRepVT Group By Name order by VoteResult DESC", connect))
                    {
                        try
                        {
                            connect.Open();
                            gg.SelectCommand.ExecuteNonQuery();
                            VRCHART.Series["Vote Count"].YValueMembers = "VoteResult";
                            VRCHART.Series["Vote Count"].XValueMember = "Name";
                            DataTable tb = new DataTable();
                            gg.Fill(tb);
                            VRCHART.DataSource = tb;
                            VRCHART.DataBind();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        totalresult();
                    }
                }

                if (comboBox1.Text == "2nd Yr. Representative")
                {
                    using (SqlDataAdapter daf = new SqlDataAdapter("select Name,Count(Name) as Votes from SecRepVT group by Name order by Votes DESC ", connect))
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        daf.SelectCommand.ExecuteNonQuery();
                        daf.Fill(dt);
                        dataGridView1.DataSource = dt;
                        connect.Close();
                    }

                    using (SqlDataAdapter gg = new SqlDataAdapter("select COUNT(Name) as VoteResult, Name from SecRepVT Group By Name order by VoteResult DESC", connect))
                    {
                        try
                        {
                            connect.Open();
                            gg.SelectCommand.ExecuteNonQuery();
                            VRCHART.Series["Vote Count"].YValueMembers = "VoteResult";
                            VRCHART.Series["Vote Count"].XValueMember = "Name";
                            DataTable tb = new DataTable();
                            gg.Fill(tb);
                            VRCHART.DataSource = tb;
                            VRCHART.DataBind();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        totalresult();
                    }
                }

                if (comboBox1.Text == "3rd Yr. Representative")
                {
                    using (SqlDataAdapter daf = new SqlDataAdapter("select Name,Count(Name) as Votes from ThirdRepVT group by Name order by Votes DESC ", connect))
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        daf.SelectCommand.ExecuteNonQuery();
                        daf.Fill(dt);
                        dataGridView1.DataSource = dt;
                        connect.Close();
                    }

                    using (SqlDataAdapter gg = new SqlDataAdapter("select COUNT(Name) as VoteResult, Name from ThirdRepVT Group By Name order by VoteResult DESC", connect))
                    {
                        try
                        {
                            connect.Open();
                            gg.SelectCommand.ExecuteNonQuery();
                            VRCHART.Series["Vote Count"].YValueMembers = "VoteResult";
                            VRCHART.Series["Vote Count"].XValueMember = "Name";
                            DataTable tb = new DataTable();
                            gg.Fill(tb);
                            VRCHART.DataSource = tb;
                            VRCHART.DataBind();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        totalresult();
                    }
                }

                if (comboBox1.Text == "4th Yr. Representative")
                {
                    using (SqlDataAdapter daf = new SqlDataAdapter("select Name,Count(Name) as Votes from FourthRepVT group by Name order by Votes DESC ", connect))
                    {
                        connect.Open();
                        DataTable dt = new DataTable();
                        daf.SelectCommand.ExecuteNonQuery();
                        daf.Fill(dt);
                        dataGridView1.DataSource = dt;
                        connect.Close();
                    }

                    using (SqlDataAdapter gg = new SqlDataAdapter("select COUNT(Name) as VoteResult, Name from FourthRepVT Group By Name order by VoteResult DESC", connect))
                    {
                        try
                        {
                            connect.Open();
                            gg.SelectCommand.ExecuteNonQuery();
                            VRCHART.Series["Vote Count"].YValueMembers = "VoteResult";
                            VRCHART.Series["Vote Count"].XValueMember = "Name";
                            DataTable tb = new DataTable();
                            gg.Fill(tb);
                            VRCHART.DataSource = tb;
                            VRCHART.DataBind();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        totalresult();
                    }
                }
            }
        }

        private void VotingResult_Load(object sender, EventArgs e)
        {
            VRCHART.Series.Add("Vote Count");
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

        private void viewStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection("Data Source=JHUNROY\\SQLEXPRESS;Database=SchoolDatabase;Trusted_Connection=True"))
            {
                {
                    using (SqlDataAdapter da = new SqlDataAdapter("select StudentNum,Firstname,LastName from StudInfo where VoteID=1", connect))
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

        private void button2_Click_1(object sender, EventArgs e)
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

        public void totalresult()
        {
            SqlDataAdapter da = new SqlDataAdapter("select Count(Name) as Totals from PresidentVotes", connect);
            connect.Open();
            da.SelectCommand.ExecuteNonQuery();
            DataTable tb = new DataTable();
            da.Fill(tb);
            connect.Close();
            foreach (DataRow rw in tb.Rows)
            {
               x = Convert.ToInt32(rw["Totals"]);                   
            }
        }

        private void testing()
        {
            int selectedIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedIndex];
            wew = row.Cells["Votes"].Value.ToString();
            compute =  Convert.ToInt32(wew) / x;
            gg = compute * isangdaan; 
            label2.Text = gg.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            testing();
        }
    }
}
