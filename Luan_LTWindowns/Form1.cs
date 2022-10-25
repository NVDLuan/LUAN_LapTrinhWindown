using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luan_LTWindowns
{
    public partial class frmTinhToan : Form
    {
        private int status = 0;
        private int tmp = 1;
        public frmTinhToan()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (this.tmp == 1)
                this.nhan(1, txtA);
            else this.nhan(1, txtB);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                bool temp = true;
                double result=0;
                int a = Convert.ToInt32(txtA.Text);
                int b = Convert.ToInt32(txtB.Text);
                if (status == 0)
                    result = a + b;
                else if (status == 1)
                    result = a - b;
                else if (status == 2)
                    result = b * a;
                else
                {
                    if (b == 0)
                    {
                        txtResult.Text = "Không thể chia cho số 0";
                        temp = false;
                    }
                    else result = 1.0* a / b;
                }
                if (temp == true) { txtResult.Text = "KQ: " + result.ToString();  }
                
            }
            catch (Exception ex)
            {
                txtA.Text = "";
                txtB.Text = "";
                MessageBox.Show("vui lòng nhập số!");
            }
        }
        private void nhan(int a, TextBox txta)
        {
            txta.Text += a.ToString();
        }
        private void cbB_SelectedIndexChanged(object sender, EventArgs e)
        {
            status = cbB.SelectedIndex;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            if (this.tmp == 1)
                this.nhan(2, txtA);
            else this.nhan(2, txtB);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (this.tmp == 1)
                this.nhan(3, txtA);
            else this.nhan(3, txtB);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (this.tmp == 1)
                this.nhan(4, txtA);
            else this.nhan(4, txtB);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (this.tmp == 1)
                this.nhan(5, txtA);
            else this.nhan(5, txtB);
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (this.tmp == 1)
                this.nhan(6, txtA);
            else this.nhan(6, txtB);
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (this.tmp == 1)
                this.nhan(7, txtA);
            else this.nhan(7, txtB);
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (this.tmp == 1)
                this.nhan(8, txtA);
            else this.nhan(8, txtB);
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (this.tmp == 1)
                this.nhan(9, txtA);
            else this.nhan(9, txtB);
        }

        private void button0_Click(object sender, EventArgs e)
        {

            if (this.tmp == 1)
                this.nhan(0, txtA);
            else this.nhan(0, txtB);
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            tmp = 1;
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            tmp = 2;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
        }
    }
}
