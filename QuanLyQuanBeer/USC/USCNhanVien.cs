﻿using QuanLyQuanBeer.DAO;
using System;
using System.Windows.Forms;

namespace QuanLyQuanBeer.USC
{
    public partial class USCNhanVien : UserControl
    {
        private BindingSource listNhanVien = new BindingSource();

        public USCNhanVien()
        {
            InitializeComponent();
            LoadAccount();
            binding();
        }

        private void LoadAccount()
        {
            dtgvNhanVien.DataSource = listNhanVien;
            listNhanVien.DataSource = ThongTinTaiKhoanDAO.Instance.GetListNhanVien1();
            dtgvNhanVien.Columns[0].HeaderText = "ID";
            dtgvNhanVien.Columns[0].FillWeight = 30;
            dtgvNhanVien.Columns[1].HeaderText = "Họ Tên";
            dtgvNhanVien.Columns[1].FillWeight = 120;
            dtgvNhanVien.Columns[2].HeaderText = "SĐT";
            dtgvNhanVien.Columns[2].FillWeight = 80;
            dtgvNhanVien.Columns[3].HeaderText = "Địa chỉ";
            dtgvNhanVien.Columns[4].HeaderText = "Số CMND";
            dtgvNhanVien.Columns[4].FillWeight = 80;
            dtgvNhanVien.Columns[5].HeaderText = "Tuổi";
            dtgvNhanVien.Columns[5].FillWeight = 35;
            dtgvNhanVien.Columns[6].HeaderText = "Giới tính";
            dtgvNhanVien.Columns[6].FillWeight = 66;
            dtgvNhanVien.Columns[7].HeaderText = "Tên đăng nhập";
        }

        private void binding()
        {
            txbIDNhanVien.DataBindings.Add("Text", dtgvNhanVien.DataSource, "id", true, DataSourceUpdateMode.Never);
            txbTenDN.DataBindings.Add("Text", dtgvNhanVien.DataSource, "TenDangNhap", true, DataSourceUpdateMode.Never);
            txbHoTen.DataBindings.Add("Text", dtgvNhanVien.DataSource, "HoTen", true, DataSourceUpdateMode.Never);
            txbDiaChi.DataBindings.Add("Text", dtgvNhanVien.DataSource, "DiaChi", true, DataSourceUpdateMode.Never);
            txbCMND.DataBindings.Add("Text", dtgvNhanVien.DataSource, "CMND", true, DataSourceUpdateMode.Never);
            txbTuoi.DataBindings.Add("Text", dtgvNhanVien.DataSource, "Tuoi", true, DataSourceUpdateMode.Never);
            txbSDT.DataBindings.Add("Text", dtgvNhanVien.DataSource, "SoDienThoai", true, DataSourceUpdateMode.Never);
        }

        private void BtSuaNV_Click(object sender, EventArgs e)
        {
            string tenDN = txbTenDN.Text;
            string hoTen = txbHoTen.Text;
            string diaChi = txbDiaChi.Text;
            string cMND = txbCMND.Text;
            string tuoi = txbTuoi.Text;
            string sDT = txbSDT.Text;
            string gioiTinh;
            if (rdbtNam.Checked)
            {
                gioiTinh = "Nam";
            }
            else
                gioiTinh = "Nữ";
            if (hoTen == string.Empty || diaChi == string.Empty || cMND == string.Empty || tuoi == string.Empty || sDT == string.Empty)
                MessageBox.Show("Bạn phải nhập đủ thông tin!", "Cập nhật thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                int CMND = int.Parse(txbCMND.Text);
                int _sDT = int.Parse(txbSDT.Text);
                int _tuoi = int.Parse(txbTuoi.Text);
                if (ThongTinTaiKhoanDAO.Instance.capNhat(hoTen, _sDT, diaChi, CMND, _tuoi, gioiTinh, tenDN))
                {
                    MessageBox.Show("Cập nhật thành công!", "Cập nhật thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAccount();
                }
                else
                    MessageBox.Show("Cập nhật không thành công!", "Cập nhật thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bdRDBT()
        {
            string tenDN = txbTenDN.Text;
            if (ThongTinTaiKhoanDAO.Instance.layGioiTinh(tenDN) == "Nam")
            {
                rdbtNam.Checked = true;
            }
            else
            {
                rdbtNu.Checked = true;
            }
        }

        private void TxbTenDN_TextChanged(object sender, EventArgs e)
        {
            bdRDBT();
        }

        private void BtSuaTK_Click(object sender, EventArgs e)
        {
        }

        private void BtLamMoi_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }
    }
}