namespace QuanLyBanHang.Views
{
    partial class uctGioHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.btnOKXoa = new System.Windows.Forms.Button();
            this.btnOKMua = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(480, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH HÀNG TRONG GIỎ HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvGioHang);
            this.groupBox1.Location = new System.Drawing.Point(247, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(927, 400);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGioHang.Location = new System.Drawing.Point(3, 23);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.RowHeadersWidth = 51;
            this.dgvGioHang.RowTemplate.Height = 24;
            this.dgvGioHang.Size = new System.Drawing.Size(921, 374);
            this.dgvGioHang.TabIndex = 0;
            // 
            // btnOKXoa
            // 
            this.btnOKXoa.Location = new System.Drawing.Point(564, 527);
            this.btnOKXoa.Name = "btnOKXoa";
            this.btnOKXoa.Size = new System.Drawing.Size(184, 43);
            this.btnOKXoa.TabIndex = 2;
            this.btnOKXoa.Text = "Xóa khỏi giỏ hàng";
            this.btnOKXoa.UseVisualStyleBackColor = true;
            this.btnOKXoa.Click += new System.EventHandler(this.btnOKXoa_Click);
            // 
            // btnOKMua
            // 
            this.btnOKMua.Location = new System.Drawing.Point(1064, 527);
            this.btnOKMua.Name = "btnOKMua";
            this.btnOKMua.Size = new System.Drawing.Size(107, 43);
            this.btnOKMua.TabIndex = 2;
            this.btnOKMua.Text = "Mua";
            this.btnOKMua.UseVisualStyleBackColor = true;
            this.btnOKMua.Click += new System.EventHandler(this.btnOKMua_Click);
            // 
            // uctGioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOKMua);
            this.Controls.Add(this.btnOKXoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "uctGioHang";
            this.Size = new System.Drawing.Size(1401, 652);
            this.Load += new System.EventHandler(this.uctGioHang_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.Button btnOKXoa;
        private System.Windows.Forms.Button btnOKMua;
    }
}
