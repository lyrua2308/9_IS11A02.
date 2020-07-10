namespace hoa_don_nhap
{
    partial class FrmBaoCaoTop3
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.masanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tênbinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.combo_manv = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.bt_batdau = new System.Windows.Forms.Button();
			this.bt_thoat = new System.Windows.Forms.Button();
			this.bt_thongke = new System.Windows.Forms.Button();
			this.bt_inbaocao = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.soluong,
            this.tennv,
            this.masanpham,
            this.Tênbinh});
			this.dataGridView1.Location = new System.Drawing.Point(119, 251);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(821, 296);
			this.dataGridView1.TabIndex = 15;
			// 
			// MaNV
			// 
			this.MaNV.DataPropertyName = "manv";
			this.MaNV.HeaderText = "Mã nhân viên";
			this.MaNV.MinimumWidth = 6;
			this.MaNV.Name = "MaNV";
			this.MaNV.Width = 125;
			// 
			// soluong
			// 
			this.soluong.DataPropertyName = "soluong";
			this.soluong.HeaderText = "Số lượng";
			this.soluong.MinimumWidth = 6;
			this.soluong.Name = "soluong";
			this.soluong.Width = 125;
			// 
			// tennv
			// 
			this.tennv.DataPropertyName = "tennv";
			this.tennv.HeaderText = "Tên NV";
			this.tennv.MinimumWidth = 6;
			this.tennv.Name = "tennv";
			this.tennv.Width = 125;
			// 
			// masanpham
			// 
			this.masanpham.DataPropertyName = "mabinh";
			this.masanpham.HeaderText = "Mã bình";
			this.masanpham.MinimumWidth = 6;
			this.masanpham.Name = "masanpham";
			this.masanpham.Width = 125;
			// 
			// Tênbinh
			// 
			this.Tênbinh.DataPropertyName = "tenbinh";
			this.Tênbinh.HeaderText = "Tên bình";
			this.Tênbinh.MinimumWidth = 6;
			this.Tênbinh.Name = "Tênbinh";
			this.Tênbinh.Width = 125;
			// 
			// combo_manv
			// 
			this.combo_manv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.combo_manv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.combo_manv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.combo_manv.FormattingEnabled = true;
			this.combo_manv.Location = new System.Drawing.Point(330, 174);
			this.combo_manv.Name = "combo_manv";
			this.combo_manv.Size = new System.Drawing.Size(241, 33);
			this.combo_manv.TabIndex = 14;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.PaleTurquoise;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(128, 178);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(169, 29);
			this.label4.TabIndex = 13;
			this.label4.Text = "Mã Nhân Viên:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(130, 141);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(0, 17);
			this.label3.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Teal;
			this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(377, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(255, 33);
			this.label2.TabIndex = 11;
			this.label2.Text = "THEO NHÂN VIÊN";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Teal;
			this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(217, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(605, 33);
			this.label1.TabIndex = 10;
			this.label1.Text = "BÁO CÁO 3 SẢN PHẨM ĐƯỢC BÁN ÍT NHẤT";
			// 
			// bt_batdau
			// 
			this.bt_batdau.BackColor = System.Drawing.Color.White;
			this.bt_batdau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_batdau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.bt_batdau.Location = new System.Drawing.Point(40, 608);
			this.bt_batdau.Name = "bt_batdau";
			this.bt_batdau.Size = new System.Drawing.Size(193, 49);
			this.bt_batdau.TabIndex = 20;
			this.bt_batdau.Text = "Bắt đầu";
			this.bt_batdau.UseVisualStyleBackColor = false;
			this.bt_batdau.Click += new System.EventHandler(this.bt_batdau_Click_1);
			// 
			// bt_thoat
			// 
			this.bt_thoat.BackColor = System.Drawing.Color.White;
			this.bt_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_thoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.bt_thoat.Image = global::hoa_don_nhap.Properties.Resources.close__1_;
			this.bt_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bt_thoat.Location = new System.Drawing.Point(796, 604);
			this.bt_thoat.Name = "bt_thoat";
			this.bt_thoat.Size = new System.Drawing.Size(182, 50);
			this.bt_thoat.TabIndex = 19;
			this.bt_thoat.Text = "Thoát";
			this.bt_thoat.UseVisualStyleBackColor = false;
			this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
			// 
			// bt_thongke
			// 
			this.bt_thongke.BackColor = System.Drawing.Color.White;
			this.bt_thongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_thongke.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.bt_thongke.Image = global::hoa_don_nhap.Properties.Resources.preview;
			this.bt_thongke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bt_thongke.Location = new System.Drawing.Point(287, 608);
			this.bt_thongke.Name = "bt_thongke";
			this.bt_thongke.Size = new System.Drawing.Size(173, 48);
			this.bt_thongke.TabIndex = 18;
			this.bt_thongke.Text = "Thống Kê";
			this.bt_thongke.UseVisualStyleBackColor = false;
			this.bt_thongke.Click += new System.EventHandler(this.bt_thongke_Click);
			// 
			// bt_inbaocao
			// 
			this.bt_inbaocao.BackColor = System.Drawing.Color.White;
			this.bt_inbaocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_inbaocao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.bt_inbaocao.Image = global::hoa_don_nhap.Properties.Resources.center_alignment1;
			this.bt_inbaocao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bt_inbaocao.Location = new System.Drawing.Point(528, 602);
			this.bt_inbaocao.Name = "bt_inbaocao";
			this.bt_inbaocao.Size = new System.Drawing.Size(182, 52);
			this.bt_inbaocao.TabIndex = 17;
			this.bt_inbaocao.Text = "In báo cáo";
			this.bt_inbaocao.UseVisualStyleBackColor = false;
			this.bt_inbaocao.Click += new System.EventHandler(this.bt_inbaocao_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(6, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1255, 138);
			this.panel1.TabIndex = 21;
			// 
			// FrmBaoCaoTop3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleTurquoise;
			this.ClientSize = new System.Drawing.Size(1063, 687);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.bt_batdau);
			this.Controls.Add(this.bt_thoat);
			this.Controls.Add(this.bt_thongke);
			this.Controls.Add(this.bt_inbaocao);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.combo_manv);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Name = "FrmBaoCaoTop3";
			this.Text = "FrmBaoCaoTop3";
			this.Load += new System.EventHandler(this.FrmBaoCaoTop3_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_thongke;
        private System.Windows.Forms.Button bt_inbaocao;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox combo_manv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_batdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn masanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tênbinh;
        private System.Windows.Forms.Panel panel1;
    }
}