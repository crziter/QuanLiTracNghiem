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
            CbDapAn.SelectedIndex = 0;
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

        private void BtnXoaCauHoi_Click(object sender, EventArgs e)
        {
            DeThiController dc = new DeThiController(this);

            if (LstCauHoi.SelectedItems.Count > 0)
            {
                CauHoi ch = (CauHoi) LstCauHoi.SelectedItems[0].Tag;
                DeThi dt = (DeThi)LstDeThi.SelectedItem;

                Result rs = dc.DeleteCauHoiFromDeThi(ch, dt);
                if (Ultilities.IsResultOk(rs))
                {
                    int idx = LstCauHoi.SelectedItems[0].Index;
                    LstCauHoi.Items.RemoveAt(idx);
                    InfoMess("Xong!");
                }
                else
                {
                    ErrMess("Có lỗi xảy ra: ");
                }
            }
        }

        private void LstDeThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeThi dethi = (DeThi)LstDeThi.SelectedItem;
            if (dethi != null)
            {
                CauHoiController c = new CauHoiController();
                var list = c.GetAllCauHoi(dethi);
                LstCauHoi.Items.Clear();

                foreach (var i in list)
                {
                    ListViewItem lvi = new ListViewItem(new string[] {i.id.ToString(), i.noi_dung, i.a, i.b, i.c, i.d});
                    lvi.Tag = i;
                    LstCauHoi.Items.Add(lvi);
                }


            }
        }

        private void LstCauHoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            CauHoi cauhoi;
            if (LstCauHoi.SelectedItems.Count > 0)
            {
                cauhoi = (CauHoi)LstCauHoi.SelectedItems[0].Tag;
                TxtNoiDung.Text = cauhoi.noi_dung;
                TxtA.Text = cauhoi.a;
                TxtB.Text = cauhoi.b;
                TxtC.Text = cauhoi.c;
                TxtD.Text = cauhoi.d;
                CbDapAn.SelectedIndex = (int)cauhoi.da - 1;
            }

        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (TxtNoiDung.Text.Trim() != "" && TxtA.Text.Trim() != "" && TxtB.Text.Trim() != "" && TxtC.Text.Trim() != "" && TxtD.Text.Trim() != "" && CbDapAn.SelectedIndex != -1)
            {
                CauHoi cauhoi = (CauHoi)LstCauHoi.SelectedItems[0].Tag;
                cauhoi.a = TxtA.Text.Trim();
                cauhoi.b = TxtB.Text.Trim();
                cauhoi.c = TxtC.Text.Trim();
                cauhoi.d = TxtD.Text.Trim();
                cauhoi.da = CbDapAn.SelectedIndex + 1;
                CauHoiController c = new CauHoiController();

                var rs = c.Update(cauhoi);
                if (Ultilities.IsResultOk(rs))
                {
                    ListViewItem lvi = new ListViewItem(new string[] { 
                        cauhoi.id.ToString(), 
                        cauhoi.noi_dung, 
                        cauhoi.a, 
                        cauhoi.b, 
                        cauhoi.c, 
                        cauhoi.d });
                    lvi.Tag = cauhoi;
                    LstCauHoi.Items[LstCauHoi.SelectedItems[0].Index] = lvi;

                    InfoMess("Thành công");
                }
                else
                {
                    ErrMess("Thất bại: " + rs.reason);
                }
            }
            else
            {
                ErrMess("Chưa điền đầy đủ thông tin hoặc chưa chọn đề!");
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            if (TxtNoiDung.Text.Trim() != "" && TxtA.Text.Trim() != "" && TxtB.Text.Trim() != "" && TxtC.Text.Trim() != "" && TxtD.Text.Trim() != "" && CbDapAn.SelectedIndex != -1)
            {
                CauHoi cauhoi = new CauHoi();
                cauhoi.noi_dung = TxtNoiDung.Text.Trim();
                cauhoi.a = TxtA.Text.Trim();
                cauhoi.b = TxtB.Text.Trim();
                cauhoi.c = TxtC.Text.Trim();
                cauhoi.d = TxtD.Text.Trim();
                cauhoi.da = CbDapAn.SelectedIndex + 1;
                Models.DeThi dethi = (Models.DeThi)LstDeThi.SelectedItem;
                if (dethi != null)
                {
                    CauHoiController c = new CauHoiController();

                    var rs = c.Add(cauhoi);
                    if (Ultilities.IsResultOk(rs))
                    {
                        ListViewItem lvi = new ListViewItem(new string[] { cauhoi.id.ToString(), cauhoi.noi_dung, cauhoi.a, cauhoi.b, cauhoi.c, cauhoi.d });
                        lvi.Tag = cauhoi;
                        LstCauHoi.Items.Add(lvi);
                        cauhoi.id = (int) rs.id;

                        rs = c.SetCauHoiToDeThi(dethi, cauhoi);
                        if (Ultilities.IsResultOk(rs))
                        {
                            InfoMess("Thành công");
                        }
                        else
                        {
                            ErrMess("Có lỗi xảy ra: " + rs.reason);
                        }
                    }
                    else
                    {
                        ErrMess("Có lỗi xảy ra: " + rs.reason);
                    }
                }
            }
            else
            {
                ErrMess("Chưa điền đầy đủ thông tin hoặc chưa chọn đề!");
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtNoiDung.Text = "";
            TxtA.Text = "";
            TxtB.Text = "";
            TxtC.Text = "";
            TxtD.Text = "";

            CbDapAn.SelectedIndex = 0;
        }

        private void BtnNewDeThi_Click(object sender, EventArgs e)
        {
            MonThi mt = (MonThi)LstMonThi.SelectedItem;
            if (mt != null) {
                var rs = _controller.NewDeThi(mt);
                if (Ultilities.IsResultOk(rs))
                {
                    DeThi dt = new DeThi();
                    dt.id = (int)rs.id;
                    dt.mon_thi_id = mt.id;
                    LstDeThi.Items.Add(dt);

                    InfoMess("Xong!");
                }
                else
                {
                    ErrMess("Có lỗi xảy ra: " + rs.reason);
                }
            }
            else
            {
                ErrMess("Chưa chọn môn thi!!!");
            }
        }

        private void BtnHideDeThi_Click(object sender, EventArgs e)
        {
            DeThi dt = (DeThi)LstDeThi.SelectedItem;
            if (dt != null)
            {
                Result rs = _controller.DeleteDeThi(dt);
                if (Ultilities.IsResultOk(rs))
                {
                    LstDeThi.Items.RemoveAt(LstDeThi.SelectedIndex);
                    LstDeThi.SelectedIndex = -1;
                    InfoMess("Đã xóa thành công.");
                }
                else
                {
                    ErrMess("Có lỗi xảy ra: " + rs.reason);
                }
            }
            else
            {
                ErrMess("Chưa chọn đề thi để xóa!");
            }
        }
    }
}
