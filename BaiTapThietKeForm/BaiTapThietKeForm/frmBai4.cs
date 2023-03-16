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
    public partial class frmBai4 : Form
    {
        public frmBai4()
        {
            InitializeComponent();
        }

        private void frmBai4_Load(object sender, EventArgs e)
        {
            Random ran = new Random();
            for(int i=0;i<10;i++)
            {
                listBox1.Items.Add(ran.Next(1, 100));
            }    
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int soCanTim = int.Parse(txtSo.Text);
            foreach (int number in listBox1.Items)
            {
                if (number == soCanTim)
                {
                    lblKetQua.Text = "Tìm thấy";
                    break;
                }    
                else
                    lblKetQua.Text = "Không tìm thấy";
            }    
        }
    }
}
