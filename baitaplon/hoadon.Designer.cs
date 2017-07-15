namespace baitaplon
{
    partial class dshoadon
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
            this.btnthemhoadon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnoigiao = new System.Windows.Forms.TextBox();
            this.btntimkiemhoadon = new System.Windows.Forms.Button();
            this.btnsuahoadon = new System.Windows.Forms.Button();
            this.btnxoahoadon = new System.Windows.Forms.Button();
            this.txtngaygiao = new System.Windows.Forms.TextBox();
            this.txtngaylap = new System.Windows.Forms.TextBox();
            this.cbnhanvien = new System.Windows.Forms.ComboBox();
            this.cbkhachhang = new System.Windows.Forms.ComboBox();
            this.hoadondsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hoadondsTableAdapter1 = new baitaplon.QLCHMTDataSet1TableAdapters.hoadondsTableAdapter();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.txtma = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.hoadondsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN HÓA ĐƠN";
            // 
            // btnthemhoadon
            // 
            this.btnthemhoadon.Location = new System.Drawing.Point(84, 289);
            this.btnthemhoadon.Name = "btnthemhoadon";
            this.btnthemhoadon.Size = new System.Drawing.Size(75, 23);
            this.btnthemhoadon.TabIndex = 1;
            this.btnthemhoadon.Text = "Thêm";
            this.btnthemhoadon.UseVisualStyleBackColor = true;
            this.btnthemhoadon.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nơi giao";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày giao";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày lập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mã khách hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mã hóa đơn";
            // 
            // txtnoigiao
            // 
            this.txtnoigiao.Location = new System.Drawing.Point(152, 235);
            this.txtnoigiao.Name = "txtnoigiao";
            this.txtnoigiao.Size = new System.Drawing.Size(121, 20);
            this.txtnoigiao.TabIndex = 13;
            // 
            // btntimkiemhoadon
            // 
            this.btntimkiemhoadon.Location = new System.Drawing.Point(84, 339);
            this.btntimkiemhoadon.Name = "btntimkiemhoadon";
            this.btntimkiemhoadon.Size = new System.Drawing.Size(75, 23);
            this.btntimkiemhoadon.TabIndex = 15;
            this.btntimkiemhoadon.Text = "Tìm kiếm";
            this.btntimkiemhoadon.UseVisualStyleBackColor = true;
            this.btntimkiemhoadon.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnsuahoadon
            // 
            this.btnsuahoadon.Location = new System.Drawing.Point(438, 289);
            this.btnsuahoadon.Name = "btnsuahoadon";
            this.btnsuahoadon.Size = new System.Drawing.Size(75, 23);
            this.btnsuahoadon.TabIndex = 16;
            this.btnsuahoadon.Text = "Sửa";
            this.btnsuahoadon.UseVisualStyleBackColor = true;
            this.btnsuahoadon.Click += new System.EventHandler(this.btnsuahoadon_Click);
            // 
            // btnxoahoadon
            // 
            this.btnxoahoadon.Location = new System.Drawing.Point(263, 289);
            this.btnxoahoadon.Name = "btnxoahoadon";
            this.btnxoahoadon.Size = new System.Drawing.Size(75, 23);
            this.btnxoahoadon.TabIndex = 17;
            this.btnxoahoadon.Text = "Xóa";
            this.btnxoahoadon.UseVisualStyleBackColor = true;
            this.btnxoahoadon.Click += new System.EventHandler(this.btnxoahoadon_Click);
            // 
            // txtngaygiao
            // 
            this.txtngaygiao.Location = new System.Drawing.Point(400, 175);
            this.txtngaygiao.Name = "txtngaygiao";
            this.txtngaygiao.Size = new System.Drawing.Size(150, 20);
            this.txtngaygiao.TabIndex = 19;
            // 
            // txtngaylap
            // 
            this.txtngaylap.Location = new System.Drawing.Point(400, 231);
            this.txtngaylap.Name = "txtngaylap";
            this.txtngaylap.Size = new System.Drawing.Size(150, 20);
            this.txtngaylap.TabIndex = 20;
            // 
            // cbnhanvien
            // 
            this.cbnhanvien.FormattingEnabled = true;
            this.cbnhanvien.Items.AddRange(new object[] {
            "nv001",
            "nv002",
            "nv003",
            "nv004",
            "nv005",
            "nv006"});
            this.cbnhanvien.Location = new System.Drawing.Point(152, 172);
            this.cbnhanvien.Name = "cbnhanvien";
            this.cbnhanvien.Size = new System.Drawing.Size(121, 21);
            this.cbnhanvien.TabIndex = 23;
            // 
            // cbkhachhang
            // 
            this.cbkhachhang.FormattingEnabled = true;
            this.cbkhachhang.Items.AddRange(new object[] {
            "kh001",
            "kh002",
            "kh003",
            "kh004",
            "kh005"});
            this.cbkhachhang.Location = new System.Drawing.Point(400, 118);
            this.cbkhachhang.Name = "cbkhachhang";
            this.cbkhachhang.Size = new System.Drawing.Size(150, 21);
            this.cbkhachhang.TabIndex = 24;
            // 
            // hoadondsTableAdapter1
            // 
            this.hoadondsTableAdapter1.ClearBeforeFill = true;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(47, 382);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(502, 137);
            this.dgvHoaDon.TabIndex = 25;
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(161, 116);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(100, 20);
            this.txtma.TabIndex = 26;
            // 
            // dshoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 530);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.cbkhachhang);
            this.Controls.Add(this.cbnhanvien);
            this.Controls.Add(this.txtngaylap);
            this.Controls.Add(this.txtngaygiao);
            this.Controls.Add(this.btnxoahoadon);
            this.Controls.Add(this.btnsuahoadon);
            this.Controls.Add(this.btntimkiemhoadon);
            this.Controls.Add(this.txtnoigiao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnthemhoadon);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "dshoadon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin hóa đơn";
            this.Load += new System.EventHandler(this.dshoadon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hoadondsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnthemhoadon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnoigiao;
        private System.Windows.Forms.Button btntimkiemhoadon;
        private System.Windows.Forms.Button btnsuahoadon;
        private System.Windows.Forms.Button btnxoahoadon;
        private System.Windows.Forms.TextBox txtngaygiao;
        private System.Windows.Forms.TextBox txtngaylap;
        private System.Windows.Forms.ComboBox cbnhanvien;
        private System.Windows.Forms.ComboBox cbkhachhang;
        private System.Windows.Forms.BindingSource hoadondsBindingSource1;
        private QLCHMTDataSet1TableAdapters.hoadondsTableAdapter hoadondsTableAdapter1;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.TextBox txtma;
    }
}