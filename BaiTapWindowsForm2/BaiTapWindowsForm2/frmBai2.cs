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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnShowResult_Click(object sender, EventArgs e)
        {
                string res = null;
                if(rdAdd.Checked)
                {
                    res = (int.Parse(txtNumber1.Text) + int.Parse(txtNumber2.Text)).ToString();
                }   
                else if(rdSub.Checked)
                {
                    res = (int.Parse(txtNumber1.Text) - int.Parse(txtNumber2.Text)).ToString();
                }   
                else if(rdMul.Checked)
                {
                    res = (int.Parse(txtNumber1.Text) * int.Parse(txtNumber2.Text)).ToString();
                }   
                else if(rdDiv.Checked)
                {
                    res = (float.Parse(txtNumber1.Text) / float.Parse(txtNumber2.Text)).ToString();
                }
                lblResult.Text = res;
        }
    }
}
