namespace QuanLyBanHang.Views
{
    partial class uctMuaHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbIDKho = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachHangDeMua = new System.Windows.Forms.DataGridView();
            this.btnOKThem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHangDeMua)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vui lòng chọn kho để xem thông tin hàng hóa";
            // 
            // cmbIDKho
            // 
            this.cmbIDKho.FormattingEnabled = true;
            this.cmbIDKho.Location = new System.Drawing.Point(464, 13);
            this.cmbIDKho.Name = "cmbIDKho";
            this.cmbIDKho.Size = new System.Drawing.Size(121, 27);
            this.cmbIDKho.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbIDKho);
            this.panel1.Location = new System.Drawing.Point(230, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 54);
            this.panel1.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(623, 8);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 35);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "Xem";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(585, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "DANH SÁCH HÀNG HÓA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhSachHangDeMua);
            this.groupBox1.Location = new System.Drawing.Point(230, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1007, 461);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // dgvDanhSachHangDeMua
            // 
            this.dgvDanhSachHangDeMua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachHangDeMua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHangDeMua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachHangDeMua.Location = new System.Drawing.Point(3, 23);
            this.dgvDanhSachHangDeMua.Name = "dgvDanhSachHangDeMua";
            this.dgvDanhSachHangDeMua.RowHeadersWidth = 51;
            this.dgvDanhSachHangDeMua.RowTemplate.Height = 24;
            this.dgvDanhSachHangDeMua.Size = new System.Drawing.Size(1001, 435);
            this.dgvDanhSachHangDeMua.TabIndex = 0;
            // 
            // btnOKThem
            // 
            this.btnOKThem.Location = new System.Drawing.Point(664, 663);
            this.btnOKThem.Name = "btnOKThem";
            this.btnOKThem.Size = new System.Drawing.Size(151, 32);
            this.btnOKThem.TabIndex = 6;
            this.btnOKThem.Text = "Thêm vào giỏ hàng";
            this.btnOKThem.UseVisualStyleBackColor = true;
            this.btnOKThem.Click += new System.EventHandler(this.btnOKThem_Click);
            // 
            // uctMuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOKThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uctMuaHang";
            this.Size = new System.Drawing.Size(1458, 720);
            this.Load += new System.EventHandler(this.uctMuaHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHangDeMua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbIDKho;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDanhSachHangDeMua;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnOKThem;
    }
}
