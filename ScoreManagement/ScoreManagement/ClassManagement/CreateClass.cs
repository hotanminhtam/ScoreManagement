using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreManagement.ClassManagement
{
    public partial class CreateClass : Form
    {
        private LogicClass Business;
        public CreateClass()
        {
            InitializeComponent();
            this.Business = new LogicClass();
            this.btnSave.Click += BtnSave_Click;
            this.btnCancel.Click += BtnCancel_Click;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var malop = int.Parse(this.txtMaLop.Text);
            var tenlop = this.txtTenLop.Text;
            this.Business.CreateClass(malop, tenlop);
            MessageBox.Show("Create Successfully!");
            this.Close();
        }
    }
}
