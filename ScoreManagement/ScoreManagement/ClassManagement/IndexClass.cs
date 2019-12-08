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
    public partial class IndexClass : Form
    {
        private LogicClass Business;
        public IndexClass()
        {
            InitializeComponent();
            this.Business = new LogicClass();
            this.Load += IndexClass_Load;
            this.btnCreate.Click += BtnCreate_Click;
            this.btnDelete.Click += BtnDelete_Click;
            this.grdClass.DoubleClick += GrdClass_DoubleClick;
            this.btnBack.Click += BtnBack_Click;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            var temp = this.Owner;
            temp.RemoveOwnedForm(this);
            this.Close();
            temp.Show();
        }

        private void GrdClass_DoubleClick(object sender, EventArgs e)
        {
            var @class = (Class)this.grdClass.SelectedRows[0].DataBoundItem;
            var updateForm = new UpdateClass(@class.ID);
            updateForm.ShowDialog();
            this.LoadAllClassess();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (this.grdClass.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Do you want to delete this?", "Confirm",
                     MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    var @class = (Class)this.grdClass.SelectedRows[0].DataBoundItem;
                    this.Business.DeleteClass(@class.ID);
                    MessageBox.Show("Delete Successfully.");
                    this.LoadAllClassess();

                }
            }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            var createForm = new CreateClass();
            createForm.ShowDialog();
            this.LoadAllClassess();
        }

        private void IndexClass_Load(object sender, EventArgs e)
        {
            this.LoadAllClassess();
        }
        private void LoadAllClassess()
        {
            var classess = this.Business.GetLOPs();
            this.grdClass.DataSource = classess;
        }
    }
}
