
namespace QuanliKhoHang
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDVT = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbinfo = new System.Windows.Forms.Label();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnluulai = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnfix = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.lbgiaxuat = new System.Windows.Forms.Label();
            this.txttonkho = new System.Windows.Forms.TextBox();
            this.lbghichu = new System.Windows.Forms.Label();
            this.lbtonkho = new System.Windows.Forms.Label();
            this.lbgianhap = new System.Windows.Forms.Label();
            this.lbdonvitinh = new System.Windows.Forms.Label();
            this.lbmathang = new System.Windows.Forms.Label();
            this.lbmahang = new System.Windows.Forms.Label();
            this.txtdonvitinh = new System.Windows.Forms.TextBox();
            this.txtgianhap = new System.Windows.Forms.TextBox();
            this.txtgiaxuat = new System.Windows.Forms.TextBox();
            this.txtmathang = new System.Windows.Forms.TextBox();
            this.txtmahang = new System.Windows.Forms.TextBox();
            this.dgvhanghoa = new System.Windows.Forms.DataGridView();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.lbtimkiem = new System.Windows.Forms.Label();
            this.btntim = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbmahang = new System.Windows.Forms.RadioButton();
            this.rdbmathang = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_XemDS = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_DVT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChinhsua = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_quaylai = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhanghoa)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.dgvDVT);
            this.panel2.Controls.Add(this.lbinfo);
            this.panel2.Controls.Add(this.btnhuy);
            this.panel2.Controls.Add(this.btnluulai);
            this.panel2.Controls.Add(this.btnxoa);
            this.panel2.Controls.Add(this.btnfix);
            this.panel2.Controls.Add(this.btnthem);
            this.panel2.Controls.Add(this.txtghichu);
            this.panel2.Controls.Add(this.lbgiaxuat);
            this.panel2.Controls.Add(this.txttonkho);
            this.panel2.Controls.Add(this.lbghichu);
            this.panel2.Controls.Add(this.lbtonkho);
            this.panel2.Controls.Add(this.lbgianhap);
            this.panel2.Controls.Add(this.lbdonvitinh);
            this.panel2.Controls.Add(this.lbmathang);
            this.panel2.Controls.Add(this.lbmahang);
            this.panel2.Controls.Add(this.txtdonvitinh);
            this.panel2.Controls.Add(this.txtgianhap);
            this.panel2.Controls.Add(this.txtgiaxuat);
            this.panel2.Controls.Add(this.txtmathang);
            this.panel2.Controls.Add(this.txtmahang);
            this.panel2.Controls.Add(this.dgvhanghoa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1282, 727);
            this.panel2.TabIndex = 47;
            // 
            // dgvDVT
            // 
            this.dgvDVT.AllowUserToAddRows = false;
            this.dgvDVT.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDVT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDVT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.TenDVT,
            this.dataGridViewTextBoxColumn2});
            this.dgvDVT.Location = new System.Drawing.Point(0, -1);
            this.dgvDVT.Name = "dgvDVT";
            this.dgvDVT.RowHeadersWidth = 51;
            this.dgvDVT.RowTemplate.Height = 29;
            this.dgvDVT.Size = new System.Drawing.Size(1282, 419);
            this.dgvDVT.TabIndex = 70;
            this.dgvDVT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDVT_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaDVT";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Đơn Vị Tính";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 300;
            // 
            // TenDVT
            // 
            this.TenDVT.DataPropertyName = "TenDVT";
            this.TenDVT.HeaderText = "Tên Đơn Vị Tính";
            this.TenDVT.MinimumWidth = 6;
            this.TenDVT.Name = "TenDVT";
            this.TenDVT.Width = 400;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "GhiChu";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ghi Chú";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 600;
            // 
            // lbinfo
            // 
            this.lbinfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbinfo.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbinfo.ForeColor = System.Drawing.Color.Red;
            this.lbinfo.Location = new System.Drawing.Point(0, 422);
            this.lbinfo.Name = "lbinfo";
            this.lbinfo.Size = new System.Drawing.Size(779, 34);
            this.lbinfo.TabIndex = 69;
            this.lbinfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
           // 
            // btnhuy
            // 
            this.btnhuy.BackColor = System.Drawing.Color.LightSalmon;
            this.btnhuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnhuy.Location = new System.Drawing.Point(1090, 611);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(94, 72);
            this.btnhuy.TabIndex = 68;
            this.btnhuy.Text = "Huỷ";
            this.btnhuy.UseVisualStyleBackColor = false;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluulai
            // 
            this.btnluulai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnluulai.Location = new System.Drawing.Point(1090, 470);
            this.btnluulai.Name = "btnluulai";
            this.btnluulai.Size = new System.Drawing.Size(94, 106);
            this.btnluulai.TabIndex = 65;
            this.btnluulai.Text = "Lưu Lại";
            this.btnluulai.UseVisualStyleBackColor = true;
            this.btnluulai.Click += new System.EventHandler(this.btnluulai_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.GreenYellow;
            this.btnxoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnxoa.Location = new System.Drawing.Point(911, 624);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(94, 59);
            this.btnxoa.TabIndex = 63;
            this.btnxoa.Text = "Xoá";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnfix
            // 
            this.btnfix.BackColor = System.Drawing.Color.GreenYellow;
            this.btnfix.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnfix.Location = new System.Drawing.Point(911, 539);
            this.btnfix.Name = "btnfix";
            this.btnfix.Size = new System.Drawing.Size(94, 59);
            this.btnfix.TabIndex = 62;
            this.btnfix.Text = "Sửa";
            this.btnfix.UseVisualStyleBackColor = false;
            this.btnfix.Click += new System.EventHandler(this.btnfix_Click);
            this.btnfix.Leave += new System.EventHandler(this.btnfix_Leave);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.GreenYellow;
            this.btnthem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnthem.Location = new System.Drawing.Point(911, 454);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(94, 59);
            this.btnthem.TabIndex = 61;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            this.btnthem.Leave += new System.EventHandler(this.btnthem_Leave);
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(374, 645);
            this.txtghichu.Multiline = true;
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(225, 70);
            this.txtghichu.TabIndex = 60;
            // 
            // lbgiaxuat
            // 
            this.lbgiaxuat.AutoSize = true;
            this.lbgiaxuat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbgiaxuat.Location = new System.Drawing.Point(415, 542);
            this.lbgiaxuat.Name = "lbgiaxuat";
            this.lbgiaxuat.Size = new System.Drawing.Size(69, 20);
            this.lbgiaxuat.TabIndex = 59;
            this.lbgiaxuat.Text = "Giá Xuất";
            // 
            // txttonkho
            // 
            this.txttonkho.Location = new System.Drawing.Point(583, 608);
            this.txttonkho.Name = "txttonkho";
            this.txttonkho.Size = new System.Drawing.Size(195, 27);
            this.txttonkho.TabIndex = 58;
            // 
            // lbghichu
            // 
            this.lbghichu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbghichu.Location = new System.Drawing.Point(288, 665);
            this.lbghichu.Name = "lbghichu";
            this.lbghichu.Size = new System.Drawing.Size(64, 38);
            this.lbghichu.TabIndex = 57;
            this.lbghichu.Text = "Ghi Chú";
            this.lbghichu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbtonkho
            // 
            this.lbtonkho.AutoSize = true;
            this.lbtonkho.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbtonkho.Location = new System.Drawing.Point(415, 611);
            this.lbtonkho.Name = "lbtonkho";
            this.lbtonkho.Size = new System.Drawing.Size(138, 20);
            this.lbtonkho.TabIndex = 56;
            this.lbtonkho.Text = "Số Lượng Tồn Kho";
            // 
            // lbgianhap
            // 
            this.lbgianhap.AutoSize = true;
            this.lbgianhap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbgianhap.Location = new System.Drawing.Point(415, 473);
            this.lbgianhap.Name = "lbgianhap";
            this.lbgianhap.Size = new System.Drawing.Size(74, 20);
            this.lbgianhap.TabIndex = 55;
            this.lbgianhap.Text = "Giá Nhập";
            // 
            // lbdonvitinh
            // 
            this.lbdonvitinh.AutoSize = true;
            this.lbdonvitinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbdonvitinh.Location = new System.Drawing.Point(0, 611);
            this.lbdonvitinh.Name = "lbdonvitinh";
            this.lbdonvitinh.Size = new System.Drawing.Size(117, 20);
            this.lbdonvitinh.TabIndex = 54;
            this.lbdonvitinh.Text = "Mã Đơn Vị Tính";
            // 
            // lbmathang
            // 
            this.lbmathang.AutoSize = true;
            this.lbmathang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbmathang.Location = new System.Drawing.Point(0, 542);
            this.lbmathang.Name = "lbmathang";
            this.lbmathang.Size = new System.Drawing.Size(107, 20);
            this.lbmathang.TabIndex = 53;
            this.lbmathang.Text = "Tên Mặt Hàng";
            // 
            // lbmahang
            // 
            this.lbmahang.AutoSize = true;
            this.lbmahang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbmahang.Location = new System.Drawing.Point(0, 473);
            this.lbmahang.Name = "lbmahang";
            this.lbmahang.Size = new System.Drawing.Size(72, 20);
            this.lbmahang.TabIndex = 52;
            this.lbmahang.Text = "Mã Hàng";
            // 
            // txtdonvitinh
            // 
            this.txtdonvitinh.Location = new System.Drawing.Point(143, 608);
            this.txtdonvitinh.Name = "txtdonvitinh";
            this.txtdonvitinh.Size = new System.Drawing.Size(195, 27);
            this.txtdonvitinh.TabIndex = 51;
            this.txtdonvitinh.Leave += new System.EventHandler(this.txtdonvitinh_Leave);
            // 
            // txtgianhap
            // 
            this.txtgianhap.Location = new System.Drawing.Point(583, 470);
            this.txtgianhap.Name = "txtgianhap";
            this.txtgianhap.Size = new System.Drawing.Size(195, 27);
            this.txtgianhap.TabIndex = 50;
            this.txtgianhap.Leave += new System.EventHandler(this.txtgianhap_Leave);
            // 
            // txtgiaxuat
            // 
            this.txtgiaxuat.Location = new System.Drawing.Point(583, 539);
            this.txtgiaxuat.Name = "txtgiaxuat";
            this.txtgiaxuat.Size = new System.Drawing.Size(195, 27);
            this.txtgiaxuat.TabIndex = 49;
            // 
            // txtmathang
            // 
            this.txtmathang.Location = new System.Drawing.Point(143, 539);
            this.txtmathang.Multiline = true;
            this.txtmathang.Name = "txtmathang";
            this.txtmathang.Size = new System.Drawing.Size(195, 27);
            this.txtmathang.TabIndex = 48;
            // 
            // txtmahang
            // 
            this.txtmahang.Location = new System.Drawing.Point(143, 470);
            this.txtmahang.Name = "txtmahang";
            this.txtmahang.Size = new System.Drawing.Size(195, 27);
            this.txtmahang.TabIndex = 47;
            this.txtmahang.Leave += new System.EventHandler(this.txtmahang_Leave);
            // 
            // dgvhanghoa
            // 
            this.dgvhanghoa.AllowUserToAddRows = false;
            this.dgvhanghoa.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvhanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhanghoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHang,
            this.TenMatHang,
            this.MaDVT,
            this.GiaNhap,
            this.GiaXuat,
            this.SoLuongTon,
            this.GhiChu});
            this.dgvhanghoa.Location = new System.Drawing.Point(0, 0);
            this.dgvhanghoa.Name = "dgvhanghoa";
            this.dgvhanghoa.RowHeadersWidth = 51;
            this.dgvhanghoa.RowTemplate.Height = 29;
            this.dgvhanghoa.Size = new System.Drawing.Size(1282, 419);
            this.dgvhanghoa.TabIndex = 46;
            this.dgvhanghoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhanghoa_CellClick);
            // 
            // MaHang
            // 
            this.MaHang.DataPropertyName = "MaHang";
            this.MaHang.HeaderText = "Mã Hàng";
            this.MaHang.MinimumWidth = 6;
            this.MaHang.Name = "MaHang";
            this.MaHang.Width = 150;
            // 
            // TenMatHang
            // 
            this.TenMatHang.DataPropertyName = "TenMatHang";
            this.TenMatHang.HeaderText = "Tên Mặt Hàng";
            this.TenMatHang.MinimumWidth = 6;
            this.TenMatHang.Name = "TenMatHang";
            this.TenMatHang.Width = 300;
            // 
            // MaDVT
            // 
            this.MaDVT.DataPropertyName = "MaDVT";
            this.MaDVT.HeaderText = "Mã Đơn Vị Tính";
            this.MaDVT.MinimumWidth = 6;
            this.MaDVT.Name = "MaDVT";
            this.MaDVT.Width = 125;
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "GiaNhap";
            this.GiaNhap.HeaderText = "Giá Nhập";
            this.GiaNhap.MinimumWidth = 6;
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.Width = 200;
            // 
            // GiaXuat
            // 
            this.GiaXuat.DataPropertyName = "GiaXuat";
            this.GiaXuat.HeaderText = "Giá Xuất";
            this.GiaXuat.MinimumWidth = 6;
            this.GiaXuat.Name = "GiaXuat";
            this.GiaXuat.Width = 200;
            // 
            // SoLuongTon
            // 
            this.SoLuongTon.DataPropertyName = "SoLuongTon";
            this.SoLuongTon.HeaderText = "Số Lượng Tồn Kho";
            this.SoLuongTon.MinimumWidth = 6;
            this.SoLuongTon.Name = "SoLuongTon";
            this.SoLuongTon.Width = 125;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Width = 200;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(869, 62);
            this.txttimkiem.Multiline = true;
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(237, 36);
            this.txttimkiem.TabIndex = 67;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // lbtimkiem
            // 
            this.lbtimkiem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbtimkiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbtimkiem.Location = new System.Drawing.Point(807, 0);
            this.lbtimkiem.Name = "lbtimkiem";
            this.lbtimkiem.Size = new System.Drawing.Size(362, 28);
            this.lbtimkiem.TabIndex = 66;
            this.lbtimkiem.Text = "Nhập Tên Mặt Hàng Hoặc Mã Hàng Cần Tìm";
            this.lbtimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btntim
            // 
            this.btntim.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btntim.Location = new System.Drawing.Point(1176, 63);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(94, 38);
            this.btntim.TabIndex = 64;
            this.btntim.Text = "Tìm Kiếm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.rdbmahang);
            this.panel1.Controls.Add(this.rdbmathang);
            this.panel1.Controls.Add(this.txttimkiem);
            this.panel1.Controls.Add(this.btntim);
            this.panel1.Controls.Add(this.lbtimkiem);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 107);
            this.panel1.TabIndex = 46;
            // 
            // rdbmahang
            // 
            this.rdbmahang.AutoSize = true;
            this.rdbmahang.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rdbmahang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbmahang.Location = new System.Drawing.Point(869, 35);
            this.rdbmahang.Name = "rdbmahang";
            this.rdbmahang.Size = new System.Drawing.Size(93, 24);
            this.rdbmahang.TabIndex = 70;
            this.rdbmahang.TabStop = true;
            this.rdbmahang.Text = "Mã Hàng";
            this.rdbmahang.UseVisualStyleBackColor = false;
            this.rdbmahang.Click += new System.EventHandler(this.rdbmahang_Click);
            // 
            // rdbmathang
            // 
            this.rdbmathang.AutoSize = true;
            this.rdbmathang.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rdbmathang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbmathang.Location = new System.Drawing.Point(978, 35);
            this.rdbmathang.Name = "rdbmathang";
            this.rdbmathang.Size = new System.Drawing.Size(128, 24);
            this.rdbmathang.TabIndex = 69;
            this.rdbmathang.TabStop = true;
            this.rdbmathang.Text = "Tên Mặt Hàng";
            this.rdbmathang.UseVisualStyleBackColor = false;
            this.rdbmathang.Click += new System.EventHandler(this.rdbmathang_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_XemDS,
            this.btn_DVT,
            this.btnChinhsua,
            this.btn_quaylai});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1282, 59);
            this.menuStrip1.TabIndex = 68;
            this.menuStrip1.Text = "Menu";
            // 
            // btn_XemDS
            // 
            this.btn_XemDS.Name = "btn_XemDS";
            this.btn_XemDS.Size = new System.Drawing.Size(136, 55);
            this.btn_XemDS.Text = "Danh Sách";
            this.btn_XemDS.Click += new System.EventHandler(this.btn_XemDS_Click);
            // 
            // btn_DVT
            // 
            this.btn_DVT.Name = "btn_DVT";
            this.btn_DVT.Size = new System.Drawing.Size(149, 55);
            this.btn_DVT.Text = "Đơn Vị Tính";
            this.btn_DVT.Click += new System.EventHandler(this.btn_DVT_Click);
            // 
            // btnChinhsua
            // 
            this.btnChinhsua.Name = "btnChinhsua";
            this.btnChinhsua.Size = new System.Drawing.Size(133, 55);
            this.btnChinhsua.Text = "Chỉnh Sửa";
            this.btnChinhsua.Click += new System.EventHandler(this.btnChinhsua_Click);
            // 
            // btn_quaylai
            // 
            this.btn_quaylai.Name = "btn_quaylai";
            this.btn_quaylai.Size = new System.Drawing.Size(118, 55);
            this.btn_quaylai.Text = "Quay Lại";
            this.btn_quaylai.Click += new System.EventHandler(this.btn_quaylai_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1282, 832);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hàng Hoá";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhanghoa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label lbtimkiem;
        private System.Windows.Forms.Button btnluulai;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnfix;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.Label lbgiaxuat;
        private System.Windows.Forms.TextBox txttonkho;
        private System.Windows.Forms.Label lbghichu;
        private System.Windows.Forms.Label lbtonkho;
        private System.Windows.Forms.Label lbgianhap;
        private System.Windows.Forms.Label lbdonvitinh;
        private System.Windows.Forms.Label lbmathang;
        private System.Windows.Forms.Label lbmahang;
        private System.Windows.Forms.TextBox txtdonvitinh;
        private System.Windows.Forms.TextBox txtgianhap;
        private System.Windows.Forms.TextBox txtgiaxuat;
        private System.Windows.Forms.TextBox txtmathang;
        private System.Windows.Forms.TextBox txtmahang;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Label lbinfo;
        private System.Windows.Forms.DataGridView dgvhanghoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_XemDS;
        private System.Windows.Forms.ToolStripMenuItem btnChinhsua;
        private System.Windows.Forms.ToolStripMenuItem btn_quaylai;
        private System.Windows.Forms.RadioButton rdbmahang;
        private System.Windows.Forms.RadioButton rdbmathang;
        private System.Windows.Forms.DataGridView dgvDVT;
        private System.Windows.Forms.ToolStripMenuItem btn_DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}