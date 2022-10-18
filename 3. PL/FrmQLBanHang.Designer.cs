namespace _3._PL
{
    partial class FrmQLBanHang
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
            this.dgrid_SanPham = new System.Windows.Forms.DataGridView();
            this.btn_TaoHoaDon = new System.Windows.Forms.Button();
            this.txt_TimKiemSanPham = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtn_ChoThanhToan = new System.Windows.Forms.RadioButton();
            this.rbtn_TatCa = new System.Windows.Forms.RadioButton();
            this.rbtn_DaHuy = new System.Windows.Forms.RadioButton();
            this.rbtn_DaThanhToan = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgrid_GioHang = new System.Windows.Forms.DataGridView();
            this.dgrid_HoaDon = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_TenNV = new System.Windows.Forms.ComboBox();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.txt_TienThua = new System.Windows.Forms.TextBox();
            this.txt_TienKhachDua = new System.Windows.Forms.TextBox();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.txt_NgayTao = new System.Windows.Forms.TextBox();
            this.txt_MaHD = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MS_QLSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_QLHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_NhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_KhachHang = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_SanPham)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_GioHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_HoaDon)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrid_SanPham
            // 
            this.dgrid_SanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_SanPham.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgrid_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_SanPham.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgrid_SanPham.Location = new System.Drawing.Point(3, 83);
            this.dgrid_SanPham.Name = "dgrid_SanPham";
            this.dgrid_SanPham.RowHeadersWidth = 51;
            this.dgrid_SanPham.RowTemplate.Height = 29;
            this.dgrid_SanPham.Size = new System.Drawing.Size(1024, 265);
            this.dgrid_SanPham.TabIndex = 0;
            this.dgrid_SanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_SanPham_CellContentClick);
            // 
            // btn_TaoHoaDon
            // 
            this.btn_TaoHoaDon.BackColor = System.Drawing.Color.LightCyan;
            this.btn_TaoHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_TaoHoaDon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_TaoHoaDon.Location = new System.Drawing.Point(869, 40);
            this.btn_TaoHoaDon.Name = "btn_TaoHoaDon";
            this.btn_TaoHoaDon.Size = new System.Drawing.Size(171, 39);
            this.btn_TaoHoaDon.TabIndex = 1;
            this.btn_TaoHoaDon.Text = "TẠO HÓA ĐƠN";
            this.btn_TaoHoaDon.UseVisualStyleBackColor = false;
            this.btn_TaoHoaDon.Click += new System.EventHandler(this.btn_TaoHoaDon_Click);
            // 
            // txt_TimKiemSanPham
            // 
            this.txt_TimKiemSanPham.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TimKiemSanPham.Location = new System.Drawing.Point(3, 39);
            this.txt_TimKiemSanPham.Name = "txt_TimKiemSanPham";
            this.txt_TimKiemSanPham.Size = new System.Drawing.Size(595, 38);
            this.txt_TimKiemSanPham.TabIndex = 2;
            this.txt_TimKiemSanPham.Text = "Tìm kiếm ... ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgrid_SanPham);
            this.panel1.Controls.Add(this.txt_TimKiemSanPham);
            this.panel1.Location = new System.Drawing.Point(13, 559);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 354);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 3;
            // 
            // rbtn_ChoThanhToan
            // 
            this.rbtn_ChoThanhToan.AutoSize = true;
            this.rbtn_ChoThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtn_ChoThanhToan.Location = new System.Drawing.Point(14, 40);
            this.rbtn_ChoThanhToan.Name = "rbtn_ChoThanhToan";
            this.rbtn_ChoThanhToan.Size = new System.Drawing.Size(168, 32);
            this.rbtn_ChoThanhToan.TabIndex = 4;
            this.rbtn_ChoThanhToan.TabStop = true;
            this.rbtn_ChoThanhToan.Text = "Chờ thanh toán";
            this.rbtn_ChoThanhToan.UseVisualStyleBackColor = true;
            // 
            // rbtn_TatCa
            // 
            this.rbtn_TatCa.AutoSize = true;
            this.rbtn_TatCa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtn_TatCa.Location = new System.Drawing.Point(287, 40);
            this.rbtn_TatCa.Name = "rbtn_TatCa";
            this.rbtn_TatCa.Size = new System.Drawing.Size(84, 32);
            this.rbtn_TatCa.TabIndex = 5;
            this.rbtn_TatCa.TabStop = true;
            this.rbtn_TatCa.Text = "Tất cả";
            this.rbtn_TatCa.UseVisualStyleBackColor = true;
            // 
            // rbtn_DaHuy
            // 
            this.rbtn_DaHuy.AutoSize = true;
            this.rbtn_DaHuy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtn_DaHuy.Location = new System.Drawing.Point(476, 40);
            this.rbtn_DaHuy.Name = "rbtn_DaHuy";
            this.rbtn_DaHuy.Size = new System.Drawing.Size(94, 32);
            this.rbtn_DaHuy.TabIndex = 6;
            this.rbtn_DaHuy.TabStop = true;
            this.rbtn_DaHuy.Text = "Đã hủy";
            this.rbtn_DaHuy.UseVisualStyleBackColor = true;
            // 
            // rbtn_DaThanhToan
            // 
            this.rbtn_DaThanhToan.AutoSize = true;
            this.rbtn_DaThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtn_DaThanhToan.Location = new System.Drawing.Point(675, 40);
            this.rbtn_DaThanhToan.Name = "rbtn_DaThanhToan";
            this.rbtn_DaThanhToan.Size = new System.Drawing.Size(157, 32);
            this.rbtn_DaThanhToan.TabIndex = 7;
            this.rbtn_DaThanhToan.TabStop = true;
            this.rbtn_DaThanhToan.Text = "Đã thanh toán";
            this.rbtn_DaThanhToan.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dgrid_GioHang);
            this.panel2.Location = new System.Drawing.Point(13, 293);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(598, 248);
            this.panel2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giỏ hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 3;
            // 
            // dgrid_GioHang
            // 
            this.dgrid_GioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_GioHang.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgrid_GioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_GioHang.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgrid_GioHang.Location = new System.Drawing.Point(0, 43);
            this.dgrid_GioHang.Name = "dgrid_GioHang";
            this.dgrid_GioHang.RowHeadersWidth = 51;
            this.dgrid_GioHang.RowTemplate.Height = 29;
            this.dgrid_GioHang.Size = new System.Drawing.Size(598, 202);
            this.dgrid_GioHang.TabIndex = 0;
            // 
            // dgrid_HoaDon
            // 
            this.dgrid_HoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_HoaDon.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgrid_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_HoaDon.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgrid_HoaDon.Location = new System.Drawing.Point(13, 100);
            this.dgrid_HoaDon.Name = "dgrid_HoaDon";
            this.dgrid_HoaDon.RowHeadersWidth = 51;
            this.dgrid_HoaDon.RowTemplate.Height = 29;
            this.dgrid_HoaDon.Size = new System.Drawing.Size(598, 187);
            this.dgrid_HoaDon.TabIndex = 5;
            this.dgrid_HoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_HoaDon_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(617, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(423, 554);
            this.panel3.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_TenNV);
            this.groupBox1.Controls.Add(this.btn_Huy);
            this.groupBox1.Controls.Add(this.txt_TienThua);
            this.groupBox1.Controls.Add(this.txt_TienKhachDua);
            this.groupBox1.Controls.Add(this.txt_TongTien);
            this.groupBox1.Controls.Add(this.txt_NgayTao);
            this.groupBox1.Controls.Add(this.txt_MaHD);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_ThanhToan);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 548);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn";
            // 
            // cmb_TenNV
            // 
            this.cmb_TenNV.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_TenNV.FormattingEnabled = true;
            this.cmb_TenNV.Location = new System.Drawing.Point(164, 203);
            this.cmb_TenNV.Name = "cmb_TenNV";
            this.cmb_TenNV.Size = new System.Drawing.Size(235, 30);
            this.cmb_TenNV.TabIndex = 22;
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.Color.LightCyan;
            this.btn_Huy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Huy.Location = new System.Drawing.Point(37, 502);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(166, 39);
            this.btn_Huy.TabIndex = 21;
            this.btn_Huy.Text = "HỦY";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // txt_TienThua
            // 
            this.txt_TienThua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TienThua.Location = new System.Drawing.Point(164, 451);
            this.txt_TienThua.Name = "txt_TienThua";
            this.txt_TienThua.Size = new System.Drawing.Size(235, 30);
            this.txt_TienThua.TabIndex = 20;
            // 
            // txt_TienKhachDua
            // 
            this.txt_TienKhachDua.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TienKhachDua.Location = new System.Drawing.Point(164, 370);
            this.txt_TienKhachDua.Name = "txt_TienKhachDua";
            this.txt_TienKhachDua.Size = new System.Drawing.Size(235, 30);
            this.txt_TienKhachDua.TabIndex = 19;
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TongTien.Location = new System.Drawing.Point(164, 289);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(235, 30);
            this.txt_TongTien.TabIndex = 18;
            // 
            // txt_NgayTao
            // 
            this.txt_NgayTao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_NgayTao.Location = new System.Drawing.Point(164, 127);
            this.txt_NgayTao.Name = "txt_NgayTao";
            this.txt_NgayTao.Size = new System.Drawing.Size(235, 30);
            this.txt_NgayTao.TabIndex = 16;
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_MaHD.Location = new System.Drawing.Point(164, 46);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.Size = new System.Drawing.Size(235, 30);
            this.txt_MaHD.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(31, 455);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 23);
            this.label11.TabIndex = 14;
            this.label11.Text = "Tiền Thừa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(31, 374);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 23);
            this.label10.TabIndex = 13;
            this.label10.Text = "Tiền Khách Đưa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(37, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "Tổng Tiền";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(37, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tên NV";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(37, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ngày Tạo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(37, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã HD";
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.BackColor = System.Drawing.Color.LightCyan;
            this.btn_ThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ThanhToan.Location = new System.Drawing.Point(224, 502);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(166, 39);
            this.btn_ThanhToan.TabIndex = 8;
            this.btn_ThanhToan.Text = "THANH TOÁN";
            this.btn_ThanhToan.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(30, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_QLSanPham,
            this.MS_QLHoaDon,
            this.MS_NhanVien,
            this.MS_KhachHang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1062, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MS_QLSanPham
            // 
            this.MS_QLSanPham.BackColor = System.Drawing.Color.LightSkyBlue;
            this.MS_QLSanPham.Name = "MS_QLSanPham";
            this.MS_QLSanPham.Size = new System.Drawing.Size(88, 24);
            this.MS_QLSanPham.Text = "Sản Phẩm";
            this.MS_QLSanPham.Click += new System.EventHandler(this.MS_QLSanPham_Click);
            // 
            // MS_QLHoaDon
            // 
            this.MS_QLHoaDon.BackColor = System.Drawing.Color.LightSkyBlue;
            this.MS_QLHoaDon.Name = "MS_QLHoaDon";
            this.MS_QLHoaDon.Size = new System.Drawing.Size(83, 24);
            this.MS_QLHoaDon.Text = "Hóa Đơn";
            // 
            // MS_NhanVien
            // 
            this.MS_NhanVien.Name = "MS_NhanVien";
            this.MS_NhanVien.Size = new System.Drawing.Size(91, 24);
            this.MS_NhanVien.Text = "Nhân Viên";
            this.MS_NhanVien.Click += new System.EventHandler(this.MS_NhanVien_Click);
            // 
            // MS_KhachHang
            // 
            this.MS_KhachHang.Name = "MS_KhachHang";
            this.MS_KhachHang.Size = new System.Drawing.Size(103, 24);
            this.MS_KhachHang.Text = "Khách Hàng";
            this.MS_KhachHang.Click += new System.EventHandler(this.MS_KhachHang_Click);
            // 
            // FrmQLBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 923);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgrid_HoaDon);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.rbtn_DaThanhToan);
            this.Controls.Add(this.rbtn_DaHuy);
            this.Controls.Add(this.rbtn_TatCa);
            this.Controls.Add(this.rbtn_ChoThanhToan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_TaoHoaDon);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmQLBanHang";
            this.Text = "FrmQLBanHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_SanPham)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_GioHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_HoaDon)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgrid_SanPham;
        private Button btn_TaoHoaDon;
        private TextBox txt_TimKiemSanPham;
        private Panel panel1;
        private Label label1;
        private RadioButton rbtn_ChoThanhToan;
        private RadioButton rbtn_TatCa;
        private RadioButton rbtn_DaHuy;
        private RadioButton rbtn_DaThanhToan;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private DataGridView dgrid_GioHang;
        private DataGridView dgrid_HoaDon;
        private Panel panel3;
        private Button btn_ThanhToan;
        private Label label6;
        private GroupBox groupBox1;
        private TextBox txt_TienThua;
        private TextBox txt_TienKhachDua;
        private TextBox txt_TongTien;
        private TextBox txt_NgayTao;
        private TextBox txt_MaHD;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MS_QLSanPham;
        private ToolStripMenuItem MS_QLHoaDon;
        private Button btn_Huy;
        private ToolStripMenuItem MS_NhanVien;
        private ToolStripMenuItem MS_KhachHang;
        private ComboBox cmb_TenNV;
    }
}