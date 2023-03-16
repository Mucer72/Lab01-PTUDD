using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void cbbTenHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            int stt = cbbTenHH.SelectedIndex;
            switch(stt)
            {
                case 0:
                    txtDonGia.Text = "100000";
                    break;
                case 1:
                    txtDonGia.Text = "150000";
                    break;
                case 2:
                    txtDonGia.Text = "2000000";
                    break;
            }    
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if(txtSoLuong.Text=="")
            {
                txtSoLuong.Text = "1";
            }    
            if(rdCK.Checked)
            {
                int TongTien = int.Parse(txtSoLuong.Text) * int.Parse(txtDonGia.Text);
                TongTien -=TongTien*5/100;
                lblTongTien.Text = TongTien.ToString();
            }    
            else if(rdTien.Checked)
            {
                int TongTien = int.Parse(txtSoLuong.Text) * int.Parse(txtDonGia.Text);
                lblTongTien.Text = TongTien.ToString();
            }    
        }
    }
}
