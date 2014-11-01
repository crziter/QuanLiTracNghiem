using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiTracNghiem.Models;
using QuanLiTracNghiem.Controllers;

namespace QuanLiTracNghiem.Views
{
    public partial class UcDeThi : UserControl
    {
        private DeThiController _controller;

        private List<MonThi> _lst_mt;
        private List<DeThi> _lst_dt;
        private List<CauHoi> _lst_ch;

        public UcDeThi()
        {
            InitializeComponent();
            _controller = new DeThiController(this);

            ReloadLstMonThi();
            UpdateLstMonThi();
        }

        private void ReloadLstMonThi()
        {
            _lst_mt = _controller.GetAllMonThi();
        }

        private void UpdateLstMonThi()
        {
            LstMonThi.Items.Clear();
            foreach(var mt in _lst_mt) {
                LstMonThi.Items.Add(mt);
            }
        }

        private void UcDeThi_Load(object sender, EventArgs e)
        {

        }

        private void LstMonThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            MonThi mt = (MonThi)LstMonThi.SelectedItem;

            if (mt != null)
            {
                TxtMonThi.Text = mt.ToString();
                ReloadLstDeThi(mt);
            }
        }

        private void ReloadLstDeThi(MonThi mt)
        {
            try
            {
                _lst_dt = _controller.GetAllDeThi(mt);

                LstDeThi.Items.Clear();
                foreach (var dt in _lst_dt)
                {
                    LstDeThi.Items.Add(dt);
                }
            }
            catch (Exception ex)
            {
                ErrMess("Gặp lỗi: " + ex.Message);
            }
        }

        private void ErrMess(string mess)
        {
            MessageBox.Show(this, mess, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void InfoMess(string mess)
        {
            MessageBox.Show(this, mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnUpDateMonThi_Click(object sender, EventArgs e)
        {
            MonThi mt = (MonThi) LstMonThi.SelectedItem;
            if (mt != null)
            {
                mt.ten = TxtMonThi.Text;
                try
                {
                    _controller.Update(mt.id, mt);
                    ReloadLstMonThi();
                    UpdateLstMonThi();
                    InfoMess("Cập nhật thành công");
                }
                catch (Exception ex)
                {
                    ErrMess("Gặp lỗi: " + ex.Message);
                }
            }
            else
            {
                ErrMess("Chưa chọn môn thi để cập nhật");
            }
        }
    }
}
