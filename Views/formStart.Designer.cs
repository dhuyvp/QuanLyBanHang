
namespace QuanLyBanHang
{
    partial class formStart
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rBtn1 = new System.Windows.Forms.RadioButton();
            this.rBtn2 = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.rBtn3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form truy cập hệ thống";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vai trò của bạn là gì";
            // 
            // rBtn1
            // 
            this.rBtn1.AutoSize = true;
            this.rBtn1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtn1.Location = new System.Drawing.Point(426, 98);
            this.rBtn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBtn1.Name = "rBtn1";
            this.rBtn1.Size = new System.Drawing.Size(75, 23);
            this.rBtn1.TabIndex = 2;
            this.rBtn1.TabStop = true;
            this.rBtn1.Text = "Admin";
            this.rBtn1.UseVisualStyleBackColor = true;
            this.rBtn1.CheckedChanged += new System.EventHandler(this.rBtn1_CheckedChanged);
            // 
            // rBtn2
            // 
            this.rBtn2.AutoSize = true;
            this.rBtn2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtn2.Location = new System.Drawing.Point(426, 136);
            this.rBtn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBtn2.Name = "rBtn2";
            this.rBtn2.Size = new System.Drawing.Size(97, 23);
            this.rBtn2.TabIndex = 3;
            this.rBtn2.TabStop = true;
            this.rBtn2.Text = "Nhân viên";
            this.rBtn2.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(426, 227);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(102, 34);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // rBtn3
            // 
            this.rBtn3.AutoSize = true;
            this.rBtn3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtn3.Location = new System.Drawing.Point(426, 174);
            this.rBtn3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBtn3.Name = "rBtn3";
            this.rBtn3.Size = new System.Drawing.Size(108, 23);
            this.rBtn3.TabIndex = 5;
            this.rBtn3.TabStop = true;
            this.rBtn3.Text = "Khách hàng";
            this.rBtn3.UseVisualStyleBackColor = true;
            // 
            // formStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.rBtn3);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.rBtn2);
            this.Controls.Add(this.rBtn1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rBtn1;
        private System.Windows.Forms.RadioButton rBtn2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.RadioButton rBtn3;
    }
}

