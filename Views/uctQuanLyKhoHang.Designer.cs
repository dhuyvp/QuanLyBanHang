namespace QuanLyBanHang.Views
{
    partial class uctQuanLyKhoHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpNgaySanXuat = new System.Windows.Forms.DateTimePicker();
            this.txtKhoQuanLy = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.dtpHanSD = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenHangHoa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaHangHoa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSHangHoa = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtIDHangHoa = new System.Windows.Forms.TextBox();
            this.grQLNhanVien = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHangHoa)).BeginInit();
            this.grQLNhanVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpNgaySanXuat
            // 
            this.dtpNgaySanXuat.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpNgaySanXuat.CalendarTitleForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtpNgaySanXuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySanXuat.Location = new System.Drawing.Point(615, 57);
            this.dtpNgaySanXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgaySanXuat.Name = "dtpNgaySanXuat";
            this.dtpNgaySanXuat.Size = new System.Drawing.Size(140, 27);
            this.dtpNgaySanXuat.TabIndex = 18;
            // 
            // txtKhoQuanLy
            // 
            this.txtKhoQuanLy.Location = new System.Drawing.Point(117, 54);
            this.txtKhoQuanLy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKhoQuanLy.Name = "txtKhoQuanLy";
            this.txtKhoQuanLy.Size = new System.Drawing.Size(200, 27);
            this.txtKhoQuanLy.TabIndex = 2;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(964, 210);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(93, 29);
            this.btnHuy.TabIndex = 39;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // dtpHanSD
            // 
            this.dtpHanSD.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpHanSD.CalendarTitleForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtpHanSD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHanSD.Location = new System.Drawing.Point(615, 87);
            this.dtpHanSD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpHanSD.Name = "dtpHanSD";
            this.dtpHanSD.Size = new System.Drawing.Size(140, 27);
            this.dtpHanSD.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tên hàng hóa:";
            // 
            // txtTenHangHoa
            // 
            this.txtTenHangHoa.Location = new System.Drawing.Point(117, 112);
            this.txtTenHangHoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenHangHoa.Name = "txtTenHangHoa";
            this.txtTenHangHoa.Size = new System.Drawing.Size(200, 27);
            this.txtTenHangHoa.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mã hàng hóa:";
            // 
            // txtMaHangHoa
            // 
            this.txtMaHangHoa.Location = new System.Drawing.Point(117, 82);
            this.txtMaHangHoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaHangHoa.Name = "txtMaHangHoa";
            this.txtMaHangHoa.Size = new System.Drawing.Size(200, 27);
            this.txtMaHangHoa.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kho quản lý:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(493, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "Hạn sử dụng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID hàng hóa:";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(578, 210);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(93, 29);
            this.btnSua.TabIndex = 36;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(461, 210);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 29);
            this.btnThem.TabIndex = 35;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(606, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 23);
            this.label2.TabIndex = 34;
            this.label2.Text = "DANH SÁCH HÀNG TRONG KHO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(636, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "QUẢN LÝ KHO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSHangHoa);
            this.groupBox1.Location = new System.Drawing.Point(190, 293);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1105, 397);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // dgvDSHangHoa
            // 
            this.dgvDSHangHoa.AllowUserToAddRows = false;
            this.dgvDSHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSHangHoa.Location = new System.Drawing.Point(3, 22);
            this.dgvDSHangHoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSHangHoa.Name = "dgvDSHangHoa";
            this.dgvDSHangHoa.RowHeadersWidth = 62;
            this.dgvDSHangHoa.RowTemplate.Height = 28;
            this.dgvDSHangHoa.Size = new System.Drawing.Size(1099, 373);
            this.dgvDSHangHoa.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(493, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ngày sản xuất:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(493, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Giá tiền";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(615, 26);
            this.txtGiaTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(200, 27);
            this.txtGiaTien.TabIndex = 0;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(834, 210);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(93, 29);
            this.btnLuu.TabIndex = 38;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(702, 210);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 29);
            this.btnXoa.TabIndex = 37;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtIDHangHoa
            // 
            this.txtIDHangHoa.Location = new System.Drawing.Point(117, 26);
            this.txtIDHangHoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDHangHoa.Name = "txtIDHangHoa";
            this.txtIDHangHoa.Size = new System.Drawing.Size(200, 27);
            this.txtIDHangHoa.TabIndex = 0;
            // 
            // grQLNhanVien
            // 
            this.grQLNhanVien.Controls.Add(this.dtpHanSD);
            this.grQLNhanVien.Controls.Add(this.dtpNgaySanXuat);
            this.grQLNhanVien.Controls.Add(this.label6);
            this.grQLNhanVien.Controls.Add(this.txtTenHangHoa);
            this.grQLNhanVien.Controls.Add(this.label5);
            this.grQLNhanVien.Controls.Add(this.txtMaHangHoa);
            this.grQLNhanVien.Controls.Add(this.label4);
            this.grQLNhanVien.Controls.Add(this.txtKhoQuanLy);
            this.grQLNhanVien.Controls.Add(this.label9);
            this.grQLNhanVien.Controls.Add(this.label8);
            this.grQLNhanVien.Controls.Add(this.label7);
            this.grQLNhanVien.Controls.Add(this.label3);
            this.grQLNhanVien.Controls.Add(this.txtGiaTien);
            this.grQLNhanVien.Controls.Add(this.txtIDHangHoa);
            this.grQLNhanVien.Location = new System.Drawing.Point(320, 42);
            this.grQLNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grQLNhanVien.Name = "grQLNhanVien";
            this.grQLNhanVien.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grQLNhanVien.Size = new System.Drawing.Size(879, 152);
            this.grQLNhanVien.TabIndex = 31;
            this.grQLNhanVien.TabStop = false;
            // 
            // uctQuanLyKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.grQLNhanVien);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uctQuanLyKhoHang";
            this.Size = new System.Drawing.Size(1475, 679);
            this.Load += new System.EventHandler(this.uctQuanLyNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHangHoa)).EndInit();
            this.grQLNhanVien.ResumeLayout(false);
            this.grQLNhanVien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgaySanXuat;
        private System.Windows.Forms.TextBox txtKhoQuanLy;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DateTimePicker dtpHanSD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenHangHoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaHangHoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSHangHoa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtIDHangHoa;
        private System.Windows.Forms.GroupBox grQLNhanVien;
    }
}
