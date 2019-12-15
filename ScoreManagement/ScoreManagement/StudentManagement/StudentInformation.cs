using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreManagement.StudentManagement
{
    public partial class StudentInformation : Form
    {
        public StudentInformation()
        {
            InitializeComponent();
            this.btnBack.Click += BtnBack_Click;
            this.btnSave.Click += BtnSave_Click;
            this.btnUpdate.Click += BtnUpdate_Click;
            this.btnDelete.Click += BtnDelete_Click;
            this.grdSinhVien.Click += GrdSinhVien_Click;
            this.grdSinhVien.DoubleClick += GrdSinhVien_DoubleClick;
        }

        private void GrdSinhVien_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            ScoreManagement.Score.Score index = new Score.Score();
            index.Show();
        }

        private void GrdSinhVien_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void StudentInformation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'scoreManagementDataSet2.SVIEN' table. You can move, or remove it, as needed.
            this.sVIENTableAdapter.Fill(this.scoreManagementDataSet2.SVIEN);

        }
    }
}
