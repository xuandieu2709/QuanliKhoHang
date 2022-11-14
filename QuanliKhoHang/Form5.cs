using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanliKhoHang
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(
        @"Data Source=DESKTOP-Q0B8QHD\MSSQLSERVER02;Initial Catalog=Quanlikhohang;Integrated Security=True");



        private void Form5_Load(object sender, EventArgs e)
        {
            dgvhoadonnhap.Hide();
            dgvhoadonnhap.Enabled = false;
            dgvhoadonxuat.Hide();
            dgvhoadonxuat.Enabled = false;
            An();
            btnthem.Hide();
            btnsua.Hide();
            btnxoa.Hide();
            btnhuy.Hide();
            btnluu.Hide();
            btntimkiem.Hide();
            txttimkiem.Hide();
            lbtimkiem.Hide();
            btnxemhoadon.Hide();
            lbinfor.Hide();
            rdbhoadon.Hide();
            rdbhoadon.Checked = false;
            rdbmahang.Hide();
            rdbmahang.Checked = false;
            lbinfor.Hide();
            
        }
        private void An()
        {
            lbmahoadon.Hide();
            txtmahoadon.Hide();
            lbmahang.Hide();
            txtmahang.Hide();
            lbsoluong.Hide();
            txtsoluong.Hide();
            lbgianhapxuat.Hide();
            txtgianhapxuat.Hide();
            lbthanhtien.Hide();
            txtthanhtien.Hide();
            lbtongtien.Hide();
            txttongtien.Hide();
            lbGTGT.Hide();
            txtGTGT.Hide();
        }
        private void connect_text_label()
        {

            lbmahoadon.Enabled = true;
            txtmahoadon.Enabled = true;
            lbmahang.Enabled = true;
            txtmahang.Enabled = true;
            lbsoluong.Enabled = true;
            txtsoluong.Enabled = true;
            lbgianhapxuat.Enabled = true;
            txtgianhapxuat.Enabled = true;
            lbthanhtien.Enabled = true;
            txtthanhtien.Enabled = true;
            lbtongtien.Enabled = true;
            txttongtien.Enabled = true;
            lbGTGT.Enabled = true;
            txtGTGT.Enabled = true;
        }
        private void Disconnect_text_label()
        {

            lbmahoadon.Enabled = false;
            txtmahoadon.Enabled = false;
            lbmahang.Enabled = false;
            txtmahang.Enabled = false;
            lbsoluong.Enabled = false;
            txtsoluong.Enabled = false;
            lbgianhapxuat.Enabled = false;
            txtgianhapxuat.Enabled = false;
            lbthanhtien.Enabled = false;
            txtthanhtien.Enabled = false;
            lbtongtien.Enabled = false;
            txttongtien.Enabled = false;
            lbGTGT.Enabled = false;
            txtGTGT.Enabled = false;
        }
        private void Hien()
        {
            lbmahoadon.Show();
            txtmahoadon.Show();
            lbmahang.Show();
            txtmahang.Show();
            lbsoluong.Show();
            txtsoluong.Show();
            lbgianhapxuat.Show();
            txtgianhapxuat.Show();
            lbthanhtien.Show();
            txtthanhtien.Show();
            lbtongtien.Show();
            txttongtien.Show();
            txtGTGT.Show();
            lbGTGT.Show();
        }

        private void btnxemhoadon_Click(object sender, EventArgs e)
        {
            if (txtmahang.Text == "")
            {
                MessageBox.Show("Vui Lòng Chọn Hóa Đơn Cần Xuất!");
            }
            else
            {
                if (dgvhoadonnhap.Enabled == true)
                {
                    MessageBox.Show(
                        "Mã Hoá Đơn:  " + txtmahoadon.Text
                        + "\nMã Hàng:  " + txtmahang.Text
                        + "\nSố Lượng:  " + txtsoluong.Text
                        + "\nGiá Nhập:  " + txtgianhapxuat.Text + " Đồng"
                        + "\nThành Tiền:  " + txtthanhtien.Text + " Đồng"
                        + "\nGiá Trị Gia Tăng:  " + txtGTGT.Text + " Đồng"
                        + "\nTổng Tiền:  " + txttongtien.Text + " Đồng", "Hoá Đơn Nhập Hàng");
                }
                if (dgvhoadonxuat.Enabled == true)
                {
                    MessageBox.Show(
                        "Mã Hoá Đơn:  " + txtmahoadon.Text
                        + "\nMã Hàng:  " + txtmahang.Text
                        + "\nSố Lượng:  " + txtsoluong.Text
                        + "\nGiá Xuất:  " + txtgianhapxuat.Text + " Đồng"
                        + "\nThành Tiền:  " + txtthanhtien.Text + " Đồng"
                        + "\nGiá Trị Gia Tăng:  " + txtGTGT.Text + " Đồng"
                        + "\nTổng Tiền:  " + txttongtien.Text + " Đồng", "Hoá Đơn Xuất Hàng");
                }
            }
        }
        Boolean Addhoadonnhapxuat;
        private void btnthem_Click(object sender, EventArgs e)
        {
            Addhoadonnhapxuat = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btntimkiem.Enabled = true;
            lbtimkiem.Enabled = true;
            txttimkiem.Enabled = true;
            connect_text_label();
            btnhuy.Enabled = true;
            btnluu.Enabled = true;
            txtmahang.Text = "";
            txtmahang.Enabled = true;
            txtmahoadon.Text = "";
            txtsoluong.Text = "";
            txtgianhapxuat.Text = "";
            txtthanhtien.Text = "";
            txtGTGT.Text = "";
            txttongtien.Text = "";
            lbinfor.Show();

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            Addhoadonnhapxuat = false;
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            lbtimkiem.Enabled = true;
            btntimkiem.Enabled = true;
            txttimkiem.Enabled = true;
            connect_text_label();
            btnhuy.Enabled = true;
            btnluu.Enabled = true;
            txtmahoadon.Enabled = false;
            lbinfor.Show();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (dgvhoadonnhap.Enabled == true)
            {
                if (Addhoadonnhapxuat == true)
                {

                    if (txtmahoadon.Text == "" || txtmahang.Text == "" ||
                        txtsoluong.Text == "" || txtgianhapxuat.Text == "" ||
                        txtthanhtien.Text == "" || txtGTGT.Text == "" ||
                        txttongtien.Text == "")
                    {
                        MessageBox.Show("Vui Lòng Điền Đầy Đủ Thông Tin", "Thông Báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_dgv();
                        btnthem_Click(sender, e);
                    }
                    else
                    {
                        try
                        {

                            SqlCommand cmd = new SqlCommand("Insert_HoaDonNhap");
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = connect;
                            cmd.Parameters.Add("@MaHD", SqlDbType.VarChar).Value = ""
                                        + txtmahoadon.Text + "";
                            cmd.Parameters.Add("@Mahang", SqlDbType.VarChar).Value = ""
                                + txtmahang.Text + "";
                            cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = ""
                                + Convert.ToInt32(txtsoluong.Text) + "";
                            cmd.Parameters.Add("@GiaNhap", SqlDbType.BigInt).Value = ""
                                + Convert.ToInt64(txtgianhapxuat.Text) + "";
                            cmd.Parameters.Add("@ThanhTien", SqlDbType.BigInt).Value = ""
                                + Convert.ToInt64(txtthanhtien.Text) + "";
                            cmd.Parameters.Add("@GTGT", SqlDbType.Int).Value = ""
                                + Convert.ToInt32(txtGTGT.Text) + "";
                            cmd.Parameters.Add("@TongTien", SqlDbType.BigInt).Value = ""
                                + Convert.ToInt64(txttongtien.Text) + "";
                            connect.Open();
                            cmd.ExecuteNonQuery();
                            connect.Close();
                            MessageBox.Show("Thêm Thành Công!\nMã Hóa Đơn:" + txtmahoadon.Text
                                + "\nMã Hàng:" + txtmahang.Text
                                + "\nSố Lượng:" + Convert.ToInt32(txtsoluong.Text)
                                + "\nGiá Nhập:" + Convert.ToInt64(txtgianhapxuat.Text)
                                + "\nThành Tiền:" + Convert.ToInt32(txtsoluong.Text) * Convert.ToInt64(txtgianhapxuat.Text)
                                + "\nGiá Trị Gia Tăng:" + Convert.ToInt32(txtGTGT.Text)
                                + "\nTổng Tiền:" + (Convert.ToInt32(txtsoluong.Text) * Convert.ToInt64(txtgianhapxuat.Text)
                                + Convert.ToInt64(txtGTGT.Text)) + ""
                                , "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Load_dgv();
                            btn_chinhsua_Click(sender, e);
                        }
                        catch
                        {
                            MessageBox.Show("Thêm Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Load_dgv();
                            btnthem_Click(sender, e);

                        }
                    }


                }
                else
                {

                    try
                    {
                        SqlCommand cmd = new SqlCommand("Update_HoaDonNhap");
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = connect;
                        cmd.Parameters.Add("@MaHD", SqlDbType.VarChar).Value = ""
                                    + txtmahoadon.Text + "";
                        cmd.Parameters.Add("@Mahang", SqlDbType.VarChar).Value = ""
                            + txtmahang.Text + "";
                        cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = ""
                            + Convert.ToInt32(txtsoluong.Text) + "";
                        cmd.Parameters.Add("@GiaNhap", SqlDbType.BigInt).Value = ""
                            + Convert.ToInt64(txtgianhapxuat.Text) + "";
                        cmd.Parameters.Add("@ThanhTien", SqlDbType.BigInt).Value = ""
                            + Convert.ToInt64(txtthanhtien.Text) + "";
                        cmd.Parameters.Add("@GTGT", SqlDbType.Int).Value = ""
                            + Convert.ToInt32(txtGTGT.Text) + "";
                        cmd.Parameters.Add("@TongTien", SqlDbType.BigInt).Value = ""
                            + Convert.ToInt64(txttongtien.Text) + "";
                        connect.Open();
                        cmd.ExecuteNonQuery();
                        connect.Close();
                        MessageBox.Show("Sửa Thành Công!", "Thông Báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_dgv();
                        btn_chinhsua_Click(sender, e);
                    }
                    catch
                    {
                        MessageBox.Show("Sửa Thất Bại!\nVui Lòng Thử Lại Sau",
                            "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Load_dgv();
                        btnsua_Click(sender, e);
                    }

                }
            }
            else
                if (dgvhoadonxuat.Enabled == true)
            {
                if (Addhoadonnhapxuat == true)
                {

                    if (txtmahoadon.Text == "" || txtmahang.Text == "" ||
                            txtsoluong.Text == "" || txtgianhapxuat.Text == "" ||
                            txtthanhtien.Text == "" || txtGTGT.Text == "" ||
                            txttongtien.Text == "")
                    {
                        MessageBox.Show("Vui Lòng Điền Đầy Đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_dgv();
                        btnthem_Click(sender, e);
                    }
                    else
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("Insert_HoaDonXuat");
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = connect;
                            cmd.Parameters.Add("@MaHD", SqlDbType.VarChar).Value = ""
                                        + txtmahoadon.Text + "";
                            cmd.Parameters.Add("@Mahang", SqlDbType.VarChar).Value = ""
                                + txtmahang.Text + "";
                            cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = ""
                                + Convert.ToInt32(txtsoluong.Text) + "";
                            cmd.Parameters.Add("@GiaXuat", SqlDbType.BigInt).Value = ""
                                + Convert.ToInt64(txtgianhapxuat.Text) + "";
                            cmd.Parameters.Add("@ThanhTien", SqlDbType.BigInt).Value = ""
                                + Convert.ToInt64(txtthanhtien.Text) + "";
                            cmd.Parameters.Add("@GTGT", SqlDbType.Int).Value = ""
                                + Convert.ToInt32(txtGTGT.Text) + "";
                            cmd.Parameters.Add("@TongTien", SqlDbType.BigInt).Value = ""
                                + Convert.ToInt64(txttongtien.Text) + "";
                            connect.Open();
                            cmd.ExecuteNonQuery();
                            connect.Close();
                            MessageBox.Show("Thêm Thành Công!\nMã Hóa Đơn:"
                                + txtmahoadon.Text
                                + "\nMã Hàng:" + txtmahang.Text
                                + "\nSố Lượng:" + Convert.ToInt32(txtsoluong.Text)
                                + "\nGiá Xuất:" + Convert.ToInt64(txtgianhapxuat.Text)
                                + "\nThành Tiền:" + Convert.ToInt32(txtsoluong.Text) * Convert.ToInt64(txtgianhapxuat.Text)
                                + "\nGiá Trị Gia Tăng:" + Convert.ToInt32(txtGTGT.Text)
                                + "\nTổng Tiền:" + (Convert.ToInt64(txtsoluong.Text) * Convert.ToInt64(txtgianhapxuat.Text)
                                + Convert.ToInt32(txtGTGT.Text)) + ""
                                , "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Load_dgv();
                            btn_chinhsua_Click(sender, e);
                        }
                        catch
                        {
                                MessageBox.Show("Thêm Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                Load_dgv();
                                btnthem_Click(sender, e);
                            
                        }
                    }

                }
                else
                {

                    try
                    {
                        SqlCommand cmd = new SqlCommand("Update_HoaDonXuat"); cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = connect;
                        cmd.Parameters.Add("@MaHD", SqlDbType.VarChar).Value = ""
                                    + txtmahoadon.Text + "";
                        cmd.Parameters.Add("@Mahang", SqlDbType.VarChar).Value = ""
                            + txtmahang.Text + "";
                        cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = ""
                            + Convert.ToInt32(txtsoluong.Text) + "";
                        cmd.Parameters.Add("@GiaXuat", SqlDbType.BigInt).Value = ""
                            + Convert.ToInt64(txtgianhapxuat.Text) + "";
                        cmd.Parameters.Add("@ThanhTien", SqlDbType.BigInt).Value = ""
                            + Convert.ToInt64(txtthanhtien.Text) + "";
                        cmd.Parameters.Add("@GTGT", SqlDbType.Int).Value = ""
                            + Convert.ToInt32(txtGTGT.Text) + "";
                        cmd.Parameters.Add("@TongTien", SqlDbType.BigInt).Value = ""
                            + Convert.ToInt64(txttongtien.Text) + "";
                        connect.Open();
                        cmd.ExecuteNonQuery();
                        connect.Close();
                        MessageBox.Show("Sửa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_dgv();
                        btn_chinhsua_Click(sender, e);
                    }
                    catch
                    {
                        MessageBox.Show("Sửa Thất Bại!\nVui Lòng Thử Lại Sau", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Load_dgv();
                        btn_chinhsua_Click(sender, e);
                    }

                }
            }
        }

        private void dgvhoadonxuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvhoadonxuat.Enabled == true)
            {
                txtmahoadon.DataBindings.Clear();
                txtmahoadon.DataBindings.Add("Text", dgvhoadonxuat.DataSource, "MaHD");
                txtmahang.DataBindings.Clear();
                txtmahang.DataBindings.Add("Text", dgvhoadonxuat.DataSource, "MaHang");
                txtsoluong.DataBindings.Clear();
                txtsoluong.DataBindings.Add("Text", dgvhoadonxuat.DataSource, "SoLuong");
                txtgianhapxuat.DataBindings.Clear();
                txtgianhapxuat.DataBindings.Add("Text", dgvhoadonxuat.DataSource, "GiaXuat");
                txtthanhtien.DataBindings.Clear();
                txtthanhtien.DataBindings.Add("Text", dgvhoadonxuat.DataSource, "ThanhTien");
                txtGTGT.DataBindings.Clear();
                txtGTGT.DataBindings.Add("Text", dgvhoadonxuat.DataSource, "GTGT");
                txttongtien.DataBindings.Clear();
                txttongtien.DataBindings.Add("Text", dgvhoadonxuat.DataSource, "TongTien");
            }
        }

        private void dgvhoadonnhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvhoadonnhap.Enabled == true)
            {
                txtmahoadon.DataBindings.Clear();
                txtmahoadon.DataBindings.Add("Text", dgvhoadonnhap.DataSource, "MaHD");
                txtmahang.DataBindings.Clear();
                txtmahang.DataBindings.Add("Text", dgvhoadonnhap.DataSource, "MaHang");
                txtsoluong.DataBindings.Clear();
                txtsoluong.DataBindings.Add("Text", dgvhoadonnhap.DataSource, "SoLuong");
                txtgianhapxuat.DataBindings.Clear();
                txtgianhapxuat.DataBindings.Add("Text", dgvhoadonnhap.DataSource, "GiaNhap");
                txtthanhtien.DataBindings.Clear();
                txtthanhtien.DataBindings.Add("Text", dgvhoadonnhap.DataSource, "ThanhTien");
                txtGTGT.DataBindings.Clear();
                txtGTGT.DataBindings.Add("Text", dgvhoadonnhap.DataSource, "GTGT");
                txttongtien.DataBindings.Clear();
                txttongtien.DataBindings.Add("Text", dgvhoadonnhap.DataSource, "TongTien");
            }
        }

        private void btnnhap_Click(object sender, EventArgs e)
        {
            An();
            rdbhoadon.Show();
            rdbmahang.Show();
            rdbhoadon.Checked = false;
            rdbmahang.Checked = false;
            lbtimkiem.Text = "Vui Lòng Click Vào Mục cần Tìm";
            btnnhap.BackColor = Color.White;
            btnxuat.BackColor = menuStrip1.BackColor;
            btn_chinhsua.BackColor = menuStrip1.BackColor;
            lbgianhapxuat.Text = "Giá Nhập";
            dgvhoadonnhap.Enabled = true;
            dgvhoadonxuat.Enabled = false;
            txttimkiem.Text = "";
            txtmahoadon.Text = "";
            txtmahang.Text = "";
            txtsoluong.Text = "";
            txtgianhapxuat.Text = "";
            txtthanhtien.Text = "";
            txtGTGT.Text = "";
            txttongtien.Text = "";
            lbinfor.Hide();
            if (dgvhoadonnhap.Enabled == true)
            {
                btnxuat.ForeColor = menuStrip1.ForeColor;
                btnnhap.ForeColor = menuStrip1.ForeColor;
            }
            dgvhoadonnhap.Show();
            dgvhoadonnhap.Size = new Size(1281, 731);
            var dap1 = new SqlDataAdapter("Select * from HoaDonNhap", connect);
            var table1 = new DataTable();
            dap1.Fill(table1);
            dgvhoadonnhap.DataSource = table1;
            dgvhoadonxuat.Hide();
            btnhuy.Hide();
            btnxemhoadon.Show();
            txttimkiem.Show();
            btntimkiem.Show();
            lbtimkiem.Show();
            Addhoadonnhapxuat = false;
        }

        private void btnxuat_Click(object sender, EventArgs e)
        {
            An();
            rdbhoadon.Show();
            rdbmahang.Show();
            rdbhoadon.Checked = false;
            rdbmahang.Checked = false;
            txttimkiem.Text = "";
            lbtimkiem.Text = "Vui Lòng Click Vào Mục cần Tìm";
            btnxuat.BackColor = Color.White;
            btnnhap.BackColor = menuStrip1.BackColor;
            btn_chinhsua.BackColor = menuStrip1.BackColor;
            dgvhoadonxuat.Enabled = true;
            dgvhoadonnhap.Enabled = false;
            txtmahoadon.Text = "";
            txtmahang.Text = "";
            txtsoluong.Text = "";
            txtgianhapxuat.Text = "";
            txtthanhtien.Text = "";
            txtGTGT.Text = "";
            txttongtien.Text = "";
            lbinfor.Hide();
            if (dgvhoadonxuat.Enabled == true)
            {
                btnxuat.ForeColor = menuStrip1.ForeColor;
                btnnhap.ForeColor = menuStrip1.ForeColor;
            }
            dgvhoadonxuat.Show();
            dgvhoadonxuat.Size = new Size(1281, 731);
            var dap2 = new SqlDataAdapter("Select * from HoaDonXuat", connect);
            var table2 = new DataTable();
            dap2.Fill(table2);
            dgvhoadonxuat.DataSource = table2;
            dgvhoadonnhap.Hide();
            btnhuy.Hide();
            btnxemhoadon.Show();
            txttimkiem.Show();
            btntimkiem.Show();
            lbtimkiem.Show();
            lbgianhapxuat.Text = "Giá Xuất";
            Addhoadonnhapxuat = false;
        }
        private void Load_dgv()
        {
            txttimkiem.Text = "";
            if (dgvhoadonnhap.Enabled == true)
            {
                var dap1 = new SqlDataAdapter("Select * from HoaDonNhap", connect);
                var table1 = new DataTable();
                dap1.Fill(table1);
                dgvhoadonnhap.DataSource = table1;
            }
            if (dgvhoadonxuat.Enabled == true)
            {
                var dap2 = new SqlDataAdapter("Select * from HoaDonXuat", connect);
                var table2 = new DataTable();
                dap2.Fill(table2);
                dgvhoadonxuat.DataSource = table2;
            }
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnhuy.Enabled = false;
            btnluu.Enabled = false;
        }
        private void btn_chinhsua_Click(object sender, EventArgs e)
        {
            txtmahoadon.Text = "";
            txtmahang.Text = "";
            txtsoluong.Text = "";
            txtgianhapxuat.Text = "";
            txtthanhtien.Text = "";
            txtGTGT.Text = "";
            txttongtien.Text = "";
            txttimkiem.Text = "";
            lbtimkiem.Text = "Vui Lòng Click Vào Mục cần Tìm";
            Load_dgv();
            
            if (dgvhoadonnhap.Enabled == true || dgvhoadonxuat.Enabled == true)
            {
                rdbhoadon.Show();
                rdbmahang.Show();
                rdbhoadon.Checked = false;
                rdbmahang.Checked = false;
                dgvhoadonnhap.Size = new Size(1281, 504);
                dgvhoadonxuat.Size = new Size(1281, 504);
                btn_chinhsua.BackColor = Color.White;
                btnxuat.BackColor = menuStrip1.BackColor;
                btnnhap.BackColor = menuStrip1.BackColor;
                Hien();
                Disconnect_text_label();
                btnthem.Show();
                btnthem.Enabled = true;
                btnsua.Show();
                btnsua.Enabled = true;
                btnxoa.Show();
                btnxoa.Enabled = true;
                btnluu.Show();
                btnluu.Enabled = false;
                btnhuy.Show();
                btnhuy.Enabled = false;
                btnxemhoadon.Hide();
                lbtimkiem.Show();
                txttimkiem.Show();
                btntimkiem.Show();
                lbinfor.Show();
                lbinfor.Text = "";
            }
            if (dgvhoadonnhap.Enabled == true)
            {
                btnnhap.ForeColor = Color.Green;
                btnxuat.ForeColor = menuStrip1.ForeColor;
            }
            else
            {
                if (dgvhoadonxuat.Enabled == true)
                {
                    btnxuat.ForeColor = Color.Green;
                    btnnhap.ForeColor = menuStrip1.ForeColor;
                }
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            btn_chinhsua_Click(sender, e);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmahoadon.Text == "")
            {
                MessageBox.Show("Vui Lòng Chọn Hóa Đơn Cần Xóa!");
            }
            else
            {
                DialogResult d;
                d = MessageBox.Show("Bạn Thật Sự Muốn Xóa Hóa Đơn\nVới Mã Hóa Đơn:"
                    + txtmahoadon.Text + " Chứ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    if (dgvhoadonnhap.Enabled == true)
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("Delete_HoaDonNhap");
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = connect;
                            cmd.Parameters.Add("@MaHD", SqlDbType.VarChar).Value = ""
                                + txtmahoadon.Text + "";
                            connect.Open();
                            cmd.ExecuteNonQuery();
                            connect.Close();
                            MessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Load_dgv();
                            btn_chinhsua_Click(sender, e);
                        }
                        catch
                        {
                            MessageBox.Show("Xóa Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Load_dgv();
                            btn_chinhsua_Click(sender, e);
                        }
                    }
                    else
                        if (dgvhoadonxuat.Enabled == true)
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("Delete_HoaDonXuat");
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = connect;
                            cmd.Parameters.Add("@MaHD", SqlDbType.VarChar).Value = ""
                                + txtmahoadon.Text + "";
                            connect.Open();
                            cmd.ExecuteNonQuery();
                            connect.Close();
                            MessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Load_dgv();
                            btn_chinhsua_Click(sender, e);
                        }
                        catch
                        {
                            MessageBox.Show("Xóa Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Load_dgv();
                            btn_chinhsua_Click(sender, e);
                        }
                    }
                }
                else
                {
                }
            }
        }
        private void Tim_maHD()
        {
            if (dgvhoadonnhap.Enabled == true)
            {
                var dap1 = new SqlDataAdapter(
                       "Select * from HoaDonNhap Where MaHD like '%"
                       + txttimkiem.Text + "%'", connect);
                var table1 = new DataTable();
                dap1.Fill(table1);
                dgvhoadonnhap.DataSource = table1;
            }
            else
            {
                if (dgvhoadonxuat.Enabled == true)
                {
                    var dap2 = new SqlDataAdapter(
                         "Select * from HoaDonXuat Where MaHD like '%"
                         + txttimkiem.Text + "%'", connect);
                    var table2 = new DataTable();
                    dap2.Fill(table2);
                    dgvhoadonxuat.DataSource = table2;
                }

            }

        }
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (rdbhoadon.Checked == false && rdbmahang.Checked == false
                && (dgvhoadonnhap.Enabled == true || dgvhoadonxuat.Enabled == true))
            {
                MessageBox.Show("Vui Lòng Click Vào Mục Cần Tìm!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txttimkiem.Text == "")
                {
                    MessageBox.Show("Vui Lòng Nhập Thông Tin Cần Tìm!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (rdbhoadon.Checked == true)
                    {
                        Tim_maHD();
                        Ktra_MaHD_Timkiem();
                    }
                    if (rdbmahang.Checked == true)
                    {
                        TimMahang();
                        Ktra_MaHang_timkiem();
                    }
                }
            }
        }
        private void ktr_mahoadon(object sender, EventArgs e)
        {
            try
            {
                if (dgvhoadonnhap.Enabled == true)
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand(
                        "SELECT COUNT(*) from HoaDonNhap where  MaHD like @MaHD", connect);
                    cmd.Parameters.AddWithValue("@MaHD", txtmahoadon.Text);
                    int MaHDCount = (int)cmd.ExecuteScalar();
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    if (MaHDCount > 0)
                    {
                        MessageBox.Show("Mã Hóa Đơn Đã Tồn Tại\nVui Lòng Nhập Mã Hóa Đơn Khác ", "Thông Báo");
                        txtmahoadon.Focus();
                    }
                    else
                    {
                    }
                }
                else
                {
                    if (dgvhoadonxuat.Enabled == true)
                    {
                        connect.Open();
                        SqlCommand cmd = new SqlCommand(
                            "SELECT COUNT(*) from HoaDonXuat where  MaHD like @MaHD", connect);
                        cmd.Parameters.AddWithValue("@MaHD", txtmahoadon.Text);
                        int MaHDCount = (int)cmd.ExecuteScalar();
                        cmd.ExecuteNonQuery();
                        connect.Close();
                        if (MaHDCount > 0)
                        {
                            MessageBox.Show("Mã Hóa Đơn Đã Tồn Tại\nVui Lòng Nhập Mã Hóa Đơn Khác ", "Thông Báo");
                            txtmahoadon.Focus();
                        }
                        else
                        {
                        }
                    }
                }
            }
            catch { }
        }
        private void Ktra_MaHD_Timkiem()
        {
            try
            {
                if (dgvhoadonnhap.Enabled == true)
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand(
                        "SELECT COUNT(*) from HoaDonNhap where  MaHD like @MaHD", connect);
                    cmd.Parameters.AddWithValue("@MaHD", txttimkiem.Text);
                    int MaHDCount = (int)cmd.ExecuteScalar();
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    if (MaHDCount < 1)
                    {
                        MessageBox.Show("Mã Hóa Đơn Không Tồn Tại\nVui Lòng Nhập Mã Hóa Đơn Khác ", "Thông Báo");

                    }

                }
                else
                {
                    if (dgvhoadonxuat.Enabled == true)
                    {
                        connect.Open();
                        SqlCommand cmd = new SqlCommand(
                            "SELECT COUNT(*) from HoaDonXuat where  MaHD like @MaHD", connect);
                        cmd.Parameters.AddWithValue("@MaHD", txttimkiem.Text);
                        int MaHDCount = (int)cmd.ExecuteScalar();
                        cmd.ExecuteNonQuery();
                        connect.Close();
                        if (MaHDCount < 1)
                        {
                            MessageBox.Show("Mã Hóa Đơn Không Tồn Tại\nVui Lòng Nhập Mã Hóa Đơn Khác ", "Thông Báo");
                        }


                    }
                }
            }
            catch { }
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            
                if(rdbmahang.Checked==true)
                {
                    TimMahang();
                }    
                if(rdbhoadon.Checked==true)
                {
                   Tim_maHD();
                }    
             
        }

        private void txtmahoadon_Leave(object sender, EventArgs e)
        {
            ktr_mahoadon(sender, e);
        }

        private void txtgianhapxuat_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtthanhtien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttongtien_TextChanged(object sender, EventArgs e)
        {

        }
        private void ktr_mahang(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT COUNT(*) from HangHoa where  MaHang like @MaHang", connect);
                cmd.Parameters.AddWithValue("@MaHang", txtmahang.Text);
                int MaHangCount = (int)cmd.ExecuteScalar();
                cmd.ExecuteNonQuery();
                connect.Close();
                if (MaHangCount < 1)
                {
                    MessageBox.Show("Mã Hàng Không Tồn Tại\nVui Lòng Nhập Mã Khác ", "Thông Báo");
                    txtmahang.Focus();
                }
                else
                {
                }
            }
            catch { }

        }
        private void txtmahang_Leave(object sender, EventArgs e)
        {

            ktr_mahang(sender, e);

        }

        private void txtthanhtien_Click(object sender, EventArgs e)
        {
            lbinfor.Text = "Có Thể Nhập Giá Trị Bất Kì(Giá Trị Là Số)\nKhi Lưu Hệ Thống Sẽ Tự Động Tính Toán Kết Quả Chính Xác";
        }

        private void txttongtien_Click(object sender, EventArgs e)
        {

            lbinfor.Text = "Có Thể Nhập Giá Trị Bất Kì(Giá Trị Là Số)\nKhi Lưu Hệ Thống Sẽ Tự Động Tính Toán Kết Quả Chính Xác";
        }
        private void Ktra_MaHang_timkiem()
        {
            try
            {
                if (dgvhoadonnhap.Enabled == true)
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand(
                        "SELECT COUNT(*) from HoaDonNhap where  MaHang like @MaHang", connect);
                    cmd.Parameters.AddWithValue("@MaHang", txttimkiem.Text);
                    int MaHangCount = (int)cmd.ExecuteScalar();
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    if (MaHangCount < 1)
                    {
                        MessageBox.Show("Mã Hàng Không Tồn Tại\nVui Lòng Nhập Mã Khác ", "Thông Báo");

                    }

                }
                else
                {
                    if (dgvhoadonxuat.Enabled == true)
                    {
                        connect.Open();
                        SqlCommand cmd = new SqlCommand(
                            "SELECT COUNT(*) from HoaDonXuat where  MaHang like @MaHang", connect);
                        cmd.Parameters.AddWithValue("@MaHang", txttimkiem.Text);
                        int MaHangCount = (int)cmd.ExecuteScalar();
                        cmd.ExecuteNonQuery();
                        connect.Close();
                        if (MaHangCount < 1)
                        {
                            MessageBox.Show("Mã Hàng Không Tồn Tại\nVui Lòng Nhập Mã Khác ", "Thông Báo");
                        }


                    }
                }
            }
            catch { }
        }
        private void Show_text_timkiem()
        {
            if (rdbhoadon.Checked == false && rdbmahang.Checked == false)
            {
                lbtimkiem.Text = "Vui Lòng Click Vào Mục Cần Tìm";
            }
            else
            {
                if(rdbhoadon.Checked==true)
                {
                    lbtimkiem.Text = "Nhập Mã Hóa Đơn Cần Tìm";
                }
                if(rdbmahang.Checked==true)
                {
                    lbtimkiem.Text = "Nhập Mã Hàng Cần Tìm";
                }    
            }    
                   
        }
        private void TimMahang()
        {
            if (dgvhoadonnhap.Enabled == true)
            {
                var dap1 = new SqlDataAdapter(
                       "Select * from HoaDonNhap Where MaHang like '%"
                       + txttimkiem.Text + "%'", connect);
                var table1 = new DataTable();
                dap1.Fill(table1);
                dgvhoadonnhap.DataSource = table1;
            }
            else
            {
                if (dgvhoadonxuat.Enabled == true)
                {
                    var dap2 = new SqlDataAdapter(
                         "Select * from HoaDonXuat Where MaHang like '%"
                         + txttimkiem.Text + "%'", connect);
                    var table2 = new DataTable();
                    dap2.Fill(table2);
                    dgvhoadonxuat.DataSource = table2;
                }

            }
        }

        private void rdbhoadon_Click(object sender, EventArgs e)
        {
            Show_text_timkiem();
            txttimkiem.Text = "";
        }

        private void rdbmahang_Click(object sender, EventArgs e)
        {
            Show_text_timkiem();
            txttimkiem.Text = "";
        }

        private void txtthanhtien_Leave(object sender, EventArgs e)
        {
            lbinfor.Text = "";
        }

        private void txttongtien_Leave(object sender, EventArgs e)
        {
            lbinfor.Text = "";
        }
    }
}
