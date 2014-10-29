using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiTracNghiem.Views
{
    public partial class FrmMain : Form
    {
        private UserControl _UcThiSinh;
        private UserControl _UcDeThiCauHoi;
        private UserControl _UcCurrent = null;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void MnuThiSinh_Click(object sender, EventArgs e)
        {
            SetContent(new UcThiSinh());
        }

        private void SetContent(UserControl uc)
        {
            if (_UcCurrent != null)
            {
                _UcCurrent.Hide();
            }

            _UcCurrent = uc;
            uc.Parent = PnContent;
            uc.SetBounds(0, 0, PnContent.Width, PnContent.Height);
            uc.Show();
        }

        private void PnContent_Resize(object sender, EventArgs e)
        {
            if (_UcCurrent != null)
            {
                _UcCurrent.SetBounds(0, 0, PnContent.Width, PnContent.Height);
            }
        }
    }
}
