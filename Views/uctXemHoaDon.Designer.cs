namespace QuanLyBanHang.Views
{
    partial class uctXemHoaDon
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMaHoaDon = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachHangTrongHoaDon = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHangTrongHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(538, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "DANH SÁCH HÀNG HÓA";
            // 
            // cmbMaHoaDon
            // 
            this.cmbMaHoaDon.FormattingEnabled = true;
            this.cmbMaHoaDon.Location = new System.Drawing.Point(501, 13);
            this.cmbMaHoaDon.Name = "cmbMaHoaDon";
            this.cmbMaHoaDon.Size = new System.Drawing.Size(183, 27);
            this.cmbMaHoaDon.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbMaHoaDon);
            this.panel1.Location = new System.Drawing.Point(183, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 54);
            this.panel1.TabIndex = 7;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(704, 8);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 35);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "Xem";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vui lòng chọn mã hóa đơn mà bạn muốn kiểm tra";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhSachHangTrongHoaDon);
            this.groupBox1.Location = new System.Drawing.Point(183, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1007, 461);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // dgvDanhSachHangTrongHoaDon
            // 
            this.dgvDanhSachHangTrongHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachHangTrongHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHangTrongHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachHangTrongHoaDon.Location = new System.Drawing.Point(3, 23);
            this.dgvDanhSachHangTrongHoaDon.Name = "dgvDanhSachHangTrongHoaDon";
            this.dgvDanhSachHangTrongHoaDon.RowHeadersWidth = 51;
            this.dgvDanhSachHangTrongHoaDon.RowTemplate.Height = 24;
            this.dgvDanhSachHangTrongHoaDon.Size = new System.Drawing.Size(1001, 435);
            this.dgvDanhSachHangTrongHoaDon.TabIndex = 0;
            // 
            // uctXemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uctXemHoaDon";
            this.Size = new System.Drawing.Size(1373, 668);
            this.Load += new System.EventHandler(this.uctXemHoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHangTrongHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMaHoaDon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDanhSachHangTrongHoaDon;
    }
}
