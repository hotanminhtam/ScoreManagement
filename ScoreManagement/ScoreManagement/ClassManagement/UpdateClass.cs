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
    public partial class UpdateClass : Form
    {
        private int ClassId;
        private LogicClass Business;

        public UpdateClass(int id)
        {
            InitializeComponent();
            this.ClassId = id;
            this.Business = new LogicClass();
            this.btnSave.Click += BtnSave_Click;
            this.btnCancel.Click += BtnCancel_Click;
            this.Load += UpdateClass_Load;
        }

        private void UpdateClass_Load(object sender, EventArgs e)
        {
            var @class = this.Business.GetLOP(this.ClassId);
            @class.MALOP = int.Parse(this.txtMaLop.Text);
            @class.TENLOP = this.txtTenLop.Text;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var malop = int.Parse(this.txtMaLop.Text);
            var tenlop = this.txtTenLop.Text;
            this.Business.UpdateClass(this.ClassId, malop, tenlop);
            MessageBox.Show("Update Successfully.");
            this.Close();
        }
    }
}
