using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsform3
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            var nhanvien = new NhanVien("NV01", "Vũ Thị Kim Ngân", Convert.ToDateTime("09/09/2005"), 50, 15);
            lblThongTin.Text = nhanvien.HienThi();
        }
    }
}
