namespace hoa_don_nhap
{
    partial class Loaics
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
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.Tenloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnThem = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnThoat = new System.Windows.Forms.Button();
			this.gridviewLoai = new System.Windows.Forms.DataGridView();
			this.Maloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtTenloai = new System.Windows.Forms.TextBox();
			this.txtMaloai = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.gridviewLoai)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.SystemColors.Window;
			this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnXoa.Image = global::hoa_don_nhap.Properties.Resources.delete__1_;
			this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnXoa.Location = new System.Drawing.Point(578, 500);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(118, 40);
			this.btnXoa.TabIndex = 18;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = false;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.BackColor = System.Drawing.SystemColors.Window;
			this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnSua.Image = global::hoa_don_nhap.Properties.Resources.refresh__1_;
			this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSua.Location = new System.Drawing.Point(394, 500);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(118, 37);
			this.btnSua.TabIndex = 17;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = false;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnLuu
			// 
			this.btnLuu.BackColor = System.Drawing.SystemColors.Window;
			this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnLuu.Image = global::hoa_don_nhap.Properties.Resources.save;
			this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLuu.Location = new System.Drawing.Point(203, 500);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(118, 37);
			this.btnLuu.TabIndex = 16;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = false;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// Tenloai
			// 
			this.Tenloai.DataPropertyName = "Tenloai";
			this.Tenloai.HeaderText = "Tên Loại";
			this.Tenloai.MinimumWidth = 6;
			this.Tenloai.Name = "Tenloai";
			this.Tenloai.Width = 125;
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.SystemColors.Window;
			this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnThem.Image = global::hoa_don_nhap.Properties.Resources.writing;
			this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThem.Location = new System.Drawing.Point(26, 498);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(118, 38);
			this.btnThem.TabIndex = 15;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(211, 87);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 24);
			this.label1.TabIndex = 10;
			this.label1.Text = "Mã loại";
			// 
			// btnThoat
			// 
			this.btnThoat.BackColor = System.Drawing.SystemColors.Window;
			this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnThoat.Image = global::hoa_don_nhap.Properties.Resources.close__1_;
			this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThoat.Location = new System.Drawing.Point(734, 499);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(118, 41);
			this.btnThoat.TabIndex = 19;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = false;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// gridviewLoai
			// 
			this.gridviewLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridviewLoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maloai,
            this.Tenloai});
			this.gridviewLoai.Location = new System.Drawing.Point(134, 202);
			this.gridviewLoai.Name = "gridviewLoai";
			this.gridviewLoai.RowHeadersWidth = 51;
			this.gridviewLoai.Size = new System.Drawing.Size(602, 235);
			this.gridviewLoai.TabIndex = 14;
			this.gridviewLoai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewLoai_CellClick);
			// 
			// Maloai
			// 
			this.Maloai.DataPropertyName = "Maloai";
			this.Maloai.HeaderText = "Mã Loại";
			this.Maloai.MinimumWidth = 6;
			this.Maloai.Name = "Maloai";
			this.Maloai.Width = 125;
			// 
			// txtTenloai
			// 
			this.txtTenloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenloai.Location = new System.Drawing.Point(374, 134);
			this.txtTenloai.Name = "txtTenloai";
			this.txtTenloai.Size = new System.Drawing.Size(172, 26);
			this.txtTenloai.TabIndex = 13;
			// 
			// txtMaloai
			// 
			this.txtMaloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaloai.Location = new System.Drawing.Point(374, 89);
			this.txtMaloai.Name = "txtMaloai";
			this.txtMaloai.Size = new System.Drawing.Size(172, 26);
			this.txtMaloai.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(211, 132);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 24);
			this.label2.TabIndex = 11;
			this.label2.Text = "Tên loại";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.Controls.Add(this.label4);
			this.panel1.Location = new System.Drawing.Point(-29, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(893, 58);
			this.panel1.TabIndex = 50;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(330, 15);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(280, 33);
			this.label4.TabIndex = 0;
			this.label4.Text = "QUẢN LÝ LOẠI GAS";
			// 
			// Loaics
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleTurquoise;
			this.ClientSize = new System.Drawing.Size(864, 590);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.btnLuu);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.gridviewLoai);
			this.Controls.Add(this.txtTenloai);
			this.Controls.Add(this.txtMaloai);
			this.Controls.Add(this.label2);
			this.Name = "Loaics";
			this.Text = "Loaics";
			this.Load += new System.EventHandler(this.Loaics_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridviewLoai)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenloai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView gridviewLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maloai;
        private System.Windows.Forms.TextBox txtTenloai;
        private System.Windows.Forms.TextBox txtMaloai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}