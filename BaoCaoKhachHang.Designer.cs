namespace hoa_don_nhap
{
    partial class BaoCaoKhachHang
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
			this.labeltongtien = new System.Windows.Forms.Label();
			this.bt_batdau = new System.Windows.Forms.Button();
			this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.giamgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenbinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mabinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ngayban = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenk = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mak = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.bt_thoat = new System.Windows.Forms.Button();
			this.bt_thongke = new System.Windows.Forms.Button();
			this.bt_inbaocao = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// labeltongtien
			// 
			this.labeltongtien.AutoSize = true;
			this.labeltongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.labeltongtien.Location = new System.Drawing.Point(768, 469);
			this.labeltongtien.Name = "labeltongtien";
			this.labeltongtien.Size = new System.Drawing.Size(0, 20);
			this.labeltongtien.TabIndex = 38;
			// 
			// bt_batdau
			// 
			this.bt_batdau.BackColor = System.Drawing.Color.White;
			this.bt_batdau.Cursor = System.Windows.Forms.Cursors.No;
			this.bt_batdau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_batdau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.bt_batdau.Location = new System.Drawing.Point(31, 469);
			this.bt_batdau.Name = "bt_batdau";
			this.bt_batdau.Size = new System.Drawing.Size(170, 54);
			this.bt_batdau.TabIndex = 32;
			this.bt_batdau.Text = "Bắt đầu";
			this.bt_batdau.UseVisualStyleBackColor = false;
			this.bt_batdau.Click += new System.EventHandler(this.bt_batdau_Click);
			// 
			// thanhtien
			// 
			this.thanhtien.DataPropertyName = "thanhtien";
			this.thanhtien.HeaderText = "Thành tiền";
			this.thanhtien.MinimumWidth = 6;
			this.thanhtien.Name = "thanhtien";
			this.thanhtien.Width = 125;
			// 
			// giamgia
			// 
			this.giamgia.DataPropertyName = "giamgia";
			this.giamgia.HeaderText = "Giảm giá";
			this.giamgia.MinimumWidth = 6;
			this.giamgia.Name = "giamgia";
			this.giamgia.Width = 125;
			// 
			// dongia
			// 
			this.dongia.DataPropertyName = "dongiaban";
			this.dongia.HeaderText = "Đơn Giá";
			this.dongia.MinimumWidth = 6;
			this.dongia.Name = "dongia";
			this.dongia.Width = 125;
			// 
			// soluong
			// 
			this.soluong.DataPropertyName = "so_luong";
			this.soluong.HeaderText = "Số lượng";
			this.soluong.MinimumWidth = 6;
			this.soluong.Name = "soluong";
			this.soluong.Width = 125;
			// 
			// tenbinh
			// 
			this.tenbinh.DataPropertyName = "tenbinh";
			this.tenbinh.HeaderText = "Tên bình";
			this.tenbinh.MinimumWidth = 6;
			this.tenbinh.Name = "tenbinh";
			this.tenbinh.Width = 125;
			// 
			// mabinh
			// 
			this.mabinh.DataPropertyName = "mabinh";
			this.mabinh.HeaderText = "mã bình";
			this.mabinh.MinimumWidth = 6;
			this.mabinh.Name = "mabinh";
			this.mabinh.Width = 125;
			// 
			// ngayban
			// 
			this.ngayban.DataPropertyName = "ngayban";
			this.ngayban.HeaderText = "Ngày bán";
			this.ngayban.MinimumWidth = 6;
			this.ngayban.Name = "ngayban";
			this.ngayban.Width = 125;
			// 
			// dienthoai
			// 
			this.dienthoai.DataPropertyName = "dienthoai";
			this.dienthoai.HeaderText = "Điện thoại";
			this.dienthoai.MinimumWidth = 6;
			this.dienthoai.Name = "dienthoai";
			this.dienthoai.Width = 125;
			// 
			// diachi
			// 
			this.diachi.DataPropertyName = "diachi";
			this.diachi.HeaderText = "Địa chỉ";
			this.diachi.MinimumWidth = 6;
			this.diachi.Name = "diachi";
			this.diachi.Width = 125;
			// 
			// tenk
			// 
			this.tenk.DataPropertyName = "tenkhach";
			this.tenk.HeaderText = "tên khách hàng";
			this.tenk.MinimumWidth = 6;
			this.tenk.Name = "tenk";
			this.tenk.Width = 125;
			// 
			// mak
			// 
			this.mak.DataPropertyName = "makhach";
			this.mak.HeaderText = "Mã khách hàng";
			this.mak.MinimumWidth = 6;
			this.mak.Name = "mak";
			this.mak.Width = 125;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mak,
            this.tenk,
            this.diachi,
            this.dienthoai,
            this.ngayban,
            this.mabinh,
            this.tenbinh,
            this.soluong,
            this.dongia,
            this.giamgia,
            this.thanhtien});
			this.dataGridView1.Location = new System.Drawing.Point(84, 166);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(729, 275);
			this.dataGridView1.TabIndex = 31;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(647, 122);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 24);
			this.comboBox2.TabIndex = 37;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(525, 117);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(65, 26);
			this.label5.TabIndex = 30;
			this.label5.Text = "Năm:";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(207, 119);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 24);
			this.comboBox1.TabIndex = 29;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(34, 114);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(167, 26);
			this.label2.TabIndex = 28;
			this.label2.Text = "Tháng báo cáo: ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(274, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(570, 29);
			this.label1.TabIndex = 27;
			this.label1.Text = "DANH SÁCH KHÁCH MUA HÀNG TRONG THÁNG";
			// 
			// bt_thoat
			// 
			this.bt_thoat.BackColor = System.Drawing.Color.White;
			this.bt_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_thoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.bt_thoat.Image = global::hoa_don_nhap.Properties.Resources.close__1_;
			this.bt_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bt_thoat.Location = new System.Drawing.Point(845, 465);
			this.bt_thoat.Name = "bt_thoat";
			this.bt_thoat.Size = new System.Drawing.Size(184, 45);
			this.bt_thoat.TabIndex = 35;
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
			this.bt_thongke.Location = new System.Drawing.Point(291, 469);
			this.bt_thongke.Name = "bt_thongke";
			this.bt_thongke.Size = new System.Drawing.Size(170, 46);
			this.bt_thongke.TabIndex = 34;
			this.bt_thongke.Text = "Thống Kê";
			this.bt_thongke.UseVisualStyleBackColor = false;
			this.bt_thongke.Click += new System.EventHandler(this.bt_thongke_Click);
			// 
			// bt_inbaocao
			// 
			this.bt_inbaocao.BackColor = System.Drawing.Color.White;
			this.bt_inbaocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_inbaocao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.bt_inbaocao.Image = global::hoa_don_nhap.Properties.Resources.center_alignment;
			this.bt_inbaocao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bt_inbaocao.Location = new System.Drawing.Point(565, 465);
			this.bt_inbaocao.Name = "bt_inbaocao";
			this.bt_inbaocao.Size = new System.Drawing.Size(184, 54);
			this.bt_inbaocao.TabIndex = 33;
			this.bt_inbaocao.Text = "In báo cáo";
			this.bt_inbaocao.UseVisualStyleBackColor = false;
			this.bt_inbaocao.Click += new System.EventHandler(this.bt_inbaocao_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(1, -2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1172, 75);
			this.panel1.TabIndex = 39;
			// 
			// BaoCaoKhachHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleTurquoise;
			this.ClientSize = new System.Drawing.Size(1087, 547);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.labeltongtien);
			this.Controls.Add(this.bt_thoat);
			this.Controls.Add(this.bt_thongke);
			this.Controls.Add(this.bt_inbaocao);
			this.Controls.Add(this.bt_batdau);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label2);
			this.Name = "BaoCaoKhachHang";
			this.Text = "BaoCaoKhachHang";
			this.Load += new System.EventHandler(this.BaoCaoKhachHang_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeltongtien;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_thongke;
        private System.Windows.Forms.Button bt_inbaocao;
        private System.Windows.Forms.Button bt_batdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenbinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn mabinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayban;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenk;
        private System.Windows.Forms.DataGridViewTextBoxColumn mak;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}