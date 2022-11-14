using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace QuanliKhoHang
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(
            @"Data Source=DESKTOP-Q0B8QHD\MSSQLSERVER02;Initial Catalog=Quanlikhohang;Integrated Security=True");
        private void Form3_Load(object sender, EventArgs e)
        {
            dgvhanghoa.Size = new Size(1282, 727);
            dgvDVT.Size = new Size(1282, 727);
            rdbmahang.Hide();
            rdbmathang.Hide();
            dgvDVT.Hide();
            dgvDVT.Enabled = false;
            An_Text_label();
            btnthem.Hide();
            btnfix.Hide();
            btnxoa.Hide();
            btntim.Hide();
            lbtimkiem.Hide();
            txttimkiem.Hide();
            btnluulai.Hide();
            btnhuy.Hide();
            dgvhanghoa.Enabled = false;
            dgvhanghoa.Hide();
            lbinfo.Hide();
            if (rdbmahang.Checked == false && rdbmathang.Checked == false)
            {
                lbtimkiem.Text = "Nhập Tên Mặt Hàng Hoặc Mã Hàng Cần Tìm";
            }
        }
        private void ReLoad_Form3(object sender, EventArgs e)
        {
            var dap = new SqlDataAdapter("Select * from HangHoa", connect);
            var table = new DataTable();
            dap.Fill(table);
            dgvhanghoa.DataSource = table;
            Hien_Text_label();
            false_Text_label();
            btnthem.Show();
            btnfix.Show();
            btnxoa.Show();
            btnthem.Enabled = true;
            btnfix.Enabled = true;
            btnxoa.Enabled = true;
            btntim.Show();
            lbtimkiem.Show();
            txttimkiem.Show();
            btnluulai.Show();
            btnluulai.Enabled = false;
            btnhuy.Show();
            btnhuy.Enabled = false;
            lbinfo.Hide();
            txttimkiem.Text = "";
        }
        Boolean AddHangHoaDVT;
        private void Re_LoadDVT()
        {
            var dap = new SqlDataAdapter("Select * from DonViTinh", connect);
            var table = new DataTable();
            dap.Fill(table);
            dgvDVT.DataSource = table;

            An_Text_label();
            txtgianhap.Show();
            txtgianhap.Enabled = false;
            lbgianhap.Show();
            lbgianhap.Enabled = false;
            txtgiaxuat.Show();
            txtgiaxuat.Enabled = false;
            lbgiaxuat.Show();
            lbgiaxuat.Enabled = false;
            txttonkho.Show();
            txttonkho.Enabled = false;
            lbtonkho.Show();
            lbtonkho.Enabled = false;
            btnthem.Show();
            btnfix.Show();
            btnxoa.Show();
            btnthem.Enabled = true;
            btnfix.Enabled = true;
            btnxoa.Enabled = true;
            btntim.Show();
            lbtimkiem.Show();
            txttimkiem.Show();
            btnluulai.Show();
            btnluulai.Enabled = false;
            btnhuy.Show();
            btnhuy.Enabled = false;
            lbinfo.Hide();
            txttimkiem.Text = "";
        }
        private void false_Text_label()
        {
            lbmahang.Enabled = false;
            txtmahang.Enabled = false;
            lbmathang.Enabled = false;
            txtmathang.Enabled = false;
            lbgianhap.Enabled = false;
            txtgianhap.Enabled = false;
            lbgiaxuat.Enabled = false;
            txtgiaxuat.Enabled = false;
            lbtonkho.Enabled = false;
            txttonkho.Enabled = false;
            lbdonvitinh.Enabled = false;
            txtdonvitinh.Enabled = false;
            lbghichu.Enabled = false;
            txtghichu.Enabled = false;
        }
        private void true_Text_label()
        {
            lbmahang.Enabled = true;
            txtmahang.Enabled = true;
            lbmathang.Enabled = true;
            txtmathang.Enabled = true;
            lbgianhap.Enabled = true;
            txtgianhap.Enabled = true;
            lbgiaxuat.Enabled = true;
            txtgiaxuat.Enabled = true;
            lbtonkho.Enabled = true;
            txttonkho.Enabled = true;
            lbdonvitinh.Enabled = true;
            txtdonvitinh.Enabled = true;
            lbghichu.Enabled = true;
            txtghichu.Enabled = true;
        }
        private void An_Text_label()
        {
            lbmahang.Hide();
            txtmahang.Hide();
            lbmathang.Hide();
            txtmathang.Hide();
            lbgianhap.Hide();
            txtgianhap.Hide();
            lbgiaxuat.Hide();
            txtgiaxuat.Hide();
            lbtonkho.Hide();
            txttonkho.Hide();
            lbdonvitinh.Hide();
            txtdonvitinh.Hide();
            lbghichu.Hide();
            txtghichu.Hide();
        }
        private void Hien_Text_label()
        {
            lbmahang.Show();
            txtmahang.Show();
            lbmathang.Show();
            txtmathang.Show();
            lbgianhap.Show();
            txtgianhap.Show();
            lbgiaxuat.Show();
            txtgiaxuat.Show();
            lbtonkho.Show();
            txttonkho.Show();
            lbdonvitinh.Show();
            txtdonvitinh.Show();
            lbghichu.Show();
            txtghichu.Show();

        }
        private void btnxemDS_Click(object sender, EventArgs e)
        {
            dgvDVT.Enabled = false;
            dgvDVT.Hide();
            dgvhanghoa.Enabled = true;
            dgvhanghoa.Size = new Size(1282, 727);
            rdbmahang.Checked = true;
            An_Text_label();
            btnthem.Hide();
            btnfix.Hide();
            btnxoa.Hide();
            btntim.Show();
            lbtimkiem.Show();
            txttimkiem.Show();
            btntim.Show();
            btnluulai.Hide();
            btnhuy.Hide();
            lbinfo.Hide();
            var dap = new SqlDataAdapter("Select * from HangHoa", connect);
            var table = new DataTable();
            dap.Fill(table);
            dgvhanghoa.DataSource = table;
            txttimkiem.Focus();
        }
        private void btnquaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            AddHangHoaDVT = true;
            if (dgvhanghoa.Enabled == true)
            {
                Hien_Text_label();
                true_Text_label();
                txtmahang.Focus();
                txtmahang.Enabled = true;
                btnhuy.Show();
                btnluulai.Show();
                btnluulai.Enabled = true;
                btnfix.Show();
                btnfix.Enabled = false;
                btnhuy.Enabled = true;
                btnxoa.Show();
                btnxoa.Enabled = false;
                txtmahang.Text = "";
                txtmathang.Text = "";
                txtdonvitinh.Text = "";
                txtgianhap.Text = "";
                txtgiaxuat.Text = "";
                txttonkho.Text = "";
                txtghichu.Text = "";
                lbinfo.Text = "Mã Hàng Không Được Trùng!" +
                    " Vui Lòng Kiểm Tra Lại Mã Hàng Trước Khi Nhập";
                lbinfo.Show();
            }
            else
            if(dgvDVT.Enabled==true)
            {
                lbmahang.Hide();
                txtmahang.Hide();
                lbmathang.Hide();
                txtmathang.Hide();
                lbdonvitinh.Hide();
                txtdonvitinh.Hide();
                lbghichu.Hide();
                txtghichu.Hide();
                btnhuy.Show();
                btnluulai.Show();
                btnluulai.Enabled = true;
                btnfix.Show();
                btnfix.Enabled = false;
                btnhuy.Enabled = true;
                btnxoa.Show();
                btnxoa.Enabled = false;
                lbgianhap.Show();
                lbgianhap.Enabled = true;
                txtgianhap.Show();
                txtgianhap.Enabled = true;
                lbgiaxuat.Show();
                lbgiaxuat.Enabled = true;
                txtgiaxuat.Show();
                txtgiaxuat.Enabled = true;
                lbtonkho.Show();
                lbtonkho.Enabled = true;
                txttonkho.Show();
                txttonkho.Enabled = true;
                txtgianhap.Text = "";
                txtgiaxuat.Text = "";
                txttonkho.Text="";
                lbinfo.Text = "Mã Đơn Vị Tính Không Được Trùng! Vui Lòng Kiểm Tra Lại Mã Đơn Vị Tính Trước Khi Nhập";
                lbinfo.Show();
            }
            
        }
        private void btnfix_Click(object sender, EventArgs e)
        {
            AddHangHoaDVT = false;
            if (dgvhanghoa.Enabled == true)
            {
                Hien_Text_label();
                true_Text_label();
                btnhuy.Show();
                btnhuy.Enabled = true;
                btnthem.Show();
                btnxoa.Show();
                btnthem.Enabled = false;
                btnxoa.Enabled = false;
                btnluulai.Show();
                btnluulai.Enabled = true;
                lbmahang.Enabled = true;
                txtmahang.Enabled = false;
                lbinfo.Text = "Mã Hàng Không Thể Thay Đổi!";
                lbinfo.Show();
            }
            else
            if(dgvDVT.Enabled==true)
            {
                lbmahang.Hide();
                txtmahang.Hide();
                lbmathang.Hide();
                txtmathang.Hide();
                lbdonvitinh.Hide();
                txtdonvitinh.Hide();
                lbghichu.Hide();
                txtghichu.Hide();
                btnhuy.Show();
                btnhuy.Enabled = true;
                btnthem.Show();
                btnxoa.Show();
                btnthem.Enabled = false;
                btnxoa.Enabled = false;
                btnluulai.Show();
                btnluulai.Enabled = true;
                // Hiện lb_text_DVT
                lbgianhap.Show();
                lbgianhap.Enabled = true;
                txtgianhap.Show();
                txtgianhap.Enabled = false;
                lbgiaxuat.Show();
                lbgiaxuat.Enabled = true;
                txtgiaxuat.Show();
                txtgiaxuat.Enabled = true;
                lbtonkho.Show();
                lbtonkho.Enabled = true;
                txttonkho.Show();
                txttonkho.Enabled = true;
                lbinfo.Text = "Mã Đơn Vị Tính Không Thể Thay Đổi";
                lbinfo.Show();
            }
            
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
                if (MaHangCount > 0)
                {
                    MessageBox.Show("Mã Hàng Đã Tồn Tại\nVui Lòng Nhập Mã Hàng Khác ", "Thông Báo");
                    txtmahang.Focus();
                }
                else
                {
                }
            }
            catch { }
            
         }
        private void ktr_maDVT(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT COUNT(*) from DonViTinh where  MaDVT like @MaDVT", connect);
                cmd.Parameters.AddWithValue("@MaDVT", txtgianhap.Text);
                int MaDVTCount = (int)cmd.ExecuteScalar();
                cmd.ExecuteNonQuery();
                connect.Close();
                if (MaDVTCount > 0)
                {
                    MessageBox.Show("Mã Đơn Vị Tính Đã Tồn Tại\nVui Lòng Nhập Mã Khác ", "Thông Báo");
                    txtgianhap.Focus();
                }
                else
                {
                }
            }
            catch { }

        }

        private void btnluulai_Click(object sender, EventArgs e)
        {
            if (dgvhanghoa.Enabled == true)
            {
                if (AddHangHoaDVT == true)
                {
                    try
                    {
                        if (txtmahang.Text == "" || txtmathang.Text == "" || txtdonvitinh.Text == ""
                           || txtgiaxuat.Text=="" || txtgianhap.Text == "" || txttonkho.Text == "")
                        {
                            MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin", "Thông Báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnthem_Click(sender, e);
                        }
                        else
                        {
                            SqlCommand cmd = new SqlCommand("Insert_HangHoa");
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = connect;
                            cmd.Parameters.Add("@Mahang", SqlDbType.VarChar).Value = ""
                                + txtmahang.Text + "";
                            cmd.Parameters.Add("@TenMatHang", SqlDbType.NVarChar).Value = ""
                                + txtmathang.Text + "";
                            cmd.Parameters.Add("@MaDVT", SqlDbType.VarChar).Value = ""
                                + txtdonvitinh.Text + "";
                            cmd.Parameters.Add("@GiaNhap", SqlDbType.Int).Value = ""
                                + Convert.ToInt32(txtgianhap.Text) + "";
                            cmd.Parameters.Add("@GiaXuat", SqlDbType.Int).Value = ""
                                + Convert.ToInt32(txtgiaxuat.Text) + "";
                            cmd.Parameters.Add("@SoLuongTon", SqlDbType.Int).Value = ""
                                + Convert.ToInt32(txttonkho.Text) + "";
                            cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = ""
                                + txtghichu.Text + "";
                            connect.Open();
                            cmd.ExecuteNonQuery();
                            connect.Close();
                            MessageBox.Show("Thêm Thành Công!\nMã Hàng: " + txtmahang.Text
                                + "\nTên Mặt Hàng: " + txtmathang.Text
                                + "\nMã Đơn Vị Tính: " + txtdonvitinh.Text
                                + "\nGiá Nhập: " + Convert.ToInt32(txtgianhap.Text)
                                + "\nGiá Xuất: " + Convert.ToInt32(txtgiaxuat.Text)
                                + "\nTồn Kho: " + Convert.ToInt32(txttonkho.Text)
                                + "\nGhi Chú: " + txtghichu.Text + "", "Thông Báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ReLoad_Form3(sender, e);
                        }
                    }
                    catch
                    {
                            MessageBox.Show("Thêm Thất Bại!\nVui Lòng Điền Đầy Đủ Thông Tin",
                                "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ReLoad_Form3(sender, e);
                            btnthem_Click(sender, e);
                    }

                }
                else
                {

                    try
                    {
                        SqlCommand cmd = new SqlCommand("Update_HangHoa");
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = connect;
                        cmd.Parameters.Add("@Mahang", SqlDbType.VarChar).Value = ""
                            + txtmahang.Text + "";
                        cmd.Parameters.Add("@TenMatHang", SqlDbType.NVarChar).Value = ""
                            + txtmathang.Text + "";
                        cmd.Parameters.Add("@MaDVT", SqlDbType.VarChar).Value = ""
                            + txtdonvitinh.Text + "";
                        cmd.Parameters.Add("@GiaNhap", SqlDbType.Int).Value = ""
                            + Convert.ToInt32(txtgianhap.Text) + "";
                        cmd.Parameters.Add("@GiaXuat", SqlDbType.Int).Value = ""
                            + Convert.ToInt32(txtgiaxuat.Text) + "";
                        cmd.Parameters.Add("@SoLuongTon", SqlDbType.Int).Value = ""
                            + Convert.ToInt32(txttonkho.Text) + "";
                        cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = ""
                            + txtghichu.Text + "";
                        connect.Open();
                        cmd.ExecuteNonQuery();
                        connect.Close();
                        MessageBox.Show("Sửa Thành Công!",
                            "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ReLoad_Form3(sender, e);
                    }
                    catch
                    {
                        MessageBox.Show("Sửa Thất Bại!", 
                            "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ReLoad_Form3(sender, e);
                        btnfix_Click(sender, e);
                    }
                }
            }
            else
                if(dgvDVT.Enabled==true)
            {
                if (AddHangHoaDVT == true)
                {
                    try
                    {
                        if ( txtgianhap.Text == "" || txtgiaxuat.Text == "")
                        {
                            MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin", "Thông Báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnthem_Click(sender, e);
                            txtgianhap.Focus();
                        }
                        else
                        {
                            SqlCommand cmd = new SqlCommand("Insert_DonViTinh");
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = connect;
                            cmd.Parameters.Add("@MaDVT", SqlDbType.VarChar).Value = ""
                                + txtgianhap.Text + "";
                            cmd.Parameters.Add("@TenDVT", SqlDbType.NVarChar).Value = ""
                                + txtgiaxuat.Text + "";
                            cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = ""
                                + txttonkho.Text + "";
                            connect.Open();
                            cmd.ExecuteNonQuery();
                            connect.Close();
                            MessageBox.Show("Thêm Thành Công!\nMã Đơn Vị Tính: "
                                + txtgianhap.Text
                                + "\nTên Đơn Vị Tính: " + txtgiaxuat.Text
                                + "\nGhi Chú: " + txttonkho.Text
                                + "", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Re_LoadDVT();
                            btnChinhsua_Click(sender, e);
                        }
                    }
                    catch
                    {
                            MessageBox.Show("Thêm Thất Bại!\nVui Lòng Điền Đầy Đủ Thông Tin",
                                "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            btnthem_Click(sender, e);
                    }

                }
                else
                {

                    try
                    {
                        SqlCommand cmd = new SqlCommand("Update_DonViTinh");
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = connect;
                        cmd.Parameters.Add("@MaDVT", SqlDbType.VarChar).Value = ""
                            + txtgianhap.Text + "";
                        cmd.Parameters.Add("@TenDVT", SqlDbType.NVarChar).Value = ""
                            + txtgiaxuat.Text + "";
                        cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = ""
                            + txttonkho.Text + "";
                        connect.Open();
                        cmd.ExecuteNonQuery();
                        connect.Close();
                        MessageBox.Show("Sửa Thành Công!", 
                            "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Re_LoadDVT();
                        btnChinhsua_Click(sender,e);
                    }
                    catch
                    {
                        MessageBox.Show("Sửa Thất Bại!",
                            "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       btnfix_Click(sender, e);
                    }
                }
            }    
    }
     
        private void btnxoa_Click(object sender, EventArgs e)
        {
            //1)
            DialogResult r;
            if (dgvhanghoa.Enabled == true && txtmahang.Text == "")
            {
                MessageBox.Show("Vui Lòng Chọn Mặt Hàng Cần Xóa", "Thông Báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            else
            {
                if (dgvhanghoa.Enabled == true && txtmahang.Text != "")
                {
                    r = MessageBox.Show("Bạn Thật Sự Muốn Xoá Mặt Hàng:\n"
                        + txtmathang.Text + " Chứ?"
                    , "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (r == DialogResult.Yes)
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("Delete_HangHoa");
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = connect;
                            cmd.Parameters.Add("@MaHang", SqlDbType.VarChar).Value = ""
                                + txtmahang.Text + "";
                            connect.Open();
                            cmd.ExecuteNonQuery();
                            connect.Close();
                            MessageBox.Show("Xóa Thành Công!",
                                "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ReLoad_Form3(sender, e);
                        }
                        catch
                        {
                            MessageBox.Show("Xóa Thất Bại!", "Thông Báo", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ReLoad_Form3(sender,e);
                        }
                    }
                    else
                    {

                    }
                }
            }
            //2)
            if(dgvDVT.Enabled==true && txtgianhap.Text=="")
            {
                MessageBox.Show("Vui Lòng Chọn Đơn Vị Tính Cần Xóa", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else 
            {
                if (dgvDVT.Enabled == true && txtgianhap.Text != "")
                {
                    r = MessageBox.Show("Bạn Thật Sự Muốn Xoá Mã Đơn Vị Tính:\n"
                        + txtgianhap.Text + " Chứ?"
                    , "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (r == DialogResult.Yes)
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand("Delete_DonViTinh");
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Connection = connect;
                            cmd.Parameters.Add("@MaDVT", SqlDbType.VarChar).Value = ""
                                + txtgianhap.Text + "";
                            connect.Open();
                            cmd.ExecuteNonQuery();
                            connect.Close();
                            MessageBox.Show("Xóa Thành Công!", "Thông Báo", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Re_LoadDVT();
                        }
                        catch
                        {
                            MessageBox.Show("Xóa Thất Bại!", "Thông Báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Re_LoadDVT();
                        }
                    }
                    else
                    { }
                }
            }
                

            
        }
        private void btnhuy_Click(object sender, EventArgs e)
        {
            txtmahang.Text = "";
            txtmathang.Text = "";
            txtdonvitinh.Text = "";
            txtgianhap.Text = "";
            txtgiaxuat.Text = "";
            txttonkho.Text = "";
            txtghichu.Text = "";
            if (dgvhanghoa.Enabled == true)
            {
                ReLoad_Form3(sender, e);
            }
            else
                if (dgvDVT.Enabled==true)
            {
                Re_LoadDVT();
            }

        }

        private void Tim_Mahang()
        {
            var dap1 = new SqlDataAdapter(
                "Select * from HangHoa Where MaHang like '%"
                +(txttimkiem.Text)+"%'", connect);
            var table1 = new DataTable();
            dap1.Fill(table1);
            dgvhanghoa.DataSource = table1;
        }
        private void Tim_Tenmathang()
        {
            var dap2 = new SqlDataAdapter(
                "Select * from HangHoa Where TenMatHang like N'%"
                + (txttimkiem.Text) + "%'", connect);
            var table2 = new DataTable();
            dap2.Fill(table2);
            dgvhanghoa.DataSource = table2;
        }
        private void Tim_MaDVT()
        {
            var dap = new SqlDataAdapter(
                "Select * from DonViTinh Where MaDVT like '%"
                + (txttimkiem.Text) + "%'", connect);
            var table = new DataTable();
            dap.Fill(table);
            dgvDVT.DataSource = table;
        }
        private void btntim_Click(object sender, EventArgs e)
        {
            //1
            if (dgvDVT.Enabled == true && txttimkiem.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Mã Đơn Vị Tính Cần Tìm!",
                   "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            if(txttimkiem.Text!="")
            {
                ktra_MaDVT_timkiem();
            }
            //
            if ((txttimkiem.Text=="" || txttimkiem.Text!="") 
                && rdbmathang.Checked==false && rdbmahang.Checked == false)
            {
                if (dgvhanghoa.Enabled == true)
                {
                    MessageBox.Show("Vui Lòng Click Vào Mục Cần Tìm!",
                        "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }       
            }
            else 
               if(txttimkiem.Text!="")
            {
                Ktra_Mahang_mathang_Timkiem();
            }
            //2
            
            if (dgvhanghoa.Enabled == true && txttimkiem.Text == "")
            {
                if (rdbmathang.Checked == true)
                {
                    MessageBox.Show("Vui Lòng Nhập Tên Mặt Hàng Cần Tìm!",
                        "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
                if (rdbmahang.Checked == true)
                {
                    MessageBox.Show("Vui Lòng Nhập Mã Hàng Cần Tìm!",
                        "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            // 
            if (dgvhanghoa.Enabled==true)
            {
                if (rdbmahang.Checked == true)
                {
                    Tim_Mahang();
                }
                else
                    if(rdbmathang.Checked==true)
                {
                    Tim_Tenmathang();
                }    
            }
            else
                if(dgvDVT.Enabled==true)
            {
                Tim_MaDVT(); 
            }
            txttimkiem.Focus();
        }

        private void dgvhanghoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvhanghoa.Enabled == true)
            {
                txtmahang.DataBindings.Clear();
                txtmahang.DataBindings.Add("Text", dgvhanghoa.DataSource, "MaHang");
                txtmathang.DataBindings.Clear();
                txtmathang.DataBindings.Add("Text", dgvhanghoa.DataSource, "TenMatHang");
                txtdonvitinh.DataBindings.Clear();
                txtdonvitinh.DataBindings.Add("Text", dgvhanghoa.DataSource, "MaDVT");
                txtgianhap.DataBindings.Clear();
                txtgianhap.DataBindings.Add("Text", dgvhanghoa.DataSource, "GiaNhap");
                txtgiaxuat.DataBindings.Clear();
                txtgiaxuat.DataBindings.Add("Text", dgvhanghoa.DataSource, "GiaXuat");
                txttonkho.DataBindings.Clear();
                txttonkho.DataBindings.Add("Text", dgvhanghoa.DataSource, "SoLuongTon");
                txtghichu.DataBindings.Clear();
                txtghichu.DataBindings.Add("Text", dgvhanghoa.DataSource, "GhiChu");
            }
            dgvDVT.Enabled = false;
        }
        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            if (dgvhanghoa.Enabled == true)
            {
                if (rdbmahang.Checked == true)
                {
                    Tim_Mahang();
                }
                else
                        if (rdbmathang.Checked == true)
                {
                    Tim_Tenmathang();
                }
            }
            else
                if(dgvDVT.Enabled==true)
            {
                Tim_MaDVT(); 
            }    
        }

        private void btn_XemDS_Click(object sender, EventArgs e)
        {
            dgvhanghoa.Enabled = true;
            dgvhanghoa.Show();
            dgvDVT.Hide();
            dgvDVT.Enabled = false;
            rdbmahang.Show();
            rdbmathang.Enabled = true;
            rdbmathang.Show();
            rdbmahang.Enabled = true;
            dgvhanghoa.Size = new Size(1282, 727);
            btn_XemDS.BackColor = Color.White;
            btnChinhsua.BackColor = menuStrip1.BackColor;
            btn_DVT.BackColor = menuStrip1.BackColor;
            btn_XemDS.ForeColor = menuStrip1.ForeColor;
            btn_DVT.ForeColor = menuStrip1.ForeColor;
            An_Text_label();
            btnthem.Hide();
            btnfix.Hide();
            btnxoa.Hide();
            btntim.Show();
            txttimkiem.Text = "";
            lbtimkiem.Show();
            lbtimkiem.Text = "Vui Lòng Click Vào Mục Cần Tìm";
            rdbmahang.Checked = false;
            rdbmathang.Checked = false;
            txttimkiem.Show();
            btntim.Show();
            btnluulai.Hide();
            btnhuy.Hide();
            lbinfo.Hide();
            var dap = new SqlDataAdapter("Select * from HangHoa", connect);
            var table = new DataTable();
            dap.Fill(table);
            dgvhanghoa.DataSource = table;
        }

        private void btnChinhsua_Click(object sender, EventArgs e)
        {
            txttimkiem.Text = "";
            txttimkiem.Focus();
            if (dgvhanghoa.Enabled == true)
            {
                dgvDVT.Hide();
                dgvDVT.Enabled = false;
                dgvhanghoa.Enabled = true;
                rdbmahang.Show();
                rdbmathang.Show();
                lbtimkiem.Text = "Vui Lòng Click Vào Mục Cần Tìm";
                rdbmahang.Checked = false;
                rdbmathang.Checked = false;
                btnChinhsua.BackColor = Color.White;
                btn_XemDS.ForeColor = Color.Green;
                btn_DVT.ForeColor = menuStrip1.ForeColor;
                btn_DVT.BackColor = menuStrip1.BackColor;
                btn_XemDS.BackColor = menuStrip1.BackColor;
                dgvhanghoa.Size = new Size(1282, 419);
                var dap = new SqlDataAdapter("Select * from HangHoa", connect);
                var table = new DataTable();
                dap.Fill(table);
                dgvhanghoa.DataSource = table;
                ReLoad_Form3(sender,e);
                Hien_Text_label();
                false_Text_label();
                btnthem.Show();
                btnfix.Show();
                btnxoa.Show();
                lbtimkiem.Show();
                txttimkiem.Show();
                btntim.Show();
                btnluulai.Show();
                btnluulai.Enabled = false;
                btnhuy.Show();
                btnhuy.Enabled = false;
                lbinfo.Hide();
                lbgianhap.Text = "Giá Nhập";
                lbgiaxuat.Text = "Giá Xuất";
                lbtonkho.Text = "Số Lượng Tồn";
                txtmahang.Text = "";
                txtmathang.Text = "";
                txtdonvitinh.Text = "";
                txtgianhap.Text = "";
                txtgiaxuat.Text = "";
                txtghichu.Text = "";
                txttonkho.Text = "";
            }
            else 
                if(dgvDVT.Enabled==true)
            {
                dgvhanghoa.Hide();
                dgvhanghoa.Enabled = false;
                dgvDVT.Enabled = true;
                dgvDVT.Size = new Size(1282, 419);
                var dap = new SqlDataAdapter("Select * from DonViTinh", connect);
                var table = new DataTable();
                dap.Fill(table);
                dgvDVT.DataSource = table;
                btnChinhsua.BackColor = Color.White;
                btn_DVT.BackColor = menuStrip1.BackColor;
                btn_DVT.ForeColor = Color.Green;
                btn_XemDS.ForeColor = menuStrip1.ForeColor;
                dgvDVT.Show();
                An_Text_label();
                txtgianhap.Show();
                txtgianhap.Enabled = false;
                lbgianhap.Show();
                lbgianhap.Enabled =false;
                txtgiaxuat.Show();
                txtgiaxuat.Enabled = false;
                lbgiaxuat.Show();
                lbgiaxuat.Enabled = false;
                txttonkho.Show();
                txttonkho.Enabled = false;
                lbtonkho.Show();
                lbtonkho.Enabled = false;
                lbgianhap.Text = "Mã Đơn Vị Tính";
                lbgiaxuat.Text = "Tên Đơn Vị Tính";
                lbtonkho.Text = "Ghi Chú";
                txtgianhap.Text = "";
                txtgiaxuat.Text = "";
                txttonkho.Text = "";
                btnthem.Show();
                btnfix.Show();
                btnxoa.Show();
                lbtimkiem.Show();
                txttimkiem.Show();
                btntim.Show();
                btnluulai.Show();
                btnluulai.Enabled = false;
                btnhuy.Show();
                btnhuy.Enabled = false;
                lbinfo.Hide();
            }
        
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbmahang_Click(object sender, EventArgs e)
        {
            txttimkiem.Text = "";
            lbtimkiem.Text = "Nhập Mã Hàng Cần Tìm";
            rdbmahang.Checked = true;
            rdbmathang.Checked = false;
        }

        private void rdbmathang_Click(object sender, EventArgs e)
        {
            txttimkiem.Text = "";
            lbtimkiem.Text = "Nhập Tên Mặt Hàng Cần Tìm";
            rdbmathang.Checked = true;
            rdbmahang.Checked = false;
        }

        private void txtmahang_Leave(object sender, EventArgs e)
        {
                ktr_mahang(sender, e);
            
        }

        private void Ktra_Mahang_mathang_Timkiem()
        {
            try
            {
                if (dgvhanghoa.Enabled == true)
                {
                    if (rdbmahang.Checked == true)
                    {
                        connect.Open();
                        SqlCommand cmd = new SqlCommand(
                            "SELECT COUNT(*) from HangHoa where  MaHang like @MaHang", connect);
                        cmd.Parameters.AddWithValue("@MaHang", txttimkiem.Text);
                        int MaHangCount = (int)cmd.ExecuteScalar();
                        cmd.ExecuteNonQuery();
                        connect.Close();
                        if (MaHangCount <= 0)
                        {
                            MessageBox.Show("Mã Hàng Không Tồn Tại\nVui Lòng Nhập Mã Hàng Khác ", "Thông Báo");
                        }
                    }
                    else
                    if (rdbmathang.Enabled == true)
                    {
                        connect.Open();
                        SqlCommand cmd = new SqlCommand(
                            "SELECT COUNT(*) from HangHoa where  TenMatHang like @TenMatHang", connect);
                        cmd.Parameters.AddWithValue("@TenMatHang", txttimkiem.Text);
                        int MatHangCount = (int)cmd.ExecuteScalar();
                        cmd.ExecuteNonQuery();
                        connect.Close();
                        if (MatHangCount < 1)
                        {
                            MessageBox.Show("Tên Mặt Hàng Không Tồn Tại\nVui Lòng Nhập Tên Mặt Hàng Khác ", "Thông Báo");
                        }

                    }
                }
                
            }
            catch { }
        }
        private void ktra_MaDVT_timkiem()
        {
                if (dgvDVT.Enabled == true)
            {
                if (rdbmahang.Enabled == false && rdbmathang.Enabled == false)
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand(
                        "SELECT COUNT(*) from DonViTinh where  MaDVT like @MaDVT", connect);
                    cmd.Parameters.AddWithValue("@MaDVT", txttimkiem.Text);
                    int MaDVTCount = (int)cmd.ExecuteScalar();
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    if (MaDVTCount < 1)
                    {
                        MessageBox.Show("Mã Đơn Vị Tính Không Tồn Tại\nVui Lòng Nhập Mã Khác ", "Thông Báo");
                    }
                }
            }
        }
        private void btn_DVT_Click(object sender, EventArgs e)
        {
            dgvDVT.Show();
            dgvDVT.Size = new Size(1282, 727);
            var dap = new SqlDataAdapter("Select * from DonViTinh", connect);
            var table = new DataTable();
            dap.Fill(table);
            dgvDVT.DataSource = table;
            dgvDVT.Enabled = true;
            dgvhanghoa.Hide();
            dgvhanghoa.Enabled = false;
            btn_DVT.BackColor = Color.White;
            btn_XemDS.BackColor = menuStrip1.BackColor;
            btnChinhsua.BackColor = menuStrip1.BackColor;
            btn_XemDS.ForeColor = menuStrip1.ForeColor;
            btn_DVT.ForeColor = menuStrip1.ForeColor;
            rdbmahang.Hide();
            rdbmahang.Enabled = false;
            rdbmathang.Hide();
            rdbmathang.Enabled = false;
            lbtimkiem.Text = "Nhập Mã Đơn Vị Tính Cần Tìm";
            lbtimkiem.Show();
            txttimkiem.Show();
            btntim.Show();
            txttimkiem.Text = "";
            txttimkiem.Focus();
        }

        private void dgvDVT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDVT.Enabled == true)
            {
                txtgianhap.DataBindings.Clear();
                txtgianhap.DataBindings.Add("Text", dgvDVT.DataSource, "MaDVT");
                txtgiaxuat.DataBindings.Clear();
                txtgiaxuat.DataBindings.Add("Text", dgvDVT.DataSource, "TenDVT");
                txttonkho.DataBindings.Clear();
                txttonkho.DataBindings.Add("Text", dgvDVT.DataSource, "GhiChu");
            }
            dgvhanghoa.Enabled = false;
        }

        private void btnthem_Leave(object sender, EventArgs e)
        {
            btn_XemDS.Enabled = true;
            btn_DVT.Enabled = true;
        }

        private void btnfix_Leave(object sender, EventArgs e)
        {
            btn_XemDS.Enabled = true;
            btn_DVT.Enabled = true;
        }

        private void txtgianhap_Leave(object sender, EventArgs e)
        {
            if(dgvDVT.Enabled==true)
            {
                ktr_maDVT(sender,e);
            }    
        }

        private void txtdonvitinh_Leave(object sender, EventArgs e)
        {
            if (dgvhanghoa.Enabled == true)
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT COUNT(*) from DonViTinh where  MaDVT like @MaDVT", connect);
                cmd.Parameters.AddWithValue("@MaDVT", txtdonvitinh.Text);
                int MaDVTCount = (int)cmd.ExecuteScalar();
                cmd.ExecuteNonQuery();
                connect.Close();
                if (MaDVTCount < 1)
                {
                    MessageBox.Show("Mã Đơn Vị Tính Không Tồn Tại\nVui Lòng Nhập Mã Khác ", "Thông Báo");
                    txtdonvitinh.Focus();
                }
                else
                {
                }
            }
        }
    }    
}
