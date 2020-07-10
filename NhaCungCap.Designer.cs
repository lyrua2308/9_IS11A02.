namespace hoa_don_nhap
{
    partial class NhaCungCap
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
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mancc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewncc = new System.Windows.Forms.DataGridView();
            this.textBoxdiachi = new System.Windows.Forms.TextBox();
            this.textBoxsodienthoai = new System.Windows.Forms.TextBox();
            this.textboxnhacungcap = new System.Windows.Forms.TextBox();
            this.textBoxmanhacungcap = new System.Windows.Forms.TextBox();
            this.labeldiachi = new System.Windows.Forms.Label();
            this.labelsodienthoai = new System.Windows.Forms.Label();
            this.labeltennhacungcap = new System.Windows.Forms.Label();
            this.labelmanhacungcap = new System.Windows.Forms.Label();
            this.buttonthoat = new System.Windows.Forms.Button();
            this.buttonxoa = new System.Windows.Forms.Button();
            this.buttonsua = new System.Windows.Forms.Button();
            this.buttonthem = new System.Windows.Forms.Button();
            this.buttonluu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewncc)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa Chỉ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.Width = 125;
            // 
            // sodienthoai
            // 
            this.sodienthoai.DataPropertyName = "dienthoai";
            this.sodienthoai.HeaderText = "Số điện thoại";
            this.sodienthoai.MinimumWidth = 6;
            this.sodienthoai.Name = "sodienthoai";
            this.sodienthoai.Width = 125;
            // 
            // tenncc
            // 
            this.tenncc.DataPropertyName = "tenncc";
            this.tenncc.HeaderText = "Tên nhà cung cấp";
            this.tenncc.MinimumWidth = 6;
            this.tenncc.Name = "tenncc";
            this.tenncc.Width = 125;
            // 
            // mancc
            // 
            this.mancc.DataPropertyName = "mancc";
            this.mancc.HeaderText = "Mã nhà cung cấp";
            this.mancc.MinimumWidth = 6;
            this.mancc.Name = "mancc";
            this.mancc.Width = 125;
            // 
            // dataGridViewncc
            // 
            this.dataGridViewncc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewncc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mancc,
            this.tenncc,
            this.sodienthoai,
            this.diachi});
            this.dataGridViewncc.Location = new System.Drawing.Point(254, 252);
            this.dataGridViewncc.Name = "dataGridViewncc";
            this.dataGridViewncc.RowHeadersWidth = 51;
            this.dataGridViewncc.Size = new System.Drawing.Size(443, 150);
            this.dataGridViewncc.TabIndex = 33;
            this.dataGridViewncc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewncc_CellClick_1);
            // 
            // textBoxdiachi
            // 
            this.textBoxdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxdiachi.Location = new System.Drawing.Point(660, 190);
            this.textBoxdiachi.Name = "textBoxdiachi";
            this.textBoxdiachi.Size = new System.Drawing.Size(161, 30);
            this.textBoxdiachi.TabIndex = 32;
            // 
            // textBoxsodienthoai
            // 
            this.textBoxsodienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxsodienthoai.Location = new System.Drawing.Point(660, 131);
            this.textBoxsodienthoai.Name = "textBoxsodienthoai";
            this.textBoxsodienthoai.Size = new System.Drawing.Size(161, 30);
            this.textBoxsodienthoai.TabIndex = 31;
            this.textBoxsodienthoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxsodienthoai_KeyPress);
            // 
            // textboxnhacungcap
            // 
            this.textboxnhacungcap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textboxnhacungcap.Location = new System.Drawing.Point(305, 190);
            this.textboxnhacungcap.Name = "textboxnhacungcap";
            this.textboxnhacungcap.Size = new System.Drawing.Size(161, 30);
            this.textboxnhacungcap.TabIndex = 30;
            // 
            // textBoxmanhacungcap
            // 
            this.textBoxmanhacungcap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxmanhacungcap.Location = new System.Drawing.Point(305, 131);
            this.textBoxmanhacungcap.Name = "textBoxmanhacungcap";
            this.textBoxmanhacungcap.Size = new System.Drawing.Size(161, 30);
            this.textBoxmanhacungcap.TabIndex = 29;
            // 
            // labeldiachi
            // 
            this.labeldiachi.AutoSize = true;
            this.labeldiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labeldiachi.Location = new System.Drawing.Point(504, 193);
            this.labeldiachi.Name = "labeldiachi";
            this.labeldiachi.Size = new System.Drawing.Size(76, 25);
            this.labeldiachi.TabIndex = 28;
            this.labeldiachi.Text = "Địa Chỉ";
            // 
            // labelsodienthoai
            // 
            this.labelsodienthoai.AutoSize = true;
            this.labelsodienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelsodienthoai.Location = new System.Drawing.Point(504, 134);
            this.labelsodienthoai.Name = "labelsodienthoai";
            this.labelsodienthoai.Size = new System.Drawing.Size(137, 25);
            this.labelsodienthoai.TabIndex = 27;
            this.labelsodienthoai.Text = "Số Điện Thoại";
            // 
            // labeltennhacungcap
            // 
            this.labeltennhacungcap.AutoSize = true;
            this.labeltennhacungcap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labeltennhacungcap.Location = new System.Drawing.Point(119, 193);
            this.labeltennhacungcap.Name = "labeltennhacungcap";
            this.labeltennhacungcap.Size = new System.Drawing.Size(183, 25);
            this.labeltennhacungcap.TabIndex = 26;
            this.labeltennhacungcap.Text = "Tên Nhà Cung Cấp";
            // 
            // labelmanhacungcap
            // 
            this.labelmanhacungcap.AutoSize = true;
            this.labelmanhacungcap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelmanhacungcap.Location = new System.Drawing.Point(119, 134);
            this.labelmanhacungcap.Name = "labelmanhacungcap";
            this.labelmanhacungcap.Size = new System.Drawing.Size(176, 25);
            this.labelmanhacungcap.TabIndex = 25;
            this.labelmanhacungcap.Text = "Mã Nhà Cung Cấp";
            // 
            // buttonthoat
            // 
            this.buttonthoat.BackColor = System.Drawing.SystemColors.Window;
            this.buttonthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonthoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonthoat.Image = global::hoa_don_nhap.Properties.Resources.close__1_;
            this.buttonthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonthoat.Location = new System.Drawing.Point(731, 446);
            this.buttonthoat.Name = "buttonthoat";
            this.buttonthoat.Size = new System.Drawing.Size(117, 46);
            this.buttonthoat.TabIndex = 38;
            this.buttonthoat.Text = "Thoát";
            this.buttonthoat.UseVisualStyleBackColor = false;
            this.buttonthoat.Click += new System.EventHandler(this.buttonthoat_Click_1);
            // 
            // buttonxoa
            // 
            this.buttonxoa.BackColor = System.Drawing.SystemColors.Window;
            this.buttonxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonxoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonxoa.Image = global::hoa_don_nhap.Properties.Resources.delete__1_;
            this.buttonxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonxoa.Location = new System.Drawing.Point(401, 444);
            this.buttonxoa.Name = "buttonxoa";
            this.buttonxoa.Size = new System.Drawing.Size(112, 46);
            this.buttonxoa.TabIndex = 36;
            this.buttonxoa.Text = "Xóa";
            this.buttonxoa.UseVisualStyleBackColor = false;
            this.buttonxoa.Click += new System.EventHandler(this.buttonxoa_Click_1);
            // 
            // buttonsua
            // 
            this.buttonsua.BackColor = System.Drawing.SystemColors.Window;
            this.buttonsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonsua.Image = global::hoa_don_nhap.Properties.Resources.refresh__1_;
            this.buttonsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonsua.Location = new System.Drawing.Point(241, 444);
            this.buttonsua.Name = "buttonsua";
            this.buttonsua.Size = new System.Drawing.Size(113, 46);
            this.buttonsua.TabIndex = 35;
            this.buttonsua.Text = "Sửa";
            this.buttonsua.UseVisualStyleBackColor = false;
            this.buttonsua.Click += new System.EventHandler(this.buttonsua_Click_1);
            // 
            // buttonthem
            // 
            this.buttonthem.BackColor = System.Drawing.SystemColors.Window;
            this.buttonthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonthem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonthem.Image = global::hoa_don_nhap.Properties.Resources.writing;
            this.buttonthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonthem.Location = new System.Drawing.Point(71, 444);
            this.buttonthem.Name = "buttonthem";
            this.buttonthem.Size = new System.Drawing.Size(117, 46);
            this.buttonthem.TabIndex = 34;
            this.buttonthem.Text = "Thêm";
            this.buttonthem.UseVisualStyleBackColor = false;
            this.buttonthem.Click += new System.EventHandler(this.buttonthem_Click_1);
            // 
            // buttonluu
            // 
            this.buttonluu.BackColor = System.Drawing.SystemColors.Window;
            this.buttonluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonluu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonluu.Image = global::hoa_don_nhap.Properties.Resources.save;
            this.buttonluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonluu.Location = new System.Drawing.Point(566, 446);
            this.buttonluu.Name = "buttonluu";
            this.buttonluu.Size = new System.Drawing.Size(105, 44);
            this.buttonluu.TabIndex = 37;
            this.buttonluu.Text = "Lưu";
            this.buttonluu.UseVisualStyleBackColor = false;
            this.buttonluu.Click += new System.EventHandler(this.buttonluu_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-54, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 58);
            this.panel1.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(329, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(362, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "QUẢN LÝ NHÀ CUNG CẤP";
            // 
            // NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(943, 526);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonthoat);
            this.Controls.Add(this.buttonxoa);
            this.Controls.Add(this.buttonsua);
            this.Controls.Add(this.buttonthem);
            this.Controls.Add(this.buttonluu);
            this.Controls.Add(this.dataGridViewncc);
            this.Controls.Add(this.textBoxdiachi);
            this.Controls.Add(this.textBoxsodienthoai);
            this.Controls.Add(this.textboxnhacungcap);
            this.Controls.Add(this.textBoxmanhacungcap);
            this.Controls.Add(this.labeldiachi);
            this.Controls.Add(this.labelsodienthoai);
            this.Controls.Add(this.labeltennhacungcap);
            this.Controls.Add(this.labelmanhacungcap);
            this.Name = "NhaCungCap";
            this.Text = "NhaCungCap";
            this.Load += new System.EventHandler(this.NhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewncc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonthoat;
        private System.Windows.Forms.Button buttonxoa;
        private System.Windows.Forms.Button buttonsua;
        private System.Windows.Forms.Button buttonthem;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn mancc;
        private System.Windows.Forms.Button buttonluu;
        private System.Windows.Forms.DataGridView dataGridViewncc;
        private System.Windows.Forms.TextBox textBoxdiachi;
        private System.Windows.Forms.TextBox textBoxsodienthoai;
        private System.Windows.Forms.TextBox textboxnhacungcap;
        private System.Windows.Forms.TextBox textBoxmanhacungcap;
        private System.Windows.Forms.Label labeldiachi;
        private System.Windows.Forms.Label labelsodienthoai;
        private System.Windows.Forms.Label labeltennhacungcap;
        private System.Windows.Forms.Label labelmanhacungcap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}