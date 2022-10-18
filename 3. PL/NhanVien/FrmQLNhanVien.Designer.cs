namespace _3._PL.NhanVien
{
    partial class FrmQLNhanVien
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
            this.MS_ChucVu = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_CuaHang = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_ChucVu = new System.Windows.Forms.ComboBox();
            this.cmb_CuaHang = new System.Windows.Forms.ComboBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_HoNV = new System.Windows.Forms.TextBox();
            this.txt_TenDemNV = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgrid_NhanVien = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TenNV = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.txt_GioiTinh = new System.Windows.Forms.TextBox();
            this.DT_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.rbtn_DangLam = new System.Windows.Forms.RadioButton();
            this.rbtn_NghiLam = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_NhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // MS_ChucVu
            // 
            this.MS_ChucVu.Name = "MS_ChucVu";
            this.MS_ChucVu.Size = new System.Drawing.Size(77, 24);
            this.MS_ChucVu.Text = "Chức Vụ";
            this.MS_ChucVu.Click += new System.EventHandler(this.MS_ChucVu_Click);
            // 
            // MS_CuaHang
            // 
            this.MS_CuaHang.Name = "MS_CuaHang";
            this.MS_CuaHang.Size = new System.Drawing.Size(89, 24);
            this.MS_CuaHang.Text = "Cửa Hàng";
            this.MS_CuaHang.Click += new System.EventHandler(this.MS_CuaHang_Click);
            // 
            // cmb_ChucVu
            // 
            this.cmb_ChucVu.FormattingEnabled = true;
            this.cmb_ChucVu.Location = new System.Drawing.Point(169, 398);
            this.cmb_ChucVu.Name = "cmb_ChucVu";
            this.cmb_ChucVu.Size = new System.Drawing.Size(234, 28);
            this.cmb_ChucVu.TabIndex = 41;
            // 
            // cmb_CuaHang
            // 
            this.cmb_CuaHang.FormattingEnabled = true;
            this.cmb_CuaHang.Location = new System.Drawing.Point(169, 438);
            this.cmb_CuaHang.Name = "cmb_CuaHang";
            this.cmb_CuaHang.Size = new System.Drawing.Size(234, 28);
            this.cmb_CuaHang.TabIndex = 40;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(169, 359);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = '*';
            this.txt_Pass.Size = new System.Drawing.Size(234, 27);
            this.txt_Pass.TabIndex = 37;
            // 
            // txt_HoNV
            // 
            this.txt_HoNV.Location = new System.Drawing.Point(169, 161);
            this.txt_HoNV.Name = "txt_HoNV";
            this.txt_HoNV.Size = new System.Drawing.Size(234, 27);
            this.txt_HoNV.TabIndex = 35;
            // 
            // txt_TenDemNV
            // 
            this.txt_TenDemNV.Location = new System.Drawing.Point(169, 121);
            this.txt_TenDemNV.Name = "txt_TenDemNV";
            this.txt_TenDemNV.Size = new System.Drawing.Size(234, 27);
            this.txt_TenDemNV.TabIndex = 34;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_CuaHang,
            this.MS_ChucVu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(596, 28);
            this.menuStrip1.TabIndex = 42;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Clear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Clear.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(0, 3);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(150, 120);
            this.btn_Clear.TabIndex = 3;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Xoa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(0, 123);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(150, 120);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Sua.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(0, 243);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(150, 120);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Them.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(0, 363);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(150, 120);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Clear);
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Controls.Add(this.btn_Sua);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(446, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 483);
            this.panel1.TabIndex = 33;
            // 
            // dgrid_NhanVien
            // 
            this.dgrid_NhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_NhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_NhanVien.Location = new System.Drawing.Point(0, 511);
            this.dgrid_NhanVien.Name = "dgrid_NhanVien";
            this.dgrid_NhanVien.RowHeadersWidth = 51;
            this.dgrid_NhanVien.RowTemplate.Height = 29;
            this.dgrid_NhanVien.Size = new System.Drawing.Size(596, 187);
            this.dgrid_NhanVien.TabIndex = 32;
            this.dgrid_NhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_NhanVien_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Mật Khẩu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "SDT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Địa Chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Ngày Sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Giới Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Họ NV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tên Đệm NV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tên NV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã NV";
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.Location = new System.Drawing.Point(169, 81);
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.Size = new System.Drawing.Size(234, 27);
            this.txt_TenNV.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 404);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 43;
            this.label10.Text = "Chức Vụ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 444);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 20);
            this.label11.TabIndex = 44;
            this.label11.Text = "Cửa Hàng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 484);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 20);
            this.label12.TabIndex = 45;
            this.label12.Text = "Trạng Thái";
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Location = new System.Drawing.Point(169, 41);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(234, 27);
            this.txt_MaNV.TabIndex = 46;
            // 
            // txt_GioiTinh
            // 
            this.txt_GioiTinh.Location = new System.Drawing.Point(169, 201);
            this.txt_GioiTinh.Name = "txt_GioiTinh";
            this.txt_GioiTinh.Size = new System.Drawing.Size(234, 27);
            this.txt_GioiTinh.TabIndex = 47;
            // 
            // DT_NgaySinh
            // 
            this.DT_NgaySinh.Location = new System.Drawing.Point(169, 239);
            this.DT_NgaySinh.Name = "DT_NgaySinh";
            this.DT_NgaySinh.Size = new System.Drawing.Size(250, 27);
            this.DT_NgaySinh.TabIndex = 48;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(169, 281);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(234, 27);
            this.txt_DiaChi.TabIndex = 49;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(169, 320);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(234, 27);
            this.txt_SDT.TabIndex = 50;
            // 
            // rbtn_DangLam
            // 
            this.rbtn_DangLam.AutoSize = true;
            this.rbtn_DangLam.Location = new System.Drawing.Point(169, 482);
            this.rbtn_DangLam.Name = "rbtn_DangLam";
            this.rbtn_DangLam.Size = new System.Drawing.Size(98, 24);
            this.rbtn_DangLam.TabIndex = 51;
            this.rbtn_DangLam.TabStop = true;
            this.rbtn_DangLam.Text = "Đang Làm";
            this.rbtn_DangLam.UseVisualStyleBackColor = true;
            // 
            // rbtn_NghiLam
            // 
            this.rbtn_NghiLam.AutoSize = true;
            this.rbtn_NghiLam.Location = new System.Drawing.Point(288, 482);
            this.rbtn_NghiLam.Name = "rbtn_NghiLam";
            this.rbtn_NghiLam.Size = new System.Drawing.Size(94, 24);
            this.rbtn_NghiLam.TabIndex = 52;
            this.rbtn_NghiLam.TabStop = true;
            this.rbtn_NghiLam.Text = "Nghỉ Làm";
            this.rbtn_NghiLam.UseVisualStyleBackColor = true;
            // 
            // FrmQLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 698);
            this.Controls.Add(this.rbtn_NghiLam);
            this.Controls.Add(this.rbtn_DangLam);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.DT_NgaySinh);
            this.Controls.Add(this.txt_GioiTinh);
            this.Controls.Add(this.txt_MaNV);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmb_ChucVu);
            this.Controls.Add(this.cmb_CuaHang);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_HoNV);
            this.Controls.Add(this.txt_TenDemNV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgrid_NhanVien);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_TenNV);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmQLNhanVien";
            this.Text = "FrmQLNhanVien";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_NhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStripMenuItem MS_ChucVu;
        private ToolStripMenuItem MS_CuaHang;
        private ComboBox cmb_ChucVu;
        private ComboBox cmb_CuaHang;
        private TextBox txt_Pass;
        private TextBox txt_HoNV;
        private TextBox txt_TenDemNV;
        private MenuStrip menuStrip1;
        private Button btn_Clear;
        private Button btn_Xoa;
        private Button btn_Sua;
        private Button btn_Them;
        private Panel panel1;
        private DataGridView dgrid_NhanVien;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_TenNV;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txt_MaNV;
        private TextBox txt_GioiTinh;
        private DateTimePicker DT_NgaySinh;
        private TextBox txt_DiaChi;
        private TextBox txt_SDT;
        private RadioButton rbtn_DangLam;
        private RadioButton rbtn_NghiLam;
    }
}