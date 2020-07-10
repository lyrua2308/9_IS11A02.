namespace hoa_don_nhap
{
    partial class NuocSX
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
			this.TennuocSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtTenSX = new System.Windows.Forms.TextBox();
			this.ManuocSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtMaSX = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.gridviewSX = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.gridviewSX)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// TennuocSX
			// 
			this.TennuocSX.DataPropertyName = "TennuocSX";
			this.TennuocSX.HeaderText = "Tên Nước Sản Xuất";
			this.TennuocSX.MinimumWidth = 6;
			this.TennuocSX.Name = "TennuocSX";
			this.TennuocSX.Width = 125;
			// 
			// txtTenSX
			// 
			this.txtTenSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenSX.Location = new System.Drawing.Point(388, 190);
			this.txtTenSX.Name = "txtTenSX";
			this.txtTenSX.Size = new System.Drawing.Size(144, 26);
			this.txtTenSX.TabIndex = 33;
			this.txtTenSX.TextChanged += new System.EventHandler(this.txtTenSX_TextChanged);
			// 
			// ManuocSX
			// 
			this.ManuocSX.DataPropertyName = "ManuocSX";
			this.ManuocSX.HeaderText = "Mã Nước Sản Xuất";
			this.ManuocSX.MinimumWidth = 6;
			this.ManuocSX.Name = "ManuocSX";
			this.ManuocSX.Width = 125;
			// 
			// txtMaSX
			// 
			this.txtMaSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaSX.Location = new System.Drawing.Point(388, 117);
			this.txtMaSX.Name = "txtMaSX";
			this.txtMaSX.Size = new System.Drawing.Size(144, 26);
			this.txtMaSX.TabIndex = 32;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(138, 188);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(207, 29);
			this.label2.TabIndex = 31;
			this.label2.Text = "Tên nước sản xuất";
			// 
			// gridviewSX
			// 
			this.gridviewSX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridviewSX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ManuocSX,
            this.TennuocSX});
			this.gridviewSX.Location = new System.Drawing.Point(159, 250);
			this.gridviewSX.Name = "gridviewSX";
			this.gridviewSX.RowHeadersWidth = 51;
			this.gridviewSX.Size = new System.Drawing.Size(382, 216);
			this.gridviewSX.TabIndex = 34;
			this.gridviewSX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewSX_CellClick);
			this.gridviewSX.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewSX_CellContentClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(138, 117);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(197, 29);
			this.label1.TabIndex = 30;
			this.label1.Text = "Mã nước sản xuất";
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.SystemColors.Window;
			this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnXoa.Image = global::hoa_don_nhap.Properties.Resources.delete__1_;
			this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnXoa.Location = new System.Drawing.Point(597, 518);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(105, 45);
			this.btnXoa.TabIndex = 38;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = false;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.BackColor = System.Drawing.SystemColors.Window;
			this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnThoat.Image = global::hoa_don_nhap.Properties.Resources.close__1_;
			this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThoat.Location = new System.Drawing.Point(777, 518);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(105, 47);
			this.btnThoat.TabIndex = 39;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = false;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnLuu
			// 
			this.btnLuu.BackColor = System.Drawing.SystemColors.Window;
			this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnLuu.Image = global::hoa_don_nhap.Properties.Resources.save;
			this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLuu.Location = new System.Drawing.Point(209, 518);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(105, 40);
			this.btnLuu.TabIndex = 36;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = false;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.SystemColors.Window;
			this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnThem.Image = global::hoa_don_nhap.Properties.Resources.writing1;
			this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThem.Location = new System.Drawing.Point(35, 518);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(105, 40);
			this.btnThem.TabIndex = 35;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnSua
			// 
			this.btnSua.BackColor = System.Drawing.SystemColors.Window;
			this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnSua.Image = global::hoa_don_nhap.Properties.Resources.refresh__1_;
			this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSua.Location = new System.Drawing.Point(402, 518);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(105, 44);
			this.btnSua.TabIndex = 37;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = false;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(-58, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1048, 58);
			this.panel1.TabIndex = 47;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(338, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(384, 33);
			this.label3.TabIndex = 0;
			this.label3.Text = "QUẢN LÝ NƯỚC SẢN XUẤT";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// NuocSX
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleTurquoise;
			this.ClientSize = new System.Drawing.Size(932, 604);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.txtTenSX);
			this.Controls.Add(this.txtMaSX);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnLuu);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.gridviewSX);
			this.Controls.Add(this.label1);
			this.Name = "NuocSX";
			this.Text = "NuocSX";
			this.Load += new System.EventHandler(this.NuocSX_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridviewSX)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TennuocSX;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTenSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManuocSX;
        private System.Windows.Forms.TextBox txtMaSX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView gridviewSX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}