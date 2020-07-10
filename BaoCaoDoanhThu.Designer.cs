namespace hoa_don_nhap
{
    partial class BaoCaoDoanhThu
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
			this.labeldoanhthu = new System.Windows.Forms.Label();
			this.lb_doanhthu = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.bt_thoat = new System.Windows.Forms.Button();
			this.bt_thongke = new System.Windows.Forms.Button();
			this.bt_inbaocao = new System.Windows.Forms.Button();
			this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ngayban = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenbinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mabinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewdoanhthu = new System.Windows.Forms.DataGridView();
			this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.bt_batdau = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewdoanhthu)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// labeldoanhthu
			// 
			this.labeldoanhthu.AutoSize = true;
			this.labeldoanhthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.labeldoanhthu.Location = new System.Drawing.Point(653, 439);
			this.labeldoanhthu.Name = "labeldoanhthu";
			this.labeldoanhthu.Size = new System.Drawing.Size(0, 20);
			this.labeldoanhthu.TabIndex = 38;
			// 
			// lb_doanhthu
			// 
			this.lb_doanhthu.AutoSize = true;
			this.lb_doanhthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_doanhthu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lb_doanhthu.Location = new System.Drawing.Point(638, 429);
			this.lb_doanhthu.Name = "lb_doanhthu";
			this.lb_doanhthu.Size = new System.Drawing.Size(0, 29);
			this.lb_doanhthu.TabIndex = 36;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(465, 429);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(167, 29);
			this.label3.TabIndex = 35;
			this.label3.Text = "DOANH THU: ";
			// 
			// bt_thoat
			// 
			this.bt_thoat.BackColor = System.Drawing.Color.White;
			this.bt_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_thoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.bt_thoat.Image = global::hoa_don_nhap.Properties.Resources.close__1_;
			this.bt_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bt_thoat.Location = new System.Drawing.Point(649, 492);
			this.bt_thoat.Name = "bt_thoat";
			this.bt_thoat.Size = new System.Drawing.Size(172, 45);
			this.bt_thoat.TabIndex = 34;
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
			this.bt_thongke.Location = new System.Drawing.Point(219, 492);
			this.bt_thongke.Name = "bt_thongke";
			this.bt_thongke.Size = new System.Drawing.Size(163, 45);
			this.bt_thongke.TabIndex = 33;
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
			this.bt_inbaocao.Location = new System.Drawing.Point(414, 492);
			this.bt_inbaocao.Name = "bt_inbaocao";
			this.bt_inbaocao.Size = new System.Drawing.Size(172, 46);
			this.bt_inbaocao.TabIndex = 32;
			this.bt_inbaocao.Text = "In báo cáo";
			this.bt_inbaocao.UseVisualStyleBackColor = false;
			this.bt_inbaocao.Click += new System.EventHandler(this.bt_inbaocao_Click);
			// 
			// tongtien
			// 
			this.tongtien.DataPropertyName = "tong_tien";
			this.tongtien.HeaderText = "Tổng tiền";
			this.tongtien.MinimumWidth = 6;
			this.tongtien.Name = "tongtien";
			this.tongtien.Width = 125;
			// 
			// comboBox2
			// 
			this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(556, 133);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(160, 33);
			this.comboBox2.TabIndex = 37;
			// 
			// dongia
			// 
			this.dongia.DataPropertyName = "dongiaban";
			this.dongia.HeaderText = "Đơn giá";
			this.dongia.MinimumWidth = 6;
			this.dongia.Name = "dongia";
			this.dongia.Width = 125;
			// 
			// ngayban
			// 
			this.ngayban.DataPropertyName = "ngayban";
			this.ngayban.HeaderText = "Ngày bán";
			this.ngayban.MinimumWidth = 6;
			this.ngayban.Name = "ngayban";
			this.ngayban.Width = 125;
			// 
			// tenbinh
			// 
			this.tenbinh.DataPropertyName = "tenbinh";
			this.tenbinh.HeaderText = "Tên Bình";
			this.tenbinh.MinimumWidth = 6;
			this.tenbinh.Name = "tenbinh";
			this.tenbinh.Width = 125;
			// 
			// mabinh
			// 
			this.mabinh.DataPropertyName = "mabinh";
			this.mabinh.HeaderText = "Mã bình";
			this.mabinh.MinimumWidth = 6;
			this.mabinh.Name = "mabinh";
			this.mabinh.Width = 125;
			// 
			// dataGridViewdoanhthu
			// 
			this.dataGridViewdoanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewdoanhthu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mabinh,
            this.tenbinh,
            this.ngayban,
            this.soluong,
            this.dongia,
            this.tongtien});
			this.dataGridViewdoanhthu.Location = new System.Drawing.Point(69, 192);
			this.dataGridViewdoanhthu.Name = "dataGridViewdoanhthu";
			this.dataGridViewdoanhthu.RowHeadersWidth = 51;
			this.dataGridViewdoanhthu.RowTemplate.Height = 24;
			this.dataGridViewdoanhthu.Size = new System.Drawing.Size(668, 224);
			this.dataGridViewdoanhthu.TabIndex = 30;
			// 
			// soluong
			// 
			this.soluong.DataPropertyName = "so_luong";
			this.soluong.HeaderText = "Số lượng";
			this.soluong.MinimumWidth = 6;
			this.soluong.Name = "soluong";
			this.soluong.Width = 125;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(485, 133);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(65, 26);
			this.label5.TabIndex = 29;
			this.label5.Text = "Năm:";
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(237, 133);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(153, 33);
			this.comboBox1.TabIndex = 28;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.PaleTurquoise;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(54, 131);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(186, 29);
			this.label2.TabIndex = 27;
			this.label2.Text = "Tháng báo cáo: ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(273, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(273, 29);
			this.label1.TabIndex = 26;
			this.label1.Text = "BÁO CÁO DOANH THU";
			// 
			// bt_batdau
			// 
			this.bt_batdau.BackColor = System.Drawing.Color.White;
			this.bt_batdau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_batdau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.bt_batdau.Location = new System.Drawing.Point(12, 491);
			this.bt_batdau.Name = "bt_batdau";
			this.bt_batdau.Size = new System.Drawing.Size(163, 46);
			this.bt_batdau.TabIndex = 39;
			this.bt_batdau.Text = "Bắt đầu";
			this.bt_batdau.UseVisualStyleBackColor = false;
			this.bt_batdau.Click += new System.EventHandler(this.bt_batdau_Click_1);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(4, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(858, 70);
			this.panel1.TabIndex = 40;
			// 
			// BaoCaoDoanhThu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleTurquoise;
			this.ClientSize = new System.Drawing.Size(863, 568);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.bt_batdau);
			this.Controls.Add(this.labeldoanhthu);
			this.Controls.Add(this.lb_doanhthu);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.bt_thoat);
			this.Controls.Add(this.bt_thongke);
			this.Controls.Add(this.bt_inbaocao);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.dataGridViewdoanhthu);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label2);
			this.Name = "BaoCaoDoanhThu";
			this.Text = "BaoCaoDoanhThu";
			this.Load += new System.EventHandler(this.BaoCaoDoanhThu_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewdoanhthu)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeldoanhthu;
        private System.Windows.Forms.Label lb_doanhthu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_thongke;
        private System.Windows.Forms.Button bt_inbaocao;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayban;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenbinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn mabinh;
        private System.Windows.Forms.DataGridView dataGridViewdoanhthu;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_batdau;
        private System.Windows.Forms.Panel panel1;
    }
}