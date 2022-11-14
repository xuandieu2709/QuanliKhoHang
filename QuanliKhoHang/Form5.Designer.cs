
namespace QuanliKhoHang
{
    partial class Form5
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
            this.dgvhoadonnhap = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbmahoadon = new System.Windows.Forms.Label();
            this.lbmahang = new System.Windows.Forms.Label();
            this.lbsoluong = new System.Windows.Forms.Label();
            this.lbgianhapxuat = new System.Windows.Forms.Label();
            this.lbthanhtien = new System.Windows.Forms.Label();
            this.lbtongtien = new System.Windows.Forms.Label();
            this.txtmahoadon = new System.Windows.Forms.TextBox();
            this.txtmahang = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtgianhapxuat = new System.Windows.Forms.TextBox();
            this.txtthanhtien = new System.Windows.Forms.TextBox();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxemhoadon = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbinfor = new System.Windows.Forms.Label();
            this.txtGTGT = new System.Windows.Forms.TextBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.lbGTGT = new System.Windows.Forms.Label();
            this.btnhuy = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.dgvhoadonxuat = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GTGT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbtimkiem = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbmahang = new System.Windows.Forms.RadioButton();
            this.rdbhoadon = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.btnxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_chinhsua = new System.Windows.Forms.ToolStripMenuItem();
            this.btnback = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadonnhap)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadonxuat)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvhoadonnhap
            // 
            this.dgvhoadonnhap.AllowUserToAddRows = false;
            this.dgvhoadonnhap.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvhoadonnhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhoadonnhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaHang,
            this.SoLuong,
            this.GiaNhap,
            this.ThanhTien,
            this.dataGridViewTextBoxColumn6,
            this.TongTien});
            this.dgvhoadonnhap.Location = new System.Drawing.Point(1, 43);
            this.dgvhoadonnhap.Name = "dgvhoadonnhap";
            this.dgvhoadonnhap.RowHeadersWidth = 51;
            this.dgvhoadonnhap.RowTemplate.Height = 29;
            this.dgvhoadonnhap.Size = new System.Drawing.Size(1281, 504);
            this.dgvhoadonnhap.TabIndex = 1;
            this.dgvhoadonnhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhoadonnhap_CellClick);
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã Hoá Đơn";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            this.MaHD.Width = 200;
            // 
            // MaHang
            // 
            this.MaHang.DataPropertyName = "MaHang";
            this.MaHang.HeaderText = "Mã Hàng";
            this.MaHang.MinimumWidth = 6;
            this.MaHang.Name = "MaHang";
            this.MaHang.Width = 200;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 125;
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "GiaNhap";
            this.GiaNhap.HeaderText = "Giá Nhập ";
            this.GiaNhap.MinimumWidth = 6;
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.Width = 200;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "GTGT";
            this.dataGridViewTextBoxColumn6.HeaderText = "Giá Trị Gia Tăng";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 300;
            // 
            // lbmahoadon
            // 
            this.lbmahoadon.AutoSize = true;
            this.lbmahoadon.Location = new System.Drawing.Point(11, 621);
            this.lbmahoadon.Name = "lbmahoadon";
            this.lbmahoadon.Size = new System.Drawing.Size(94, 20);
            this.lbmahoadon.TabIndex = 6;
            this.lbmahoadon.Text = "Mã Hoá Đơn";
            // 
            // lbmahang
            // 
            this.lbmahang.AutoSize = true;
            this.lbmahang.Location = new System.Drawing.Point(13, 665);
            this.lbmahang.Name = "lbmahang";
            this.lbmahang.Size = new System.Drawing.Size(70, 20);
            this.lbmahang.TabIndex = 7;
            this.lbmahang.Text = "Mã Hàng";
            // 
            // lbsoluong
            // 
            this.lbsoluong.AutoSize = true;
            this.lbsoluong.Location = new System.Drawing.Point(13, 706);
            this.lbsoluong.Name = "lbsoluong";
            this.lbsoluong.Size = new System.Drawing.Size(72, 20);
            this.lbsoluong.TabIndex = 8;
            this.lbsoluong.Text = "Số Lượng";
            // 
            // lbgianhapxuat
            // 
            this.lbgianhapxuat.AutoSize = true;
            this.lbgianhapxuat.Location = new System.Drawing.Point(478, 621);
            this.lbgianhapxuat.Name = "lbgianhapxuat";
            this.lbgianhapxuat.Size = new System.Drawing.Size(105, 20);
            this.lbgianhapxuat.TabIndex = 9;
            this.lbgianhapxuat.Text = "Giá Nhập Xuất";
            // 
            // lbthanhtien
            // 
            this.lbthanhtien.AutoSize = true;
            this.lbthanhtien.Location = new System.Drawing.Point(478, 665);
            this.lbthanhtien.Name = "lbthanhtien";
            this.lbthanhtien.Size = new System.Drawing.Size(81, 20);
            this.lbthanhtien.TabIndex = 10;
            this.lbthanhtien.Text = "Thành Tiền";
            // 
            // lbtongtien
            // 
            this.lbtongtien.AutoSize = true;
            this.lbtongtien.Location = new System.Drawing.Point(252, 739);
            this.lbtongtien.Name = "lbtongtien";
            this.lbtongtien.Size = new System.Drawing.Size(75, 20);
            this.lbtongtien.TabIndex = 11;
            this.lbtongtien.Text = "Tổng Tiền";
            // 
            // txtmahoadon
            // 
            this.txtmahoadon.Location = new System.Drawing.Point(114, 614);
            this.txtmahoadon.Name = "txtmahoadon";
            this.txtmahoadon.Size = new System.Drawing.Size(187, 27);
            this.txtmahoadon.TabIndex = 12;
            this.txtmahoadon.Leave += new System.EventHandler(this.txtmahoadon_Leave);
            // 
            // txtmahang
            // 
            this.txtmahang.Location = new System.Drawing.Point(114, 658);
            this.txtmahang.Name = "txtmahang";
            this.txtmahang.Size = new System.Drawing.Size(187, 27);
            this.txtmahang.TabIndex = 13;
            this.txtmahang.Leave += new System.EventHandler(this.txtmahang_Leave);
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(114, 703);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(187, 27);
            this.txtsoluong.TabIndex = 14;
            // 
            // txtgianhapxuat
            // 
            this.txtgianhapxuat.Location = new System.Drawing.Point(603, 614);
            this.txtgianhapxuat.Name = "txtgianhapxuat";
            this.txtgianhapxuat.Size = new System.Drawing.Size(187, 27);
            this.txtgianhapxuat.TabIndex = 15;
            this.txtgianhapxuat.TextChanged += new System.EventHandler(this.txtgianhapxuat_TextChanged);
            // 
            // txtthanhtien
            // 
            this.txtthanhtien.Location = new System.Drawing.Point(604, 658);
            this.txtthanhtien.Name = "txtthanhtien";
            this.txtthanhtien.Size = new System.Drawing.Size(187, 27);
            this.txtthanhtien.TabIndex = 16;
            this.txtthanhtien.Click += new System.EventHandler(this.txtthanhtien_Click);
            this.txtthanhtien.TextChanged += new System.EventHandler(this.txtthanhtien_TextChanged);
            this.txtthanhtien.Leave += new System.EventHandler(this.txtthanhtien_Leave);
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(359, 736);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(187, 27);
            this.txttongtien.TabIndex = 17;
            this.txttongtien.Click += new System.EventHandler(this.txttongtien_Click);
            this.txttongtien.TextChanged += new System.EventHandler(this.txttongtien_TextChanged);
            this.txttongtien.Leave += new System.EventHandler(this.txttongtien_Leave);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.GreenYellow;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnthem.Location = new System.Drawing.Point(989, 578);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(94, 49);
            this.btnthem.TabIndex = 18;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.GreenYellow;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsua.Location = new System.Drawing.Point(989, 643);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(94, 49);
            this.btnsua.TabIndex = 19;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.GreenYellow;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnxoa.Location = new System.Drawing.Point(989, 710);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(94, 49);
            this.btnxoa.TabIndex = 20;
            this.btnxoa.Text = "Xoá";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluu
            // 
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnluu.Location = new System.Drawing.Point(1153, 578);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(94, 96);
            this.btnluu.TabIndex = 21;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxemhoadon
            // 
            this.btnxemhoadon.BackColor = System.Drawing.Color.Gold;
            this.btnxemhoadon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnxemhoadon.Location = new System.Drawing.Point(114, 4);
            this.btnxemhoadon.Name = "btnxemhoadon";
            this.btnxemhoadon.Size = new System.Drawing.Size(139, 37);
            this.btnxemhoadon.TabIndex = 5;
            this.btnxemhoadon.Text = "Xuất Hoá Đơn";
            this.btnxemhoadon.UseVisualStyleBackColor = false;
            this.btnxemhoadon.Click += new System.EventHandler(this.btnxemhoadon_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbinfor);
            this.panel2.Controls.Add(this.txtGTGT);
            this.panel2.Controls.Add(this.btntimkiem);
            this.panel2.Controls.Add(this.lbGTGT);
            this.panel2.Controls.Add(this.btnhuy);
            this.panel2.Controls.Add(this.txttimkiem);
            this.panel2.Controls.Add(this.btnxemhoadon);
            this.panel2.Controls.Add(this.dgvhoadonxuat);
            this.panel2.Controls.Add(this.dgvhoadonnhap);
            this.panel2.Controls.Add(this.btnluu);
            this.panel2.Controls.Add(this.btnxoa);
            this.panel2.Controls.Add(this.btnsua);
            this.panel2.Controls.Add(this.btnthem);
            this.panel2.Controls.Add(this.txttongtien);
            this.panel2.Controls.Add(this.txtmahoadon);
            this.panel2.Controls.Add(this.lbtongtien);
            this.panel2.Controls.Add(this.txtsoluong);
            this.panel2.Controls.Add(this.txtthanhtien);
            this.panel2.Controls.Add(this.txtmahang);
            this.panel2.Controls.Add(this.lbsoluong);
            this.panel2.Controls.Add(this.lbmahoadon);
            this.panel2.Controls.Add(this.lbmahang);
            this.panel2.Controls.Add(this.txtgianhapxuat);
            this.panel2.Controls.Add(this.lbthanhtien);
            this.panel2.Controls.Add(this.lbgianhapxuat);
            this.panel2.Location = new System.Drawing.Point(1, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1281, 774);
            this.panel2.TabIndex = 27;
            // 
            // lbinfor
            // 
            this.lbinfor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbinfor.ForeColor = System.Drawing.Color.Maroon;
            this.lbinfor.Location = new System.Drawing.Point(13, 554);
            this.lbinfor.Name = "lbinfor";
            this.lbinfor.Size = new System.Drawing.Size(777, 47);
            this.lbinfor.TabIndex = 28;
            this.lbinfor.Text = "label1";
            this.lbinfor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGTGT
            // 
            this.txtGTGT.Location = new System.Drawing.Point(603, 703);
            this.txtGTGT.Name = "txtGTGT";
            this.txtGTGT.Size = new System.Drawing.Size(187, 27);
            this.txtGTGT.TabIndex = 27;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btntimkiem.Location = new System.Drawing.Point(1126, 8);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(121, 29);
            this.btntimkiem.TabIndex = 25;
            this.btntimkiem.Text = "Tìm Kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // lbGTGT
            // 
            this.lbGTGT.AutoSize = true;
            this.lbGTGT.Location = new System.Drawing.Point(478, 706);
            this.lbGTGT.Name = "lbGTGT";
            this.lbGTGT.Size = new System.Drawing.Size(44, 20);
            this.lbGTGT.TabIndex = 26;
            this.lbGTGT.Text = "GTGT";
            // 
            // btnhuy
            // 
            this.btnhuy.BackColor = System.Drawing.Color.LightSalmon;
            this.btnhuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnhuy.Location = new System.Drawing.Point(1153, 703);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(94, 56);
            this.btnhuy.TabIndex = 25;
            this.btnhuy.Text = "Huỷ";
            this.btnhuy.UseVisualStyleBackColor = false;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txttimkiem.Location = new System.Drawing.Point(827, 8);
            this.txttimkiem.Multiline = true;
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(267, 29);
            this.txttimkiem.TabIndex = 26;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // dgvhoadonxuat
            // 
            this.dgvhoadonxuat.AllowUserToAddRows = false;
            this.dgvhoadonxuat.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvhoadonxuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhoadonxuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.GiaXuat,
            this.dataGridViewTextBoxColumn4,
            this.GTGT,
            this.dataGridViewTextBoxColumn5});
            this.dgvhoadonxuat.Location = new System.Drawing.Point(1, 43);
            this.dgvhoadonxuat.Name = "dgvhoadonxuat";
            this.dgvhoadonxuat.RowHeadersWidth = 51;
            this.dgvhoadonxuat.RowTemplate.Height = 29;
            this.dgvhoadonxuat.Size = new System.Drawing.Size(1281, 504);
            this.dgvhoadonxuat.TabIndex = 6;
            this.dgvhoadonxuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhoadonxuat_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaHD";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Hoá Đơn";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaHang";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã Hàng";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SoLuong";
            this.dataGridViewTextBoxColumn3.HeaderText = "Số Lượng";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // GiaXuat
            // 
            this.GiaXuat.DataPropertyName = "GiaXuat";
            this.GiaXuat.HeaderText = "Giá Xuất";
            this.GiaXuat.MinimumWidth = 6;
            this.GiaXuat.Name = "GiaXuat";
            this.GiaXuat.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ThanhTien";
            this.dataGridViewTextBoxColumn4.HeaderText = "Thành Tiền";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // GTGT
            // 
            this.GTGT.DataPropertyName = "GTGT";
            this.GTGT.HeaderText = "Giá Trị Gia Tăng";
            this.GTGT.MinimumWidth = 6;
            this.GTGT.Name = "GTGT";
            this.GTGT.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TongTien";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tổng Tiền";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 300;
            // 
            // lbtimkiem
            // 
            this.lbtimkiem.AutoSize = true;
            this.lbtimkiem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbtimkiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbtimkiem.Location = new System.Drawing.Point(822, 4);
            this.lbtimkiem.Name = "lbtimkiem";
            this.lbtimkiem.Size = new System.Drawing.Size(272, 28);
            this.lbtimkiem.TabIndex = 27;
            this.lbtimkiem.Text = "Nhập Mã Hoá Đơn Cần Tìm";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.rdbmahang);
            this.panel1.Controls.Add(this.rdbhoadon);
            this.panel1.Controls.Add(this.lbtimkiem);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 59);
            this.panel1.TabIndex = 26;
            // 
            // rdbmahang
            // 
            this.rdbmahang.AutoSize = true;
            this.rdbmahang.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rdbmahang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbmahang.Location = new System.Drawing.Point(1003, 35);
            this.rdbmahang.Name = "rdbmahang";
            this.rdbmahang.Size = new System.Drawing.Size(93, 24);
            this.rdbmahang.TabIndex = 29;
            this.rdbmahang.TabStop = true;
            this.rdbmahang.Text = "Mã Hàng";
            this.rdbmahang.UseVisualStyleBackColor = false;
            this.rdbmahang.Click += new System.EventHandler(this.rdbmahang_Click);
            // 
            // rdbhoadon
            // 
            this.rdbhoadon.AutoSize = true;
            this.rdbhoadon.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rdbhoadon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbhoadon.Location = new System.Drawing.Point(827, 35);
            this.rdbhoadon.Name = "rdbhoadon";
            this.rdbhoadon.Size = new System.Drawing.Size(117, 24);
            this.rdbhoadon.TabIndex = 28;
            this.rdbhoadon.TabStop = true;
            this.rdbhoadon.Text = "Mã Hóa Đơn";
            this.rdbhoadon.UseVisualStyleBackColor = false;
            this.rdbhoadon.Click += new System.EventHandler(this.rdbhoadon_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnnhap,
            this.btnxuat,
            this.btn_chinhsua,
            this.btnback});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1282, 59);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnnhap
            // 
            this.btnnhap.Name = "btnnhap";
            this.btnnhap.Size = new System.Drawing.Size(178, 55);
            this.btnnhap.Text = "Hóa Đơn Nhập";
            this.btnnhap.Click += new System.EventHandler(this.btnnhap_Click);
            // 
            // btnxuat
            // 
            this.btnxuat.Name = "btnxuat";
            this.btnxuat.Size = new System.Drawing.Size(171, 55);
            this.btnxuat.Text = "Hóa Đơn Xuất";
            this.btnxuat.Click += new System.EventHandler(this.btnxuat_Click);
            // 
            // btn_chinhsua
            // 
            this.btn_chinhsua.Name = "btn_chinhsua";
            this.btn_chinhsua.Size = new System.Drawing.Size(133, 55);
            this.btn_chinhsua.Text = "Chỉnh Sửa";
            this.btn_chinhsua.Click += new System.EventHandler(this.btn_chinhsua_Click);
            // 
            // btnback
            // 
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(118, 55);
            this.btnback.Text = "Quay Lại";
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1282, 832);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoá Đơn";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadonnhap)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadonxuat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvhoadonnhap;
        private System.Windows.Forms.Label lbmahoadon;
        private System.Windows.Forms.Label lbmahang;
        private System.Windows.Forms.Label lbgianhapxuat;
        private System.Windows.Forms.Label lbthanhtien;
        private System.Windows.Forms.Label lbtongtien;
        private System.Windows.Forms.TextBox txtmahoadon;
        private System.Windows.Forms.TextBox txtmahang;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtgianhapxuat;
        private System.Windows.Forms.TextBox txtthanhtien;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnluu;
        public System.Windows.Forms.Label lbsoluong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvhoadonxuat;
        private System.Windows.Forms.Button btnxemhoadon;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnnhap;
        private System.Windows.Forms.ToolStripMenuItem btnxuat;
        private System.Windows.Forms.ToolStripMenuItem btn_chinhsua;
        private System.Windows.Forms.ToolStripMenuItem btnback;
        private System.Windows.Forms.Label lbtimkiem;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn GTGT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox txtGTGT;
        private System.Windows.Forms.Label lbGTGT;
        private System.Windows.Forms.Label lbinfor;
        private System.Windows.Forms.RadioButton rdbmahang;
        private System.Windows.Forms.RadioButton rdbhoadon;
    }
}