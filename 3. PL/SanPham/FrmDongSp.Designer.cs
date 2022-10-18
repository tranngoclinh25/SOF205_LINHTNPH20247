namespace _3._PL.SanPham
{
    partial class FrmDongSp
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
            this.dgrid_DongSp = new System.Windows.Forms.DataGridView();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_TenDongSp = new System.Windows.Forms.TextBox();
            this.txt_MaDongSp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_DongSp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrid_DongSp
            // 
            this.dgrid_DongSp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_DongSp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_DongSp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_DongSp.Location = new System.Drawing.Point(0, 255);
            this.dgrid_DongSp.Name = "dgrid_DongSp";
            this.dgrid_DongSp.RowHeadersWidth = 51;
            this.dgrid_DongSp.RowTemplate.Height = 29;
            this.dgrid_DongSp.Size = new System.Drawing.Size(377, 188);
            this.dgrid_DongSp.TabIndex = 25;
            this.dgrid_DongSp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_DongSp_CellContentClick);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(270, 204);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(94, 29);
            this.btn_Xoa.TabIndex = 24;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(141, 204);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(94, 29);
            this.btn_Sua.TabIndex = 23;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(9, 204);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(94, 29);
            this.btn_Them.TabIndex = 22;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_TenDongSp
            // 
            this.txt_TenDongSp.Location = new System.Drawing.Point(153, 136);
            this.txt_TenDongSp.Name = "txt_TenDongSp";
            this.txt_TenDongSp.Size = new System.Drawing.Size(162, 27);
            this.txt_TenDongSp.TabIndex = 21;
            // 
            // txt_MaDongSp
            // 
            this.txt_MaDongSp.Location = new System.Drawing.Point(153, 50);
            this.txt_MaDongSp.Name = "txt_MaDongSp";
            this.txt_MaDongSp.Size = new System.Drawing.Size(162, 27);
            this.txt_MaDongSp.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên Dòng SP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã  Dòng SP";
            // 
            // FrmQLDongSp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 443);
            this.Controls.Add(this.dgrid_DongSp);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_TenDongSp);
            this.Controls.Add(this.txt_MaDongSp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDongSp";
            this.Text = "FrmDongSp";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_DongSp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dgrid_DongSp;
        private Button btn_Xoa;
        private Button btn_Sua;
        private Button btn_Them;
        private TextBox txt_TenDongSp;
        private TextBox txt_MaDongSp;
        private Label label2;
        private Label label1;
    }
}