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
        private Logic Business;
        string nganh;
        public StudentInformation(string nganh)
        {
            InitializeComponent();
            this.Business = new Logic();
            this.nganh = nganh;
            this.Load += StudentInformation_Load1;
            this.btnBack.Click += BtnBack_Click;
            this.btnSave.Click += BtnSave_Click;
            this.btnUpdate.Click += BtnUpdate_Click;
            this.btnDelete.Click += BtnDelete_Click;
            this.grdSinhVien.SelectionChanged += GrdSinhVien_SelectionChanged;
            this.grdSinhVien.AllowUserToAddRows = false;
        }

        private void GrdSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            if (this.grdSinhVien.SelectedRows.Count == 1)
            {
                txtMaSv.Text = this.grdSinhVien.SelectedRows[0].Cells[0].Value.ToString();
                txtTenSv.Text = this.grdSinhVien.SelectedRows[0].Cells[2].Value.ToString();
                dtpNgaySinh.Value = DateTime.Parse(this.grdSinhVien.SelectedRows[0].Cells[3].Value.ToString());
                if (bool.Parse(this.grdSinhVien.SelectedRows[0].Cells[4].Value.ToString()) == true)
                {
                    rdbNam.Checked = true;
                }
                else
                {
                    rdbNu.Checked = true;
                }
                txtCMND.Text = this.grdSinhVien.SelectedRows[0].Cells[5].Value.ToString();
                txtQueQuan.Text = this.grdSinhVien.SelectedRows[0].Cells[7].Value.ToString();
                txtDiaChi.Text = this.grdSinhVien.SelectedRows[0].Cells[8].Value.ToString();
                txtSDT.Text = this.grdSinhVien.SelectedRows[0].Cells[9].Value.ToString();
            }
        }

        private void StudentInformation_Load1(object sender, EventArgs e)
        {
            this.LoadAllStudent();
        }

        private void LoadAllStudent()
        {
            MessageBox.Show(nganh);
            var std = this.Business.GetStudentsOfFaculty(nganh);
            this.grdSinhVien.DataSource = std;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(this.grdSinhVien.SelectedRows.Count == 1)
            {
                if(MessageBox.Show("Do you want delete?", "Comfirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var sv = (SVIEN)this.grdSinhVien.SelectedRows[0].DataBoundItem;
                    this.Business.DeleteStudent(sv.MASV);
                    MessageBox.Show("Delete successfully!");
                    this.LoadAllStudent();
                }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var manganh = int.Parse(this.cboMaNganh.Text);
            var masv = this.txtMaSv.Text;
            var tensv = this.txtTenSv.Text;
            var gioitinh = "";
            if(this.rdbNam.Checked == true)
            {
                gioitinh = "Nam";
            }
            if(this.rdbNu.Checked == true)
            {
                gioitinh = "Nữ";
            }
            var ngaysinh = this.dtpNgaySinh.Value;
            var sdt = this.txtSDT.Text;
            var email = this.txtEmail.Text;
            var cmnd = int.Parse(this.txtCMND.Text);
            var quequan = this.txtQueQuan.Text;
            var diachi = this.txtDiaChi.Text;

            this.Business.CreateStudents(manganh, masv, tensv, ngaysinh, gioitinh, sdt, email, cmnd, quequan, diachi);
            MessageBox.Show("Create student successfully!");

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            var temp = this.Owner;
            temp.RemoveOwnedForm(this);
            this.Close();
            temp.Show();
        }

        private void StudentInformation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'scoreManagementDataSet3.NGANH' table. You can move, or remove it, as needed.
            this.nGANHTableAdapter.Fill(this.scoreManagementDataSet3.NGANH);
            // TODO: This line of code loads data into the 'scoreManagementDataSet2.SVIEN' table. You can move, or remove it, as needed.
            this.sVIENTableAdapter.Fill(this.scoreManagementDataSet2.SVIEN);

        }
    }
}
