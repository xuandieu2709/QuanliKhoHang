using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanliKhoHang
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(
        @"Data Source=DESKTOP-Q0B8QHD\MSSQLSERVER02;Initial Catalog=Quanlikhohang;Integrated Security=True");

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dgvnhapkho.Hide();
            dgvnhapkho.Enabled = false;
            dgvxuatkho.Hide();
            dgvxuatkho.Enabled = false;
            dgvNCC.Hide();
            dgvNCC.Enabled = false;
            Hide_lb_text();
            btnthem.Hide();
            btnsua.Hide();
            btnxoa.Hide();
            btnhuy.Hide();
            btnluu.Hide();
            lbtimkiem.Hide();
            txttimkiem.Hide();
            btntimkiem.Hide();
            lbtimkiem.Text = "Vui Lòng Click Vào Mục Cần Tìm!";
            rdbmahang_NCC.Hide();
            rdbmanhapxuat.Hide();
            rdbmaNCC_tenNCC.Hide();
            dgvnhapkho.Columns[3].DefaultCellStyle.Format= "dd/MM/yyyy";
            dgvxuatkho.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dtpdatetime.CustomFormat = "dd-MM-yyyy";

        }
        private void Hide_lb_text()
        {
            lbmanhapxuat.Hide();
            txtmanhapxuat.Hide();
            lbmahang.Hide();
            txtmahang.Hide();
            lbnhacc.Hide();
            txtnhacc.Hide();
            lbngaynhapxuat.Hide();
            dtpdatetime.Hide();
            lbsoluong.Hide();
            txtsoluong.Hide();
            lbghichu.Hide();
            txtghichu.Hide();

        }
        private void false_lb_text()
        {
            lbmanhapxuat.Enabled=false;
            txtmanhapxuat.Enabled = false;
            lbmahang.Enabled = false;
            txtmahang.Enabled = false;
            lbnhacc.Enabled = false;
            txtnhacc.Enabled = false;
            lbngaynhapxuat.Enabled = false;
            dtpdatetime.Enabled = false;
            lbsoluong.Enabled = false;
            txtsoluong.Enabled = false;
            lbghichu.Enabled = false;
            txtghichu.Enabled = false;
        }
        private void true_lb_text()
        {
            lbmanhapxuat.Enabled = true;
            txtmanhapxuat.Enabled = true;
            lbmahang.Enabled = true;
            txtmahang.Enabled = true;
            lbnhacc.Enabled = true;
            txtnhacc.Enabled = true;
            lbngaynhapxuat.Enabled = true;
            dtpdatetime.Enabled = true;
            lbsoluong.Enabled = true;
            txtsoluong.Enabled = true;
            lbghichu.Enabled = true;
            txtghichu.Enabled = true;
        }
        private void Show_lb_text()
        {
            lbmanhapxuat.Show();
            txtmanhapxuat.Show();
            lbmahang.Show();
            txtmahang.Show();
            lbnhacc.Show();
            txtnhacc.Show();
            lbngaynhapxuat.Show();
            dtpdatetime.Show();
            lbsoluong.Show();
            txtsoluong.Show();
            lbghichu.Show();
            txtghichu.Show();

        }

        
        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvxuatkho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvxuatkho.Enabled == true)
            {
                txtmanhapxuat.DataBindings.Clear();
                txtmanhapxuat.DataBindings.Add("Text", dgvxuatkho.DataSource, "MaXuat");
                txtmahang.DataBindings.Clear();
                txtmahang.DataBindings.Add("Text", dgvxuatkho.DataSource, "MaHang");
                txtnhacc.DataBindings.Clear();
                txtnhacc.DataBindings.Add("Text", dgvxuatkho.DataSource, "MaNCC");
                dtpdatetime.DataBindings.Clear();
                dtpdatetime.DataBindings.Add("Text", dgvxuatkho.DataSource, "NgayXuat");
                txtsoluong.DataBindings.Clear();
                txtsoluong.DataBindings.Add("Text", dgvxuatkho.DataSource, "SoLuong");
                txtghichu.DataBindings.Clear();
                txtghichu.DataBindings.Add("Text", dgvxuatkho.DataSource, "GhiChu");
            }
            dgvnhapkho.Enabled = false;
            dgvNCC.Enabled = false;
        }

        private void dgvnhapkho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvnhapkho.Enabled == true)
            {
                txtmanhapxuat.DataBindings.Clear();
                txtmanhapxuat.DataBindings.Add("Text", dgvnhapkho.DataSource, "MaNhap");
                txtmahang.DataBindings.Clear();
                txtmahang.DataBindings.Add("Text", dgvnhapkho.DataSource, "MaHang");
                txtnhacc.DataBindings.Clear();
                txtnhacc.DataBindings.Add("Text", dgvnhapkho.DataSource, "MaNCC");
                dtpdatetime.DataBindings.Clear();
                dtpdatetime.DataBindings.Add("Text", dgvnhapkho.DataSource, "NgayNhap");
                txtsoluong.DataBindings.Clear();
                txtsoluong.DataBindings.Add("Text", dgvnhapkho.DataSource, "SoLuong");
                txtghichu.DataBindings.Clear();
                txtghichu.DataBindings.Add("Text", dgvnhapkho.DataSource, "GhiChu");
            }
            dgvxuatkho.Enabled = false;
            dgvNCC.Enabled = false;
        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNCC.Enabled == true)
            {
                txtmanhapxuat.DataBindings.Clear();
                txtmanhapxuat.DataBindings.Add("Text", dgvNCC.DataSource, "MaNCC");
                txtmahang.DataBindings.Clear();
                txtmahang.DataBindings.Add("Text", dgvNCC.DataSource, "TenNCC");
                txtnhacc.DataBindings.Clear();
                txtnhacc.DataBindings.Add("Text", dgvNCC.DataSource, "SDT");
                txtsoluong.DataBindings.Clear();
                txtsoluong.DataBindings.Add("Text", dgvNCC.DataSource, "DiaChi");
                txtghichu.DataBindings.Clear();
                txtghichu.DataBindings.Add("Text", dgvNCC.DataSource, "GhiChu");
            }
            dgvnhapkho.Enabled = false;
            dgvxuatkho.Enabled = false;
        }
        private void show_timkiem()
        {
            lbtimkiem.Show();
            txttimkiem.Show();
            btntimkiem.Show();
            rdbmahang_NCC.Show();
            rdbmanhapxuat.Show();
            rdbmaNCC_tenNCC.Show();
        }

        private void btnNhaphang_Click(object sender, EventArgs e)
        {
            txttimkiem.Size = new Size(359, 32);
            btnNhaphang.BackColor = Color.White;
            btnNhaphang.ForeColor = menuStrip1.ForeColor;
            btnXuathang.ForeColor = menuStrip1.ForeColor;
            btnNhaCC.ForeColor = menuStrip1.ForeColor;
            btn_Chinhsua.BackColor = menuStrip1.BackColor;
            btnXuathang.BackColor = menuStrip1.BackColor;
            btnNhaCC.BackColor = menuStrip1.BackColor;
            dgvnhapkho.Size = new Size(1283, 748);
            dgvnhapkho.Show();
            dgvnhapkho.Enabled = true;
            dgvNCC.Hide();
            dgvNCC.Enabled = false;
            dgvxuatkho.Hide();
            dgvxuatkho.Enabled = false;
            var dap = new SqlDataAdapter("Select * from NhapHang", connect);
            var table = new DataTable();
            dap.Fill(table);
            dgvnhapkho.DataSource = table;
            show_timkiem();
            lbmanhapxuat.Text = "Mã Nhập";
            lbngaynhapxuat.Text = "Ngày Nhập";
            lbmahang.Text = "Mã Hàng";
            lbnhacc.Text = "Mã Nhà Cung Cấp";
            lbsoluong.Text = "Số Lượng";
            txtmanhapxuat.Text = "";
            txtmahang.Text = "";
            txtnhacc.Text = "";
            dtpdatetime.Value = DateTime.Today;
            txtsoluong.Text = "";
            txtghichu.Text = "";
            Hide_lb_text();
            btnthem.Hide();
            btnsua.Hide();
            btnxoa.Hide();
            btnhuy.Hide();
            btnluu.Hide();
            lbtimkiem.Text = "Vui Lòng Click Vào Mục Cần Tìm";
            rdbmanhapxuat.Checked = false;
            rdbmaNCC_tenNCC.Checked = false;
            rdbmahang_NCC.Checked = false;
            rdbmanhapxuat.Text = "Mã Nhập";
            rdbmahang_NCC.Text = "Mã Hàng";
            rdbmahang_NCC.Location = new Point(907, 25);
            rdbmaNCC_tenNCC.Text = "Mã Nhà Cung Cấp";
            txttimkiem.Text = "";
            
        }
        private void ReLoad_Nhap_XuatNCC()
        {
            txttimkiem.Text = "";
            if (dgvnhapkho.Enabled==true ||  dgvxuatkho.Enabled==true )
            {
                var dap1 = new SqlDataAdapter("Select * from NhapHang", connect);
                var table1 = new DataTable();
                dap1.Fill(table1);
                dgvnhapkho.DataSource = table1;
                var dap2 = new SqlDataAdapter("Select * from XuatHang", connect);
                var table2= new DataTable();
                dap2.Fill(table2);
                dgvxuatkho.DataSource = table2;
                btnthem.Show();
                btnthem.Enabled = true;
                btnsua.Show();
                btnsua.Enabled = true;
                btnxoa.Show();
                btnxoa.Enabled = true;
                btnhuy.Show();
                btnhuy.Enabled = false;
                btnluu.Show();
                btnluu.Enabled = false;
                Show_lb_text();
                false_lb_text();
            }
            else
                if(dgvNCC.Enabled==true)
            {
                var dap3 = new SqlDataAdapter("Select * from NhaCungCap", connect);
                var table3 = new DataTable();
                dap3.Fill(table3);
                dgvNCC.DataSource = table3;
                btnthem.Show();
                btnthem.Enabled = true;
                btnsua.Show();
                btnsua.Enabled = true;
                btnxoa.Show();
                btnxoa.Enabled = true;
                btnhuy.Show();
                btnhuy.Enabled = false;
                btnluu.Show();
                btnluu.Enabled = false;
                Show_lb_text();
                false_lb_text();
                lbngaynhapxuat.Hide();
                dtpdatetime.Hide();
            }
        }
        private void btnXuathang_Click(object sender, EventArgs e)
        {
            txttimkiem.Size = new Size(359, 32);
            dgvxuatkho.Size = new Size(1283, 748);
            dgvxuatkho.Show();
            dgvxuatkho.Enabled = true;
            dgvnhapkho.Hide();
            dgvnhapkho.Enabled = false;
            dgvNCC.Hide();
            dgvNCC.Enabled = false;
            btnXuathang.BackColor = Color.White;
            btnXuathang.ForeColor = menuStrip1.ForeColor;
            btnNhaphang.ForeColor = menuStrip1.ForeColor;
            btnNhaCC.ForeColor = menuStrip1.ForeColor;
            btn_Chinhsua.BackColor = menuStrip1.BackColor;
            btnNhaphang.BackColor = menuStrip1.BackColor;
            btnNhaCC.BackColor = menuStrip1.BackColor;
            var dap = new SqlDataAdapter("Select * from XuatHang", connect);
            var table = new DataTable();
            dap.Fill(table);
            dgvxuatkho.DataSource = table;
            show_timkiem();
            lbmanhapxuat.Text = "Mã Xuất";
            lbngaynhapxuat.Text = "Ngày Xuất";
            lbmahang.Text = "Mã Hàng";
            lbnhacc.Text = "Mã Nhà Cung Cấp";
            lbsoluong.Text = "Số Lượng";
            txtmanhapxuat.Text = "";
            txtmahang.Text = "";
            txtnhacc.Text = "";
            dtpdatetime.Value = DateTime.Today;
            txtsoluong.Text = "";
            txtghichu.Text = "";
            lbtimkiem.Text = "Vui Lòng Click Vào Mục Cần Tìm";
            rdbmanhapxuat.Checked = false;
            rdbmaNCC_tenNCC.Checked = false;
            rdbmahang_NCC.Checked = false;
            rdbmanhapxuat.Text = "Mã Xuất";
            rdbmahang_NCC.Text = "Mã Hàng";
            rdbmahang_NCC.Location = new Point(907, 25);
            rdbmaNCC_tenNCC.Text = "Mã Nhà Cung Cấp";
            txttimkiem.Text = "";
            Hide_lb_text();
            btnthem.Hide();
            btnsua.Hide();
            btnxoa.Hide();
            btnhuy.Hide();
            btnluu.Hide();


        }

        private void btn_Chinhsua_Click(object sender, EventArgs e)
        {

            dgvnhapkho.Size = new Size(1283, 561);
            dgvxuatkho.Size = new Size(1283, 561);
            dgvNCC.Size = new Size(1283, 561);
            txtmanhapxuat.Text = "";
            txtmahang.Text = "";
            txtnhacc.Text = "";
            txtsoluong.Text = "";
            dtpdatetime.Value = DateTime.Today;
            txtghichu.Text = "";
            ReLoad_Nhap_XuatNCC();
            if (dgvnhapkho.Enabled == true || dgvxuatkho.Enabled == true)
            {
                show_timkiem();
                Show_lb_text();
                false_lb_text();
                btnthem.Show();
                btnthem.Enabled = true;
                btnsua.Show();
                btnsua.Enabled = true;
                btnxoa.Show();
                btnxoa.Enabled = true;
                btnhuy.Show();
                btnhuy.Enabled = false;
                btnluu.Show();
                btnluu.Enabled = false;
                btn_Chinhsua.BackColor = Color.White;
                btnNhaphang.BackColor = menuStrip1.BackColor;
                btnXuathang.BackColor = menuStrip1.BackColor;
                btnNhaCC.BackColor = menuStrip1.BackColor;
                lbngaynhapxuat.Show();
                dtpdatetime.Show();
                if(dgvnhapkho.Enabled==true)
                {
                    btnNhaphang.ForeColor = Color.Green;
                    btnXuathang.ForeColor = menuStrip1.ForeColor;
                    btnNhaCC.ForeColor = menuStrip1.ForeColor;
                } 
                else
                if(dgvxuatkho.Enabled==true)
                {
                    btnXuathang.ForeColor = Color.Green;
                    btnNhaphang.ForeColor = menuStrip1.ForeColor;
                    btnNhaCC.ForeColor = menuStrip1.ForeColor;

                }    
            }
            else
             if (dgvNCC.Enabled == true)
            {
                show_timkiem();
                Show_lb_text();
                false_lb_text();
                btnthem.Show();
                btnthem.Enabled = true;
                btnsua.Show();
                btnsua.Enabled = true;
                btnxoa.Show();
                btnxoa.Enabled = true;
                btnhuy.Show();
                btnhuy.Enabled = false;
                btnluu.Show();
                btnluu.Enabled = false;
                btn_Chinhsua.BackColor = Color.White;
                btnNhaphang.BackColor = menuStrip1.BackColor;
                btnXuathang.BackColor = menuStrip1.BackColor;
                btnNhaCC.BackColor = menuStrip1.BackColor;
                btnNhaCC.ForeColor = Color.Green;
                btnNhaphang.ForeColor = menuStrip1.ForeColor;
                btnXuathang.ForeColor = menuStrip1.ForeColor;
                lbngaynhapxuat.Hide();
                dtpdatetime.Hide();
            }
        }

        private void btnNhaCC_Click(object sender, EventArgs e)
        {
            btnNhaCC.BackColor = Color.White;
            btnNhaCC.ForeColor = menuStrip1.ForeColor;
            btnNhaphang.ForeColor = menuStrip1.ForeColor;
            btnXuathang.ForeColor = menuStrip1.ForeColor;
            btn_Chinhsua.BackColor = menuStrip1.BackColor;
            btnNhaphang.BackColor = menuStrip1.BackColor;
            btnXuathang.BackColor = menuStrip1.BackColor;
            dgvNCC.Show();
            dgvNCC.Enabled = true;
            dgvNCC.Size = new Size(1283, 748);
            dgvnhapkho.Hide();
            dgvnhapkho.Enabled = false;
            dgvxuatkho.Hide();
            dgvxuatkho.Enabled = false;
            var dap = new SqlDataAdapter("Select * from NhaCungCap", connect);
            var table = new DataTable();
            dap.Fill(table);
            dgvNCC.DataSource = table;
            show_timkiem();
            lbtimkiem.Text = "Vui Lòng Click Vào Mục Cần Tìm";
            rdbmanhapxuat.Checked = false;
            rdbmaNCC_tenNCC.Checked = false;
            rdbmahang_NCC.Checked = false;
            lbmanhapxuat.Text = "Mã Nhà Cung Cấp";
            lbmahang.Text = "Tên Nhà Cung Cấp";
            lbnhacc.Text = "Số Điện Thoại";
            lbsoluong.Text = "Địa Chỉ";
            lbghichu.Text = "Ghi Chú";
            txtmanhapxuat.Text = "";
            txtmahang.Text = "";
            txtnhacc.Text = "";
            txtsoluong.Text = "";
            txtghichu.Text = "";
            rdbmanhapxuat.Hide();
            rdbmahang_NCC.Text = "Mã Nhà Cung Cấp";
            rdbmahang_NCC.Location = new Point(767, 25);
            rdbmaNCC_tenNCC.Text = "Tên Nhà Cung Cấp";
            txttimkiem.Text = "";
            Hide_lb_text();
            btnthem.Hide();
            btnsua.Hide();
            btnxoa.Hide();
            btnhuy.Hide();
            btnluu.Hide();
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Boolean Add_NhapXuatHang_NCC;
        private void btnthem_Click(object sender, EventArgs e)
        {
            Add_NhapXuatHang_NCC = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnhuy.Enabled = true;
            btnluu.Enabled = true;
            txtmanhapxuat.Text = "";
            txtmahang.Text = "";
            txtnhacc.Text = "";
            dtpdatetime.Value = DateTime.Today;
            txtsoluong.Text = "";
            txtghichu.Text = "";
            Show_lb_text();
            true_lb_text();
            if(dgvNCC.Enabled==true)
            {
                lbngaynhapxuat.Hide();
                dtpdatetime.Hide();
            }    
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            Add_NhapXuatHang_NCC = false;
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            btnhuy.Enabled = true;
            btnluu.Enabled = true;
            Show_lb_text();
            true_lb_text();

            txtmanhapxuat.Enabled = false;
            if (dgvNCC.Enabled == true)
            {
                lbngaynhapxuat.Hide();
                dtpdatetime.Hide();
            }
        }
        private void ktr_manhapxuat_NCC(object sender, EventArgs e)
        {
            try
            {
                if (dgvnhapkho.Enabled == true)
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand(
                        "SELECT COUNT(*) from NhapHang where  MaNhap like @MaNhap", connect);
                    cmd.Parameters.AddWithValue("@MaNhap", txtmanhapxuat.Text);
                    int MaNhapCount = (int)cmd.ExecuteScalar();
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    if (MaNhapCount > 0)
                    {
                        MessageBox.Show("Mã Nhập Đã Tồn Tại\nVui Lòng Nhập Mã Khác ", "Thông Báo");
                        txtmanhapxuat.Focus();
                    }
                    else
                    {
                    }
                }
                if (dgvxuatkho.Enabled == true)
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand(
                        "SELECT COUNT(*) from XuatHang where  MaXuat like @MaXuat", connect);
                    cmd.Parameters.AddWithValue("@MaXuat", txtmanhapxuat.Text);
                    int MaXuatCount = (int)cmd.ExecuteScalar();
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    if (MaXuatCount > 0)
                    {
                        MessageBox.Show("Mã Xuất Đã Tồn Tại\nVui Lòng Nhập Mã Khác ", "Thông Báo");
                        txtmanhapxuat.Focus();
                    }
                    else
                    {
                    }
                }
                if (dgvNCC.Enabled == true)
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand(
                        "SELECT COUNT(*) from NhaCungCap where  MaNCC like @MaNCC", connect);
                    cmd.Parameters.AddWithValue("@MaNCC", txtmanhapxuat.Text);
                    int MaNCCCount = (int)cmd.ExecuteScalar();
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    if (MaNCCCount > 0)
                    {
                        MessageBox.Show("Mã Nhà Cung Cấp Đã Tồn Tại\nVui Lòng Nhập Mã Khác ", "Thông Báo");
                        txtmanhapxuat.Focus();
                    }
                    else
                    {
                    }
                }
            }
            catch { }
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            if(Add_NhapXuatHang_NCC==true)
            {
                if(dgvnhapkho.Enabled==true)
                {
                    try
                    {
                        if (txtmanhapxuat.Text == "" || txtmahang.Text == "" ||
                            txtnhacc.Text == "" || txtsoluong.Text == "")
                        {
                            MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin", "Thông Báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnthem_Click(sender, e);
                        }
                        else
                        {
                            SqlCommand cmd = new SqlCommand("Insert_NhapHang");
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = connect;
                            cmd.Parameters.Add("@MaNhap", SqlDbType.VarChar).Value = ""
                                        + txtmanhapxuat.Text + "";
                            cmd.Parameters.Add("@MaHang", SqlDbType.VarChar).Value = ""
                                       + txtmahang.Text + "";
                            cmd.Parameters.Add("@MaNCC", SqlDbType.VarChar).Value = ""
                                       + txtnhacc.Text + "";
                            cmd.Parameters.Add("@NgayNhap", SqlDbType.DateTime).Value = ""
                                       + dtpdatetime.Text + "";
                            cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = ""
                                       + Convert.ToInt32(txtsoluong.Text) + "";
                            cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = ""
                                       + txtghichu.Text + "";
                            connect.Open();
                            cmd.ExecuteNonQuery();
                            connect.Close();
                            MessageBox.Show(
                                "Thêm Thành Công!\nMã Nhập:" + txtmanhapxuat.Text
                                + "\nMã Hàng:" + txtmahang.Text
                                + "\nMã Nhà Cung Cấp:" + txtnhacc.Text
                                + "\nNgày Nhập :" + dtpdatetime.Text
                                + "\nSố Lượng:" + Convert.ToInt32(txtsoluong.Text)
                                + "\nGhi Chú:" + txtghichu.Text + "", "Thông Báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ReLoad_Nhap_XuatNCC();
                        }
                    }
                    catch 
                    {
                        MessageBox.Show("Thêm Thất Bại!", "Thông Báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ReLoad_Nhap_XuatNCC();
                    }
                }
                if(dgvxuatkho.Enabled==true)
                {
                    try
                    {
                        if (txtmanhapxuat.Text == "" || txtmahang.Text == "" ||
                            txtnhacc.Text == "" || txtsoluong.Text == "")
                        {
                            MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin",
                                "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnthem_Click(sender, e);
                        }
                        else
                        {
                            SqlCommand cmd = new SqlCommand("Insert_XuatHang");
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = connect;
                            cmd.Parameters.Add("@MaXuat", SqlDbType.VarChar).Value = ""
                                        + txtmanhapxuat.Text + "";
                            cmd.Parameters.Add("@MaHang", SqlDbType.VarChar).Value = ""
                                       + txtmahang.Text + "";
                            cmd.Parameters.Add("@MaNCC", SqlDbType.VarChar).Value = ""
                                       + txtnhacc.Text + "";
                            cmd.Parameters.Add("@NgayXuat", SqlDbType.DateTime).Value = ""
                                       + dtpdatetime.Text + "";
                            cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = ""
                                       + Convert.ToInt32(txtsoluong.Text) + "";
                            cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = ""
                                       + txtghichu.Text + "";
                            connect.Open();
                            cmd.ExecuteNonQuery();
                            connect.Close();
                            MessageBox.Show(
                                "Thêm Thành Công!\nMã Xuất:" + txtmanhapxuat.Text
                                + "\nMã Hàng:" + txtmahang.Text
                                + "\nMã Nhà Cung Cấp:" + txtnhacc.Text
                                + "\nNgày Xuất :" + dtpdatetime.Text
                                + "\nSố Lượng:" + Convert.ToInt32(txtsoluong.Text)
                                + "\nGhi Chú:" + txtghichu.Text + "", "Thông Báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ReLoad_Nhap_XuatNCC();
                        }
                    }
                    catch 
                    {
                        MessageBox.Show("Thêm Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ReLoad_Nhap_XuatNCC();
                    }
                }
                if(dgvNCC.Enabled==true)
                {
                    try
                    {
                        if (txtmanhapxuat.Text == "" || txtmahang.Text == "" || txtnhacc.Text == ""
                            || txtsoluong.Text == "")
                        {
                            MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnthem_Click(sender, e);
                        }
                        else
                        {
                            SqlCommand cmd = new SqlCommand("Insert_NhaCungCap");
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = connect;
                            cmd.Parameters.Add("@MaNCC", SqlDbType.VarChar).Value = ""
                                        + txtmanhapxuat.Text + "";
                            cmd.Parameters.Add("@TenNCC", SqlDbType.NVarChar).Value = ""
                                       + txtmahang.Text + "";
                            cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = ""
                                       + txtnhacc.Text + "";
                            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = ""
                                       + txtsoluong.Text + "";
                            cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = ""
                                       + txtghichu.Text + "";

                            connect.Open();
                            cmd.ExecuteNonQuery();
                            connect.Close();
                            MessageBox.Show(
                                "Thêm Thành Công!\nMã Nhà Cung Cấp:" + txtmanhapxuat.Text
                                + "\nTên Nhà Cung Cấp:" + txtmahang.Text
                                + "\nSố Điện Thoại:" + txtnhacc.Text
                                + "\nĐịa Chỉ:" + txtsoluong.Text
                                + "\nGhi Chú:" + txtghichu.Text + "", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ReLoad_Nhap_XuatNCC();
                        }
                    }
                    catch 
                    {
                        MessageBox.Show("Thêm Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ReLoad_Nhap_XuatNCC();
                    }
                }

            }   
            else
            if(Add_NhapXuatHang_NCC==false)
            {
                if (dgvnhapkho.Enabled == true)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("Update_NhapHang");
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = connect;
                        cmd.Parameters.Add("@MaNhap", SqlDbType.VarChar).Value = ""
                                    + txtmanhapxuat.Text + "";
                        cmd.Parameters.Add("@MaHang", SqlDbType.VarChar).Value = ""
                                   + txtmahang.Text + "";
                        cmd.Parameters.Add("@MaNCC", SqlDbType.VarChar).Value = ""
                                   + txtnhacc.Text + "";
                        cmd.Parameters.Add("@NgayNhap", SqlDbType.DateTime).Value = ""
                                   + dtpdatetime.Text + "";
                        cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = ""
                                   + Convert.ToInt32(txtsoluong.Text) + "";
                        cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = ""
                                   + txtghichu.Text + "";
                        connect.Open();
                        cmd.ExecuteNonQuery();
                        connect.Close();
                        MessageBox.Show("Sửa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ReLoad_Nhap_XuatNCC();
                    }
                    catch 
                    {
                        MessageBox.Show("Sửa Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ReLoad_Nhap_XuatNCC();
                    }
                }
                if (dgvxuatkho.Enabled == true)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("Update_XuatHang");
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = connect;
                        cmd.Parameters.Add("@MaXuat", SqlDbType.VarChar).Value = ""
                                    + txtmanhapxuat.Text + "";
                        cmd.Parameters.Add("@MaHang", SqlDbType.VarChar).Value = ""
                                   + txtmahang.Text + "";
                        cmd.Parameters.Add("@MaNCC", SqlDbType.VarChar).Value = ""
                                   + txtnhacc.Text + "";
                        cmd.Parameters.Add("@NgayXuat", SqlDbType.DateTime).Value = ""
                                   + dtpdatetime.Text + "";
                        cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = ""
                                   + Convert.ToInt32(txtsoluong.Text) + "";
                        cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = ""
                                   + txtghichu.Text + "";
                        connect.Open();
                        cmd.ExecuteNonQuery();
                        connect.Close();
                        MessageBox.Show("Sửa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ReLoad_Nhap_XuatNCC();
                    }
                    catch 
                    {
                        MessageBox.Show("Sửa Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ReLoad_Nhap_XuatNCC();
                    }
                }
                if (dgvNCC.Enabled == true)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("Update_NhaCungCap");
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = connect;
                        cmd.Parameters.Add("@MaNCC", SqlDbType.VarChar).Value = ""
                                    + txtmanhapxuat.Text + "";
                        cmd.Parameters.Add("@TenNCC", SqlDbType.NVarChar).Value = ""
                                   + txtmahang.Text + "";
                        cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = ""
                                   + txtnhacc.Text + "";
                        cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = ""
                                   + txtsoluong.Text + "";
                        cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = ""
                                   + txtghichu.Text + "";
                        connect.Open();
                        cmd.ExecuteNonQuery();
                        connect.Close();
                        MessageBox.Show("Sửa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ReLoad_Nhap_XuatNCC();
                    }
                    catch
                    {
                        MessageBox.Show("Sửa Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ReLoad_Nhap_XuatNCC();
                    }
                }
            }    
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            ReLoad_Nhap_XuatNCC();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmanhapxuat.Text == "")
            {
                MessageBox.Show("Vui Lòng Chọn Đối Tượng Cần Xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ReLoad_Nhap_XuatNCC();
            }
            else
            {
                DialogResult d;
                if (dgvnhapkho.Enabled == true)
                {
                    d = MessageBox.Show("Bạn Thật Sự Muốn Xóa \nMã Nhập: " + txtmanhapxuat.Text
                        + " Này Chứ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (d == DialogResult.Yes)
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("Delete_NhapHang");
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = connect;
                            cmd.Parameters.Add("@MaNhap", SqlDbType.VarChar).Value = ""
                                        + txtmanhapxuat.Text + "";
                            connect.Open();
                            cmd.ExecuteNonQuery();
                            connect.Close();
                            ReLoad_Nhap_XuatNCC();
                            MessageBox.Show("Xóa Thành Công","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Xóa Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ReLoad_Nhap_XuatNCC();
                        }
                    }
                    else
                    {
                    }


                }
                else
                if (dgvxuatkho.Enabled == true)
                {
                    d = MessageBox.Show("Bạn Thật Sự Muốn Xóa \nMã Xuất: " + txtmanhapxuat.Text
                        + "Này Chứ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (d == DialogResult.Yes)
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("Delete_XuatHang");
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = connect;
                            cmd.Parameters.Add("@MaXuat", SqlDbType.VarChar).Value = ""
                                        + txtmanhapxuat.Text + "";
                            connect.Open();
                            cmd.ExecuteNonQuery();
                            connect.Close();
                            ReLoad_Nhap_XuatNCC();
                            MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Xóa Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ReLoad_Nhap_XuatNCC();
                        }
                    }
                    else
                    { }
                }
                else
                    if (dgvNCC.Enabled == true)
                {
                    d = MessageBox.Show("Bạn Thật Sự Muốn Xóa Mã Nhà Cung Cấp:\n" + txtmanhapxuat.Text
                          + " Này Chứ!", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (d == DialogResult.Yes)
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("Delete_NhaCungCap");
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = connect;
                            cmd.Parameters.Add("@MaNCC", SqlDbType.VarChar).Value = ""
                                        + txtmanhapxuat.Text + "";
                            connect.Open();
                            cmd.ExecuteNonQuery();
                            connect.Close();
                            ReLoad_Nhap_XuatNCC();
                            MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Xóa Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ReLoad_Nhap_XuatNCC();
                        }
                    }
                    else
                    { }
                }
            }
               
        }
        private void Tim_NhapXuat()
        {
            if (dgvnhapkho.Enabled == true)
            {
                if (rdbmanhapxuat.Checked == true)
                {
                    var dap1 = new SqlDataAdapter(
                           "Select * from NhapHang Where MaNhap like N'%"
                           + txttimkiem.Text + "%'", connect);
                    var table1 = new DataTable();
                    dap1.Fill(table1);
                    dgvnhapkho.DataSource = table1;
                    
                }
                if (rdbmahang_NCC.Checked == true)
                {
                    var dap2 = new SqlDataAdapter(
                           "Select * from NhapHang Where MaHang like N'%"
                           + txttimkiem.Text + "%'", connect);
                    var table2 = new DataTable();
                    dap2.Fill(table2);
                    dgvnhapkho.DataSource = table2;
                    
                }
                if (rdbmaNCC_tenNCC.Checked == true)
                {
                    var dap3 = new SqlDataAdapter(
                           "Select * from NhapHang Where MaNCC like N'%"
                           + txttimkiem.Text + "%'", connect);
                    var table3 = new DataTable();
                    dap3.Fill(table3);
                    dgvnhapkho.DataSource = table3;
                    
                }
            }
            else
            if (dgvxuatkho.Enabled == true)
            {
                if (rdbmanhapxuat.Checked == true)
                {
                    var dap1 = new SqlDataAdapter(
                           "Select * from XuatHang Where MaXuat like N'%"
                           + txttimkiem.Text + "%'", connect);
                    var table1 = new DataTable();
                    dap1.Fill(table1);
                    dgvxuatkho.DataSource = table1;
                    
                }
                if (rdbmahang_NCC.Checked == true)
                {
                    var dap2 = new SqlDataAdapter(
                           "Select * from XuatHang Where MaHang like N'%"
                           + txttimkiem.Text + "%'", connect);
                    var table2 = new DataTable();
                    dap2.Fill(table2);
                    dgvxuatkho.DataSource = table2;
                    
                }
                if (rdbmaNCC_tenNCC.Checked == true)
                {
                    var dap3 = new SqlDataAdapter(
                           "Select * from XuatHang Where MaNCC like N'%"
                           + txttimkiem.Text + "%'", connect);
                    var table3 = new DataTable();
                    dap3.Fill(table3);
                    dgvxuatkho.DataSource = table3;
                    
                }
            }
        }
        private void Tim_NCC()
        {
            if (dgvNCC.Enabled == true)
            {
                if (rdbmahang_NCC.Checked == true)
                {
                    var dap2 = new SqlDataAdapter(
                           "Select * from NhaCungCap Where MaNCC like N'%"
                           + txttimkiem.Text + "%'", connect);
                    var table2 = new DataTable();
                    dap2.Fill(table2);
                    dgvNCC.DataSource = table2;
                    
                }
                if (rdbmaNCC_tenNCC.Checked == true)
                {
                    var dap3 = new SqlDataAdapter(
                           "Select * from NhaCungCap Where TenNCC like N'%"
                           + txttimkiem.Text + "%'", connect);
                    var table3 = new DataTable();
                    dap3.Fill(table3);
                    dgvNCC.DataSource = table3;
                    
                }
            }
        }
        private void txtmanhapxuat_Leave(object sender, EventArgs e)
        {
            ktr_manhapxuat_NCC(sender,e);
        }

        private void rdbmanhapxuat_Click(object sender, EventArgs e)
        {
            txttimkiem.Text = "";
            rdbmanhapxuat.Checked = true;
            rdbmaNCC_tenNCC.Checked = false;
            rdbmahang_NCC.Checked = false;
            if (rdbmanhapxuat.Checked == true && dgvnhapkho.Enabled == true)
            {
                lbtimkiem.Text = "Nhập Mã Nhập Cần Tìm";
            }
            else
                if (rdbmanhapxuat.Checked == true && dgvxuatkho.Enabled == true)
            {
                lbtimkiem.Text = "Nhập Mã Xuất Cần Tìm";
            }
            Tim_NhapXuat();
        }

        private void rdbmahang_NCC_Click(object sender, EventArgs e)
        {
            txttimkiem.Text = "";
            rdbmanhapxuat.Checked = false;
            rdbmaNCC_tenNCC.Checked = false;
            rdbmahang_NCC.Checked = true;
            if (rdbmahang_NCC.Checked == true && dgvnhapkho.Enabled == true
                || dgvxuatkho.Enabled==true)
            {
                lbtimkiem.Text = "Nhập Mã Hàng Cần Tìm";
            }
            else
            if(rdbmahang_NCC.Checked==true && dgvNCC.Enabled==true)
            {
                lbtimkiem.Text = "Nhập Mã Nhà Cung Cấp Cần Tìm";
            }    
            
            if (dgvnhapkho.Enabled == true || dgvxuatkho.Enabled == true)
            {
                Tim_NhapXuat();
            }
            else
                if (dgvNCC.Enabled == true)
            {
                Tim_NCC();
            }
        }

        private void rdbmaNCC_tenNCC_Click(object sender, EventArgs e)
        {
            txttimkiem.Text = "";
            rdbmanhapxuat.Checked = false;
            rdbmaNCC_tenNCC.Checked = true;
            rdbmahang_NCC.Checked = false;
            if (rdbmaNCC_tenNCC.Checked == true && dgvnhapkho.Enabled == true
                || dgvxuatkho.Enabled == true)
            {
                lbtimkiem.Text = "Nhập Mã Nhà Cung Cấp cần Tìm";
            }
            else
            if (rdbmaNCC_tenNCC.Checked == true && dgvNCC.Enabled == true)
            {
                lbtimkiem.Text = "Nhập Tên Nhà Cung Cấp Cần Tìm";
            }
            if (dgvnhapkho.Enabled == true || dgvxuatkho.Enabled == true)
            {
                Tim_NhapXuat();
            }
            else
                if (dgvNCC.Enabled == true)
            {
                Tim_NCC();
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            
            if( rdbmanhapxuat.Checked==false && rdbmaNCC_tenNCC.Checked==false
                    && rdbmahang_NCC.Checked==false)
                {
                    MessageBox.Show("Vui Lòng Click Vào Mục Cần Tìm!", 
                        "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
            else
                    if(dgvNCC.Enabled==true && rdbmahang_NCC.Checked==false 
                    && rdbmaNCC_tenNCC.Checked==false)
                    
                {
                    MessageBox.Show("Vui Lòng Click Vào Mục Cần Tìm!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            //
            if (txttimkiem.Text == "" && (dgvnhapkho.Enabled==true || dgvxuatkho.Enabled==true || dgvNCC.Enabled==true)
                && (rdbmanhapxuat.Checked==true || rdbmahang_NCC.Checked==true || rdbmaNCC_tenNCC.Checked==true))
            {
                MessageBox.Show("Vui Lòng Nhập Thông Tin Cần Tìm!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttimkiem.Focus();
            }
            else
            {
                Tim_NhapXuat();
                Ktra_MaNhapXuat_TimKiem();
                Tim_NCC();
                Ktra_NCC_TimKiem();
            }
            
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            Tim_NhapXuat();
            Tim_NCC();

        }
        private void Ktra_MaNhapXuat_TimKiem()
        {
            try
            {
                if (dgvnhapkho.Enabled == true)
                {
                    if (rdbmanhapxuat.Checked == true)
                    {
                        connect.Open();
                        SqlCommand cmd = new SqlCommand(
                            "SELECT COUNT(*) from NhapHang where  MaNhap like @MaNhap", connect);
                        cmd.Parameters.AddWithValue("@MaNhap", txttimkiem.Text);
                        int MaNhapCount = (int)cmd.ExecuteScalar();
                        cmd.ExecuteNonQuery();
                        connect.Close();
                        if (MaNhapCount <= 0)
                        {
                            MessageBox.Show("Mã Nhập Không Tồn Tại.\nVui Lòng Nhập Mã Khác! ", "Thông Báo");

                        }
                    }
                    if (rdbmahang_NCC.Checked == true)
                    {
                        connect.Open();
                        SqlCommand cmd = new SqlCommand(
                            "SELECT COUNT(*) from NhapHang where  Mahang like @MaHang", connect);
                        cmd.Parameters.AddWithValue("@MaHang", txttimkiem.Text);
                        int MaHangCount = (int)cmd.ExecuteScalar();
                        cmd.ExecuteNonQuery();
                        connect.Close();
                        if (MaHangCount <= 0)
                        {
                            MessageBox.Show("Mã Hàng Không Tồn Tại. Vui Lòng Nhập Mã Khác! ", "Thông Báo");

                        }
                    }
                    if (rdbmaNCC_tenNCC.Checked == true)
                    {
                        connect.Open();
                        SqlCommand cmd = new SqlCommand(
                            "SELECT COUNT(*) from NhapHang where  MaNCC like @MaNCC", connect);
                        cmd.Parameters.AddWithValue("@MaNCC", txttimkiem.Text);
                        int MaNCCCount = (int)cmd.ExecuteScalar();
                        cmd.ExecuteNonQuery();
                        connect.Close();
                        if (MaNCCCount <= 0)
                        {
                            MessageBox.Show("Mã Nhà Cung Cấp Không Tồn Tại. Vui Lòng Nhập Mã Khác! ", "Thông Báo");

                        }
                    }
                }
                else
                if (dgvxuatkho.Enabled == true)
                {
                    if (rdbmanhapxuat.Checked == true)
                    {
                        connect.Open();
                        SqlCommand cmd = new SqlCommand(
                            "SELECT COUNT(*) from XuatHang where  MaXuat like @MaXuat", connect);
                        cmd.Parameters.AddWithValue("@MaXuat", txttimkiem.Text);
                        int MaXuatCount = (int)cmd.ExecuteScalar();
                        cmd.ExecuteNonQuery();
                        connect.Close();
                        if (MaXuatCount <= 0)
                        {
                            MessageBox.Show("Mã Xuất Không Tồn Tại. Vui Lòng Nhập Mã Khác! ", "Thông Báo");

                        }
                    }
                    if (rdbmahang_NCC.Checked == true)
                    {
                        connect.Open();
                        SqlCommand cmd = new SqlCommand(
                            "SELECT COUNT(*) from XuatHang where  MaHang like @MaHang", connect);
                        cmd.Parameters.AddWithValue("@MaHang", txttimkiem.Text);
                        int MaHangCount = (int)cmd.ExecuteScalar();
                        cmd.ExecuteNonQuery();
                        connect.Close();
                        if (MaHangCount <= 0)
                        {
                            MessageBox.Show("Mã Hàng Không Tồn Tại. Vui Lòng Nhập Mã Khác! ", "Thông Báo");

                        }
                    }
                    if (rdbmaNCC_tenNCC.Checked == true)
                    {
                        connect.Open();
                        SqlCommand cmd = new SqlCommand(
                            "SELECT COUNT(*) from XuatHang where  MaNCC like @MaNCC", connect);
                        cmd.Parameters.AddWithValue("@MaNCC", txttimkiem.Text);
                        int MaNCCCount = (int)cmd.ExecuteScalar();
                        cmd.ExecuteNonQuery();
                        connect.Close();
                        if (MaNCCCount <= 0)
                        {
                            MessageBox.Show("Mã Nhà Cung Cấp Không Tồn Tại. Vui Lòng Nhập Mã Khác! ", "Thông Báo");

                        }
                    }
                }
            }
            catch { }

        }
        private void Ktra_NCC_TimKiem()
        {
            try
            {
                if (dgvNCC.Enabled == true)
                {
                    if (rdbmahang_NCC.Checked == true)
                    {
                        connect.Open();
                        SqlCommand cmd = new SqlCommand(
                            "SELECT COUNT(*) from NhaCungCap where  MaNCC like @MaNCC", connect);
                        cmd.Parameters.AddWithValue("@MaNCC", txttimkiem.Text);
                        int MaNCCCount = (int)cmd.ExecuteScalar();
                        cmd.ExecuteNonQuery();
                        connect.Close();
                        if (MaNCCCount <= 0)
                        {
                            MessageBox.Show("Mã Nhà Cung Cấp Không Tồn Tại. Vui Lòng Nhập Mã Khác! ", "Thông Báo");

                        }
                    }
                    if (rdbmaNCC_tenNCC.Checked == true)
                    {
                        connect.Open();
                        SqlCommand cmd = new SqlCommand(
                            "SELECT COUNT(*) from NhaCungCap where  TenNCC like @TenNCC", connect);
                        cmd.Parameters.AddWithValue("@TenNCC", txttimkiem.Text);
                        int TenNCCCount = (int)cmd.ExecuteScalar();
                        cmd.ExecuteNonQuery();
                        connect.Close();
                        if (TenNCCCount <= 0)
                        {
                            MessageBox.Show("Tên Nhà Cung Cấp Không Tồn Tại. Vui Lòng Nhập Tên Khác! ", "Thông Báo");

                        }
                    }
                }
            }
            catch { }
        }
        private void ktr_mahang(object sender, EventArgs e)
        {
            try
            {
                if (dgvnhapkho.Enabled == true || dgvxuatkho.Enabled == true)
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
            }
            catch { }

        }
        private void txtmahang_Leave(object sender, EventArgs e)
        {
            ktr_mahang(sender, e);
       }

        private void txtnhacc_Leave(object sender, EventArgs e)
        {
            try
            {
                if (dgvnhapkho.Enabled == true || dgvxuatkho.Enabled == true)
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand(
                        "SELECT COUNT(*) from NhaCungCap where  MaNCC like @MaNCC", connect);
                    cmd.Parameters.AddWithValue("@MaNCC", txtnhacc.Text);
                    int MaNCCCount = (int)cmd.ExecuteScalar();
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    if (MaNCCCount < 1)
                    {
                        MessageBox.Show("Mã Nhà Cung Cấp Không Tồn Tại\nVui Lòng Nhập Mã Khác ", "Thông Báo");
                        txtnhacc.Focus();
                    }
                    else
                    {
                    }
                }
            }
            catch { }
        }

        private void txtsoluong_Leave(object sender, EventArgs e)
        {
          
        }
    }
}
