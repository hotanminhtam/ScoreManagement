namespace ScoreManagement.FacultyManagement
{
    partial class IndexForm
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
            this.btnFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grdFalculty = new System.Windows.Forms.DataGridView();
            this.grdFaculty = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFalculty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFaculty)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFile,
            this.btnBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1672, 43);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnFile
            // 
            this.btnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreate,
            this.btnDelete});
            this.btnFile.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(75, 37);
            this.btnFile.Text = "File";
            // 
            // btnCreate
            // 
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(270, 42);
            this.btnCreate.Text = "Create";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 37);
            this.btnBack.Text = "Back";
            // 
            // grdFalculty
            // 
            this.grdFalculty.AllowUserToAddRows = false;
            this.grdFalculty.AllowUserToDeleteRows = false;
            this.grdFalculty.BackgroundColor = this.BackColor;
            this.grdFalculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFalculty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdFalculty.Location = new System.Drawing.Point(0, 43);
            this.grdFalculty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdFalculty.Name = "grdFalculty";
            this.grdFalculty.ReadOnly = true;
            this.grdFalculty.RowHeadersWidth = 62;
            this.grdFalculty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdFalculty.Size = new System.Drawing.Size(1672, 765);
            this.grdFalculty.TabIndex = 1;
            // 
            // grdFaculty
            // 
            this.grdFaculty.AllowUserToAddRows = false;
            this.grdFaculty.AllowUserToDeleteRows = false;
            this.grdFaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFaculty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdFaculty.Location = new System.Drawing.Point(0, 34);
            this.grdFaculty.Name = "grdFaculty";
            this.grdFaculty.ReadOnly = true;
            this.grdFaculty.RowHeadersWidth = 62;
            this.grdFaculty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdFaculty.Size = new System.Drawing.Size(1115, 491);
            this.grdFaculty.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(270, 42);
            this.btnDelete.Text = "Delete";
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1672, 808);
            this.Controls.Add(this.grdFalculty);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "IndexForm";
            this.Text = "IndexForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFalculty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFaculty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnFile;
        private System.Windows.Forms.DataGridView grdFalculty;
        private System.Windows.Forms.DataGridView grdFaculty;
        private System.Windows.Forms.ToolStripMenuItem btnBack;
        private System.Windows.Forms.ToolStripMenuItem btnCreate;
        private System.Windows.Forms.ToolStripMenuItem btnDelete;
    }
}