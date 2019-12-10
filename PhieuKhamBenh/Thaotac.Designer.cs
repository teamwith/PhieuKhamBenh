namespace PhieuKhamBenh
{
    partial class Thaotac
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
            this.btnTaophieumoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Xemdanhsach = new System.Windows.Forms.Button();
            this.Quaylai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTaophieumoi
            // 
            this.btnTaophieumoi.Location = new System.Drawing.Point(257, 175);
            this.btnTaophieumoi.Name = "btnTaophieumoi";
            this.btnTaophieumoi.Size = new System.Drawing.Size(177, 58);
            this.btnTaophieumoi.TabIndex = 0;
            this.btnTaophieumoi.Text = "Tạo  Phiếu Mới ";
            this.btnTaophieumoi.UseVisualStyleBackColor = true;
            this.btnTaophieumoi.Click += new System.EventHandler(this.BtnTaophieumoi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome!!!";
            // 
            // Xemdanhsach
            // 
            this.Xemdanhsach.Location = new System.Drawing.Point(12, 175);
            this.Xemdanhsach.Name = "Xemdanhsach";
            this.Xemdanhsach.Size = new System.Drawing.Size(177, 58);
            this.Xemdanhsach.TabIndex = 2;
            this.Xemdanhsach.Text = "Xem danh sách";
            this.Xemdanhsach.UseVisualStyleBackColor = true;
            this.Xemdanhsach.Click += new System.EventHandler(this.button1_Click);
            // 
            // Quaylai
            // 
            this.Quaylai.Location = new System.Drawing.Point(135, 267);
            this.Quaylai.Name = "Quaylai";
            this.Quaylai.Size = new System.Drawing.Size(177, 58);
            this.Quaylai.TabIndex = 3;
            this.Quaylai.Text = "Quay lại";
            this.Quaylai.UseVisualStyleBackColor = true;
            this.Quaylai.Click += new System.EventHandler(this.Quaylai_Click);
            // 
            // Thaotac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 337);
            this.Controls.Add(this.Quaylai);
            this.Controls.Add(this.Xemdanhsach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTaophieumoi);
            this.MaximizeBox = false;
            this.Name = "Thaotac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thao Tác";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTaophieumoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Xemdanhsach;
        private System.Windows.Forms.Button Quaylai;
    }
}