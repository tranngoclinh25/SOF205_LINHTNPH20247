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
using _2._BUS.IService.NhanVien;
using _2._BUS.Service.NhanVien;
using _2._BUS.ViewModels;

namespace _3._PL.NhanVien
{
    public partial class FrmQLNhanVien : Form
    {
        private INhanVienService _iNhanVienService;
        private IChucVuService _iChucVuService;
        private ICuaHangService _iCuaHangService;
        Guid _id;
        public FrmQLNhanVien()
        {
            InitializeComponent();
            _iNhanVienService = new NhanVienService();
            _iChucVuService = new ChucVuService();
            _iCuaHangService = new CuaHangService();
            rbtn_DangLam.Checked = true;
            LoadNhanVien();
            LoadCombobox();
        }
        private void LoadNhanVien()
        {
            int stt = 1;
            dgrid_NhanVien.ColumnCount = 12;
            dgrid_NhanVien.Columns[0].Name = "STT";
            dgrid_NhanVien.Columns[1].Name = "ID";
            dgrid_NhanVien.Columns[2].Name = "Tên NV";
            dgrid_NhanVien.Columns[3].Name = "Giới Tính";
            dgrid_NhanVien.Columns[4].Name = "Ngày Sinh";
            dgrid_NhanVien.Columns[5].Name = "Tuổi";
            dgrid_NhanVien.Columns[6].Name = "Địa Chỉ";
            dgrid_NhanVien.Columns[7].Name = "SDT";
            dgrid_NhanVien.Columns[8].Name = "Mật Khẩu";
            dgrid_NhanVien.Columns[9].Name = "Chức Vụ";
            dgrid_NhanVien.Columns[10].Name = "Của Hàng";
            dgrid_NhanVien.Columns[11].Name = "Trạng Thái";
            dgrid_NhanVien.Rows.Clear();
            dgrid_NhanVien.Columns[1].Visible = false;
            foreach (var x in _iNhanVienService.GetAll())
            {
                dgrid_NhanVien.Rows.Add(stt++, x.IdNv,$"{x.HoNv} {x.TenDemNv} {x.TenNv}", x.GioiTinh, x.NgaySinh, x.Tuoi ,x.DiaChiNV,x.Sdt,x.MatKhau,x.TenCv,x.TenCh,x.TrangThai==1?"Đang Làm":"Nghỉ Làm");
            }
        }

        private void LoadCombobox()
        {
            foreach (var x in _iChucVuService.GetAll())
            {
                cmb_ChucVu.Items.Add(x.TenCv);
                cmb_ChucVu.SelectedIndex = 0;
            }

            foreach (var x in _iCuaHangService.GetAll())
            {
                cmb_CuaHang.Items.Add(x.TenCh);
                cmb_CuaHang.SelectedIndex = 0;
            }
        }

        private void dgrid_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            _id = Guid.Parse(dgrid_NhanVien.Rows[rowindex].Cells[1].Value.ToString());
            var temp = _iNhanVienService.getByGuid(_id);
            cmb_ChucVu.SelectedItem = _iNhanVienService.GetAll().FirstOrDefault(p=>p.IdCv_FK == temp.IdCv).TenCv;
            cmb_CuaHang.SelectedItem = _iNhanVienService.GetAll().FirstOrDefault(p => p.IdCh_FK == temp.IdCh).TenCh;
            txt_MaNV.Text = temp.Ma;
            txt_TenNV.Text = temp.Ten;
            txt_TenDemNV.Text = temp.TenDem;
            txt_HoNV.Text = temp.Ho;
            txt_GioiTinh.Text = temp.GioiTinh;
            DT_NgaySinh.Value = (DateTime)temp.NgaySinh;
            txt_DiaChi.Text = temp.DiaChi;
            txt_SDT.Text = temp.Sdt;
            txt_Pass.Text = temp.MatKhau;
            if (temp.TrangThai == 1)
            {
                rbtn_DangLam.Checked = true;
                return;
            }
            rbtn_NghiLam.Checked = true;
        }
        private QLNhanVienViewModel getNhanVienControl()
        {
            var cv = _iChucVuService.GetAll().FirstOrDefault(p => p.TenCv == cmb_ChucVu.Text);
            var ch = _iCuaHangService.GetAll().FirstOrDefault(p => p.TenCh == cmb_CuaHang.Text);
            return new QLNhanVienViewModel()
            {
                IdNv = Guid.Empty,
                MaNv = txt_MaNV.Text,
                TenNv = txt_TenNV.Text,
                TenDemNv = txt_TenDemNV.Text,
                HoNv = txt_HoNV.Text,
                GioiTinh = txt_GioiTinh.Text,
                NgaySinh = DT_NgaySinh.Value,
                DiaChiNV = txt_DiaChi.Text,
                Sdt = txt_SDT.Text,
                MatKhau = txt_Pass.Text,
                IdCv_FK = cv.IdCv,
                IdCh_FK = ch.IdCh,
                TrangThai = rbtn_DangLam.Checked == true ? 1 : 0
            };
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_iNhanVienService.Add(getNhanVienControl()));
            LoadNhanVien();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var temp = getNhanVienControl();
            temp.IdNv = _id;
            MessageBox.Show(_iNhanVienService.Update(temp));
            LoadNhanVien();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var temp = getNhanVienControl();
            temp.IdNv = _id;
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(_iNhanVienService.Delete(temp));
                LoadNhanVien();
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_MaNV.Text = null;
            txt_TenNV.Text = null;
            txt_TenDemNV.Text = null;
            txt_HoNV.Text = null;
            txt_GioiTinh.Text = null;
            DT_NgaySinh.Value = DateTime.Now;
            txt_DiaChi.Text = null;
            txt_SDT.Text = null;
            txt_Pass.Text = null;
            cmb_ChucVu.SelectedIndex = 0;
            cmb_CuaHang.SelectedIndex = 0;
            rbtn_DangLam.Checked = true;
        }

        private void MS_CuaHang_Click(object sender, EventArgs e)
        {
            FrmCuaHang _frmCuaHang;
            _frmCuaHang = new FrmCuaHang();
            _frmCuaHang.ShowDialog();
        }

        private void MS_ChucVu_Click(object sender, EventArgs e)
        {
            FrmChucVu _frmChucVu;
            _frmChucVu = new FrmChucVu();
            _frmChucVu.ShowDialog();
        }
    }
}
