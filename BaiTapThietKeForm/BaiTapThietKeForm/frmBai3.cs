using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThietKeForm
{
    public partial class frmBai3 : Form
    {
        List<string> list = new List<string>();
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tu = txtTuMoi.Text;
            string nghia = txtNghia.Text;
            if(txtNghia.Text==null || txtTuMoi.Text==null)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Thông báo");
                return;
            }
            listBox1.Items.Add(tu);
            list.Add(nghia);
            txtTuMoi.Focus();
            txtTuMoi.Text = null;
            txtNghia.Text = null;

            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            txtHienThiNghia.Text = nghia;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int stt = listBox1.SelectedIndex;
            txtHienThiNghia.Text = list[stt];
        }
    }
}
