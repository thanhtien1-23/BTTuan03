using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Form1 : Form
    {
        private DataTable tbOrder = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count > 0)
            {
                string tenmon = DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                int dong = Mondachon(tenmon, tbOrder);
                int soluong = Convert.ToInt32(tbOrder.Rows[dong]["Quantity"]);
                if (soluong == 1)
                    tbOrder.Rows.RemoveAt(dong);
                else
                    tbOrder.Rows[dong]["Quantity"] = Convert.ToInt32(tbOrder.Rows[dong]["Quantity"]) - 1;
            }
            else
                MessageBox.Show("Chưa chọn món cần xóa");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string tenmon = ((Button)sender).Text;
            DataRow r = tbOrder.NewRow();

            int dong = Mondachon(tenmon, tbOrder);
            if (dong != -1) 
            {
                tbOrder.Rows[dong]["Quantity"] = Convert.ToInt32(tbOrder.Rows[dong]["Quantity"]) + 1;
            }
            else
            {
                r["FoodName"] = tenmon;
                r["Quantity"] = 1;
                tbOrder.Rows.Add(r);
            }
            DataGridView1.DataSource = tbOrder;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbOrder.Columns.Add("FoodName");
            tbOrder.Columns.Add("Quantity");
        }

        private int Mondachon(string tenmon, DataTable dt)
        { 
            int dong = -1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["FoodName"].ToString() == tenmon)
                {
                    dong = i;
                    break;
                }
            }
            return dong; 
        }
    }
}
