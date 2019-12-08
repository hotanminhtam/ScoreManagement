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
    public partial class CreateForm : Form
    {
        private Logic Business;
        public CreateForm()
        {
            InitializeComponent();
            this.Business = new Logic();
            this.btnSave.Click += BtnSave_Click;
            this.btnCancel.Click += BtnCancel_Click;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var makhoa = int.Parse(this.txtMaKhoa.Text);
            var tenkhoa = this.txtTenKhoa.Text;
            this.Business.CreateFaculty(makhoa, tenkhoa);
            MessageBox.Show("Create Successfully!");
            this.Close();
        }

        private void CreateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
