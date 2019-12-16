using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreManagement.FacultyManagement
{
    public partial class IndexFac : Form
    {
        public IndexFac()
        {
            InitializeComponent();
            this.btnTim.Click += BtnTim_Click;
        }

        private void BtnTim_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScoreManagement.StudentManagement.StudentInformation index = new StudentManagement.StudentInformation();
            index.Show();
            
        }

        private void IndexFac_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'scoreManagementDataSet1.NGANH' table. You can move, or remove it, as needed.
            this.nGANHTableAdapter.Fill(this.scoreManagementDataSet1.NGANH);

        }
    }
}
