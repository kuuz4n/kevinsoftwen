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
    public partial class AdminForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=JHUNROY\\SQLEXPRESS;Database=SchoolDatabase;Trusted_Connection=True; MultipleActiveResultSets=True;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        public AdminForm()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //panel1.Visible = true;
        }

        private void ASButton_Click(object sender, EventArgs e)
        {
            RegisterStudents rs = new RegisterStudents();
            rs.Show();
            this.Hide();
        }

        private void ACButton_Click(object sender, EventArgs e)
        {
            AddCandidate ac = new AddCandidate();
            ac.Show();
            this.Hide();
        }

        private void VRButton_Click(object sender, EventArgs e)
        {
            VotingResult vr = new VotingResult();
            vr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CandidateList cl = new CandidateList();
            cl.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStaff we = new AddStaff();
            we.Show();
            this.Hide();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}

