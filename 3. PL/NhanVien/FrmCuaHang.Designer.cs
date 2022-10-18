namespace _3._PL.NhanVien
{
    partial class FrmCuaHang
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
            this.dgrid_CuaHang = new System.Windows.Forms.DataGridView();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_TenCuaHang = new System.Windows.Forms.TextBox();
            this.txt_MaCuaHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_ThanhPho = new System.Windows.Forms.ComboBox();
            this.cmb_QuocGia = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_CuaHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrid_CuaHang
            // 
            this.dgrid_CuaHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_CuaHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_CuaHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_CuaHang.Location = new System.Drawing.Point(0, 384);
            this.dgrid_CuaHang.Name = "dgrid_CuaHang";
            this.dgrid_CuaHang.RowHeadersWidth = 51;
            this.dgrid_CuaHang.RowTemplate.Height = 29;
            this.dgrid_CuaHang.Size = new System.Drawing.Size(377, 188);
            this.dgrid_CuaHang.TabIndex = 33;
            this.dgrid_CuaHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_KhachHang_CellContentClick);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(271, 334);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(94, 29);
            this.btn_Xoa.TabIndex = 32;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(142, 334);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(94, 29);
            this.btn_Sua.TabIndex = 31;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(10, 334);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(94, 29);
            this.btn_Them.TabIndex = 30;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_TenCuaHang
            // 
            this.txt_TenCuaHang.Location = new System.Drawing.Point(153, 90);
            this.txt_TenCuaHang.Name = "txt_TenCuaHang";
            this.txt_TenCuaHang.Size = new System.Drawing.Size(191, 27);
            this.txt_TenCuaHang.TabIndex = 29;
            // 
            // txt_MaCuaHang
            // 
            this.txt_MaCuaHang.Location = new System.Drawing.Point(153, 25);
            this.txt_MaCuaHang.Name = "txt_MaCuaHang";
            this.txt_MaCuaHang.Size = new System.Drawing.Size(191, 27);
            this.txt_MaCuaHang.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tên Cửa Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã Cửa Hàng";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(153, 155);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(191, 27);
            this.txt_DiaChi.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Thành Phố";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Quốc Gia";
            // 
            // cmb_ThanhPho
            // 
            this.cmb_ThanhPho.FormattingEnabled = true;
            this.cmb_ThanhPho.Location = new System.Drawing.Point(153, 222);
            this.cmb_ThanhPho.Name = "cmb_ThanhPho";
            this.cmb_ThanhPho.Size = new System.Drawing.Size(191, 28);
            this.cmb_ThanhPho.TabIndex = 40;
            // 
            // cmb_QuocGia
            // 
            this.cmb_QuocGia.FormattingEnabled = true;
            this.cmb_QuocGia.Location = new System.Drawing.Point(153, 282);
            this.cmb_QuocGia.Name = "cmb_QuocGia";
            this.cmb_QuocGia.Size = new System.Drawing.Size(191, 28);
            this.cmb_QuocGia.TabIndex = 41;
            // 
            // FrmCuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 572);
            this.Controls.Add(this.cmb_QuocGia);
            this.Controls.Add(this.cmb_ThanhPho);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.dgrid_CuaHang);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_TenCuaHang);
            this.Controls.Add(this.txt_MaCuaHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCuaHang";
            this.Text = "FrmCuaHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_CuaHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgrid_CuaHang;
        private Button btn_Xoa;
        private Button btn_Sua;
        private Button btn_Them;
        private TextBox txt_TenCuaHang;
        private TextBox txt_MaCuaHang;
        private Label label2;
        private Label label1;
        private TextBox txt_DiaChi;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmb_ThanhPho;
        private ComboBox cmb_QuocGia;
    }
}