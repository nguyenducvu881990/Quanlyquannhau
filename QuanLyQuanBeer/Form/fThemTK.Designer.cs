﻿namespace QuanLyQuanBeer
{
    partial class fThemTK
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btThem = new System.Windows.Forms.Button();
            this.grbLoaiTK = new System.Windows.Forms.GroupBox();
            this.rdbtNhanVien = new System.Windows.Forms.RadioButton();
            this.rdbtQuanLy = new System.Windows.Forms.RadioButton();
            this.lbLoaiTK = new System.Windows.Forms.Label();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.txbTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.lbTenTK = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grbLoaiTK.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 48);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÊM TÀI KHOẢN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btThoat);
            this.panel2.Controls.Add(this.btThem);
            this.panel2.Controls.Add(this.grbLoaiTK);
            this.panel2.Controls.Add(this.lbLoaiTK);
            this.panel2.Controls.Add(this.txbMatKhau);
            this.panel2.Controls.Add(this.lbMatKhau);
            this.panel2.Controls.Add(this.txbTenTaiKhoan);
            this.panel2.Controls.Add(this.lbTenTK);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(371, 183);
            this.panel2.TabIndex = 1;
            // 
            // btThem
            // 
            this.btThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.btThem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.White;
            this.btThem.Location = new System.Drawing.Point(72, 137);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(104, 36);
            this.btThem.TabIndex = 50;
            this.btThem.Text = "&Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.BtThem_Click);
            // 
            // grbLoaiTK
            // 
            this.grbLoaiTK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grbLoaiTK.Controls.Add(this.rdbtNhanVien);
            this.grbLoaiTK.Controls.Add(this.rdbtQuanLy);
            this.grbLoaiTK.Location = new System.Drawing.Point(135, 89);
            this.grbLoaiTK.Name = "grbLoaiTK";
            this.grbLoaiTK.Size = new System.Drawing.Size(209, 42);
            this.grbLoaiTK.TabIndex = 49;
            this.grbLoaiTK.TabStop = false;
            // 
            // rdbtNhanVien
            // 
            this.rdbtNhanVien.AutoSize = true;
            this.rdbtNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtNhanVien.Location = new System.Drawing.Point(97, 12);
            this.rdbtNhanVien.Name = "rdbtNhanVien";
            this.rdbtNhanVien.Size = new System.Drawing.Size(101, 25);
            this.rdbtNhanVien.TabIndex = 1;
            this.rdbtNhanVien.TabStop = true;
            this.rdbtNhanVien.Text = "Nhân Viên";
            this.rdbtNhanVien.UseVisualStyleBackColor = true;
            // 
            // rdbtQuanLy
            // 
            this.rdbtQuanLy.AutoSize = true;
            this.rdbtQuanLy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtQuanLy.Location = new System.Drawing.Point(6, 12);
            this.rdbtQuanLy.Name = "rdbtQuanLy";
            this.rdbtQuanLy.Size = new System.Drawing.Size(85, 25);
            this.rdbtQuanLy.TabIndex = 0;
            this.rdbtQuanLy.TabStop = true;
            this.rdbtQuanLy.Text = "Quản Lý";
            this.rdbtQuanLy.UseVisualStyleBackColor = true;
            // 
            // lbLoaiTK
            // 
            this.lbLoaiTK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbLoaiTK.AutoSize = true;
            this.lbLoaiTK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiTK.Location = new System.Drawing.Point(19, 101);
            this.lbLoaiTK.Name = "lbLoaiTK";
            this.lbLoaiTK.Size = new System.Drawing.Size(110, 21);
            this.lbLoaiTK.TabIndex = 48;
            this.lbLoaiTK.Text = "Loại tài khoản:";
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbMatKhau.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMatKhau.Location = new System.Drawing.Point(135, 53);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Size = new System.Drawing.Size(209, 33);
            this.txbMatKhau.TabIndex = 47;
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatKhau.Location = new System.Drawing.Point(51, 59);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(78, 21);
            this.lbMatKhau.TabIndex = 46;
            this.lbMatKhau.Text = "Mật khẩu:";
            // 
            // txbTenTaiKhoan
            // 
            this.txbTenTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbTenTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenTaiKhoan.Location = new System.Drawing.Point(135, 14);
            this.txbTenTaiKhoan.Name = "txbTenTaiKhoan";
            this.txbTenTaiKhoan.Size = new System.Drawing.Size(209, 33);
            this.txbTenTaiKhoan.TabIndex = 45;
            // 
            // lbTenTK
            // 
            this.lbTenTK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTenTK.AutoSize = true;
            this.lbTenTK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenTK.Location = new System.Drawing.Point(25, 20);
            this.lbTenTK.Name = "lbTenTK";
            this.lbTenTK.Size = new System.Drawing.Size(104, 21);
            this.lbTenTK.TabIndex = 44;
            this.lbTenTK.Text = "Tên tài khoản:";
            // 
            // btThoat
            // 
            this.btThoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.btThoat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.btThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ForeColor = System.Drawing.Color.White;
            this.btThoat.Location = new System.Drawing.Point(198, 137);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(104, 36);
            this.btThoat.TabIndex = 71;
            this.btThoat.Text = "&Thoát";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.BtThoat_Click);
            // 
            // fThemTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 231);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fThemTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemTK";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grbLoaiTK.ResumeLayout(false);
            this.grbLoaiTK.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.TextBox txbTenTaiKhoan;
        private System.Windows.Forms.Label lbTenTK;
        private System.Windows.Forms.GroupBox grbLoaiTK;
        private System.Windows.Forms.RadioButton rdbtNhanVien;
        private System.Windows.Forms.RadioButton rdbtQuanLy;
        private System.Windows.Forms.Label lbLoaiTK;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btThoat;
    }
}