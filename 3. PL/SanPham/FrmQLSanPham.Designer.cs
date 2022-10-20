namespace _3._PL
{
    partial class FrmQLSanPham
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
            this.txt_NamBH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgrid_ChiTietSP = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_MoTa = new System.Windows.Forms.TextBox();
            this.txt_SoLuongTon = new System.Windows.Forms.TextBox();
            this.txt_GiaNhap = new System.Windows.Forms.TextBox();
            this.txt_GiaBan = new System.Windows.Forms.TextBox();
            this.cmb_TenSP = new System.Windows.Forms.ComboBox();
            this.cmb_DongSP = new System.Windows.Forms.ComboBox();
            this.cmb_NSX = new System.Windows.Forms.ComboBox();
            this.cmb_MauSac = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MS_SP = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_DongSP = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Nsx = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_MauSac = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ChiTietSP)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_NamBH
            // 
            this.txt_NamBH.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_NamBH.Location = new System.Drawing.Point(623, 55);
            this.txt_NamBH.Name = "txt_NamBH";
            this.txt_NamBH.Size = new System.Drawing.Size(259, 32);
            this.txt_NamBH.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Sản Phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dòng Sản Phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhà Sản Xuất";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(23, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Màu Sắc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(477, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Năm Bảo Hành";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(477, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mô Tả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(477, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Số Lượng Tồn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(477, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Giá Nhập";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(477, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Giá Bán";
            // 
            // dgrid_ChiTietSP
            // 
            this.dgrid_ChiTietSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_ChiTietSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_ChiTietSP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_ChiTietSP.Location = new System.Drawing.Point(0, 321);
            this.dgrid_ChiTietSP.Name = "dgrid_ChiTietSP";
            this.dgrid_ChiTietSP.RowHeadersWidth = 51;
            this.dgrid_ChiTietSP.RowTemplate.Height = 29;
            this.dgrid_ChiTietSP.Size = new System.Drawing.Size(1038, 200);
            this.dgrid_ChiTietSP.TabIndex = 10;
            this.dgrid_ChiTietSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_ChiTietSP_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Clear);
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Controls.Add(this.btn_Sua);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(931, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(107, 321);
            this.panel1.TabIndex = 12;
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Clear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Clear.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(0, 1);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(107, 80);
            this.btn_Clear.TabIndex = 3;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Xoa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(0, 81);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(107, 80);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Sua.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(0, 161);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(107, 80);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Them.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(0, 241);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(107, 80);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_MoTa
            // 
            this.txt_MoTa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_MoTa.Location = new System.Drawing.Point(623, 108);
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.Size = new System.Drawing.Size(259, 32);
            this.txt_MoTa.TabIndex = 13;
            // 
            // txt_SoLuongTon
            // 
            this.txt_SoLuongTon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_SoLuongTon.Location = new System.Drawing.Point(623, 161);
            this.txt_SoLuongTon.Name = "txt_SoLuongTon";
            this.txt_SoLuongTon.Size = new System.Drawing.Size(259, 32);
            this.txt_SoLuongTon.TabIndex = 14;
            // 
            // txt_GiaNhap
            // 
            this.txt_GiaNhap.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_GiaNhap.Location = new System.Drawing.Point(623, 214);
            this.txt_GiaNhap.Name = "txt_GiaNhap";
            this.txt_GiaNhap.Size = new System.Drawing.Size(259, 32);
            this.txt_GiaNhap.TabIndex = 15;
            // 
            // txt_GiaBan
            // 
            this.txt_GiaBan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_GiaBan.Location = new System.Drawing.Point(623, 267);
            this.txt_GiaBan.Name = "txt_GiaBan";
            this.txt_GiaBan.Size = new System.Drawing.Size(259, 32);
            this.txt_GiaBan.TabIndex = 16;
            // 
            // cmb_TenSP
            // 
            this.cmb_TenSP.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_TenSP.FormattingEnabled = true;
            this.cmb_TenSP.Location = new System.Drawing.Point(169, 55);
            this.cmb_TenSP.Name = "cmb_TenSP";
            this.cmb_TenSP.Size = new System.Drawing.Size(259, 33);
            this.cmb_TenSP.TabIndex = 17;
            // 
            // cmb_DongSP
            // 
            this.cmb_DongSP.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_DongSP.FormattingEnabled = true;
            this.cmb_DongSP.Location = new System.Drawing.Point(169, 107);
            this.cmb_DongSP.Name = "cmb_DongSP";
            this.cmb_DongSP.Size = new System.Drawing.Size(259, 33);
            this.cmb_DongSP.TabIndex = 18;
            // 
            // cmb_NSX
            // 
            this.cmb_NSX.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_NSX.FormattingEnabled = true;
            this.cmb_NSX.Location = new System.Drawing.Point(169, 159);
            this.cmb_NSX.Name = "cmb_NSX";
            this.cmb_NSX.Size = new System.Drawing.Size(259, 33);
            this.cmb_NSX.TabIndex = 19;
            // 
            // cmb_MauSac
            // 
            this.cmb_MauSac.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_MauSac.FormattingEnabled = true;
            this.cmb_MauSac.Location = new System.Drawing.Point(169, 211);
            this.cmb_MauSac.Name = "cmb_MauSac";
            this.cmb_MauSac.Size = new System.Drawing.Size(259, 33);
            this.cmb_MauSac.TabIndex = 20;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_SP,
            this.MS_DongSP,
            this.MS_Nsx,
            this.MS_MauSac});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(931, 28);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MS_SP
            // 
            this.MS_SP.Name = "MS_SP";
            this.MS_SP.Size = new System.Drawing.Size(88, 24);
            this.MS_SP.Text = "Sản Phẩm";
            this.MS_SP.Click += new System.EventHandler(this.MS_SP_Click);
            // 
            // MS_DongSP
            // 
            this.MS_DongSP.Name = "MS_DongSP";
            this.MS_DongSP.Size = new System.Drawing.Size(129, 24);
            this.MS_DongSP.Text = "Dòng Sản Phẩm";
            this.MS_DongSP.Click += new System.EventHandler(this.MS_DongSP_Click);
            // 
            // MS_Nsx
            // 
            this.MS_Nsx.Name = "MS_Nsx";
            this.MS_Nsx.Size = new System.Drawing.Size(112, 24);
            this.MS_Nsx.Text = "Nhà Sản Xuất";
            this.MS_Nsx.Click += new System.EventHandler(this.MS_Nsx_Click);
            // 
            // MS_MauSac
            // 
            this.MS_MauSac.Name = "MS_MauSac";
            this.MS_MauSac.Size = new System.Drawing.Size(79, 24);
            this.MS_MauSac.Text = "Màu Sắc";
            this.MS_MauSac.Click += new System.EventHandler(this.MS_MauSac_Click);
            // 
            // FrmQLSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 521);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cmb_MauSac);
            this.Controls.Add(this.cmb_NSX);
            this.Controls.Add(this.cmb_DongSP);
            this.Controls.Add(this.cmb_TenSP);
            this.Controls.Add(this.txt_GiaBan);
            this.Controls.Add(this.txt_GiaNhap);
            this.Controls.Add(this.txt_SoLuongTon);
            this.Controls.Add(this.txt_MoTa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgrid_ChiTietSP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_NamBH);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmQLSanPham";
            this.Text = "FrmQLSanPham";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ChiTietSP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_NamBH;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private DataGridView dgrid_ChiTietSP;
        private Panel panel1;
        private Button btn_Clear;
        private Button btn_Xoa;
        private Button btn_Sua;
        private Button btn_Them;
        private TextBox txt_MoTa;
        private TextBox txt_SoLuongTon;
        private TextBox txt_GiaNhap;
        private TextBox txt_GiaBan;
        private ComboBox cmb_TenSP;
        private ComboBox cmb_DongSP;
        private ComboBox cmb_NSX;
        private ComboBox cmb_MauSac;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MS_SP;
        private ToolStripMenuItem MS_DongSP;
        private ToolStripMenuItem MS_Nsx;
        private ToolStripMenuItem MS_MauSac;
    }
}