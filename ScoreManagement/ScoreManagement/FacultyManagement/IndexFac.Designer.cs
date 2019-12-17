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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.cboNganh = new System.Windows.Forms.ComboBox();
            this.nGANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scoreManagementDataSet1 = new ScoreManagement.ScoreManagementDataSet1();
            this.nGANHTableAdapter = new ScoreManagement.ScoreManagementDataSet1TableAdapters.NGANHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nGANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreManagementDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngành";
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(189, 115);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(107, 42);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // cboNganh
            // 
            this.cboNganh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboNganh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboNganh.DataSource = this.nGANHBindingSource;
            this.cboNganh.DisplayMember = "TENNGANH";
            this.cboNganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNganh.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNganh.FormattingEnabled = true;
            this.cboNganh.Location = new System.Drawing.Point(133, 64);
            this.cboNganh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboNganh.Name = "cboNganh";
            this.cboNganh.Size = new System.Drawing.Size(361, 42);
            this.cboNganh.TabIndex = 3;
            this.cboNganh.ValueMember = "TENNGANH";
            // 
            // nGANHBindingSource
            // 
            this.nGANHBindingSource.DataMember = "NGANH";
            this.nGANHBindingSource.DataSource = this.scoreManagementDataSet1;
            // 
            // scoreManagementDataSet1
            // 
            this.scoreManagementDataSet1.DataSetName = "ScoreManagementDataSet1";
            this.scoreManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nGANHTableAdapter
            // 
            this.nGANHTableAdapter.ClearBeforeFill = true;
            // 
            // IndexFac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 166);
            this.Controls.Add(this.cboNganh);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IndexFac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm Kiếm";
            this.Load += new System.EventHandler(this.IndexFac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nGANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreManagementDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ComboBox cboNganh;
        private ScoreManagementDataSet1 scoreManagementDataSet1;
        private System.Windows.Forms.BindingSource nGANHBindingSource;
        private ScoreManagementDataSet1TableAdapters.NGANHTableAdapter nGANHTableAdapter;
    }
}