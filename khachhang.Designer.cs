namespace hoa_don_nhap
{
    partial class khachhang
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
            this.textBoxsodienthoai = new System.Windows.Forms.TextBox();
            this.textBoxdiachi = new System.Windows.Forms.TextBox();
            this.textBoxtenkh = new System.Windows.Forms.TextBox();
            this.textBoxmakh = new System.Windows.Forms.TextBox();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewkhachhang = new System.Windows.Forms.DataGridView();
            this.sodt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelsodienthoai = new System.Windows.Forms.Label();
            this.labeldiachi = new System.Windows.Forms.Label();
            this.labeltenKh = new System.Windows.Forms.Label();
            this.labelMaKH = new System.Windows.Forms.Label();
            this.buttonthoat = new System.Windows.Forms.Button();
            this.buttonluu = new System.Windows.Forms.Button();
            this.buttonxoa = new System.Windows.Forms.Button();
            this.buttonsua = new System.Windows.Forms.Button();
            this.buttonthem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewkhachhang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxsodienthoai
            // 
            this.textBoxsodienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxsodienthoai.Location = new System.Drawing.Point(705, 196);
            this.textBoxsodienthoai.Name = "textBoxsodienthoai";
            this.textBoxsodienthoai.Size = new System.Drawing.Size(159, 30);
            this.textBoxsodienthoai.TabIndex = 31;
            this.textBoxsodienthoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxsodienthoai_KeyPress);
            // 
            // textBoxdiachi
            // 
            this.textBoxdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxdiachi.Location = new System.Drawing.Point(705, 122);
            this.textBoxdiachi.Name = "textBoxdiachi";
            this.textBoxdiachi.Size = new System.Drawing.Size(159, 30);
            this.textBoxdiachi.TabIndex = 30;
            // 
            // textBoxtenkh
            // 
            this.textBoxtenkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxtenkh.Location = new System.Drawing.Point(236, 191);
            this.textBoxtenkh.Name = "textBoxtenkh";
            this.textBoxtenkh.Size = new System.Drawing.Size(159, 30);
            this.textBoxtenkh.TabIndex = 29;
            // 
            // textBoxmakh
            // 
            this.textBoxmakh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxmakh.Location = new System.Drawing.Point(236, 127);
            this.textBoxmakh.Name = "textBoxmakh";
            this.textBoxmakh.Size = new System.Drawing.Size(159, 30);
            this.textBoxmakh.TabIndex = 28;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.Width = 125;
            // 
            // tenkh
            // 
            this.tenkh.DataPropertyName = "tenkhach";
            this.tenkh.HeaderText = "Tên khách hàng";
            this.tenkh.MinimumWidth = 6;
            this.tenkh.Name = "tenkh";
            this.tenkh.Width = 125;
            // 
            // makh
            // 
            this.makh.DataPropertyName = "makhach";
            this.makh.HeaderText = "Mã khách hàng";
            this.makh.MinimumWidth = 6;
            this.makh.Name = "makh";
            this.makh.Width = 125;
            // 
            // dataGridViewkhachhang
            // 
            this.dataGridViewkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewkhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makh,
            this.tenkh,
            this.diachi,
            this.sodt});
            this.dataGridViewkhachhang.Location = new System.Drawing.Point(195, 292);
            this.dataGridViewkhachhang.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dataGridViewkhachhang.Name = "dataGridViewkhachhang";
            this.dataGridViewkhachhang.RowHeadersWidth = 51;
            this.dataGridViewkhachhang.Size = new System.Drawing.Size(556, 157);
            this.dataGridViewkhachhang.TabIndex = 27;
            this.dataGridViewkhachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewkhachhang_CellClick);
            // 
            // sodt
            // 
            this.sodt.DataPropertyName = "dienthoai";
            this.sodt.HeaderText = "Số điện thoại";
            this.sodt.MinimumWidth = 6;
            this.sodt.Name = "sodt";
            this.sodt.Width = 125;
            // 
            // labelsodienthoai
            // 
            this.labelsodienthoai.AutoSize = true;
            this.labelsodienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelsodienthoai.Location = new System.Drawing.Point(532, 196);
            this.labelsodienthoai.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelsodienthoai.Name = "labelsodienthoai";
            this.labelsodienthoai.Size = new System.Drawing.Size(142, 25);
            this.labelsodienthoai.TabIndex = 26;
            this.labelsodienthoai.Text = "Số  Điện Thoại";
            // 
            // labeldiachi
            // 
            this.labeldiachi.AutoSize = true;
            this.labeldiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labeldiachi.Location = new System.Drawing.Point(532, 127);
            this.labeldiachi.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labeldiachi.Name = "labeldiachi";
            this.labeldiachi.Size = new System.Drawing.Size(76, 25);
            this.labeldiachi.TabIndex = 25;
            this.labeldiachi.Text = "Địa Chỉ";
            // 
            // labeltenKh
            // 
            this.labeltenKh.AutoSize = true;
            this.labeltenKh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labeltenKh.Location = new System.Drawing.Point(36, 191);
            this.labeltenKh.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labeltenKh.Name = "labeltenKh";
            this.labeltenKh.Size = new System.Drawing.Size(161, 25);
            this.labeltenKh.TabIndex = 24;
            this.labeltenKh.Text = "Tên Khách Hàng";
            // 
            // labelMaKH
            // 
            this.labelMaKH.AutoSize = true;
            this.labelMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelMaKH.Location = new System.Drawing.Point(43, 120);
            this.labelMaKH.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelMaKH.Name = "labelMaKH";
            this.labelMaKH.Size = new System.Drawing.Size(154, 25);
            this.labelMaKH.TabIndex = 23;
            this.labelMaKH.Text = "Mã Khách Hàng";
            // 
            // buttonthoat
            // 
            this.buttonthoat.BackColor = System.Drawing.SystemColors.Window;
            this.buttonthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonthoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonthoat.Image = global::hoa_don_nhap.Properties.Resources.close__1_;
            this.buttonthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonthoat.Location = new System.Drawing.Point(863, 527);
            this.buttonthoat.Name = "buttonthoat";
            this.buttonthoat.Size = new System.Drawing.Size(139, 43);
            this.buttonthoat.TabIndex = 37;
            this.buttonthoat.Text = "Thoát";
            this.buttonthoat.UseVisualStyleBackColor = false;
            this.buttonthoat.Click += new System.EventHandler(this.buttonthoat_Click_1);
            // 
            // buttonluu
            // 
            this.buttonluu.BackColor = System.Drawing.SystemColors.Window;
            this.buttonluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonluu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonluu.Image = global::hoa_don_nhap.Properties.Resources.save;
            this.buttonluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonluu.Location = new System.Drawing.Point(473, 525);
            this.buttonluu.Name = "buttonluu";
            this.buttonluu.Size = new System.Drawing.Size(139, 47);
            this.buttonluu.TabIndex = 36;
            this.buttonluu.Text = "Lưu";
            this.buttonluu.UseVisualStyleBackColor = false;
            this.buttonluu.Click += new System.EventHandler(this.buttonluu_Click);
            // 
            // buttonxoa
            // 
            this.buttonxoa.BackColor = System.Drawing.SystemColors.Window;
            this.buttonxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonxoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonxoa.Image = global::hoa_don_nhap.Properties.Resources.delete__1_;
            this.buttonxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonxoa.Location = new System.Drawing.Point(678, 530);
            this.buttonxoa.Name = "buttonxoa";
            this.buttonxoa.Size = new System.Drawing.Size(139, 42);
            this.buttonxoa.TabIndex = 35;
            this.buttonxoa.Text = "Xóa";
            this.buttonxoa.UseVisualStyleBackColor = false;
            this.buttonxoa.Click += new System.EventHandler(this.buttonxoa_Click);
            // 
            // buttonsua
            // 
            this.buttonsua.BackColor = System.Drawing.SystemColors.Window;
            this.buttonsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonsua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonsua.Image = global::hoa_don_nhap.Properties.Resources.refresh__1_;
            this.buttonsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonsua.Location = new System.Drawing.Point(236, 525);
            this.buttonsua.Name = "buttonsua";
            this.buttonsua.Size = new System.Drawing.Size(139, 42);
            this.buttonsua.TabIndex = 34;
            this.buttonsua.Text = "Sửa";
            this.buttonsua.UseVisualStyleBackColor = false;
            this.buttonsua.Click += new System.EventHandler(this.buttonsua_Click);
            // 
            // buttonthem
            // 
            this.buttonthem.BackColor = System.Drawing.SystemColors.Window;
            this.buttonthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonthem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonthem.Image = global::hoa_don_nhap.Properties.Resources.writing;
            this.buttonthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonthem.Location = new System.Drawing.Point(22, 523);
            this.buttonthem.Name = "buttonthem";
            this.buttonthem.Size = new System.Drawing.Size(139, 46);
            this.buttonthem.TabIndex = 33;
            this.buttonthem.Text = "Thêm";
            this.buttonthem.UseVisualStyleBackColor = false;
            this.buttonthem.Click += new System.EventHandler(this.buttonthem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 64);
            this.panel1.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(384, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(337, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // khachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1052, 604);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonthoat);
            this.Controls.Add(this.buttonluu);
            this.Controls.Add(this.buttonxoa);
            this.Controls.Add(this.buttonsua);
            this.Controls.Add(this.buttonthem);
            this.Controls.Add(this.textBoxsodienthoai);
            this.Controls.Add(this.textBoxdiachi);
            this.Controls.Add(this.textBoxtenkh);
            this.Controls.Add(this.textBoxmakh);
            this.Controls.Add(this.dataGridViewkhachhang);
            this.Controls.Add(this.labelsodienthoai);
            this.Controls.Add(this.labeldiachi);
            this.Controls.Add(this.labeltenKh);
            this.Controls.Add(this.labelMaKH);
            this.Name = "khachhang";
            this.Text = "khachhang";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewkhachhang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonthoat;
        private System.Windows.Forms.Button buttonluu;
        private System.Windows.Forms.Button buttonxoa;
        private System.Windows.Forms.Button buttonsua;
        private System.Windows.Forms.Button buttonthem;
        private System.Windows.Forms.TextBox textBoxsodienthoai;
        private System.Windows.Forms.TextBox textBoxdiachi;
        private System.Windows.Forms.TextBox textBoxtenkh;
        private System.Windows.Forms.TextBox textBoxmakh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
        private System.Windows.Forms.DataGridView dataGridViewkhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodt;
        private System.Windows.Forms.Label labelsodienthoai;
        private System.Windows.Forms.Label labeldiachi;
        private System.Windows.Forms.Label labeltenKh;
        private System.Windows.Forms.Label labelMaKH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}