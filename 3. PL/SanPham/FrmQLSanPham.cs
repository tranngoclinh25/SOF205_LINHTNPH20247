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
using _3._PL.SanPham;

namespace _3._PL
{
    public partial class FrmQLSanPham : Form
    {
        private IQLSanPhamService _iChiTietSanPhamService;
        private ISanPhamService _iSanPhamService;
        private IDongSpService _iDongSpService;
        private IMauSacService _iMauSacService;
        private INsxService _iNsxService;
        private Guid _id;
        public FrmQLSanPham()
        {
            InitializeComponent();
            _iChiTietSanPhamService = new QLSanPhamService();
            _iSanPhamService = new SanPhamService();
            _iDongSpService = new DongSpService();
            _iMauSacService = new MauSacService();
            _iNsxService = new NsxService();
            LoadChiTietSanPham();
            LoadCombobox();
        }
        private void LoadChiTietSanPham()
        {
            int stt = 1;
            dgrid_ChiTietSP.ColumnCount = 11;
            dgrid_ChiTietSP.Columns[0].Name = "STT";
            dgrid_ChiTietSP.Columns[1].Name = "ID";
            dgrid_ChiTietSP.Columns[2].Name = "Tên SP";
            dgrid_ChiTietSP.Columns[3].Name = "Dòng SP";
            dgrid_ChiTietSP.Columns[4].Name = "Màu Sắc";
            dgrid_ChiTietSP.Columns[5].Name = "Nhà Sản Xuất";
            dgrid_ChiTietSP.Columns[6].Name = "Năm BH";
            dgrid_ChiTietSP.Columns[7].Name = "Mô tả";
            dgrid_ChiTietSP.Columns[8].Name = "SL Tồn";
            dgrid_ChiTietSP.Columns[9].Name = "Giá Nhập";
            dgrid_ChiTietSP.Columns[10].Name = "Giá Bán";
            dgrid_ChiTietSP.Rows.Clear();
            dgrid_ChiTietSP.Columns[1].Visible = false;
            foreach (var x in _iChiTietSanPhamService.GetAll())
            {
                dgrid_ChiTietSP.Rows.Add(stt++, x.ChiTietSp.Id, x.SanPham.Ten, x.DongSp.Ten, x.MauSac.Ten, x.Nsx.Ten, x.ChiTietSp.NamBh, x.ChiTietSp.MoTa, x.ChiTietSp.SoLuongTon, x.ChiTietSp.GiaNhap, x.ChiTietSp.GiaBan);
            }
        }

        private void LoadCombobox()
        {
            foreach (var x in _iSanPhamService.GetAll())
            {
                cmb_TenSP.Items.Add(x.SanPham.Ten);
                cmb_TenSP.SelectedIndex = 0;
            }
            foreach (var x in _iDongSpService.GetAll())
            {
                cmb_DongSP.Items.Add(x.DongSp.Ten);
                cmb_DongSP.SelectedIndex = 0;
            }
            foreach (var x in _iMauSacService.GetAll())
            {
                cmb_MauSac.Items.Add(x.MauSac.Ten);
                cmb_MauSac.SelectedIndex = 0;
            }
            foreach (var x in _iNsxService.GetAll())
            {
                cmb_NSX.Items.Add(x.Nsx.Ten);
                cmb_NSX.SelectedIndex = 0;
            }
        }
        private void dgrid_ChiTietSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            _id = Guid.Parse(dgrid_ChiTietSP.Rows[rowindex].Cells[1].Value.ToString());
            var temp = _iChiTietSanPhamService.getByGuidChiTietSpSanPham(_id);
            cmb_TenSP.SelectedItem = _iChiTietSanPhamService.GetAll().FirstOrDefault(p => p.SanPham.Id == temp.IdSp).SanPham.Ten;
            cmb_DongSP.SelectedItem = _iChiTietSanPhamService.GetAll().FirstOrDefault(p => p.DongSp.Id == temp.IdDongSp).DongSp.Ten;
            cmb_MauSac.SelectedItem =
                _iChiTietSanPhamService.GetAll().FirstOrDefault(p => p.MauSac.Id == temp.IdMauSac).MauSac.Ten;
            cmb_NSX.SelectedItem = _iChiTietSanPhamService.GetAll().FirstOrDefault(p => p.Nsx.Id == temp.IdNsx).Nsx.Ten;
            txt_NamBH.Text = temp.NamBh.ToString();
            txt_MoTa.Text = temp.MoTa;
            txt_SoLuongTon.Text = temp.SoLuongTon.ToString();
            txt_GiaNhap.Text = temp.GiaNhap.ToString();
            txt_GiaBan.Text = temp.GiaBan.ToString();
        }
        private QLSanPhamViewModel getChiTietSpControl()
        {
            var sp = _iSanPhamService.GetAll().FirstOrDefault(p => p.SanPham.Ten == cmb_TenSP.Text);
            var dsp = _iDongSpService.GetAll().FirstOrDefault(p => p.DongSp.Ten == cmb_DongSP.Text);
            var ms = _iMauSacService.GetAll().FirstOrDefault(p => p.MauSac.Ten == cmb_MauSac.Text);
            var nsx = _iNsxService.GetAll().FirstOrDefault(p => p.Nsx.Ten == cmb_NSX.Text);
            var ctsp = new ChiTietSp() { Id = Guid.Empty, IdSp = sp.SanPham.Id, IdDongSp = dsp.DongSp.Id, IdMauSac = ms.MauSac.Id, IdNsx = nsx.Nsx.Id, NamBh = int.Parse(txt_NamBH.Text), MoTa = txt_MoTa.Text, SoLuongTon = int.Parse(txt_SoLuongTon.Text), GiaNhap = int.Parse(txt_GiaNhap.Text), GiaBan = int.Parse(txt_GiaBan.Text)};
            return new QLSanPhamViewModel() { ChiTietSp = ctsp};
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iChiTietSanPhamService.Add(getChiTietSpControl()));
            LoadChiTietSanPham();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var temp = getChiTietSpControl();
            temp.ChiTietSp.Id = _id;
            MessageBox.Show(_iChiTietSanPhamService.Update(temp));
            LoadChiTietSanPham();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var temp = getChiTietSpControl();
            temp.ChiTietSp.Id = _id;
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(_iChiTietSanPhamService.Delete(temp));
                LoadChiTietSanPham();
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            cmb_TenSP.Text = null;
            cmb_DongSP.Text = null;
            cmb_MauSac.Text = null;
            cmb_NSX.Text = null;
            txt_NamBH.Text = null;
            txt_MoTa.Text = null;
            txt_SoLuongTon.Text = null;
            txt_GiaNhap.Text = null;
            txt_GiaBan.Text = null;
        }

        private void MS_SP_Click(object sender, EventArgs e)
        {
            FrmSanPham _frmQlSanPham;
            _frmQlSanPham = new FrmSanPham();
            _frmQlSanPham.ShowDialog();
        }

        private void MS_DongSP_Click(object sender, EventArgs e)
        {
            FrmDongSp _frmQlDongSp;
            _frmQlDongSp = new FrmDongSp();
            _frmQlDongSp.ShowDialog();
        }

        private void MS_Nsx_Click(object sender, EventArgs e)
        {
            FrmNsx _frmQlNsx;
            _frmQlNsx = new FrmNsx();
            _frmQlNsx.ShowDialog();
        }

        private void MS_MauSac_Click(object sender, EventArgs e)
        {
            FrmMauSac _frmQlMauSac;
            _frmQlMauSac = new FrmMauSac();
            _frmQlMauSac.ShowDialog();
        }
    }
}
