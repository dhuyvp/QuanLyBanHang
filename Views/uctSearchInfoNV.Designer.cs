
namespace QuanLyBanHang.Views
{
    partial class uctSearchInforNV
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
            this.btnFind = new System.Windows.Forms.Button();
            this.txBFind = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSNhanVien = new System.Windows.Forms.DataGridView();
            this.cmbFind = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(667, 201);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(124, 38);
            this.btnFind.TabIndex = 31;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txBFind
            // 
            this.txBFind.Location = new System.Drawing.Point(397, 142);
            this.txBFind.Name = "txBFind";
            this.txBFind.Size = new System.Drawing.Size(371, 26);
            this.txBFind.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(195, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 22);
            this.label3.TabIndex = 29;
            this.label3.Text = "Nội dung tìm kiếm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSNhanVien);
            this.groupBox1.Location = new System.Drawing.Point(111, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1184, 311);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // dgvDSNhanVien
            // 
            this.dgvDSNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNhanVien.ColumnHeadersVisible = false;
            this.dgvDSNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSNhanVien.Location = new System.Drawing.Point(3, 22);
            this.dgvDSNhanVien.Name = "dgvDSNhanVien";
            this.dgvDSNhanVien.RowHeadersWidth = 62;
            this.dgvDSNhanVien.RowTemplate.Height = 28;
            this.dgvDSNhanVien.Size = new System.Drawing.Size(1178, 286);
            this.dgvDSNhanVien.TabIndex = 0;
            // 
            // cmbFind
            // 
            this.cmbFind.FormattingEnabled = true;
            this.cmbFind.Location = new System.Drawing.Point(397, 76);
            this.cmbFind.Name = "cmbFind";
            this.cmbFind.Size = new System.Drawing.Size(280, 28);
            this.cmbFind.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tìm kiếm theo mục";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(562, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 26);
            this.label1.TabIndex = 25;
            this.label1.Text = "TÌM KIẾM THÔNG TIN NHÂN VIÊN";
            // 
            // uctSearchInforNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanHang.Properties.Resources.admin_background;
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txBFind);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "uctSearchInforNV";
            this.Size = new System.Drawing.Size(1152, 604);
            this.Load += new System.EventHandler(this.uctSearchInforNV_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txBFind;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSNhanVien;
        private System.Windows.Forms.ComboBox cmbFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
