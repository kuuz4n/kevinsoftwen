using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SCVotingSystem
{
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
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
