namespace hoa_don_nhap
{
    partial class Mau
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.txtTenmau = new System.Windows.Forms.TextBox();
			this.txtMamau = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Tenmau = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Mamau = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gridviewMau = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.gridviewMau)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtTenmau
			// 
			this.txtTenmau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenmau.Location = new System.Drawing.Point(290, 163);
			this.txtTenmau.Name = "txtTenmau";
			this.txtTenmau.Size = new System.Drawing.Size(119, 26);
			this.txtTenmau.TabIndex = 23;
			// 
			// txtMamau
			// 
			this.txtMamau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMamau.Location = new System.Drawing.Point(290, 91);
			this.txtMamau.Name = "txtMamau";
			this.txtMamau.Size = new System.Drawing.Size(119, 26);
			this.txtMamau.TabIndex = 22;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(159, 161);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 24);
			this.label2.TabIndex = 21;
			this.label2.Text = "Tên màu:";
			// 
			// Tenmau
			// 
			this.Tenmau.DataPropertyName = "Tenmau";
			this.Tenmau.HeaderText = "Tên Màu";
			this.Tenmau.MinimumWidth = 6;
			this.Tenmau.Name = "Tenmau";
			this.Tenmau.Width = 125;
			// 
			// Mamau
			// 
			this.Mamau.DataPropertyName = "Mamau";
			this.Mamau.HeaderText = "Mã Màu";
			this.Mamau.MinimumWidth = 6;
			this.Mamau.Name = "Mamau";
			this.Mamau.Width = 125;
			// 
			// gridviewMau
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridviewMau.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.gridviewMau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridviewMau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mamau,
            this.Tenmau});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridviewMau.DefaultCellStyle = dataGridViewCellStyle2;
			this.gridviewMau.Location = new System.Drawing.Point(142, 235);
			this.gridviewMau.Name = "gridviewMau";
			this.gridviewMau.RowHeadersWidth = 51;
			this.gridviewMau.Size = new System.Drawing.Size(302, 157);
			this.gridviewMau.TabIndex = 24;
			this.gridviewMau.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewMau_CellClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(159, 91);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 24);
			this.label1.TabIndex = 20;
			this.label1.Text = "Mã màu:";
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.SystemColors.Window;
			this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnXoa.Image = global::hoa_don_nhap.Properties.Resources.delete__1_;
			this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnXoa.Location = new System.Drawing.Point(534, 445);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(107, 39);
			this.btnXoa.TabIndex = 28;
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
			this.btnThoat.Location = new System.Drawing.Point(681, 447);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(107, 37);
			this.btnThoat.TabIndex = 29;
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
			this.btnLuu.Location = new System.Drawing.Point(194, 446);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(107, 37);
			this.btnLuu.TabIndex = 26;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = false;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.SystemColors.Window;
			this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnThem.Image = global::hoa_don_nhap.Properties.Resources.writing;
			this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThem.Location = new System.Drawing.Point(12, 446);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(107, 40);
			this.btnThem.TabIndex = 25;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnSua
			// 
			this.btnSua.BackColor = System.Drawing.SystemColors.Window;
			this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnSua.Image = global::hoa_don_nhap.Properties.Resources.refresh__1_;
			this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSua.Location = new System.Drawing.Point(377, 445);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(107, 38);
			this.btnSua.TabIndex = 27;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = false;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.Controls.Add(this.label4);
			this.panel1.Location = new System.Drawing.Point(-124, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(923, 58);
			this.panel1.TabIndex = 49;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(428, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(212, 33);
			this.label4.TabIndex = 0;
			this.label4.Text = "QUẢN LÝ MÀU";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// Mau
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleTurquoise;
			this.ClientSize = new System.Drawing.Size(800, 522);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.txtTenmau);
			this.Controls.Add(this.txtMamau);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnLuu);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.gridviewMau);
			this.Controls.Add(this.label1);
			this.Name = "Mau";
			this.Text = "Mau";
			this.Load += new System.EventHandler(this.Mau_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridviewMau)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTenmau;
        private System.Windows.Forms.TextBox txtMamau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenmau;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mamau;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView gridviewMau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}