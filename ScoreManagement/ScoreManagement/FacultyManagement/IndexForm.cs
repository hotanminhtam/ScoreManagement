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
    public partial class IndexForm : Form
    {
        private Logic Business;

        public IndexForm()
        {
            InitializeComponent();
            this.Business = new Logic();
            this.Load += IndexForm_Load;
            this.btnCreate.Click += BtnCreate_Click;
            this.btnDelete.Click += BtnDelete_Click;
            this.grdFaculty.DoubleClick += GrdFaculty_DoubleClick;
        }

        private void GrdFaculty_DoubleClick(object sender, EventArgs e)
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
            this.ShowAllFaculty();
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            this.ShowAllFaculty();
        }
        
        private void ShowAllFaculty()
        {
            var khoa = this.Business.GetKHOAs();
            this.grdFaculty.DataSource = khoa;
        }
    }
}
