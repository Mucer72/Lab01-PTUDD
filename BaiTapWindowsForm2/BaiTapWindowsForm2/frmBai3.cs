using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm2
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void rdNoiChuoi_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible=true;
            panel2.Visible=false;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            string res = null;
            Bai3.NoiChuoi(txtHo.Text, txtTen.Text, ref res);
            txtResult.Text = res;
        }

        private void rdGiaThua_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            txtResult2.Text = Bai3.GiaThua(int.Parse(txtNumber.Text)).ToString();
        }
    }
}
