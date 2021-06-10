namespace ChuanDoanBenh
{
    partial class TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_BatDau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(790, 506);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Image = global::ChuanDoanBenh.Properties.Resources.hinh3;
            this.label2.Location = new System.Drawing.Point(50, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(690, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "CHUẨN ĐOÁN BÊNH VIÊM PHẾ QUẢNG";
            // 
            // btn_BatDau
            // 
            this.btn_BatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BatDau.ForeColor = System.Drawing.Color.SpringGreen;
            this.btn_BatDau.Image = ((System.Drawing.Image)(resources.GetObject("btn_BatDau.Image")));
            this.btn_BatDau.Location = new System.Drawing.Point(336, 301);
            this.btn_BatDau.Name = "btn_BatDau";
            this.btn_BatDau.Size = new System.Drawing.Size(159, 62);
            this.btn_BatDau.TabIndex = 2;
            this.btn_BatDau.Text = "Bắt Đầu";
            this.btn_BatDau.UseVisualStyleBackColor = true;
            this.btn_BatDau.Click += new System.EventHandler(this.btn_BatDau_Click);
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 506);
            this.Controls.Add(this.btn_BatDau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TrangChu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_BatDau;

    }
}

