using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.btnStart.Click += BtnStart_Click;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScoreManagement.FacultyManagement.IndexForm index = new FacultyManagement.IndexForm();
            index.Show();
            index.Owner = this;
        }
    }
}
