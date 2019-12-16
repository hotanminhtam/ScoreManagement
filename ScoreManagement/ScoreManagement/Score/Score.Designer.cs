namespace ScoreManagement.Score
{
    partial class Score
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
            this.components = new System.ComponentModel.Container();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scoreManagementDataSet = new ScoreManagement.ScoreManagementDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.grdScore = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAMHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mASVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHUYENCANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAITAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIUAKIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUOIKIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tONGKETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scoreManagementDataSetDiem = new ScoreManagement.ScoreManagementDataSetDiem();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.mONHOCTableAdapter = new ScoreManagement.ScoreManagementDataSetTableAdapters.MONHOCTableAdapter();
            this.dIEMTableAdapter = new ScoreManagement.ScoreManagementDataSetDiemTableAdapters.DIEMTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreManagementDataSetDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(14, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(215, 32);
            this.label9.TabIndex = 42;
            this.label9.Text = "Điểm sinh viên";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.mONHOCBindingSource;
            this.comboBox1.DisplayMember = "TENMH";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(566, 60);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(314, 33);
            this.comboBox1.TabIndex = 43;
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.scoreManagementDataSet;
            // 
            // scoreManagementDataSet
            // 
            this.scoreManagementDataSet.DataSetName = "ScoreManagementDataSet";
            this.scoreManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(388, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 35);
            this.label2.TabIndex = 44;
            this.label2.Text = "Tên môn học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(14, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 35);
            this.label1.TabIndex = 45;
            this.label1.Text = "Mã môn học";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.mONHOCBindingSource;
            this.comboBox2.DisplayMember = "MAMH";
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(174, 60);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(163, 33);
            this.comboBox2.TabIndex = 46;
            // 
            // grdScore
            // 
            this.grdScore.AutoGenerateColumns = false;
            this.grdScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdScore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.mAMHDataGridViewTextBoxColumn,
            this.mASVDataGridViewTextBoxColumn,
            this.cHUYENCANDataGridViewTextBoxColumn,
            this.bAITAPDataGridViewTextBoxColumn,
            this.gIUAKIDataGridViewTextBoxColumn,
            this.cUOIKIDataGridViewTextBoxColumn,
            this.tONGKETDataGridViewTextBoxColumn});
            this.grdScore.DataSource = this.dIEMBindingSource;
            this.grdScore.Location = new System.Drawing.Point(4, 161);
            this.grdScore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdScore.Name = "grdScore";
            this.grdScore.RowHeadersWidth = 51;
            this.grdScore.RowTemplate.Height = 24;
            this.grdScore.Size = new System.Drawing.Size(1341, 398);
            this.grdScore.TabIndex = 47;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // mAMHDataGridViewTextBoxColumn
            // 
            this.mAMHDataGridViewTextBoxColumn.DataPropertyName = "MAMH";
            this.mAMHDataGridViewTextBoxColumn.HeaderText = "Mã môn học";
            this.mAMHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mAMHDataGridViewTextBoxColumn.Name = "mAMHDataGridViewTextBoxColumn";
            this.mAMHDataGridViewTextBoxColumn.Width = 125;
            // 
            // mASVDataGridViewTextBoxColumn
            // 
            this.mASVDataGridViewTextBoxColumn.DataPropertyName = "MASV";
            this.mASVDataGridViewTextBoxColumn.HeaderText = "Mã sinh viên";
            this.mASVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mASVDataGridViewTextBoxColumn.Name = "mASVDataGridViewTextBoxColumn";
            this.mASVDataGridViewTextBoxColumn.Width = 125;
            // 
            // cHUYENCANDataGridViewTextBoxColumn
            // 
            this.cHUYENCANDataGridViewTextBoxColumn.DataPropertyName = "CHUYENCAN";
            this.cHUYENCANDataGridViewTextBoxColumn.HeaderText = "Chuyên cần";
            this.cHUYENCANDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cHUYENCANDataGridViewTextBoxColumn.Name = "cHUYENCANDataGridViewTextBoxColumn";
            this.cHUYENCANDataGridViewTextBoxColumn.Width = 125;
            // 
            // bAITAPDataGridViewTextBoxColumn
            // 
            this.bAITAPDataGridViewTextBoxColumn.DataPropertyName = "BAITAP";
            this.bAITAPDataGridViewTextBoxColumn.HeaderText = "Bài tập";
            this.bAITAPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bAITAPDataGridViewTextBoxColumn.Name = "bAITAPDataGridViewTextBoxColumn";
            this.bAITAPDataGridViewTextBoxColumn.Width = 125;
            // 
            // gIUAKIDataGridViewTextBoxColumn
            // 
            this.gIUAKIDataGridViewTextBoxColumn.DataPropertyName = "GIUAKI";
            this.gIUAKIDataGridViewTextBoxColumn.HeaderText = "Giữa kỳ";
            this.gIUAKIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gIUAKIDataGridViewTextBoxColumn.Name = "gIUAKIDataGridViewTextBoxColumn";
            this.gIUAKIDataGridViewTextBoxColumn.Width = 125;
            // 
            // cUOIKIDataGridViewTextBoxColumn
            // 
            this.cUOIKIDataGridViewTextBoxColumn.DataPropertyName = "CUOIKI";
            this.cUOIKIDataGridViewTextBoxColumn.HeaderText = "Cuối kỳ";
            this.cUOIKIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cUOIKIDataGridViewTextBoxColumn.Name = "cUOIKIDataGridViewTextBoxColumn";
            this.cUOIKIDataGridViewTextBoxColumn.Width = 125;
            // 
            // tONGKETDataGridViewTextBoxColumn
            // 
            this.tONGKETDataGridViewTextBoxColumn.DataPropertyName = "TONGKET";
            this.tONGKETDataGridViewTextBoxColumn.HeaderText = "Tổng kết";
            this.tONGKETDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tONGKETDataGridViewTextBoxColumn.Name = "tONGKETDataGridViewTextBoxColumn";
            this.tONGKETDataGridViewTextBoxColumn.Width = 125;
            // 
            // dIEMBindingSource
            // 
            this.dIEMBindingSource.DataMember = "DIEM";
            this.dIEMBindingSource.DataSource = this.scoreManagementDataSetDiem;
            // 
            // scoreManagementDataSetDiem
            // 
            this.scoreManagementDataSetDiem.DataSetName = "ScoreManagementDataSetDiem";
            this.scoreManagementDataSetDiem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.MintCream;
            this.btnBack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBack.Location = new System.Drawing.Point(1352, 344);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(163, 52);
            this.btnBack.TabIndex = 51;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Blue;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdate.Location = new System.Drawing.Point(1352, 450);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(163, 52);
            this.btnUpdate.TabIndex = 49;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.Location = new System.Drawing.Point(1352, 398);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 52);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.Location = new System.Drawing.Point(1352, 502);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(163, 52);
            this.btnDelete.TabIndex = 50;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // dIEMTableAdapter
            // 
            this.dIEMTableAdapter.ClearBeforeFill = true;
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1529, 562);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grdScore);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label9);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Score";
            this.Text = "Score";
            this.Load += new System.EventHandler(this.Score_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreManagementDataSetDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView grdScore;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private ScoreManagementDataSet scoreManagementDataSet;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private ScoreManagementDataSetTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private ScoreManagementDataSetDiem scoreManagementDataSetDiem;
        private System.Windows.Forms.BindingSource dIEMBindingSource;
        private ScoreManagementDataSetDiemTableAdapters.DIEMTableAdapter dIEMTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAMHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mASVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHUYENCANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bAITAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIUAKIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUOIKIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tONGKETDataGridViewTextBoxColumn;
    }
}