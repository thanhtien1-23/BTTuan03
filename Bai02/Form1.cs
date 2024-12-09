using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
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

        private void txtSonguyen_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstKetqua_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btCapnhat_Click(object sender, EventArgs e)
        {
            lstKetqua.Items.Add(txtSonguyen.Text);
            txtSonguyen.Text = "";
            txtSonguyen.Focus();
        }

        private void btTang2_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.Items.Count; //Số mục trong lst
            for (int i = 0; i < n; i++)
            {
                int tam = int.Parse(lstKetqua.Items[i].ToString()) + 2;
                lstKetqua.Items.RemoveAt(i);
                lstKetqua.Items.Insert(i, tam.ToString());
            }
        }

        private void btChonchandau_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.Items.Count; //Số mục trong lst
            for (int i = 0; i < n - 1; i++)
            {
                if (int.Parse(lstKetqua.Items[i].ToString()) % 2 == 0)
                {
                    string s = lstKetqua.Items[i].ToString();//Lay gia tri muc gia tri chan
                    lstKetqua.SelectedItem = s;//Chon muc co gia tri chan
                    break; //Thuc hien duoc so chn dau thi ket thuc vong lap
                }
            }
        }

        private void btLecuoi_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.Items.Count; //Số mục trong lst
            for (int i = n - 1; i >= 0; i--)
            {
                if (int.Parse(lstKetqua.Items[i].ToString()) % 2 == 1)
                {
                    string s = lstKetqua.Items[i].ToString();//Lay gia tri muc gia tri lẻ
                    lstKetqua.SelectedItem = s;//Chon muc co gia tri le
                    break; //Thuc hien duoc so le dau (tu duoi len) thi ket thuc vong lap
                }
            }
        }

        private void btXoaphantudangchon_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.SelectedItems.Count; //Số mục dang duoc chon trong lstKetqua
            for (int i = n - 1; i >= 0; i--)
                lstKetqua.Items.Remove(lstKetqua.SelectedItems[i].ToString());

        }

        private void btXoaphantudau_Click(object sender, EventArgs e)
        {
            lstKetqua.Items.Remove(lstKetqua.Items[0].ToString());
        }

        private void btXoaphantucuoi_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.Items.Count;
            lstKetqua.Items.Remove(lstKetqua.Items[n - 1].ToString());
        }

        private void btKetthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
