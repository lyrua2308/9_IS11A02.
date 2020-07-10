namespace hoa_don_nhap
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grbThongtinchung = new System.Windows.Forms.GroupBox();
            this.mskDienthoai = new System.Windows.Forms.MaskedTextBox();
            this.cboMaNCC = new System.Windows.Forms.ComboBox();
            this.cboManhanvien = new System.Windows.Forms.ComboBox();
            this.txtTennhanvien = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtNgaynhap = new System.Windows.Forms.TextBox();
            this.txtSoHDN = new System.Windows.Forms.TextBox();
            this.lblDienthoai = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblTenNCC = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.lblNgaynhap = new System.Windows.Forms.Label();
            this.lblSoHD = new System.Windows.Forms.Label();
            this.grbThongtinmathang = new System.Windows.Forms.GroupBox();
            this.DataGridView_hdn = new System.Windows.Forms.DataGridView();
            this.sohdn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mabinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenbinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mancc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giamgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.lblBangchu = new System.Windows.Forms.Label();
            this.lblTongtien = new System.Windows.Forms.Label();
            this.cboMabinh = new System.Windows.Forms.ComboBox();
            this.txtThanhtien = new System.Windows.Forms.TextBox();
            this.txtGiamgia = new System.Windows.Forms.TextBox();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.txtTenbinh = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.lblThanhtien = new System.Windows.Forms.Label();
            this.lblGiamgia = new System.Windows.Forms.Label();
            this.lblSoluong = new System.Windows.Forms.Label();
            this.lblDongia = new System.Windows.Forms.Label();
            this.lblTenbinh = new System.Windows.Forms.Label();
            this.lblMabinh = new System.Windows.Forms.Label();
            this.bt_timkiem = new System.Windows.Forms.Button();
            this.lblNoidung12 = new System.Windows.Forms.Label();
            this.btnHienthi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnInhoadon = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThemmoi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbThongtinchung.SuspendLayout();
            this.grbThongtinmathang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_hdn)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbThongtinchung
            // 
            this.grbThongtinchung.Controls.Add(this.mskDienthoai);
            this.grbThongtinchung.Controls.Add(this.cboMaNCC);
            this.grbThongtinchung.Controls.Add(this.cboManhanvien);
            this.grbThongtinchung.Controls.Add(this.txtTennhanvien);
            this.grbThongtinchung.Controls.Add(this.txtDiachi);
            this.grbThongtinchung.Controls.Add(this.txtTenNCC);
            this.grbThongtinchung.Controls.Add(this.txtNgaynhap);
            this.grbThongtinchung.Controls.Add(this.txtSoHDN);
            this.grbThongtinchung.Controls.Add(this.lblDienthoai);
            this.grbThongtinchung.Controls.Add(this.lblTenNV);
            this.grbThongtinchung.Controls.Add(this.lblDiachi);
            this.grbThongtinchung.Controls.Add(this.lblTenNCC);
            this.grbThongtinchung.Controls.Add(this.lblMaNV);
            this.grbThongtinchung.Controls.Add(this.lblMaNCC);
            this.grbThongtinchung.Controls.Add(this.lblNgaynhap);
            this.grbThongtinchung.Controls.Add(this.lblSoHD);
            this.grbThongtinchung.Location = new System.Drawing.Point(28, 65);
            this.grbThongtinchung.Margin = new System.Windows.Forms.Padding(4);
            this.grbThongtinchung.Name = "grbThongtinchung";
            this.grbThongtinchung.Padding = new System.Windows.Forms.Padding(4);
            this.grbThongtinchung.Size = new System.Drawing.Size(1009, 177);
            this.grbThongtinchung.TabIndex = 63;
            this.grbThongtinchung.TabStop = false;
            this.grbThongtinchung.Text = "Thông tin chung";
            this.grbThongtinchung.Enter += new System.EventHandler(this.grbThongtinchung_Enter);
            // 
            // mskDienthoai
            // 
            this.mskDienthoai.Location = new System.Drawing.Point(607, 142);
            this.mskDienthoai.Margin = new System.Windows.Forms.Padding(4);
            this.mskDienthoai.Mask = "(999) 000-0000";
            this.mskDienthoai.Name = "mskDienthoai";
            this.mskDienthoai.Size = new System.Drawing.Size(223, 22);
            this.mskDienthoai.TabIndex = 7;
            // 
            // cboMaNCC
            // 
            this.cboMaNCC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboMaNCC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMaNCC.FormattingEnabled = true;
            this.cboMaNCC.Location = new System.Drawing.Point(607, 37);
            this.cboMaNCC.Margin = new System.Windows.Forms.Padding(4);
            this.cboMaNCC.Name = "cboMaNCC";
            this.cboMaNCC.Size = new System.Drawing.Size(221, 24);
            this.cboMaNCC.TabIndex = 4;
            this.cboMaNCC.SelectedIndexChanged += new System.EventHandler(this.cboMaNCC_SelectedIndexChanged);
            // 
            // cboManhanvien
            // 
            this.cboManhanvien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboManhanvien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboManhanvien.FormattingEnabled = true;
            this.cboManhanvien.Location = new System.Drawing.Point(180, 106);
            this.cboManhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.cboManhanvien.Name = "cboManhanvien";
            this.cboManhanvien.Size = new System.Drawing.Size(221, 24);
            this.cboManhanvien.TabIndex = 2;
            this.cboManhanvien.SelectedIndexChanged += new System.EventHandler(this.cboManhanvien_SelectedIndexChanged);
            // 
            // txtTennhanvien
            // 
            this.txtTennhanvien.Location = new System.Drawing.Point(180, 138);
            this.txtTennhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTennhanvien.Name = "txtTennhanvien";
            this.txtTennhanvien.Size = new System.Drawing.Size(221, 22);
            this.txtTennhanvien.TabIndex = 3;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(607, 110);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(223, 22);
            this.txtDiachi.TabIndex = 6;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(607, 75);
            this.txtTenNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(223, 22);
            this.txtTenNCC.TabIndex = 5;
            // 
            // txtNgaynhap
            // 
            this.txtNgaynhap.Location = new System.Drawing.Point(180, 70);
            this.txtNgaynhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgaynhap.Name = "txtNgaynhap";
            this.txtNgaynhap.Size = new System.Drawing.Size(221, 22);
            this.txtNgaynhap.TabIndex = 1;
            // 
            // txtSoHDN
            // 
            this.txtSoHDN.Location = new System.Drawing.Point(180, 37);
            this.txtSoHDN.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoHDN.Name = "txtSoHDN";
            this.txtSoHDN.Size = new System.Drawing.Size(223, 22);
            this.txtSoHDN.TabIndex = 0;
            // 
            // lblDienthoai
            // 
            this.lblDienthoai.AutoSize = true;
            this.lblDienthoai.Location = new System.Drawing.Point(457, 146);
            this.lblDienthoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDienthoai.Name = "lblDienthoai";
            this.lblDienthoai.Size = new System.Drawing.Size(76, 17);
            this.lblDienthoai.TabIndex = 0;
            this.lblDienthoai.Text = "Điện thoại:";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(36, 142);
            this.lblTenNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(103, 17);
            this.lblTenNV.TabIndex = 0;
            this.lblTenNV.Text = "Tên nhân viên:";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Location = new System.Drawing.Point(457, 116);
            this.lblDiachi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(55, 17);
            this.lblDiachi.TabIndex = 0;
            this.lblDiachi.Text = "Địa chỉ:";
            // 
            // lblTenNCC
            // 
            this.lblTenNCC.AutoSize = true;
            this.lblTenNCC.Location = new System.Drawing.Point(457, 79);
            this.lblTenNCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenNCC.Name = "lblTenNCC";
            this.lblTenNCC.Size = new System.Drawing.Size(127, 17);
            this.lblTenNCC.TabIndex = 0;
            this.lblTenNCC.Text = "Tên nhà cung cấp:";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(36, 110);
            this.lblMaNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(97, 17);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "Mã nhân viên:";
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.Location = new System.Drawing.Point(457, 41);
            this.lblMaNCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(121, 17);
            this.lblMaNCC.TabIndex = 0;
            this.lblMaNCC.Text = "Mã nhà cung cấp:";
            // 
            // lblNgaynhap
            // 
            this.lblNgaynhap.AutoSize = true;
            this.lblNgaynhap.Location = new System.Drawing.Point(36, 73);
            this.lblNgaynhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgaynhap.Name = "lblNgaynhap";
            this.lblNgaynhap.Size = new System.Drawing.Size(81, 17);
            this.lblNgaynhap.TabIndex = 0;
            this.lblNgaynhap.Text = "Ngày nhập:";
            // 
            // lblSoHD
            // 
            this.lblSoHD.AutoSize = true;
            this.lblSoHD.Location = new System.Drawing.Point(36, 37);
            this.lblSoHD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoHD.Name = "lblSoHD";
            this.lblSoHD.Size = new System.Drawing.Size(85, 17);
            this.lblSoHD.TabIndex = 0;
            this.lblSoHD.Text = "Số hoá đơn:\r\n";
            // 
            // grbThongtinmathang
            // 
            this.grbThongtinmathang.Controls.Add(this.btnDong);
            this.grbThongtinmathang.Controls.Add(this.btnInhoadon);
            this.grbThongtinmathang.Controls.Add(this.btnHuy);
            this.grbThongtinmathang.Controls.Add(this.btnLuu);
            this.grbThongtinmathang.Controls.Add(this.btnThemmoi);
            this.grbThongtinmathang.Controls.Add(this.DataGridView_hdn);
            this.grbThongtinmathang.Controls.Add(this.txtTongtien);
            this.grbThongtinmathang.Controls.Add(this.lblBangchu);
            this.grbThongtinmathang.Controls.Add(this.lblTongtien);
            this.grbThongtinmathang.Controls.Add(this.cboMabinh);
            this.grbThongtinmathang.Controls.Add(this.txtThanhtien);
            this.grbThongtinmathang.Controls.Add(this.txtGiamgia);
            this.grbThongtinmathang.Controls.Add(this.txtDongia);
            this.grbThongtinmathang.Controls.Add(this.txtTenbinh);
            this.grbThongtinmathang.Controls.Add(this.txtSoluong);
            this.grbThongtinmathang.Controls.Add(this.lblThanhtien);
            this.grbThongtinmathang.Controls.Add(this.lblGiamgia);
            this.grbThongtinmathang.Controls.Add(this.lblSoluong);
            this.grbThongtinmathang.Controls.Add(this.lblDongia);
            this.grbThongtinmathang.Controls.Add(this.lblTenbinh);
            this.grbThongtinmathang.Controls.Add(this.lblMabinh);
            this.grbThongtinmathang.Location = new System.Drawing.Point(28, 245);
            this.grbThongtinmathang.Margin = new System.Windows.Forms.Padding(4);
            this.grbThongtinmathang.Name = "grbThongtinmathang";
            this.grbThongtinmathang.Padding = new System.Windows.Forms.Padding(4);
            this.grbThongtinmathang.Size = new System.Drawing.Size(1009, 369);
            this.grbThongtinmathang.TabIndex = 64;
            this.grbThongtinmathang.TabStop = false;
            this.grbThongtinmathang.Text = "Thông tin các mặt hàng";
            this.grbThongtinmathang.Enter += new System.EventHandler(this.grbThongtinmathang_Enter);
            // 
            // DataGridView_hdn
            // 
            this.DataGridView_hdn.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.DataGridView_hdn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_hdn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sohdn,
            this.mabinh,
            this.tenbinh,
            this.manv,
            this.mancc,
            this.soluong,
            this.ngaynhap,
            this.dongia,
            this.giamgia,
            this.thanhtien});
            this.DataGridView_hdn.Location = new System.Drawing.Point(31, 108);
            this.DataGridView_hdn.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView_hdn.Name = "DataGridView_hdn";
            this.DataGridView_hdn.RowHeadersWidth = 51;
            this.DataGridView_hdn.Size = new System.Drawing.Size(987, 138);
            this.DataGridView_hdn.TabIndex = 10;
            this.DataGridView_hdn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_hdn_CellClick);
            this.DataGridView_hdn.DoubleClick += new System.EventHandler(this.DataGridView_hdn_DoubleClick);
            // 
            // sohdn
            // 
            this.sohdn.DataPropertyName = "sohdn";
            this.sohdn.HeaderText = "Số hóa đơn nhập";
            this.sohdn.MinimumWidth = 6;
            this.sohdn.Name = "sohdn";
            this.sohdn.Width = 125;
            // 
            // mabinh
            // 
            this.mabinh.DataPropertyName = "mabinh";
            this.mabinh.HeaderText = "Mã bình";
            this.mabinh.MinimumWidth = 6;
            this.mabinh.Name = "mabinh";
            this.mabinh.Width = 125;
            // 
            // tenbinh
            // 
            this.tenbinh.DataPropertyName = "tenbinh";
            this.tenbinh.HeaderText = "Tên bình";
            this.tenbinh.MinimumWidth = 6;
            this.tenbinh.Name = "tenbinh";
            this.tenbinh.Width = 125;
            // 
            // manv
            // 
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "Mã nhân viên";
            this.manv.MinimumWidth = 6;
            this.manv.Name = "manv";
            this.manv.Width = 125;
            // 
            // mancc
            // 
            this.mancc.DataPropertyName = "mancc";
            this.mancc.HeaderText = "Mã NCC";
            this.mancc.MinimumWidth = 6;
            this.mancc.Name = "mancc";
            this.mancc.Width = 125;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            this.soluong.Width = 125;
            // 
            // ngaynhap
            // 
            this.ngaynhap.DataPropertyName = "ngaynhap";
            this.ngaynhap.HeaderText = "Ngày nhập";
            this.ngaynhap.MinimumWidth = 6;
            this.ngaynhap.Name = "ngaynhap";
            this.ngaynhap.Width = 125;
            // 
            // dongia
            // 
            this.dongia.DataPropertyName = "dongia";
            this.dongia.HeaderText = "Đơn giá";
            this.dongia.MinimumWidth = 6;
            this.dongia.Name = "dongia";
            this.dongia.Width = 125;
            // 
            // giamgia
            // 
            this.giamgia.DataPropertyName = "giamgia";
            this.giamgia.HeaderText = "Giảm giá";
            this.giamgia.MinimumWidth = 6;
            this.giamgia.Name = "giamgia";
            this.giamgia.Width = 125;
            // 
            // thanhtien
            // 
            this.thanhtien.DataPropertyName = "thanhtien";
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.MinimumWidth = 6;
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.Width = 125;
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(747, 246);
            this.txtTongtien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(193, 22);
            this.txtTongtien.TabIndex = 9;
            this.txtTongtien.TextChanged += new System.EventHandler(this.txtTongtien_TextChanged);
            // 
            // lblBangchu
            // 
            this.lblBangchu.AutoSize = true;
            this.lblBangchu.Location = new System.Drawing.Point(26, 269);
            this.lblBangchu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBangchu.Name = "lblBangchu";
            this.lblBangchu.Size = new System.Drawing.Size(72, 17);
            this.lblBangchu.TabIndex = 6;
            this.lblBangchu.Text = "Bằng chữ:";
            // 
            // lblTongtien
            // 
            this.lblTongtien.AutoSize = true;
            this.lblTongtien.Location = new System.Drawing.Point(644, 250);
            this.lblTongtien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongtien.Name = "lblTongtien";
            this.lblTongtien.Size = new System.Drawing.Size(72, 17);
            this.lblTongtien.TabIndex = 8;
            this.lblTongtien.Text = "Tổng tiền:";
            // 
            // cboMabinh
            // 
            this.cboMabinh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboMabinh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMabinh.FormattingEnabled = true;
            this.cboMabinh.Location = new System.Drawing.Point(124, 23);
            this.cboMabinh.Margin = new System.Windows.Forms.Padding(4);
            this.cboMabinh.Name = "cboMabinh";
            this.cboMabinh.Size = new System.Drawing.Size(193, 24);
            this.cboMabinh.TabIndex = 8;
            this.cboMabinh.SelectedIndexChanged += new System.EventHandler(this.cboMabinh_SelectedIndexChanged);
            // 
            // txtThanhtien
            // 
            this.txtThanhtien.Location = new System.Drawing.Point(747, 53);
            this.txtThanhtien.Margin = new System.Windows.Forms.Padding(4);
            this.txtThanhtien.Name = "txtThanhtien";
            this.txtThanhtien.Size = new System.Drawing.Size(172, 22);
            this.txtThanhtien.TabIndex = 13;
            // 
            // txtGiamgia
            // 
            this.txtGiamgia.Location = new System.Drawing.Point(433, 53);
            this.txtGiamgia.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiamgia.Name = "txtGiamgia";
            this.txtGiamgia.Size = new System.Drawing.Size(179, 22);
            this.txtGiamgia.TabIndex = 12;
            this.txtGiamgia.TextChanged += new System.EventHandler(this.txtGiamgia_TextChanged);
            this.txtGiamgia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiamgia_KeyPress);
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(747, 23);
            this.txtDongia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(172, 22);
            this.txtDongia.TabIndex = 10;
            this.txtDongia.TextChanged += new System.EventHandler(this.txtDongia_TextChanged);
            this.txtDongia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDongia_KeyPress);
            // 
            // txtTenbinh
            // 
            this.txtTenbinh.Location = new System.Drawing.Point(433, 22);
            this.txtTenbinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenbinh.Name = "txtTenbinh";
            this.txtTenbinh.Size = new System.Drawing.Size(179, 22);
            this.txtTenbinh.TabIndex = 9;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(124, 53);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(193, 22);
            this.txtSoluong.TabIndex = 11;
            this.txtSoluong.TextChanged += new System.EventHandler(this.txtSoluong_TextChanged);
            this.txtSoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoluong_KeyPress);
            // 
            // lblThanhtien
            // 
            this.lblThanhtien.AutoSize = true;
            this.lblThanhtien.Location = new System.Drawing.Point(644, 57);
            this.lblThanhtien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThanhtien.Name = "lblThanhtien";
            this.lblThanhtien.Size = new System.Drawing.Size(80, 17);
            this.lblThanhtien.TabIndex = 0;
            this.lblThanhtien.Text = "Thành tiền:";
            // 
            // lblGiamgia
            // 
            this.lblGiamgia.AutoSize = true;
            this.lblGiamgia.Location = new System.Drawing.Point(355, 57);
            this.lblGiamgia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGiamgia.Name = "lblGiamgia";
            this.lblGiamgia.Size = new System.Drawing.Size(68, 17);
            this.lblGiamgia.TabIndex = 0;
            this.lblGiamgia.Text = "Giảm giá:";
            // 
            // lblSoluong
            // 
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.Location = new System.Drawing.Point(47, 57);
            this.lblSoluong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(68, 17);
            this.lblSoluong.TabIndex = 0;
            this.lblSoluong.Text = "Số lượng:";
            // 
            // lblDongia
            // 
            this.lblDongia.AutoSize = true;
            this.lblDongia.Location = new System.Drawing.Point(644, 26);
            this.lblDongia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDongia.Name = "lblDongia";
            this.lblDongia.Size = new System.Drawing.Size(97, 17);
            this.lblDongia.TabIndex = 0;
            this.lblDongia.Text = "Đơn giá nhập:";
            // 
            // lblTenbinh
            // 
            this.lblTenbinh.AutoSize = true;
            this.lblTenbinh.Location = new System.Drawing.Point(355, 26);
            this.lblTenbinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenbinh.Name = "lblTenbinh";
            this.lblTenbinh.Size = new System.Drawing.Size(68, 17);
            this.lblTenbinh.TabIndex = 0;
            this.lblTenbinh.Text = "Tên bình:";
            // 
            // lblMabinh
            // 
            this.lblMabinh.AutoSize = true;
            this.lblMabinh.Location = new System.Drawing.Point(47, 26);
            this.lblMabinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMabinh.Name = "lblMabinh";
            this.lblMabinh.Size = new System.Drawing.Size(62, 17);
            this.lblMabinh.TabIndex = 0;
            this.lblMabinh.Text = "Mã bình:";
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bt_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_timkiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bt_timkiem.Location = new System.Drawing.Point(444, 625);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(127, 41);
            this.bt_timkiem.TabIndex = 69;
            this.bt_timkiem.Text = "Tìm kiếm";
            this.bt_timkiem.UseVisualStyleBackColor = false;
            this.bt_timkiem.Click += new System.EventHandler(this.bt_timkiem_Click);
            // 
            // lblNoidung12
            // 
            this.lblNoidung12.AutoSize = true;
            this.lblNoidung12.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoidung12.ForeColor = System.Drawing.Color.White;
            this.lblNoidung12.Location = new System.Drawing.Point(374, 11);
            this.lblNoidung12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoidung12.Name = "lblNoidung12";
            this.lblNoidung12.Size = new System.Drawing.Size(289, 30);
            this.lblNoidung12.TabIndex = 109;
            this.lblNoidung12.Text = "HOÁ ĐƠN NHẬP HÀNG";
            // 
            // btnHienthi
            // 
            this.btnHienthi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnHienthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienthi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHienthi.Location = new System.Drawing.Point(751, 625);
            this.btnHienthi.Name = "btnHienthi";
            this.btnHienthi.Size = new System.Drawing.Size(115, 41);
            this.btnHienthi.TabIndex = 109;
            this.btnHienthi.Text = "Hiển thị";
            this.btnHienthi.UseVisualStyleBackColor = false;
            this.btnHienthi.Click += new System.EventHandler(this.btnHienthi_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(161, 625);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 41);
            this.button1.TabIndex = 110;
            this.button1.Text = "Bắt đầu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.SystemColors.Window;
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(825, 306);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(149, 47);
            this.btnDong.TabIndex = 18;
            this.btnDong.Text = "Thoát";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnInhoadon
            // 
            this.btnInhoadon.BackColor = System.Drawing.SystemColors.Window;
            this.btnInhoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInhoadon.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnInhoadon.Image = ((System.Drawing.Image)(resources.GetObject("btnInhoadon.Image")));
            this.btnInhoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInhoadon.Location = new System.Drawing.Point(607, 306);
            this.btnInhoadon.Margin = new System.Windows.Forms.Padding(4);
            this.btnInhoadon.Name = "btnInhoadon";
            this.btnInhoadon.Size = new System.Drawing.Size(149, 47);
            this.btnInhoadon.TabIndex = 17;
            this.btnInhoadon.Text = " In hoá đơn";
            this.btnInhoadon.UseVisualStyleBackColor = false;
            this.btnInhoadon.Click += new System.EventHandler(this.btnInhoadon_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.Window;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(395, 305);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(148, 47);
            this.btnHuy.TabIndex = 16;
            this.btnHuy.Text = "   Huỷ hoá đơn";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.Window;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(197, 305);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(156, 47);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "  Lưu hoá đơn";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.BackColor = System.Drawing.SystemColors.Window;
            this.btnThemmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemmoi.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnThemmoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemmoi.Image")));
            this.btnThemmoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemmoi.Location = new System.Drawing.Point(8, 305);
            this.btnThemmoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(159, 47);
            this.btnThemmoi.TabIndex = 14;
            this.btnThemmoi.Text = "   Thêm hoá đơn";
            this.btnThemmoi.UseVisualStyleBackColor = false;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lblNoidung12);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 59);
            this.panel1.TabIndex = 111;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1069, 726);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHienthi);
            this.Controls.Add(this.bt_timkiem);
            this.Controls.Add(this.grbThongtinmathang);
            this.Controls.Add(this.grbThongtinchung);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbThongtinchung.ResumeLayout(false);
            this.grbThongtinchung.PerformLayout();
            this.grbThongtinmathang.ResumeLayout(false);
            this.grbThongtinmathang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_hdn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongtinchung;
        private System.Windows.Forms.MaskedTextBox mskDienthoai;
        private System.Windows.Forms.ComboBox cboMaNCC;
        private System.Windows.Forms.ComboBox cboManhanvien;
        private System.Windows.Forms.TextBox txtTennhanvien;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtNgaynhap;
        public System.Windows.Forms.TextBox txtSoHDN;
        private System.Windows.Forms.Label lblDienthoai;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblTenNCC;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblMaNCC;
        private System.Windows.Forms.Label lblNgaynhap;
        private System.Windows.Forms.Label lblSoHD;
        private System.Windows.Forms.GroupBox grbThongtinmathang;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnInhoadon;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThemmoi;
        private System.Windows.Forms.DataGridView DataGridView_hdn;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Label lblBangchu;
        private System.Windows.Forms.Label lblTongtien;
        private System.Windows.Forms.ComboBox cboMabinh;
        private System.Windows.Forms.TextBox txtThanhtien;
        private System.Windows.Forms.TextBox txtGiamgia;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.TextBox txtTenbinh;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label lblThanhtien;
        private System.Windows.Forms.Label lblGiamgia;
        private System.Windows.Forms.Label lblSoluong;
        private System.Windows.Forms.Label lblDongia;
        private System.Windows.Forms.Label lblTenbinh;
        private System.Windows.Forms.Label lblMabinh;
        private System.Windows.Forms.Button bt_timkiem;
        private System.Windows.Forms.Label lblNoidung12;
        private System.Windows.Forms.DataGridViewTextBoxColumn sohdn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mabinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenbinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn mancc;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.Button btnHienthi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}

