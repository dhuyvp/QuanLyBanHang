namespace QuanLyBanHang.Views
{
    partial class uctQuanLyKho
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
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTaiChinh = new System.Windows.Forms.TextBox();
            this.dgvDSKho = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDKhoQuanLy = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grQLNhanVien = new System.Windows.Forms.GroupBox();
            this.cmbDiaChi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKho)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grQLNhanVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(516, 154);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(93, 29);
            this.btnLuu.TabIndex = 36;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(384, 154);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 29);
            this.btnXoa.TabIndex = 35;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(260, 154);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(93, 29);
            this.btnSua.TabIndex = 34;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(142, 154);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 29);
            this.btnThem.TabIndex = 33;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(540, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 26);
            this.label2.TabIndex = 32;
            this.label2.Text = "DANH SÁCH KHO HÀNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(549, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 26);
            this.label1.TabIndex = 31;
            this.label1.Text = "QUẢN LÝ KHO HÀNG";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(442, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 23);
            this.label10.TabIndex = 9;
            this.label10.Text = "Quỹ tiền(VNĐ):";
            // 
            // txtTaiChinh
            // 
            this.txtTaiChinh.Location = new System.Drawing.Point(578, 26);
            this.txtTaiChinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTaiChinh.Name = "txtTaiChinh";
            this.txtTaiChinh.Size = new System.Drawing.Size(200, 31);
            this.txtTaiChinh.TabIndex = 8;
            // 
            // dgvDSKho
            // 
            this.dgvDSKho.AllowUserToAddRows = false;
            this.dgvDSKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSKho.Location = new System.Drawing.Point(3, 26);
            this.dgvDSKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSKho.Name = "dgvDSKho";
            this.dgvDSKho.RowHeadersWidth = 62;
            this.dgvDSKho.RowTemplate.Height = 28;
            this.dgvDSKho.Size = new System.Drawing.Size(1064, 268);
            this.dgvDSKho.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID kho hàng:";
            // 
            // txtIDKhoQuanLy
            // 
            this.txtIDKhoQuanLy.Location = new System.Drawing.Point(195, 26);
            this.txtIDKhoQuanLy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDKhoQuanLy.Name = "txtIDKhoQuanLy";
            this.txtIDKhoQuanLy.Size = new System.Drawing.Size(200, 31);
            this.txtIDKhoQuanLy.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(646, 154);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(93, 29);
            this.btnHuy.TabIndex = 37;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSKho);
            this.groupBox1.Location = new System.Drawing.Point(97, 300);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1070, 296);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // grQLNhanVien
            // 
            this.grQLNhanVien.Controls.Add(this.cmbDiaChi);
            this.grQLNhanVien.Controls.Add(this.btnLuu);
            this.grQLNhanVien.Controls.Add(this.label4);
            this.grQLNhanVien.Controls.Add(this.btnXoa);
            this.grQLNhanVien.Controls.Add(this.btnSua);
            this.grQLNhanVien.Controls.Add(this.label10);
            this.grQLNhanVien.Controls.Add(this.btnThem);
            this.grQLNhanVien.Controls.Add(this.txtTaiChinh);
            this.grQLNhanVien.Controls.Add(this.label3);
            this.grQLNhanVien.Controls.Add(this.btnHuy);
            this.grQLNhanVien.Controls.Add(this.txtIDKhoQuanLy);
            this.grQLNhanVien.Location = new System.Drawing.Point(199, 44);
            this.grQLNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grQLNhanVien.Name = "grQLNhanVien";
            this.grQLNhanVien.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grQLNhanVien.Size = new System.Drawing.Size(879, 226);
            this.grQLNhanVien.TabIndex = 29;
            this.grQLNhanVien.TabStop = false;
            // 
            // cmbDiaChi
            // 
            this.cmbDiaChi.FormattingEnabled = true;
            this.cmbDiaChi.Items.AddRange(new object[] {
            "An Giang",
            "Bà Rịa-Vũng Tàu",
            "Bạc Liêu",
            "Bắc Kạn",
            "Bắc Giang",
            "Bắc Ninh",
            "Bến Tre",
            "Bình Dương",
            "Bình Định",
            "Bình Phước",
            "Bình Thuận",
            "Cà Mau",
            "Cao Bằng",
            "Cần Thơ ",
            "Đà Nẵng ",
            "Đắk Lắk",
            "Đắk Nông",
            "Điện Biên",
            "Đồng Nai",
            "Đồng Tháp",
            "Gia Lai",
            "Hà Giang",
            "Hà Nam",
            "Hà Nội ",
            "Hà Tây",
            "Hà Tĩnh",
            "Hải Dương",
            "Hải Phòng ",
            "Hòa Bình",
            "Hồ Chí Minh ",
            "Hậu Giang",
            "Hưng Yên",
            "Khánh Hòa",
            "Kiên Giang",
            "Kon Tum",
            "Lai Châu",
            "Lào Cai",
            "Lạng Sơn",
            "Lâm Đồng",
            "Long An",
            "Nam Định",
            "Nghệ An",
            "Ninh Bình",
            "Ninh Thuận",
            "Phú Thọ",
            "Phú Yên",
            "Quảng Bình",
            "Quảng Nam",
            "Quảng Ngãi",
            "Quảng Ninh",
            "Quảng Trị",
            "Sóc Trăng",
            "Sơn La",
            "Tây Ninh",
            "Thái Bình",
            "Thái Nguyên",
            "Thanh Hóa",
            "Thừa Thiên – Huế",
            "Tiền Giang",
            "Trà Vinh",
            "Tuyên Quang",
            "Vĩnh Long",
            "Vĩnh Phúc",
            "Yên Bái"});
            this.cmbDiaChi.Location = new System.Drawing.Point(195, 82);
            this.cmbDiaChi.Name = "cmbDiaChi";
            this.cmbDiaChi.Size = new System.Drawing.Size(200, 30);
            this.cmbDiaChi.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Địa chỉ:";
            // 
            // uctQuanLyKho
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::QuanLyBanHang.Properties.Resources.admin_background;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grQLNhanVien);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uctQuanLyKho";
            this.Size = new System.Drawing.Size(1491, 743);
            this.Load += new System.EventHandler(this.uctQuanLyKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKho)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.grQLNhanVien.ResumeLayout(false);
            this.grQLNhanVien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTaiChinh;
        private System.Windows.Forms.DataGridView dgvDSKho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDKhoQuanLy;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grQLNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDiaChi;
    }
}
