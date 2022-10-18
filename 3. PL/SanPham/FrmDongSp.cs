using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1._DAL.DomainClass;
using _2._BUS.IService.SanPham;
using _2._BUS.Service;
using _2._BUS.Service.SanPham;
using _2._BUS.ViewModels;

namespace _3._PL.SanPham
{
    public partial class FrmDongSp : Form
    {
        private IDongSpService _iDongSpService;
        private Guid _id;
        public FrmDongSp()
        {
            InitializeComponent();
            _iDongSpService = new DongSpService();
            LoadDongSp();
        }
        private void LoadDongSp()
        {
            int stt = 1;
            dgrid_DongSp.ColumnCount = 4;
            dgrid_DongSp.Columns[0].Name = "STT";
            dgrid_DongSp.Columns[1].Name = "ID";
            dgrid_DongSp.Columns[2].Name = "Mã Dòng SP";
            dgrid_DongSp.Columns[3].Name = "Tên Dòng SP";
            dgrid_DongSp.Rows.Clear();
            dgrid_DongSp.Columns[1].Visible = false;
            foreach (var dsp in _iDongSpService.GetAll())
            {
                dgrid_DongSp.Rows.Add(stt++, dsp.IdDsp, dsp.MaDsp, dsp.TenDsp);
            }
        }

        private void dgrid_DongSp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            _id = Guid.Parse(dgrid_DongSp.Rows[rowindex].Cells[1].Value.ToString());
            var temp = _iDongSpService.getByGuid(_id);
            txt_MaDongSp.Text = temp.Ma;
            txt_TenDongSp.Text = temp.Ten;
        }
        private QLSanPhamViewModel getDongSpControl()
        {
            return new QLSanPhamViewModel()
            {
                IdDsp = Guid.Empty,
                MaDsp = txt_MaDongSp.Text,
                TenDsp = txt_TenDongSp.Text,
            };
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iDongSpService.Add(getDongSpControl()));
            LoadDongSp();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var temp = getDongSpControl();
            temp.IdDsp = _id;
            MessageBox.Show(_iDongSpService.Update(temp));
            LoadDongSp();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var temp = getDongSpControl();
            temp.IdDsp = _id;
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(_iDongSpService.Delete(temp));
                LoadDongSp();
            }
        }
    }
}
