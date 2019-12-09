namespace ScoreManagement.FacultyManagement
{
    partial class IndexFac
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnBack = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.grdFac = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFac)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack,
            this.btnFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(911, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 31);
            this.btnBack.Text = "Back";
            // 
            // btnFile
            // 
            this.btnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreate,
            this.btnDelete,
            this.btnUpdate});
            this.btnFile.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(62, 31);
            this.btnFile.Text = "File";
            // 
            // btnCreate
            // 
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(224, 32);
            this.btnCreate.Text = "Create";
            // 
            // btnDelete
            // 
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(224, 32);
            this.btnDelete.Text = "Delete";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(224, 32);
            this.btnUpdate.Text = "Update";
            // 
            // grdFac
            // 
            this.grdFac.AllowUserToAddRows = false;
            this.grdFac.AllowUserToDeleteRows = false;
            this.grdFac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdFac.Location = new System.Drawing.Point(0, 35);
            this.grdFac.Name = "grdFac";
            this.grdFac.ReadOnly = true;
            this.grdFac.RowHeadersWidth = 51;
            this.grdFac.RowTemplate.Height = 24;
            this.grdFac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdFac.Size = new System.Drawing.Size(911, 469);
            this.grdFac.TabIndex = 1;
            // 
            // IndexFac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 504);
            this.Controls.Add(this.grdFac);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "IndexFac";
            this.Text = "IndexFac";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnBack;
        private System.Windows.Forms.ToolStripMenuItem btnFile;
        private System.Windows.Forms.ToolStripMenuItem btnCreate;
        private System.Windows.Forms.ToolStripMenuItem btnDelete;
        private System.Windows.Forms.ToolStripMenuItem btnUpdate;
        private System.Windows.Forms.DataGridView grdFac;
    }
}