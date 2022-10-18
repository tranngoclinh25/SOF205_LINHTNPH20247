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
using _2._BUS.IService;
using _2._BUS.IService.NhanVien;
using _2._BUS.IService.SanPham;
using _2._BUS.Service;
using _2._BUS.Service.NhanVien;
using _2._BUS.Service.SanPham;
using _2._BUS.ViewModels;
using _3._PL.NhanVien;
using _3._PL.SanPham;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace _3._PL
{
    public partial class FrmQLBanHang : Form
    {
        private Guid Key;
        private Guid _idHoaDon;
        private IQLSanPhamService _iSanPhamService;
        private IHoaDonService _iHoaDonService;
        private INhanVienService _iNhanVienService;
        public FrmQLBanHang()
        {
            InitializeComponent();
            _iSanPhamService = new QLSanPhamService();
            _iHoaDonService = new HoaDonService();
            _iNhanVienService = new NhanVienService();
            LoadSanPham();
            LoadHoaDon();
            LoadTenNV();
            LoadGioHang(Key);
        }

        private void LoadSanPham()
        {
            int stt = 1;
            dgrid_SanPham.ColumnCount = 11;
            dgrid_SanPham.Columns[0].Name = "STT";
            dgrid_SanPham.Columns[1].Name = "ID";
            dgrid_SanPham.Columns[2].Name = "Mã SP";
            dgrid_SanPham.Columns[3].Name = "Tên SP";
            dgrid_SanPham.Columns[4].Name = "Màu Sắc";
            dgrid_SanPham.Columns[5].Name = "Năm BH";
            dgrid_SanPham.Columns[6].Name = "Dòng SP";
            dgrid_SanPham.Columns[7].Name = "Mô tả";
            dgrid_SanPham.Columns[8].Name = "SL SP";
            dgrid_SanPham.Columns[9].Name = "Giá Nhập";
            dgrid_SanPham.Columns[10].Name = "Giá Bán";
            dgrid_SanPham.Rows.Clear();
            dgrid_SanPham.Columns[1].Visible = false;
            foreach (var x in _iSanPhamService.GetAll())
            {
                dgrid_SanPham.Rows.Add(stt++, x.SanPham.Id, x.SanPham.Ma, x.SanPham.Ten, x.MauSac.Ten, x.ChiTietSp.NamBh, x.DongSp.Ten, x.ChiTietSp.MoTa, x.ChiTietSp.SoLuongTon, x.ChiTietSp.GiaNhap, x.ChiTietSp.GiaBan);
            }
        }

        #region Hóa Đơn
        private void LoadHoaDon()
        {
            int stt = 1;
            dgrid_HoaDon.ColumnCount = 6;
            dgrid_HoaDon.Columns[0].Name = "STT";
            dgrid_HoaDon.Columns[1].Name = "ID";
            dgrid_HoaDon.Columns[2].Name = "Mã HD";
            dgrid_HoaDon.Columns[3].Name = "Ngày Tạo";
            dgrid_HoaDon.Columns[4].Name = "Tên NV";
            dgrid_HoaDon.Columns[5].Name = "Tình Trạng";
            dgrid_HoaDon.Rows.Clear();
            dgrid_HoaDon.Columns[1].Visible = false;
            foreach (var x in _iHoaDonService.GetAll())
            {
                dgrid_HoaDon.Rows.Add(stt++, x.HoaDon.Id, x.HoaDon.Ma, x.HoaDon.NgayTao,x.NhanVien.Ten, x.HoaDon.TinhTrang == 1 ? "Chờ thanh toán" : x.HoaDon.TinhTrang == 2 ? "Đã hủy" : "Đã thanh toán");
            }
        }
        private void LoadTenNV()
        {
            foreach (var x in _iHoaDonService.GetAll())
            {
                cmb_TenNV.Items.Add(x.NhanVien.Ten);
                cmb_TenNV.SelectedIndex = 0;
            }
        }
        private void dgrid_HoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            _idHoaDon = Guid.Parse(dgrid_HoaDon.Rows[rowindex].Cells[1].Value.ToString());
            var temp = _iHoaDonService.getByGuid(_idHoaDon);
            txt_MaHD.Text = temp.Ma;
            txt_NgayTao.Text = temp.NgayTao.ToString();
            cmb_TenNV.SelectedItem = _iHoaDonService.GetAll().FirstOrDefault(p => p.NhanVien.Id == temp.IdNv).NhanVien.Ten;
        }
        private QLHoaDonViewModel getHoaDonControl()
        {
            var nv = _iNhanVienService.GetAll().FirstOrDefault(p => p.NhanVien.Ten == cmb_TenNV.Text);
            var hd = new HoaDon() { Id = Guid.Empty, NgayTao = DateTime.Now, IdNv = nv.NhanVien.Id, TinhTrang = 1};
            return new QLHoaDonViewModel() { HoaDon = hd };
        }
        private void btn_TaoHoaDon_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iHoaDonService.Add(getHoaDonControl()));
            LoadHoaDon();
        }
        private void btn_Huy_Click(object sender, EventArgs e)
        {

        }
        #endregion
        private void dgrid_SanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            Key = Guid.Parse(dgrid_SanPham.Rows[rowindex].Cells[1].Value.ToString());
            LoadGioHang(Key);
        }

        private void LoadGioHang(Guid id)
        {
            int stt = 1;
            decimal? thanhTien;
            dgrid_GioHang.ColumnCount = 6;
            dgrid_GioHang.Columns[0].Name = "STT";
            dgrid_GioHang.Columns[1].Name = "Mã SP";
            dgrid_GioHang.Columns[2].Name = "Tên SP";
            dgrid_GioHang.Columns[3].Name = "Số Lượng";
            dgrid_GioHang.Columns[4].Name = "Đơn Giá";
            dgrid_GioHang.Columns[5].Name = "Thành Tiền";
            dgrid_GioHang.Rows.Clear();
        }

        private void MS_QLSanPham_Click(object sender, EventArgs e)
        {
            FrmQLSanPham _frmQlChiTietSanPham;
            _frmQlChiTietSanPham = new FrmQLSanPham();
            _frmQlChiTietSanPham.ShowDialog();
        }

        private void MS_CuaHang_Click(object sender, EventArgs e)
        {
            FrmCuaHang _frmCuaHang;
            _frmCuaHang = new FrmCuaHang();
            _frmCuaHang.ShowDialog();
        }

        private void MS_NhanVien_Click(object sender, EventArgs e)
        {
            FrmQLNhanVien _frmQLNhanVien;
            _frmQLNhanVien = new FrmQLNhanVien();
            _frmQLNhanVien.ShowDialog();
        }

        private void MS_KhachHang_Click(object sender, EventArgs e)
        {
            FrmKhachHang _frmKhachHang;
            _frmKhachHang = new FrmKhachHang();
            _frmKhachHang.ShowDialog();
        }
    }
}
