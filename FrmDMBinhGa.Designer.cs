namespace hoa_don_nhap
{
    partial class FrmDMBinhGa
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
			this.Ảnh = new System.Windows.Forms.Button();
			this.txtMaBinh = new System.Windows.Forms.TextBox();
			this.txtGhichu = new System.Windows.Forms.TextBox();
			this.txtAnh = new System.Windows.Forms.TextBox();
			this.txtTGBH = new System.Windows.Forms.TextBox();
			this.GridViewBinhGas = new System.Windows.Forms.DataGridView();
			this.Mabinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tennuocsx = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenmau = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tenbinh = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Maloai = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Mamau = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Makhoiluong = new System.Windows.Forms.DataGridViewButtonColumn();
			this.ManuocSX = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Soluong = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Dongianhap = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Dongiaban = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Thoigianbaohanh = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Anh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ghichu = new System.Windows.Forms.DataGridViewButtonColumn();
			this.txtDonGiaBan = new System.Windows.Forms.TextBox();
			this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
			this.txtSoLuong = new System.Windows.Forms.TextBox();
			this.txtTenBinh = new System.Windows.Forms.TextBox();
			this.cmbNuocSX = new System.Windows.Forms.ComboBox();
			this.cmbMau = new System.Windows.Forms.ComboBox();
			this.cmbKhoiLuong = new System.Windows.Forms.ComboBox();
			this.cmbLoaiGas = new System.Windows.Forms.ComboBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnHienThi = new System.Windows.Forms.Button();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.picAnh = new System.Windows.Forms.PictureBox();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label14 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.GridViewBinhGas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Ảnh
			// 
			this.Ảnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.Ảnh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.Ảnh.Location = new System.Drawing.Point(602, 403);
			this.Ảnh.Name = "Ảnh";
			this.Ảnh.Size = new System.Drawing.Size(82, 30);
			this.Ảnh.TabIndex = 72;
			this.Ảnh.Text = "Open";
			this.Ảnh.UseVisualStyleBackColor = false;
			this.Ảnh.Click += new System.EventHandler(this.Ảnh_Click);
			// 
			// txtMaBinh
			// 
			this.txtMaBinh.Location = new System.Drawing.Point(195, 126);
			this.txtMaBinh.Name = "txtMaBinh";
			this.txtMaBinh.Size = new System.Drawing.Size(121, 22);
			this.txtMaBinh.TabIndex = 71;
			// 
			// txtGhichu
			// 
			this.txtGhichu.Location = new System.Drawing.Point(602, 308);
			this.txtGhichu.Name = "txtGhichu";
			this.txtGhichu.Size = new System.Drawing.Size(129, 22);
			this.txtGhichu.TabIndex = 69;
			// 
			// txtAnh
			// 
			this.txtAnh.Location = new System.Drawing.Point(602, 350);
			this.txtAnh.Name = "txtAnh";
			this.txtAnh.Size = new System.Drawing.Size(129, 22);
			this.txtAnh.TabIndex = 68;
			// 
			// txtTGBH
			// 
			this.txtTGBH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.txtTGBH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txtTGBH.Location = new System.Drawing.Point(602, 259);
			this.txtTGBH.Name = "txtTGBH";
			this.txtTGBH.Size = new System.Drawing.Size(129, 22);
			this.txtTGBH.TabIndex = 74;
			// 
			// GridViewBinhGas
			// 
			this.GridViewBinhGas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GridViewBinhGas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mabinh,
            this.tenloai,
            this.tennuocsx,
            this.tenmau,
            this.Tenbinh,
            this.Maloai,
            this.Mamau,
            this.Makhoiluong,
            this.ManuocSX,
            this.Soluong,
            this.Dongianhap,
            this.Dongiaban,
            this.Thoigianbaohanh,
            this.Anh,
            this.Ghichu});
			this.GridViewBinhGas.Location = new System.Drawing.Point(0, 476);
			this.GridViewBinhGas.Name = "GridViewBinhGas";
			this.GridViewBinhGas.RowHeadersWidth = 51;
			this.GridViewBinhGas.RowTemplate.Height = 24;
			this.GridViewBinhGas.Size = new System.Drawing.Size(1323, 186);
			this.GridViewBinhGas.TabIndex = 62;
			this.GridViewBinhGas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewBinhGas_CellClick_1);
			// 
			// Mabinh
			// 
			this.Mabinh.DataPropertyName = "Mabinh";
			this.Mabinh.HeaderText = "Mã Bình";
			this.Mabinh.MinimumWidth = 6;
			this.Mabinh.Name = "Mabinh";
			this.Mabinh.Width = 125;
			// 
			// tenloai
			// 
			this.tenloai.DataPropertyName = "tenloai";
			this.tenloai.HeaderText = "Tên loai";
			this.tenloai.MinimumWidth = 6;
			this.tenloai.Name = "tenloai";
			this.tenloai.Visible = false;
			this.tenloai.Width = 125;
			// 
			// tennuocsx
			// 
			this.tennuocsx.DataPropertyName = "tennuocsx";
			this.tennuocsx.HeaderText = "Tên nước";
			this.tennuocsx.MinimumWidth = 6;
			this.tennuocsx.Name = "tennuocsx";
			this.tennuocsx.Visible = false;
			this.tennuocsx.Width = 125;
			// 
			// tenmau
			// 
			this.tenmau.DataPropertyName = "tenmau";
			this.tenmau.HeaderText = "Tên màu";
			this.tenmau.MinimumWidth = 6;
			this.tenmau.Name = "tenmau";
			this.tenmau.Visible = false;
			this.tenmau.Width = 125;
			// 
			// Tenbinh
			// 
			this.Tenbinh.DataPropertyName = "Tenbinh";
			this.Tenbinh.HeaderText = "Tên Bình";
			this.Tenbinh.MinimumWidth = 6;
			this.Tenbinh.Name = "Tenbinh";
			this.Tenbinh.Width = 125;
			// 
			// Maloai
			// 
			this.Maloai.DataPropertyName = "Maloai";
			this.Maloai.HeaderText = "Mã Loại";
			this.Maloai.MinimumWidth = 6;
			this.Maloai.Name = "Maloai";
			this.Maloai.Width = 125;
			// 
			// Mamau
			// 
			this.Mamau.DataPropertyName = "Mamau";
			this.Mamau.HeaderText = "Mã Màu";
			this.Mamau.MinimumWidth = 6;
			this.Mamau.Name = "Mamau";
			this.Mamau.Width = 125;
			// 
			// Makhoiluong
			// 
			this.Makhoiluong.DataPropertyName = "Makhoiluong";
			this.Makhoiluong.HeaderText = "Mã Khối Lượng";
			this.Makhoiluong.MinimumWidth = 6;
			this.Makhoiluong.Name = "Makhoiluong";
			this.Makhoiluong.Width = 125;
			// 
			// ManuocSX
			// 
			this.ManuocSX.DataPropertyName = "ManuocSX";
			this.ManuocSX.HeaderText = "Mã Nước SX";
			this.ManuocSX.MinimumWidth = 6;
			this.ManuocSX.Name = "ManuocSX";
			this.ManuocSX.Width = 125;
			// 
			// Soluong
			// 
			this.Soluong.DataPropertyName = "Soluong";
			this.Soluong.HeaderText = "Số Lượng";
			this.Soluong.MinimumWidth = 6;
			this.Soluong.Name = "Soluong";
			this.Soluong.Width = 125;
			// 
			// Dongianhap
			// 
			this.Dongianhap.DataPropertyName = "Dongianhap";
			this.Dongianhap.HeaderText = "Đơn Giá Nhập ";
			this.Dongianhap.MinimumWidth = 6;
			this.Dongianhap.Name = "Dongianhap";
			this.Dongianhap.Width = 125;
			// 
			// Dongiaban
			// 
			this.Dongiaban.DataPropertyName = "Dongiaban";
			this.Dongiaban.HeaderText = "Đơn Giá Bán";
			this.Dongiaban.MinimumWidth = 6;
			this.Dongiaban.Name = "Dongiaban";
			this.Dongiaban.Width = 125;
			// 
			// Thoigianbaohanh
			// 
			this.Thoigianbaohanh.DataPropertyName = "Thoigianbaohanh";
			this.Thoigianbaohanh.HeaderText = "Thời Gian Bảo Hành";
			this.Thoigianbaohanh.MinimumWidth = 6;
			this.Thoigianbaohanh.Name = "Thoigianbaohanh";
			this.Thoigianbaohanh.Width = 125;
			// 
			// Anh
			// 
			this.Anh.DataPropertyName = "Anh";
			this.Anh.HeaderText = "Ảnh";
			this.Anh.MinimumWidth = 6;
			this.Anh.Name = "Anh";
			this.Anh.Width = 125;
			// 
			// Ghichu
			// 
			this.Ghichu.DataPropertyName = "Ghichu";
			this.Ghichu.HeaderText = "Ghi Chú";
			this.Ghichu.MinimumWidth = 6;
			this.Ghichu.Name = "Ghichu";
			this.Ghichu.Width = 125;
			// 
			// txtDonGiaBan
			// 
			this.txtDonGiaBan.Location = new System.Drawing.Point(602, 220);
			this.txtDonGiaBan.Name = "txtDonGiaBan";
			this.txtDonGiaBan.Size = new System.Drawing.Size(129, 22);
			this.txtDonGiaBan.TabIndex = 61;
			// 
			// txtDonGiaNhap
			// 
			this.txtDonGiaNhap.Location = new System.Drawing.Point(602, 178);
			this.txtDonGiaNhap.Name = "txtDonGiaNhap";
			this.txtDonGiaNhap.Size = new System.Drawing.Size(129, 22);
			this.txtDonGiaNhap.TabIndex = 60;
			this.txtDonGiaNhap.TextChanged += new System.EventHandler(this.txtDonGiaNhap_TextChanged_1);
			// 
			// txtSoLuong
			// 
			this.txtSoLuong.Location = new System.Drawing.Point(602, 126);
			this.txtSoLuong.Name = "txtSoLuong";
			this.txtSoLuong.Size = new System.Drawing.Size(129, 22);
			this.txtSoLuong.TabIndex = 59;
			// 
			// txtTenBinh
			// 
			this.txtTenBinh.Location = new System.Drawing.Point(195, 178);
			this.txtTenBinh.Name = "txtTenBinh";
			this.txtTenBinh.Size = new System.Drawing.Size(121, 22);
			this.txtTenBinh.TabIndex = 58;
			// 
			// cmbNuocSX
			// 
			this.cmbNuocSX.FormattingEnabled = true;
			this.cmbNuocSX.Location = new System.Drawing.Point(195, 348);
			this.cmbNuocSX.Name = "cmbNuocSX";
			this.cmbNuocSX.Size = new System.Drawing.Size(121, 24);
			this.cmbNuocSX.Sorted = true;
			this.cmbNuocSX.TabIndex = 57;
			// 
			// cmbMau
			// 
			this.cmbMau.FormattingEnabled = true;
			this.cmbMau.Location = new System.Drawing.Point(195, 259);
			this.cmbMau.Name = "cmbMau";
			this.cmbMau.Size = new System.Drawing.Size(121, 24);
			this.cmbMau.Sorted = true;
			this.cmbMau.TabIndex = 56;
			this.cmbMau.SelectedIndexChanged += new System.EventHandler(this.cmbMau_SelectedIndexChanged);
			// 
			// cmbKhoiLuong
			// 
			this.cmbKhoiLuong.FormattingEnabled = true;
			this.cmbKhoiLuong.Location = new System.Drawing.Point(195, 301);
			this.cmbKhoiLuong.Name = "cmbKhoiLuong";
			this.cmbKhoiLuong.Size = new System.Drawing.Size(121, 24);
			this.cmbKhoiLuong.Sorted = true;
			this.cmbKhoiLuong.TabIndex = 55;
			// 
			// cmbLoaiGas
			// 
			this.cmbLoaiGas.FormattingEnabled = true;
			this.cmbLoaiGas.Location = new System.Drawing.Point(195, 220);
			this.cmbLoaiGas.Name = "cmbLoaiGas";
			this.cmbLoaiGas.Size = new System.Drawing.Size(121, 24);
			this.cmbLoaiGas.Sorted = true;
			this.cmbLoaiGas.TabIndex = 54;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.Black;
			this.label13.Location = new System.Drawing.Point(431, 301);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(70, 20);
			this.label13.TabIndex = 53;
			this.label13.Text = "Ghi Chú";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Black;
			this.label12.Location = new System.Drawing.Point(431, 354);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(38, 20);
			this.label12.TabIndex = 52;
			this.label12.Text = "Ảnh";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Black;
			this.label11.Location = new System.Drawing.Point(431, 263);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(161, 20);
			this.label11.TabIndex = 51;
			this.label11.Text = "Thời Gian Bảo Hành";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(427, 222);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(110, 20);
			this.label10.TabIndex = 50;
			this.label10.Text = "Đơn Giá Bán ";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Black;
			this.label9.Location = new System.Drawing.Point(431, 178);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(114, 20);
			this.label9.TabIndex = 49;
			this.label9.Text = "Đơn Giá Nhập";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(436, 123);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 20);
			this.label8.TabIndex = 48;
			this.label8.Text = "Số Lượng";
			this.label8.Click += new System.EventHandler(this.label8_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(99, 354);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(75, 20);
			this.label7.TabIndex = 47;
			this.label7.Text = "Nước SX";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(97, 308);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(93, 20);
			this.label6.TabIndex = 46;
			this.label6.Text = "Khối Lượng";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(97, 268);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 20);
			this.label5.TabIndex = 45;
			this.label5.Text = "Màu ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(97, 227);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 20);
			this.label3.TabIndex = 44;
			this.label3.Text = "Loại Gas";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(97, 180);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 20);
			this.label2.TabIndex = 43;
			this.label2.Text = "Tên Bình";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(97, 129);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 20);
			this.label4.TabIndex = 42;
			this.label4.Text = "Mã Bình";
			// 
			// btnHienThi
			// 
			this.btnHienThi.BackColor = System.Drawing.SystemColors.Window;
			this.btnHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHienThi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnHienThi.Image = global::hoa_don_nhap.Properties.Resources.television;
			this.btnHienThi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnHienThi.Location = new System.Drawing.Point(1035, 696);
			this.btnHienThi.Name = "btnHienThi";
			this.btnHienThi.Size = new System.Drawing.Size(129, 41);
			this.btnHienThi.TabIndex = 75;
			this.btnHienThi.Text = "Hiển Thị";
			this.btnHienThi.UseVisualStyleBackColor = false;
			this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.BackColor = System.Drawing.SystemColors.Window;
			this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnTimKiem.Image = global::hoa_don_nhap.Properties.Resources.preview;
			this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTimKiem.Location = new System.Drawing.Point(847, 696);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(140, 41);
			this.btnTimKiem.TabIndex = 73;
			this.btnTimKiem.Text = "Tìm Kiếm";
			this.btnTimKiem.UseVisualStyleBackColor = false;
			this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
			// 
			// picAnh
			// 
			this.picAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.picAnh.InitialImage = null;
			this.picAnh.Location = new System.Drawing.Point(755, 78);
			this.picAnh.Name = "picAnh";
			this.picAnh.Size = new System.Drawing.Size(478, 355);
			this.picAnh.TabIndex = 70;
			this.picAnh.TabStop = false;
			// 
			// btnThoat
			// 
			this.btnThoat.BackColor = System.Drawing.SystemColors.Window;
			this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnThoat.Image = global::hoa_don_nhap.Properties.Resources.close__1_;
			this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThoat.Location = new System.Drawing.Point(1247, 696);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(125, 41);
			this.btnThoat.TabIndex = 67;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = false;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
			// 
			// btnLuu
			// 
			this.btnLuu.BackColor = System.Drawing.SystemColors.Window;
			this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnLuu.Image = global::hoa_don_nhap.Properties.Resources.save;
			this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLuu.Location = new System.Drawing.Point(632, 696);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(114, 41);
			this.btnLuu.TabIndex = 66;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = false;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
			// 
			// btnSua
			// 
			this.btnSua.BackColor = System.Drawing.SystemColors.Window;
			this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnSua.Image = global::hoa_don_nhap.Properties.Resources.refresh__1_;
			this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSua.Location = new System.Drawing.Point(431, 696);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(114, 41);
			this.btnSua.TabIndex = 65;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = false;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.SystemColors.Window;
			this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnXoa.Image = global::hoa_don_nhap.Properties.Resources.delete__1_;
			this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnXoa.Location = new System.Drawing.Point(225, 696);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(117, 41);
			this.btnXoa.TabIndex = 64;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = false;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.SystemColors.Window;
			this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnThem.Image = global::hoa_don_nhap.Properties.Resources.writing;
			this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThem.Location = new System.Drawing.Point(30, 696);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(123, 41);
			this.btnThem.TabIndex = 63;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.Controls.Add(this.label14);
			this.panel1.Location = new System.Drawing.Point(0, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1541, 64);
			this.panel1.TabIndex = 76;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.White;
			this.label14.Location = new System.Drawing.Point(470, 19);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(423, 33);
			this.label14.TabIndex = 0;
			this.label14.Text = "QUẢN LÝ DANH MỤC BÌNH GA";
			// 
			// FrmDMBinhGa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleTurquoise;
			this.ClientSize = new System.Drawing.Size(1382, 763);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnHienThi);
			this.Controls.Add(this.btnTimKiem);
			this.Controls.Add(this.Ảnh);
			this.Controls.Add(this.txtMaBinh);
			this.Controls.Add(this.picAnh);
			this.Controls.Add(this.txtGhichu);
			this.Controls.Add(this.txtAnh);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnLuu);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.txtTGBH);
			this.Controls.Add(this.GridViewBinhGas);
			this.Controls.Add(this.txtDonGiaBan);
			this.Controls.Add(this.txtDonGiaNhap);
			this.Controls.Add(this.txtSoLuong);
			this.Controls.Add(this.txtTenBinh);
			this.Controls.Add(this.cmbNuocSX);
			this.Controls.Add(this.cmbMau);
			this.Controls.Add(this.cmbKhoiLuong);
			this.Controls.Add(this.cmbLoaiGas);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label4);
			this.Name = "FrmDMBinhGa";
			this.Text = "FrmDMBinhGa";
			this.Load += new System.EventHandler(this.FrmDMBinhGa_Load);
			((System.ComponentModel.ISupportInitialize)(this.GridViewBinhGas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button Ảnh;
        private System.Windows.Forms.TextBox txtMaBinh;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTGBH;
        private System.Windows.Forms.DataGridView GridViewBinhGas;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.TextBox txtDonGiaNhap;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenBinh;
        private System.Windows.Forms.ComboBox cmbNuocSX;
        private System.Windows.Forms.ComboBox cmbMau;
        private System.Windows.Forms.ComboBox cmbKhoiLuong;
        private System.Windows.Forms.ComboBox cmbLoaiGas;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mabinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennuocsx;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmau;
        private System.Windows.Forms.DataGridViewButtonColumn Tenbinh;
        private System.Windows.Forms.DataGridViewButtonColumn Maloai;
        private System.Windows.Forms.DataGridViewButtonColumn Mamau;
        private System.Windows.Forms.DataGridViewButtonColumn Makhoiluong;
        private System.Windows.Forms.DataGridViewButtonColumn ManuocSX;
        private System.Windows.Forms.DataGridViewButtonColumn Soluong;
        private System.Windows.Forms.DataGridViewButtonColumn Dongianhap;
        private System.Windows.Forms.DataGridViewButtonColumn Dongiaban;
        private System.Windows.Forms.DataGridViewButtonColumn Thoigianbaohanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anh;
        private System.Windows.Forms.DataGridViewButtonColumn Ghichu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
    }
}