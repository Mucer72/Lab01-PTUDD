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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private bool IsNumber(string s)
        {
            if (int.Parse(s) % 1 == 0)
                return true;
            else return false;
        }

        private void btnTinhToan_Click(object sender, EventArgs e)
        {
            int KetQua=0;
            if(rdTongAB.Checked)
            {
                if(IsNumber(txtSoA.Text)&&IsNumber(txtSoB.Text))
                {
                    int a = int.Parse(txtSoA.Text);
                    int b = int.Parse(txtSoB.Text);
                    TinhToan.CongHaiSo(a,b,ref KetQua);
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin vừa nhập", "Thông báo");
                }
            }
            else if(rdTongN.Checked)
            {
                int n = int.Parse(txtSoN.Text);
                if(IsNumber(txtSoN.Text))
                {
                    KetQua = TinhToan.TongDaySo(n);
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin vừa nhập", "Thông báo");
                }
            }
            lblKetQua.Text = KetQua.ToString();
        }
    }
}
