namespace QuanLyCuaHang
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.btSanPham = new System.Windows.Forms.Button();
            this.btKhachHang = new System.Windows.Forms.Button();
            this.btDonHang = new System.Windows.Forms.Button();
            this.btNCC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSanPham
            // 
            this.btSanPham.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSanPham.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSanPham.Location = new System.Drawing.Point(51, 25);
            this.btSanPham.Name = "btSanPham";
            this.btSanPham.Size = new System.Drawing.Size(152, 38);
            this.btSanPham.TabIndex = 0;
            this.btSanPham.Text = "Sản phẩm";
            this.btSanPham.UseVisualStyleBackColor = false;
            this.btSanPham.Click += new System.EventHandler(this.btSanPham_Click);
            // 
            // btKhachHang
            // 
            this.btKhachHang.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKhachHang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btKhachHang.Location = new System.Drawing.Point(239, 25);
            this.btKhachHang.Name = "btKhachHang";
            this.btKhachHang.Size = new System.Drawing.Size(152, 38);
            this.btKhachHang.TabIndex = 1;
            this.btKhachHang.Text = "Khách hàng";
            this.btKhachHang.UseVisualStyleBackColor = false;
            this.btKhachHang.Click += new System.EventHandler(this.btKhachHang_Click);
            // 
            // btDonHang
            // 
            this.btDonHang.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDonHang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btDonHang.Location = new System.Drawing.Point(429, 25);
            this.btDonHang.Name = "btDonHang";
            this.btDonHang.Size = new System.Drawing.Size(152, 38);
            this.btDonHang.TabIndex = 2;
            this.btDonHang.Text = "Đơn hàng";
            this.btDonHang.UseVisualStyleBackColor = false;
            this.btDonHang.Click += new System.EventHandler(this.btDonHang_Click);
            // 
            // btNCC
            // 
            this.btNCC.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNCC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btNCC.Location = new System.Drawing.Point(613, 25);
            this.btNCC.Name = "btNCC";
            this.btNCC.Size = new System.Drawing.Size(152, 38);
            this.btNCC.TabIndex = 3;
            this.btNCC.Text = "NCC";
            this.btNCC.UseVisualStyleBackColor = false;
            this.btNCC.Click += new System.EventHandler(this.btNCC_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btNCC);
            this.Controls.Add(this.btDonHang);
            this.Controls.Add(this.btKhachHang);
            this.Controls.Add(this.btSanPham);
            this.Name = "home";
            this.Text = "Trang chủ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSanPham;
        private System.Windows.Forms.Button btKhachHang;
        private System.Windows.Forms.Button btDonHang;
        private System.Windows.Forms.Button btNCC;
    }
}