namespace hoa_don_nhap
{
    partial class NhanVien
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
            this.maskedTextBoxngaysinh = new System.Windows.Forms.MaskedTextBox();
            this.macv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewNhanVien = new System.Windows.Forms.DataGridView();
            this.comboBoxmaca = new System.Windows.Forms.ComboBox();
            this.comboBoxmacongviec = new System.Windows.Forms.ComboBox();
            this.comboBoxgioitinh = new System.Windows.Forms.ComboBox();
            this.textBoxdiachi = new System.Windows.Forms.TextBox();
            this.textBoxdienthoai = new System.Windows.Forms.TextBox();
            this.textBoxTenNV = new System.Windows.Forms.TextBox();
            this.textBoxMaNV = new System.Windows.Forms.TextBox();
            this.labelmaca = new System.Windows.Forms.Label();
            this.labelcongviec = new System.Windows.Forms.Label();
            this.labeldiachi = new System.Windows.Forms.Label();
            this.labeldienthoai = new System.Windows.Forms.Label();
            this.labelgioitinh = new System.Windows.Forms.Label();
            this.labelngaysinh = new System.Windows.Forms.Label();
            this.labelTenNV = new System.Windows.Forms.Label();
            this.labelMaNV = new System.Windows.Forms.Label();
            this.buttonluu = new System.Windows.Forms.Button();
            this.buttonxoa = new System.Windows.Forms.Button();
            this.buttonsua = new System.Windows.Forms.Button();
            this.buttonthem = new System.Windows.Forms.Button();
            this.buttonthoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maskedTextBoxngaysinh
            // 
            this.maskedTextBoxngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maskedTextBoxngaysinh.Location = new System.Drawing.Point(278, 239);
            this.maskedTextBoxngaysinh.Mask = "00/00/0000";
            this.maskedTextBoxngaysinh.Name = "maskedTextBoxngaysinh";
            this.maskedTextBoxngaysinh.Size = new System.Drawing.Size(151, 30);
            this.maskedTextBoxngaysinh.TabIndex = 44;
            // 
            // macv
            // 
            this.macv.DataPropertyName = "macv";
            this.macv.HeaderText = "Mã Công Việc";
            this.macv.MinimumWidth = 6;
            this.macv.Name = "macv";
            this.macv.Width = 125;
            // 
            // maca
            // 
            this.maca.DataPropertyName = "maca";
            this.maca.HeaderText = "Mã Ca";
            this.maca.MinimumWidth = 6;
            this.maca.Name = "maca";
            this.maca.Width = 125;
            // 
            // Diachi
            // 
            this.Diachi.DataPropertyName = "diachi";
            this.Diachi.HeaderText = "Địa Chỉ";
            this.Diachi.MinimumWidth = 6;
            this.Diachi.Name = "Diachi";
            this.Diachi.Width = 125;
            // 
            // dienthoai
            // 
            this.dienthoai.DataPropertyName = "dienthoai";
            this.dienthoai.HeaderText = "Điện Thoại";
            this.dienthoai.MinimumWidth = 6;
            this.dienthoai.Name = "dienthoai";
            this.dienthoai.Width = 125;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày Sinh";
            this.ngaysinh.MinimumWidth = 6;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Width = 125;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới Tính";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Width = 125;
            // 
            // tennv
            // 
            this.tennv.DataPropertyName = "tennv";
            this.tennv.HeaderText = "Tên Nhân Viên";
            this.tennv.MinimumWidth = 6;
            this.tennv.Name = "tennv";
            this.tennv.Width = 125;
            // 
            // manv
            // 
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "Mã Nhân Viên";
            this.manv.MinimumWidth = 6;
            this.manv.Name = "manv";
            this.manv.Width = 125;
            // 
            // dataGridViewNhanVien
            // 
            this.dataGridViewNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.tennv,
            this.gioitinh,
            this.ngaysinh,
            this.dienthoai,
            this.Diachi,
            this.maca,
            this.macv});
            this.dataGridViewNhanVien.Location = new System.Drawing.Point(134, 306);
            this.dataGridViewNhanVien.Name = "dataGridViewNhanVien";
            this.dataGridViewNhanVien.RowHeadersWidth = 51;
            this.dataGridViewNhanVien.Size = new System.Drawing.Size(722, 150);
            this.dataGridViewNhanVien.TabIndex = 38;
            this.dataGridViewNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNhanVien_CellClick_1);
            // 
            // comboBoxmaca
            // 
            this.comboBoxmaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxmaca.FormattingEnabled = true;
            this.comboBoxmaca.Location = new System.Drawing.Point(735, 239);
            this.comboBoxmaca.Name = "comboBoxmaca";
            this.comboBoxmaca.Size = new System.Drawing.Size(151, 33);
            this.comboBoxmaca.TabIndex = 37;
            // 
            // comboBoxmacongviec
            // 
            this.comboBoxmacongviec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxmacongviec.FormattingEnabled = true;
            this.comboBoxmacongviec.Location = new System.Drawing.Point(735, 180);
            this.comboBoxmacongviec.Name = "comboBoxmacongviec";
            this.comboBoxmacongviec.Size = new System.Drawing.Size(151, 33);
            this.comboBoxmacongviec.TabIndex = 36;
            // 
            // comboBoxgioitinh
            // 
            this.comboBoxgioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxgioitinh.FormattingEnabled = true;
            this.comboBoxgioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBoxgioitinh.Location = new System.Drawing.Point(278, 180);
            this.comboBoxgioitinh.Name = "comboBoxgioitinh";
            this.comboBoxgioitinh.Size = new System.Drawing.Size(151, 33);
            this.comboBoxgioitinh.TabIndex = 35;
            // 
            // textBoxdiachi
            // 
            this.textBoxdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxdiachi.Location = new System.Drawing.Point(735, 131);
            this.textBoxdiachi.Name = "textBoxdiachi";
            this.textBoxdiachi.Size = new System.Drawing.Size(151, 30);
            this.textBoxdiachi.TabIndex = 34;
            // 
            // textBoxdienthoai
            // 
            this.textBoxdienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxdienthoai.Location = new System.Drawing.Point(735, 80);
            this.textBoxdienthoai.Name = "textBoxdienthoai";
            this.textBoxdienthoai.Size = new System.Drawing.Size(151, 30);
            this.textBoxdienthoai.TabIndex = 33;
            this.textBoxdienthoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxdienthoai_KeyPress);
            // 
            // textBoxTenNV
            // 
            this.textBoxTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxTenNV.Location = new System.Drawing.Point(278, 134);
            this.textBoxTenNV.Name = "textBoxTenNV";
            this.textBoxTenNV.Size = new System.Drawing.Size(151, 30);
            this.textBoxTenNV.TabIndex = 32;
            // 
            // textBoxMaNV
            // 
            this.textBoxMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxMaNV.Location = new System.Drawing.Point(278, 82);
            this.textBoxMaNV.Name = "textBoxMaNV";
            this.textBoxMaNV.Size = new System.Drawing.Size(151, 30);
            this.textBoxMaNV.TabIndex = 31;
            // 
            // labelmaca
            // 
            this.labelmaca.AutoSize = true;
            this.labelmaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelmaca.Location = new System.Drawing.Point(579, 244);
            this.labelmaca.Name = "labelmaca";
            this.labelmaca.Size = new System.Drawing.Size(71, 25);
            this.labelmaca.TabIndex = 30;
            this.labelmaca.Text = "Mã Ca";
            // 
            // labelcongviec
            // 
            this.labelcongviec.AutoSize = true;
            this.labelcongviec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelcongviec.Location = new System.Drawing.Point(579, 188);
            this.labelcongviec.Name = "labelcongviec";
            this.labelcongviec.Size = new System.Drawing.Size(137, 25);
            this.labelcongviec.TabIndex = 29;
            this.labelcongviec.Text = "Mã Công Việc";
            // 
            // labeldiachi
            // 
            this.labeldiachi.AutoSize = true;
            this.labeldiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labeldiachi.Location = new System.Drawing.Point(579, 139);
            this.labeldiachi.Name = "labeldiachi";
            this.labeldiachi.Size = new System.Drawing.Size(76, 25);
            this.labeldiachi.TabIndex = 28;
            this.labeldiachi.Text = "Địa Chỉ";
            // 
            // labeldienthoai
            // 
            this.labeldienthoai.AutoSize = true;
            this.labeldienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labeldienthoai.Location = new System.Drawing.Point(579, 88);
            this.labeldienthoai.Name = "labeldienthoai";
            this.labeldienthoai.Size = new System.Drawing.Size(107, 25);
            this.labeldienthoai.TabIndex = 27;
            this.labeldienthoai.Text = "Điện Thoại";
            // 
            // labelgioitinh
            // 
            this.labelgioitinh.AutoSize = true;
            this.labelgioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelgioitinh.Location = new System.Drawing.Point(169, 183);
            this.labelgioitinh.Name = "labelgioitinh";
            this.labelgioitinh.Size = new System.Drawing.Size(90, 25);
            this.labelgioitinh.TabIndex = 26;
            this.labelgioitinh.Text = "Giới Tính";
            // 
            // labelngaysinh
            // 
            this.labelngaysinh.AutoSize = true;
            this.labelngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelngaysinh.Location = new System.Drawing.Point(169, 244);
            this.labelngaysinh.Name = "labelngaysinh";
            this.labelngaysinh.Size = new System.Drawing.Size(103, 25);
            this.labelngaysinh.TabIndex = 25;
            this.labelngaysinh.Text = "Ngày Sinh";
            // 
            // labelTenNV
            // 
            this.labelTenNV.AutoSize = true;
            this.labelTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTenNV.Location = new System.Drawing.Point(169, 134);
            this.labelTenNV.Name = "labelTenNV";
            this.labelTenNV.Size = new System.Drawing.Size(80, 25);
            this.labelTenNV.TabIndex = 24;
            this.labelTenNV.Text = "Tên NV";
            // 
            // labelMaNV
            // 
            this.labelMaNV.AutoSize = true;
            this.labelMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelMaNV.Location = new System.Drawing.Point(169, 85);
            this.labelMaNV.Name = "labelMaNV";
            this.labelMaNV.Size = new System.Drawing.Size(73, 25);
            this.labelMaNV.TabIndex = 23;
            this.labelMaNV.Text = "Mã NV";
            // 
            // buttonluu
            // 
            this.buttonluu.BackColor = System.Drawing.SystemColors.Window;
            this.buttonluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonluu.ForeColor = System.Drawing.Color.Maroon;
            this.buttonluu.Image = global::hoa_don_nhap.Properties.Resources.save;
            this.buttonluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonluu.Location = new System.Drawing.Point(629, 492);
            this.buttonluu.Name = "buttonluu";
            this.buttonluu.Size = new System.Drawing.Size(112, 43);
            this.buttonluu.TabIndex = 42;
            this.buttonluu.Text = "Lưu";
            this.buttonluu.UseVisualStyleBackColor = false;
            this.buttonluu.Click += new System.EventHandler(this.buttonluu_Click_1);
            // 
            // buttonxoa
            // 
            this.buttonxoa.BackColor = System.Drawing.SystemColors.Window;
            this.buttonxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonxoa.ForeColor = System.Drawing.Color.Maroon;
            this.buttonxoa.Image = global::hoa_don_nhap.Properties.Resources.delete__1_;
            this.buttonxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonxoa.Location = new System.Drawing.Point(456, 492);
            this.buttonxoa.Name = "buttonxoa";
            this.buttonxoa.Size = new System.Drawing.Size(110, 43);
            this.buttonxoa.TabIndex = 41;
            this.buttonxoa.Text = "Xóa";
            this.buttonxoa.UseVisualStyleBackColor = false;
            this.buttonxoa.Click += new System.EventHandler(this.buttonxoa_Click_1);
            // 
            // buttonsua
            // 
            this.buttonsua.BackColor = System.Drawing.SystemColors.Window;
            this.buttonsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsua.ForeColor = System.Drawing.Color.Maroon;
            this.buttonsua.Image = global::hoa_don_nhap.Properties.Resources.refresh__1_;
            this.buttonsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonsua.Location = new System.Drawing.Point(271, 492);
            this.buttonsua.Name = "buttonsua";
            this.buttonsua.Size = new System.Drawing.Size(111, 43);
            this.buttonsua.TabIndex = 40;
            this.buttonsua.Text = "Sửa";
            this.buttonsua.UseVisualStyleBackColor = false;
            this.buttonsua.Click += new System.EventHandler(this.buttonsua_Click_1);
            // 
            // buttonthem
            // 
            this.buttonthem.BackColor = System.Drawing.SystemColors.Window;
            this.buttonthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonthem.ForeColor = System.Drawing.Color.Maroon;
            this.buttonthem.Image = global::hoa_don_nhap.Properties.Resources.writing;
            this.buttonthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonthem.Location = new System.Drawing.Point(105, 492);
            this.buttonthem.Name = "buttonthem";
            this.buttonthem.Size = new System.Drawing.Size(114, 43);
            this.buttonthem.TabIndex = 39;
            this.buttonthem.Text = "Thêm";
            this.buttonthem.UseVisualStyleBackColor = false;
            this.buttonthem.Click += new System.EventHandler(this.buttonthem_Click_1);
            // 
            // buttonthoat
            // 
            this.buttonthoat.BackColor = System.Drawing.SystemColors.Window;
            this.buttonthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonthoat.ForeColor = System.Drawing.Color.Maroon;
            this.buttonthoat.Image = global::hoa_don_nhap.Properties.Resources.close__1_;
            this.buttonthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonthoat.Location = new System.Drawing.Point(797, 492);
            this.buttonthoat.Name = "buttonthoat";
            this.buttonthoat.Size = new System.Drawing.Size(111, 43);
            this.buttonthoat.TabIndex = 43;
            this.buttonthoat.Text = "Thoát";
            this.buttonthoat.UseVisualStyleBackColor = false;
            this.buttonthoat.Click += new System.EventHandler(this.buttonthoat_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 58);
            this.panel1.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(356, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1044, 583);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.maskedTextBoxngaysinh);
            this.Controls.Add(this.buttonluu);
            this.Controls.Add(this.buttonxoa);
            this.Controls.Add(this.buttonsua);
            this.Controls.Add(this.buttonthem);
            this.Controls.Add(this.buttonthoat);
            this.Controls.Add(this.dataGridViewNhanVien);
            this.Controls.Add(this.comboBoxmaca);
            this.Controls.Add(this.comboBoxmacongviec);
            this.Controls.Add(this.comboBoxgioitinh);
            this.Controls.Add(this.textBoxdiachi);
            this.Controls.Add(this.textBoxdienthoai);
            this.Controls.Add(this.textBoxTenNV);
            this.Controls.Add(this.textBoxMaNV);
            this.Controls.Add(this.labelmaca);
            this.Controls.Add(this.labelcongviec);
            this.Controls.Add(this.labeldiachi);
            this.Controls.Add(this.labeldienthoai);
            this.Controls.Add(this.labelgioitinh);
            this.Controls.Add(this.labelngaysinh);
            this.Controls.Add(this.labelTenNV);
            this.Controls.Add(this.labelMaNV);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxngaysinh;
        private System.Windows.Forms.Button buttonluu;
        private System.Windows.Forms.Button buttonxoa;
        private System.Windows.Forms.Button buttonsua;
        private System.Windows.Forms.Button buttonthem;
        private System.Windows.Forms.DataGridViewTextBoxColumn macv;
        private System.Windows.Forms.DataGridViewTextBoxColumn maca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.Button buttonthoat;
        private System.Windows.Forms.DataGridView dataGridViewNhanVien;
        private System.Windows.Forms.ComboBox comboBoxmaca;
        private System.Windows.Forms.ComboBox comboBoxmacongviec;
        private System.Windows.Forms.ComboBox comboBoxgioitinh;
        private System.Windows.Forms.TextBox textBoxdiachi;
        private System.Windows.Forms.TextBox textBoxdienthoai;
        private System.Windows.Forms.TextBox textBoxTenNV;
        private System.Windows.Forms.TextBox textBoxMaNV;
        private System.Windows.Forms.Label labelmaca;
        private System.Windows.Forms.Label labelcongviec;
        private System.Windows.Forms.Label labeldiachi;
        private System.Windows.Forms.Label labeldienthoai;
        private System.Windows.Forms.Label labelgioitinh;
        private System.Windows.Forms.Label labelngaysinh;
        private System.Windows.Forms.Label labelTenNV;
        private System.Windows.Forms.Label labelMaNV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}