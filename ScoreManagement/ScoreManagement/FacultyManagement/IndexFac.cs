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
        private Logic Business;
        public IndexFac()
        {
            InitializeComponent();
            this.Business = new Logic();
            this.Load += IndexFac_Load;
            this.btnCreate.Click += BtnCreate_Click;
            this.btnDelete.Click += BtnDelete_Click;
            this.btnUpdate.Click += BtnUpdate_Click;
            this.grdFac.Click += GrdFac_Click;
            this.btnBack.Click += BtnBack_Click;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            var temp = this.Owner;
            temp.RemoveOwnedForm(this);
            this.Close();
            temp.Show();
        }

        private void GrdFac_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            new CreateForm().ShowDialog();
            this.ShowAllFac();
        }

        private void IndexFac_Load(object sender, EventArgs e)
        {
            this.ShowAllFac();
        }

        private void ShowAllFac()
        {
            this.grdFac.DataSource = this.Business.GetKHOAs();
        }
    }
}
