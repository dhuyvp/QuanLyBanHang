namespace QuanLyBanHang.Views
{
    partial class uctThongKeKhachHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvThongKeKhachHang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvThongKeKhachHang);
            this.groupBox1.Location = new System.Drawing.Point(44, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1173, 444);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dgvThongKeKhachHang
            // 
            this.dgvThongKeKhachHang.AllowUserToAddRows = false;
            this.dgvThongKeKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKeKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKeKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongKeKhachHang.Location = new System.Drawing.Point(3, 27);
            this.dgvThongKeKhachHang.Name = "dgvThongKeKhachHang";
            this.dgvThongKeKhachHang.RowHeadersWidth = 51;
            this.dgvThongKeKhachHang.RowTemplate.Height = 24;
            this.dgvThongKeKhachHang.Size = new System.Drawing.Size(1167, 414);
            this.dgvThongKeKhachHang.TabIndex = 0;
            this.dgvThongKeKhachHang.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvThongKeKhachHang_RowPrePaint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(565, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thống kê khách hàng";
            // 
            // uctThongKeKhachHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::QuanLyBanHang.Properties.Resources.NV_background;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uctThongKeKhachHang";
            this.Size = new System.Drawing.Size(1467, 734);
            this.Load += new System.EventHandler(this.uctThongKeKhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvThongKeKhachHang;
        private System.Windows.Forms.Label label1;
    }
}
