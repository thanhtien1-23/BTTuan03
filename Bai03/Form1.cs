using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void GetPay()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!"); txtName.Focus();
            }
            else
            {
                long total = 0;
                if (chkClean.Checked == true)
                    total += 100000;
                if (chkWhitening.Checked == true)
                    total += 1200000;
                if (chkXRay.Checked == true)
                    total += 200000;
                int soluong = int.Parse(numFilling.Value.ToString());              
                total += soluong * 80000;
                txtTotal.Text = String.Format("{0:#,###} đồng", total);
            }
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            GetPay();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
