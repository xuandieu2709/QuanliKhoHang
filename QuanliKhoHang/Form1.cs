using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanliKhoHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            txttaikhoan.Focus();
            lbhienpass.Hide();
            txtmatkhau.UseSystemPasswordChar = true;
        }
        int count;
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            
            string tk = txttaikhoan.Text;
            string mk = txtmatkhau.Text;
            if (tk.Length == 0 || mk.Length == 0)
            { MessageBox.Show("Vui Lòng Nhập Đầy Đủ Tài Khoản Và Mật Khẩu",
                "Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txttaikhoan.Focus();
            }
            else
                     if (tk != "congtyxyz" || mk != "hoixeptong")
            {
                if (count < 2)
                {
                    MessageBox.Show("😰😰Tài Khoản Hoặc Mật Khẩu Không Chính Xác😰😰\nSai Quá 3 Lần Sẽ Bị Khoá",
                        "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txttaikhoan.Focus();
                }
                count++;
                if (count == 3)
                {
                    MessageBox.Show("Vui Lòng Liên Hệ Phòng Kĩ Thuật Để Lấy Lại Mật Khẩu👋👋👋", 
                        "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close(); 
                }
            }
            else
                       if (tk == "congtyxyz" && mk == "hoixeptong")
            { MessageBox.Show("👻👻Đăng Nhập Thành Công👻👻", 
                "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form2 frm2 = new Form2();
                this.Visible = false;
                frm2.ShowDialog();
                this.Close();
            }
            
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtmatkhau_TextChanged(object sender, EventArgs e)
        {
            if (txtmatkhau.Text != "")
            {
                lbhienpass.Show();
            }
            else
                lbhienpass.Hide();

        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtmatkhau.UseSystemPasswordChar = false;
            }
            else
                txtmatkhau.UseSystemPasswordChar = true;
        }

       

        private void btnnext_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Visible = false;
            frm2.ShowDialog();
            this.Close();
        }
    }
}
