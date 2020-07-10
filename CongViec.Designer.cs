namespace hoa_don_nhap
{
    partial class CongViec
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
            this.dataGridViewcv = new System.Windows.Forms.DataGridView();
            this.macv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tencv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxtencv = new System.Windows.Forms.TextBox();
            this.textBoxmacv = new System.Windows.Forms.TextBox();
            this.labeltencv = new System.Windows.Forms.Label();
            this.labelmacv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonthoat = new System.Windows.Forms.Button();
            this.buttonluu = new System.Windows.Forms.Button();
            this.buttonxoa = new System.Windows.Forms.Button();
            this.buttonsua = new System.Windows.Forms.Button();
            this.buttonthem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewcv
            // 
            this.dataGridViewcv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewcv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.macv,
            this.tencv});
            this.dataGridViewcv.Location = new System.Drawing.Point(254, 217);
            this.dataGridViewcv.Name = "dataGridViewcv";
            this.dataGridViewcv.RowHeadersWidth = 51;
            this.dataGridViewcv.Size = new System.Drawing.Size(382, 227);
            this.dataGridViewcv.TabIndex = 41;
            this.dataGridViewcv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewcv_CellClick);
            // 
            // macv
            // 
            this.macv.DataPropertyName = "macv";
            this.macv.HeaderText = "Mã công việc";
            this.macv.MinimumWidth = 6;
            this.macv.Name = "macv";
            this.macv.Width = 125;
            // 
            // tencv
            // 
            this.tencv.DataPropertyName = "tencv";
            this.tencv.HeaderText = "Tên công việc";
            this.tencv.MinimumWidth = 6;
            this.tencv.Name = "tencv";
            this.tencv.Width = 125;
            // 
            // textBoxtencv
            // 
            this.textBoxtencv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxtencv.Location = new System.Drawing.Point(675, 123);
            this.textBoxtencv.Name = "textBoxtencv";
            this.textBoxtencv.Size = new System.Drawing.Size(142, 30);
            this.textBoxtencv.TabIndex = 40;
            // 
            // textBoxmacv
            // 
            this.textBoxmacv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxmacv.Location = new System.Drawing.Point(200, 128);
            this.textBoxmacv.Name = "textBoxmacv";
            this.textBoxmacv.Size = new System.Drawing.Size(142, 30);
            this.textBoxmacv.TabIndex = 39;
            // 
            // labeltencv
            // 
            this.labeltencv.AutoSize = true;
            this.labeltencv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labeltencv.Location = new System.Drawing.Point(471, 126);
            this.labeltencv.Name = "labeltencv";
            this.labeltencv.Size = new System.Drawing.Size(135, 25);
            this.labeltencv.TabIndex = 38;
            this.labeltencv.Text = "Tên công việc";
            // 
            // labelmacv
            // 
            this.labelmacv.AutoSize = true;
            this.labelmacv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelmacv.Location = new System.Drawing.Point(43, 128);
            this.labelmacv.Name = "labelmacv";
            this.labelmacv.Size = new System.Drawing.Size(128, 25);
            this.labelmacv.TabIndex = 37;
            this.labelmacv.Text = "Mã công việc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(335, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "QUẢN LÝ CÔNG VIỆC";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonthoat
            // 
            this.buttonthoat.BackColor = System.Drawing.SystemColors.Window;
            this.buttonthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonthoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonthoat.Image = global::hoa_don_nhap.Properties.Resources.close__1_;
            this.buttonthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonthoat.Location = new System.Drawing.Point(776, 480);
            this.buttonthoat.Name = "buttonthoat";
            this.buttonthoat.Size = new System.Drawing.Size(124, 42);
            this.buttonthoat.TabIndex = 36;
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
            this.buttonluu.Location = new System.Drawing.Point(598, 483);
            this.buttonluu.Name = "buttonluu";
            this.buttonluu.Size = new System.Drawing.Size(134, 41);
            this.buttonluu.TabIndex = 35;
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
            this.buttonxoa.Location = new System.Drawing.Point(413, 480);
            this.buttonxoa.Name = "buttonxoa";
            this.buttonxoa.Size = new System.Drawing.Size(139, 44);
            this.buttonxoa.TabIndex = 34;
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
            this.buttonsua.Location = new System.Drawing.Point(221, 480);
            this.buttonsua.Name = "buttonsua";
            this.buttonsua.Size = new System.Drawing.Size(139, 44);
            this.buttonsua.TabIndex = 33;
            this.buttonsua.Text = "Sửa";
            this.buttonsua.UseVisualStyleBackColor = false;
            this.buttonsua.Click += new System.EventHandler(this.buttonsua_Click);
            // 
            // buttonthem
            // 
            this.buttonthem.BackColor = System.Drawing.SystemColors.Window;
            this.buttonthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonthem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonthem.Image = global::hoa_don_nhap.Properties.Resources.writing1;
            this.buttonthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonthem.Location = new System.Drawing.Point(32, 480);
            this.buttonthem.Name = "buttonthem";
            this.buttonthem.Size = new System.Drawing.Size(139, 44);
            this.buttonthem.TabIndex = 32;
            this.buttonthem.Text = "Thêm";
            this.buttonthem.UseVisualStyleBackColor = false;
            this.buttonthem.Click += new System.EventHandler(this.buttonthem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 69);
            this.panel1.TabIndex = 42;
            // 
            // CongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(912, 584);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewcv);
            this.Controls.Add(this.textBoxtencv);
            this.Controls.Add(this.textBoxmacv);
            this.Controls.Add(this.labeltencv);
            this.Controls.Add(this.labelmacv);
            this.Controls.Add(this.buttonthoat);
            this.Controls.Add(this.buttonluu);
            this.Controls.Add(this.buttonxoa);
            this.Controls.Add(this.buttonsua);
            this.Controls.Add(this.buttonthem);
            this.Name = "CongViec";
            this.Text = "CongViec";
            this.Load += new System.EventHandler(this.CongViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewcv;
        private System.Windows.Forms.DataGridViewTextBoxColumn macv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tencv;
        private System.Windows.Forms.TextBox textBoxtencv;
        private System.Windows.Forms.TextBox textBoxmacv;
        private System.Windows.Forms.Label labeltencv;
        private System.Windows.Forms.Label labelmacv;
        private System.Windows.Forms.Button buttonthoat;
        private System.Windows.Forms.Button buttonluu;
        private System.Windows.Forms.Button buttonxoa;
        private System.Windows.Forms.Button buttonsua;
        private System.Windows.Forms.Button buttonthem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}