namespace hoa_don_nhap
{
    partial class KhoiLuong
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
			this.Makhoiluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gridviewKhoiluong = new System.Windows.Forms.DataGridView();
			this.txtMakl = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnLuu = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.gridviewKhoiluong)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Makhoiluong
			// 
			this.Makhoiluong.DataPropertyName = "Makhoiluong";
			this.Makhoiluong.HeaderText = "Mã Khối Lượng";
			this.Makhoiluong.MinimumWidth = 6;
			this.Makhoiluong.Name = "Makhoiluong";
			this.Makhoiluong.Width = 125;
			// 
			// gridviewKhoiluong
			// 
			this.gridviewKhoiluong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridviewKhoiluong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Makhoiluong});
			this.gridviewKhoiluong.Location = new System.Drawing.Point(176, 214);
			this.gridviewKhoiluong.Name = "gridviewKhoiluong";
			this.gridviewKhoiluong.RowHeadersWidth = 51;
			this.gridviewKhoiluong.Size = new System.Drawing.Size(349, 213);
			this.gridviewKhoiluong.TabIndex = 11;
			this.gridviewKhoiluong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewKhoiluong_CellClick);
			// 
			// txtMakl
			// 
			this.txtMakl.Location = new System.Drawing.Point(333, 130);
			this.txtMakl.Name = "txtMakl";
			this.txtMakl.Size = new System.Drawing.Size(192, 22);
			this.txtMakl.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(160, 130);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(156, 25);
			this.label1.TabIndex = 9;
			this.label1.Text = " Mã Khối Lượng:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// btnLuu
			// 
			this.btnLuu.BackColor = System.Drawing.SystemColors.Window;
			this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnLuu.Image = global::hoa_don_nhap.Properties.Resources.save;
			this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLuu.Location = new System.Drawing.Point(245, 454);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(110, 41);
			this.btnLuu.TabIndex = 15;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = false;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.SystemColors.Window;
			this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnXoa.Image = global::hoa_don_nhap.Properties.Resources.delete__1_;
			this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnXoa.Location = new System.Drawing.Point(484, 455);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(110, 40);
			this.btnXoa.TabIndex = 14;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = false;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.BackColor = System.Drawing.SystemColors.Window;
			this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnThoat.Image = global::hoa_don_nhap.Properties.Resources.close__1_;
			this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThoat.Location = new System.Drawing.Point(669, 454);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(110, 39);
			this.btnThoat.TabIndex = 13;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = false;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.SystemColors.Window;
			this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnThem.Image = global::hoa_don_nhap.Properties.Resources.writing;
			this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThem.Location = new System.Drawing.Point(35, 452);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(110, 43);
			this.btnThem.TabIndex = 12;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.Controls.Add(this.label4);
			this.panel1.Location = new System.Drawing.Point(-8, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(893, 58);
			this.panel1.TabIndex = 51;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(290, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(330, 33);
			this.label4.TabIndex = 0;
			this.label4.Text = "QUẢN LÝ KHỐI LƯỢNG";
			// 
			// KhoiLuong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleTurquoise;
			this.ClientSize = new System.Drawing.Size(876, 581);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnLuu);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.gridviewKhoiluong);
			this.Controls.Add(this.txtMakl);
			this.Controls.Add(this.label1);
			this.Name = "KhoiLuong";
			this.Text = "KhoiLuong";
			this.Load += new System.EventHandler(this.KhoiLuong_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridviewKhoiluong)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Makhoiluong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView gridviewKhoiluong;
        private System.Windows.Forms.TextBox txtMakl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}