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
    public partial class FrmSanPham : Form
    {
        private ISanPhamService _iSanPhamService;
        private Guid _id;
        public FrmSanPham()
        {
            InitializeComponent();
            _iSanPhamService = new SanPhamService();
            LoadSanPham();
        }
        private void LoadSanPham()
        {
            int stt = 1;
            dgrid_SP.ColumnCount = 4;
            dgrid_SP.Columns[0].Name = "STT";
            dgrid_SP.Columns[1].Name = "ID";
            dgrid_SP.Columns[2].Name = "Mã SP";
            dgrid_SP.Columns[3].Name = "Tên SP";
            dgrid_SP.Rows.Clear();
            dgrid_SP.Columns[1].Visible = false;
            foreach (var sp in _iSanPhamService.GetAll())
            {
                dgrid_SP.Rows.Add(stt++, sp.SanPham.Id, sp.SanPham.Ma, sp.SanPham.Ten);
            }
        }
        private void dgrid_SP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexrow = e.RowIndex;
            _id = Guid.Parse(dgrid_SP.Rows[indexrow].Cells[1].Value.ToString());
            var temp = _iSanPhamService.getByGuid(_id);
            txt_MaSP.Text = temp.Ma;
            txt_TenSP.Text = temp.Ten;
        }
        private QLSanPhamViewModel getSanPhamControl()
        {
            var sp = new _1._DAL.DomainClass.SanPham() { Id = Guid.Empty, Ma = txt_MaSP.Text, Ten = txt_TenSP.Text };
            return new QLSanPhamViewModel() { SanPham = sp};
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iSanPhamService.Add(getSanPhamControl()));
            LoadSanPham();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var temp = getSanPhamControl();
            temp.SanPham.Id = _id;
            MessageBox.Show(_iSanPhamService.Update(temp));
            LoadSanPham();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var temp = getSanPhamControl();
            temp.SanPham.Id = _id;
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(_iSanPhamService.Delete(temp));
                LoadSanPham();
            }
        }
}
}
