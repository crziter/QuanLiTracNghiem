using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiTracNghiem.Controllers;
using QuanLiTracNghiem.Models;

namespace QuanLiTracNghiem.Views
{
    public partial class UcThiSinh : UserControl
    {
        private ThiSinhController _controller;
        private List<ThiSinh> _lst_ts;

        public UcThiSinh()
        {
            InitializeComponent();
            _controller = new ThiSinhController(this);

            ReloadList();
            SetList(_lst_ts);
        }

        private void ReloadList()
        {
            _lst_ts = _controller.GetAll();
        }

        private void SetList(List<ThiSinh> ts)
        {
            if (ts == null) return;

            LstThiSinh.Items.Clear();

            foreach (var t in ts)
            {
                ListViewItem lvi = new ListViewItem(t.id.ToString());
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, t.ten_dang_nhap));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, t.ten_that));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, t.email));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, t.active.ToString()));

                lvi.Tag = t;
                LstThiSinh.Items.Add(lvi);
            }
        }

        private void LstThiSinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstThiSinh.SelectedItems.Count == 0) return;

            var si = LstThiSinh.SelectedItems[0];
            ThiSinh ts = (ThiSinh)si.Tag;
            if (ts != null)
            {
                TxtTenDangNhap.Text = ts.ten_dang_nhap;
                TxtTenThat.Text = ts.ten_that;
                TxtMatKhau.Text = ts.mat_khau;
                TxtEmail.Text = ts.email;

                ChkActivate.Checked = (ts.active == true);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (LstThiSinh.SelectedItems.Count == 0)
            {
                MessageBox.Show(this, "Chưa chọn thí sinh để xóa", "Lỗi");
                return;
            }

            ThiSinh t = (ThiSinh)LstThiSinh.SelectedItems[0].Tag;
            if (t != null)
            {
                _controller.Delete(t);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (LstThiSinh.SelectedItems.Count == 0) {
                MessageBox.Show(this, "Chưa chọn thí sinh để cập nhật", "Lỗi");
                return;
            }

            ThiSinh cts = (ThiSinh) LstThiSinh.SelectedItems[0].Tag;

            ThiSinh ts = new ThiSinh();
            ts.ten_dang_nhap = TxtTenDangNhap.Text;
            ts.email = TxtEmail.Text;
            ts.mat_khau = TxtMatKhau.Text;
            ts.ten_that = TxtTenThat.Text;
            ts.active = ChkActivate.Checked;

            if (_controller.Update(cts.id, ts))
            {
                ReloadList();
                SetList(_lst_ts);

                MessageBox.Show(this, "Cập nhật thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show(this, "Cập nhật thất bại", "Thông báo");
            }
        }
    }
}
