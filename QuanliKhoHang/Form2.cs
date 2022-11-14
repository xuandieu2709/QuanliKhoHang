using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanliKhoHang
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txt = label1.Text;
            len = txt.Length;

         }

        
        string txt;
        int dem = 0;
        int len = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Form3 frm3 = new Form3();
            this.Visible = false;
            frm3.ShowDialog();
            this.Visible = true;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            this.Visible = false;
            frm4.ShowDialog();
            this.Visible = true;

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form5 frrm5 = new Form5();
            this.Visible = false;
            frrm5.ShowDialog();
            this.Visible = true;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            DialogResult r;
            r = MessageBox.Show("Bạn Muốn Thoát Không?", "Xác Nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            { }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {


            dem++;
            if (dem > len)
            {
                dem = 0;
                label1.Text = "";

            }

            else
            {

                label1.Text = txt.Substring(0, dem);
                if (label1.ForeColor == Color.DarkOliveGreen)
                    label1.ForeColor = Color.Red;
                else
                    label1.ForeColor = Color.DarkOliveGreen;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Made By \nNguyễn Xuân Diệu\nTrương Đăng Quý\nNguyễn Hoàng Huy\nNguyễn Xuân Tiến Dũng");
        }
    }
}
