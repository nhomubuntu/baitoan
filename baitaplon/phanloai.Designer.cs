namespace baitaplon
{
    partial class phanloai
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
            this.btnthem = new System.Windows.Forms.Button();
            this.txtmaloai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttenloai = new System.Windows.Forms.TextBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.qLCHMTDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLCHMTDataSet = new baitaplon.QLCHMTDataSet();
            this.qLCHMTDataSet2 = new baitaplon.QLCHMTDataSet2();
            this.phanloaidsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phanloaidsTableAdapter = new baitaplon.QLCHMTDataSet2TableAdapters.phanloaidsTableAdapter();
            this.phan_loaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phan_loaiTableAdapter = new baitaplon.QLCHMTDataSetTableAdapters.phan_loaiTableAdapter();
            this.tableAdapterManager = new baitaplon.QLCHMTDataSetTableAdapters.TableAdapterManager();
            this.dgphanloai = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHMTDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHMTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHMTDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanloaidsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phan_loaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgphanloai)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN PHÂN LOẠI";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(33, 154);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtmaloai
            // 
            this.txtmaloai.Location = new System.Drawing.Point(113, 98);
            this.txtmaloai.Name = "txtmaloai";
            this.txtmaloai.Size = new System.Drawing.Size(100, 20);
            this.txtmaloai.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã loại";
            // 
            // txttenloai
            // 
            this.txttenloai.Location = new System.Drawing.Point(334, 98);
            this.txttenloai.Name = "txttenloai";
            this.txttenloai.Size = new System.Drawing.Size(100, 20);
            this.txttenloai.TabIndex = 6;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(161, 154);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 7;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(299, 154);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 8;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(415, 154);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 24);
            this.btntimkiem.TabIndex = 9;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // qLCHMTDataSetBindingSource
            // 
            this.qLCHMTDataSetBindingSource.DataSource = this.qLCHMTDataSet;
            this.qLCHMTDataSetBindingSource.Position = 0;
            // 
            // qLCHMTDataSet
            // 
            this.qLCHMTDataSet.DataSetName = "QLCHMTDataSet";
            this.qLCHMTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLCHMTDataSet2
            // 
            this.qLCHMTDataSet2.DataSetName = "QLCHMTDataSet2";
            this.qLCHMTDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phanloaidsBindingSource
            // 
            this.phanloaidsBindingSource.DataMember = "phanloaids";
            this.phanloaidsBindingSource.DataSource = this.qLCHMTDataSet2;
            // 
            // phanloaidsTableAdapter
            // 
            this.phanloaidsTableAdapter.ClearBeforeFill = true;
            // 
            // phan_loaiBindingSource
            // 
            this.phan_loaiBindingSource.DataMember = "phan loai";
            this.phan_loaiBindingSource.DataSource = this.qLCHMTDataSet;
            // 
            // phan_loaiTableAdapter
            // 
            this.phan_loaiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chi_tiet_hoa_donTableAdapter = null;
            this.tableAdapterManager.cung_capTableAdapter = null;
            this.tableAdapterManager.hoadondsTableAdapter = null;
            this.tableAdapterManager.khach_hangTableAdapter = null;
            this.tableAdapterManager.kho_hangTableAdapter = null;
            this.tableAdapterManager.mat_hangTableAdapter = null;
            this.tableAdapterManager.nha_cung_capTableAdapter = null;
            this.tableAdapterManager.nhan_vienTableAdapter = null;
            this.tableAdapterManager.phan_loaiTableAdapter = this.phan_loaiTableAdapter;
            this.tableAdapterManager.UpdateOrder = baitaplon.QLCHMTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgphanloai
            // 
            this.dgphanloai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgphanloai.Location = new System.Drawing.Point(33, 197);
            this.dgphanloai.Name = "dgphanloai";
            this.dgphanloai.Size = new System.Drawing.Size(457, 150);
            this.dgphanloai.TabIndex = 10;
            // 
            // phanloai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 359);
            this.Controls.Add(this.dgphanloai);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.txttenloai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmaloai);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "phanloai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin phân loại";
            this.Load += new System.EventHandler(this.phanloai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLCHMTDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHMTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHMTDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanloaidsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phan_loaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgphanloai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtmaloai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttenloai;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.BindingSource qLCHMTDataSetBindingSource;
        private QLCHMTDataSet qLCHMTDataSet;
        private QLCHMTDataSet2 qLCHMTDataSet2;
        private System.Windows.Forms.BindingSource phanloaidsBindingSource;
        private QLCHMTDataSet2TableAdapters.phanloaidsTableAdapter phanloaidsTableAdapter;
        private System.Windows.Forms.BindingSource phan_loaiBindingSource;
        private QLCHMTDataSetTableAdapters.phan_loaiTableAdapter phan_loaiTableAdapter;
        private QLCHMTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgphanloai;
    }
}