using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = lsvNhanvien.Items.Add(txtHoten.Text);
            lvi.SubItems.Add (dtpNgaysinh.Value.ToShortDateString()); 
            lvi.SubItems.Add(txtDienthoai.Text); 
            lvi.SubItems.Add(txtDiachi.Text);
            setNull();
        
        }

        void setNull()
        {
            txtHoten.Text = "";
            txtDienthoai.Text = "";
            txtDiachi.Text = "";
            txtHoten.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lsvNhanvien.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Bạn muốn " + txtHoten.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)               
                {
                    lsvNhanvien.Items.Remove(lsvNhanvien.SelectedItems[0]);
                    setNull();
                }
            }
            else
                MessageBox.Show("Bạn vui lòng chọn dòng cần xóa");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lsvNhanvien.SelectedItems.Count > 0)
            {
                lsvNhanvien.SelectedItems[0].SubItems[0].Text = txtHoten.Text; 
                lsvNhanvien.SelectedItems[0].SubItems[1].Text = dtpNgaysinh.Value.ToShortDateString(); 
                lsvNhanvien.SelectedItems[0].SubItems[2].Text = txtDienthoai.Text;
                lsvNhanvien.SelectedItems[0].SubItems[3].Text = txtDiachi.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lsvNhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvNhanvien.SelectedItems.Count > 0)
            {
                txtHoten.Text = lsvNhanvien.SelectedItems[0].SubItems[0].Text;
                dtpNgaysinh.Text = lsvNhanvien.SelectedItems[0].SubItems[1].Text; 
                txtDienthoai.Text = lsvNhanvien.SelectedItems[0].SubItems[2].Text; 
                txtDiachi.Text = lsvNhanvien.SelectedItems[0].SubItems[3].Text;
            }
        }
    }
}
